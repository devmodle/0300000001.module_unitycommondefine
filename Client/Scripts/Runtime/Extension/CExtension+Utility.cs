using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using TMPro;

using MessagePack;
using DG.Tweening;
using Coffee.UIExtensions;

#if UNITY_ANDROID
using UnityEngine.Android;
#endif // #if UNITY_ANDROID

#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
using Newtonsoft.Json;
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE

/** 확장 클래스 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this Renderer a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.receiveShadows = true;
		a_oSender.staticShadowCaster = true;
		a_oSender.allowOcclusionWhenDynamic = true;

		a_oSender.lightProbeUsage = LightProbeUsage.BlendProbes;
		a_oSender.shadowCastingMode = ShadowCastingMode.On;
	}

	/** 애니메이션을 시작한다 */
	public static Sequence ExStartAnim(this CFXBase a_oSender, float a_fStartVal, float a_fEndVal, float a_fDuration, System.Action<CFXBase, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oSender != null);
		return CFactory.MakeSequence(CFactory.MakeAnim(() => a_oSender.effectFactor, (a_fVal) => a_oSender.effectFactor = a_fVal, () => a_oSender.effectFactor = a_fStartVal, null, a_fEndVal, a_fDuration, a_eEase, a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}

	/** 종류 => 타입으로 변환한다 */
	public static int ExKindsToType(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? a_nSender / KCDefine.G_UNIT_KINDS_PER_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 타입 종류로 변환한다 */
	public static int ExKindsToTypeKinds(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? a_nSender.ExKindsToType() * KCDefine.G_UNIT_KINDS_PER_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 서브 타입으로 변환한다 */
	public static int ExKindsToSubType(this int a_nSender)
	{
		int nSubType = a_nSender % KCDefine.G_UNIT_KINDS_PER_TYPE;
		return a_nSender.ExIsValidIdx() ? a_nSender.ExKindsToTypeKinds() + ((nSubType / KCDefine.G_UNIT_KINDS_PER_SUB_TYPE) * KCDefine.G_UNIT_KINDS_PER_SUB_TYPE) : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 서브 타입 값으로 변환한다 */
	public static int ExKindsToSubTypeVal(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? (a_nSender % KCDefine.G_UNIT_KINDS_PER_TYPE) / KCDefine.G_UNIT_KINDS_PER_SUB_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 종류 타입으로 변환한다 */
	public static int ExKindsToKindsType(this int a_nSender)
	{
		int nKindsType = a_nSender % KCDefine.G_UNIT_KINDS_PER_SUB_TYPE;
		return a_nSender.ExIsValidIdx() ? a_nSender.ExKindsToSubType() + ((nKindsType / KCDefine.G_UNIT_KINDS_PER_KINDS_TYPE) * KCDefine.G_UNIT_KINDS_PER_KINDS_TYPE) : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 종류 타입 값으로 변환한다 */
	public static int ExKindsToKindsTypeVal(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? (a_nSender % KCDefine.G_UNIT_KINDS_PER_TYPE) / KCDefine.G_UNIT_KINDS_PER_KINDS_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 서브 종류 타입으로 변환한다 */
	public static int ExKindsToSubKindsType(this int a_nSender)
	{
		int nSubKindsType = a_nSender % KCDefine.G_UNIT_KINDS_PER_KINDS_TYPE;
		return a_nSender.ExIsValidIdx() ? a_nSender.ExKindsToKindsType() + ((nSubKindsType / KCDefine.G_UNIT_KINDS_PER_SUB_KINDS_TYPE) * KCDefine.G_UNIT_KINDS_PER_SUB_KINDS_TYPE) : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 서브 종류 타입 값으로 변환한다 */
	public static int ExKindsToSubKindsTypeVal(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? (a_nSender % KCDefine.G_UNIT_KINDS_PER_KINDS_TYPE) / KCDefine.G_UNIT_KINDS_PER_SUB_KINDS_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 세부 서브 종류 타입으로 변환한다 */
	public static int ExKindsToDetailSubKindsType(this int a_nSender)
	{
		int nDetailSubKindsType = a_nSender % KCDefine.G_UNIT_KINDS_PER_SUB_KINDS_TYPE;
		return a_nSender.ExIsValidIdx() ? a_nSender.ExKindsToSubKindsType() + nDetailSubKindsType : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 세부 서브 종류 타입 값으로 변환한다 */
	public static int ExKindsToDetailSubKindsTypeVal(this int a_nSender)
	{
		return a_nSender.ExIsValidIdx() ? a_nSender % KCDefine.G_UNIT_KINDS_PER_SUB_KINDS_TYPE : KCDefine.G_IDX_INVALID;
	}

	/** 종류 => 보정 된 종류로 변환한다 */
	public static int ExKindsToAdjustKinds(this int a_nSender, EKindsGroupType a_eKindsGroupType)
	{
		switch(a_eKindsGroupType)
		{
			case EKindsGroupType.TYPE:
				return a_nSender.ExKindsToTypeKinds();

			case EKindsGroupType.SUB_TYPE:
				return a_nSender.ExKindsToSubType();

			case EKindsGroupType.KINDS_TYPE:
				return a_nSender.ExKindsToKindsType();

			case EKindsGroupType.SUB_KINDS_TYPE:
				return a_nSender.ExKindsToSubKindsType();
		}

		return a_nSender.ExKindsToDetailSubKindsType();
	}

	/** 고유 레벨 식별자 => 식별자로 변환한다 */
	public static int ExULevelIDToLevelID(this ulong a_nSender)
	{
		return (int)(a_nSender % KCDefine.G_UNIT_IDS_PER_IDS_02);
	}

	/** 고유 레벨 식별자 => 스테이지 식별자로 변환한다 */
	public static int ExULevelIDToStageID(this ulong a_nSender)
	{
		return (int)((a_nSender % KCDefine.G_UNIT_IDS_PER_IDS_03) / KCDefine.G_UNIT_IDS_PER_IDS_02);
	}

	/** 고유 레벨 식별자 => 챕터 식별자로 변환한다 */
	public static int ExULevelIDToChapterID(this ulong a_nSender)
	{
		return (int)(a_nSender / KCDefine.G_UNIT_IDS_PER_IDS_03);
	}

	/** 교유 레벨 식별자 => 식별자 정보로 변환한다 */
	public static STIDInfo ExULevelIDToIDInfo(this ulong a_nSender)
	{
		return new STIDInfo(a_nSender.ExULevelIDToLevelID(), a_nSender.ExULevelIDToStageID(), a_nSender.ExULevelIDToChapterID());
	}

	/** 로컬 => 월드로 변환한다 */
	public static Vector3 ExToWorld(this Vector2 a_stSender, GameObject a_oParent, bool a_bIsCoord = true, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oParent != null);
		return a_stSender.ExTo3D(a_fZ).ExToWorld(a_oParent, a_bIsCoord);
	}

	/** 로컬 => 월드로 변환한다 */
	public static Vector3 ExToWorld(this Vector3 a_stSender, GameObject a_oParent, bool a_bIsCoord = true)
	{
		CFunc.Assert(a_oParent != null);
		return a_oParent.transform.localToWorldMatrix * a_stSender.ExTo4D(a_bIsCoord);
	}

	/** 월드 => 캔버스로 변환한다 */
	public static Vector3 ExWorldToCanvas(this Vector2 a_stSender, Canvas a_oCanvas, GameObject a_oParent, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oCanvas != null);
		return a_stSender.ExTo3D(a_fZ).ExWorldToCanvas(a_oCanvas, a_oParent);
	}

	/** 월드 => 캔버스로 변환한다 */
	public static Vector3 ExWorldToCanvas(this Vector2 a_stSender, Canvas a_oCanvas, Camera a_oCamera, GameObject a_oParent, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oCanvas != null);
		return a_stSender.ExTo3D(a_fZ).ExWorldToCanvas(a_oCanvas, a_oCamera, a_oParent);
	}

	/** 월드 => 캔버스로 변환한다 */
	public static Vector3 ExWorldToCanvas(this Vector3 a_stSender, Canvas a_oCanvas, GameObject a_oParent)
	{
		CFunc.Assert(a_oCanvas != null);
		a_stSender.z = KCDefine.B_VAL_0_REAL;

		return ((a_stSender.ExGetScaleVec(a_oCanvas.transform.localScale / KCDefine.G_UNIT_SCALE) + a_oCanvas.transform.position)).ExToLocal(a_oParent);
	}

	/** 월드 => 캔버스로 변환한다 */
	public static Vector3 ExWorldToCanvas(this Vector3 a_stSender, Canvas a_oCanvas, Camera a_oCamera, GameObject a_oParent)
	{
		CFunc.Assert(a_oCanvas != null);
		return (a_oCamera.cameraToWorldMatrix * a_stSender.ExTo4D()).ExTo3D().ExWorldToCanvas(a_oCanvas, a_oParent);
	}

	/** 캔버스 => 월드로 변환한다 */
	public static Vector3 ExCanvasToWorld(this Vector2 a_stSender, Canvas a_oCanvas, GameObject a_oParent, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oCanvas != null);
		return a_stSender.ExTo3D(a_fZ).ExCanvasToWorld(a_oCanvas, a_oParent);
	}

	/** 캔버스 => 월드로 변환한다 */
	public static Vector3 ExCanvasToWorld(this Vector2 a_stSender, Canvas a_oCanvas, Camera a_oCamera, GameObject a_oParent, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oCanvas != null);
		return a_stSender.ExTo3D(a_fZ).ExCanvasToWorld(a_oCanvas, a_oCamera, a_oParent);
	}

	/** 캔버스 => 월드로 변환한다 */
	public static Vector3 ExCanvasToWorld(this Vector3 a_stSender, Canvas a_oCanvas, GameObject a_oParent)
	{
		CFunc.Assert(a_oCanvas != null);
		var stScale = new Vector3(KCDefine.B_VAL_1_REAL / a_oCanvas.transform.localScale.x, KCDefine.B_VAL_1_REAL / a_oCanvas.transform.localScale.y, KCDefine.B_VAL_1_REAL / a_oCanvas.transform.localScale.z);

		return ((a_stSender.ExGetScaleVec(stScale) - a_oCanvas.transform.position)).ExToLocal(a_oParent);
	}

	/** 캔버스 => 월드로 변환한다 */
	public static Vector3 ExCanvasToWorld(this Vector3 a_stSender, Canvas a_oCanvas, Camera a_oCamera, GameObject a_oParent)
	{
		CFunc.Assert(a_oCanvas != null);
		return (a_oCamera.worldToCameraMatrix * a_stSender.ExTo4D()).ExTo3D().ExCanvasToWorld(a_oCanvas, a_oParent);
	}

	/** 위치 => 인덱스로 변환한다 */
	public static Vector3Int ExToIdx(this Vector2 a_stSender, Vector3 a_stPivotPos, Vector3 a_stSize, int a_nZ = KCDefine.B_VAL_0_INT)
	{
		return a_stSender.ExTo3D(a_nZ).ExToIdx(a_stPivotPos, a_stSize);
	}

	/** 위치 => 인덱스로 변환한다 */
	public static Vector3Int ExToIdx(this Vector3 a_stSender, Vector3 a_stPivotPos, Vector3 a_stSize)
	{
		CFunc.Assert(a_stSize.x.ExIsGreatEquals(KCDefine.B_VAL_0_REAL) && a_stSize.y.ExIsGreatEquals(KCDefine.B_VAL_0_REAL) && a_stSize.z.ExIsGreatEquals(KCDefine.B_VAL_0_REAL));
		var stDelta = a_stSender - a_stPivotPos;

		return (stDelta.x.ExIsGreatEquals(KCDefine.B_VAL_0_REAL) && stDelta.y.ExIsLessEquals(KCDefine.B_VAL_0_REAL) && stDelta.z.ExIsLessEquals(KCDefine.B_VAL_0_REAL)) ? new Vector3Int((int)(stDelta.x / a_stSize.x), (int)(stDelta.y / -a_stSize.y), a_stSize.z.ExIsLessEquals(KCDefine.B_VAL_0_REAL) ? KCDefine.B_VAL_0_INT : (int)(stDelta.z / -a_stSize.z)) : KCDefine.G_IDX_INVALID_3D;
	}

	/** 인덱스 => 위치로 변환한다 */
	public static Vector3 ExToPos(this Vector2Int a_stSender, Vector3 a_stOffset, Vector3 a_stSize, int a_nZ = KCDefine.B_VAL_0_INT)
	{
		return a_stSender.ExTo3D(a_nZ).ExToPos(a_stOffset, a_stSize);
	}

	/** 인덱스 => 위치로 변환한다 */
	public static Vector3 ExToPos(this Vector3Int a_stSender, Vector3 a_stOffset, Vector3 a_stSize)
	{
		return new Vector3((a_stSender.x * a_stSize.x) + a_stOffset.x, (a_stSender.y * -a_stSize.y) + a_stOffset.y, (a_stSender.z * -a_stSize.z) + a_stOffset.z);
	}

	/** 문자열 => Base64 문자열로 변환한다 */
	public static string ExToBase64Str(this string a_oSender, System.Text.Encoding a_oEncoding = null)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		return System.Convert.ToBase64String((a_oEncoding ?? System.Text.Encoding.Default).GetBytes(a_oSender));
	}

	/** 문자열 => Base64 Zip 문자열로 변환한다 */
	public static string ExToBase64ZipStr(this string a_oSender, System.Text.Encoding a_oEncoding = null)
	{
		CFunc.Assert(a_oSender.ExIsValid());

		using(var oMemoryStream = new MemoryStream())
		{
			using(var oGZipStream = new GZipStream(oMemoryStream, CompressionMode.Compress))
			{
				var oBytes = (a_oEncoding ?? System.Text.Encoding.Default).GetBytes(a_oSender);
				oGZipStream.Write(oBytes, 0, oBytes.Length);
			}

			var oZipBytes = oMemoryStream.ToArray();
			return System.Convert.ToBase64String(oZipBytes, 0, oZipBytes.Length);
		}
	}

	/** Base64 문자열 => 문자열로 변환한다 */
	public static string ExBase64StrToStr(this string a_oSender, System.Text.Encoding a_oEncoding = null)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		return (a_oEncoding ?? System.Text.Encoding.Default).GetString(System.Convert.FromBase64String(a_oSender));
	}

	/** 압축 된 문자열 => 문자열로 변환한다 */
	public static string ExBase64ZipStrToStr(this string a_oSender, System.Text.Encoding a_oEncoding = null)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		var oBytes = System.Convert.FromBase64String(a_oSender);

		using(var oResultStream = new MemoryStream())
		{
			using(var oMemoryStream = new MemoryStream(oBytes, 0, oBytes.Length))
			{
				using(var oGZipStream = new GZipStream(oMemoryStream, CompressionMode.Decompress))
				{
					oGZipStream.CopyTo(oResultStream);
				}

				oResultStream.Seek(0, SeekOrigin.Begin);
				return (a_oEncoding ?? System.Text.Encoding.Default).GetString(oResultStream.ToArray());
			}
		}
	}

	/** JSON 문자열 => JSON 배열로 변환한다 */
	public static SimpleJSON.JSONNode ExJSONStrToJSONArray(this string a_oSender)
	{
		CFunc.Assert(a_oSender.ExIsValid());

		var oTokens = Regex.Replace(a_oSender, KCDefine.B_PATTERN_SPACE, string.Empty).Split(KCDefine.B_TOKEN_COMMA);
		var oJSONArray = new SimpleJSON.JSONArray();

		for(int i = 0; i < oTokens.Length; ++i)
		{
			oJSONArray.Add(oTokens[i]);
		}

		return oJSONArray;
	}

	/** 유저 권한을 요청한다 */
	public static void ExRequestUserPermission(this MonoBehaviour a_oSender, string a_oPermission, System.Action<string, bool> a_oCallback, bool a_bIsRealtime = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oPermission.ExIsValid()));

		// 컴포넌트가 존재 할 경우
		if(a_oSender != null && a_oPermission.ExIsValid())
		{
#if UNITY_ANDROID
			// 유저 권한이 유효 할 경우
			if(CAccess.IsEnableUserPermission(a_oPermission)) {
				a_oCallback?.Invoke(a_oPermission, true);
			} else {
				Permission.RequestUserPermission(a_oPermission);

				a_oSender.ExRepeatCallFunc((a_oSender, a_bIsComplete) => {
					// 완료되었을 경우
					if(a_bIsComplete) {
						a_oCallback?.Invoke(a_oPermission, CAccess.IsEnableUserPermission(a_oPermission));
					}

					return !CAccess.IsEnableUserPermission(a_oPermission);
				}, KCDefine.B_DELTA_T_PERMISSION_M_REQUEST_CHECK, KCDefine.B_MAX_DELTA_T_PERMISSION_M_REQUEST_CHECK, a_bIsRealtime);
			}
#else
			a_oCallback?.Invoke(a_oPermission, false);
#endif // #if UNITY_ANDROID
		}
	}

	/** 객체를 제거한다 */
	private static void RemoveObj(Object a_oObj, bool a_bIsRemoveAsset = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oObj != null);

		// 객체가 존재 할 경우
		if(a_oObj != null)
		{
			// 앱이 실행 중 일 경우
			if(Application.isPlaying)
			{
				GameObject.Destroy(a_oObj);
			}
			else
			{
				GameObject.DestroyImmediate(a_oObj, a_bIsRemoveAsset);
			}
		}
	}
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 객체 => JSON 문자열로 변환한다 */
	public static string ExToMsgPackJSONStr<T>(this T a_tSender)
	{
		return MessagePackSerializer.ConvertToJson(MessagePackSerializer.Serialize<T>(a_tSender));
	}

	/** 객체 => Base64 문자열로 변환한다 */
	public static string ExToMsgPackBase64Str<T>(this T a_tSender)
	{
		return System.Convert.ToBase64String(MessagePackSerializer.Serialize<T>(a_tSender));
	}

	/** JSON 문자열 => 객체로 변환한다 */
	public static T ExMsgPackJSONStrToObj<T>(this string a_oSender)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		return MessagePackSerializer.Deserialize<T>(MessagePackSerializer.ConvertFromJson(a_oSender));
	}

	/** Base64 문자열 => 객체로 변환한다 */
	public static T ExMsgPackBase64StrToObj<T>(this string a_oSender)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		return MessagePackSerializer.Deserialize<T>(System.Convert.FromBase64String(a_oSender));
	}
	#endregion // 제네릭 클래스 함수

	#region 조건부 제네릭 클래스 함수
#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
	/** 객체 => JSON 문자열로 변환한다 */
	public static string ExToJSONStr<T>(this T a_tSender, bool a_bIsNeedsRoot = false, bool a_bIsPretty = false)
	{
		object oObj = !a_bIsNeedsRoot ? a_tSender as object : new Dictionary<string, object>()
		{
			[KCDefine.B_KEY_ROOT] = a_tSender
		};

		return JsonConvert.SerializeObject(oObj, a_bIsPretty ? Formatting.Indented : Formatting.None);
	}

	/** JSON 문자열 => 객체로 변환한다 */
	public static T ExJSONStrToObj<T>(this string a_oSender)
	{
		CFunc.Assert(a_oSender.ExIsValid());
		return JsonConvert.DeserializeObject<T>(a_oSender);
	}
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
	#endregion // 조건부 제네릭 클래스 함수
}
