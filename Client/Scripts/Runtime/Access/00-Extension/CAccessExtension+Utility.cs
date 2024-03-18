using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.Linq;
using UnityEngine.U2D;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Linq;
using DG.Tweening;
using EnhancedUI.EnhancedScroller;

#if UNITY_EDITOR
using UnityEditor;
#endif // #if UNITY_EDITOR

#if UNITY_IOS
#if NOTI_MODULE_ENABLE
using Unity.Notifications.iOS;
#endif // #if NOTI_MODULE_ENABLE
#endif // #if UNITY_IOS

/** 접근자 확장 클래스 */
public static partial class CAccessExtension
{
	#region 클래스 함수
	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EValType a_eSender)
	{
		return a_eSender > EValType.NONE && a_eSender < EValType.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EGridType a_eSender)
	{
		return a_eSender > EGridType.NONE && a_eSender < EGridType.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EUserType a_eSender)
	{
		return a_eSender > EUserType.NONE && a_eSender < EUserType.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EDeviceType a_eSender)
	{
		return a_eSender > EDeviceType.NONE && a_eSender < EDeviceType.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EFontSet a_eSender)
	{
		return a_eSender > EFontSet.NONE && a_eSender < EFontSet.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EDirection a_eSender)
	{
		return a_eSender > EDirection.NONE && a_eSender < EDirection.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EDifficulty a_eSender)
	{
		return a_eSender > EDifficulty.NONE && a_eSender < EDifficulty.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EVibrateType a_eSender)
	{
		return a_eSender > EVibrateType.NONE && a_eSender < EVibrateType.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EVibrateStyle a_eSender)
	{
		return a_eSender > EVibrateStyle.NONE && a_eSender < EVibrateStyle.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this SystemLanguage a_eSender)
	{
		return a_eSender >= SystemLanguage.Afrikaans && a_eSender < SystemLanguage.Unknown;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this TextAsset a_oSender)
	{
		return a_oSender != null && (a_oSender.text.ExIsValid() || a_oSender.bytes.ExIsValid());
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this SpriteAtlas a_oSender)
	{
		return a_oSender != null && a_oSender.spriteCount > KCDefine.B_VAL_0_INT;
	}

	/** 인덱스 유효 여부를 검사한다 */
	public static bool ExIsValidIdx(this SimpleJSON.JSONArray a_oSender, int a_nIdx)
	{
		CFunc.Assert(a_oSender != null);
		return a_nIdx > KCDefine.B_IDX_INVALID && a_nIdx < a_oSender.Count;
	}

	/** 인덱스 유효 여부를 검사한다 */
	public static bool ExIsValidIdx(this EnhancedScroller a_oSender, int a_nIdx)
	{
		CFunc.Assert(a_oSender != null);
		return a_nIdx > KCDefine.B_IDX_INVALID && a_nIdx < a_oSender.NumberOfCells;
	}

	/** 수직 여부를 검사한다 */
	public static bool ExIsVertical(this EDirection a_eSender)
	{
		return a_eSender == EDirection.UP || a_eSender == EDirection.DOWN || a_eSender == EDirection.VERTICAL;
	}

	/** 수평 여부를 검사한다 */
	public static bool ExIsHorizontal(this EDirection a_eSender)
	{
		return a_eSender == EDirection.LEFT || a_eSender == EDirection.RIGHT || a_eSender == EDirection.HORIZONTAL;
	}

	/** 동일 여부를 검사한다 */
	public static bool ExIsEquals(this Rect a_stSender, Rect a_stRhs)
	{
		return a_stSender.min.ExIsEquals(a_stRhs.min) && a_stSender.max.ExIsEquals(a_stRhs.max);
	}

	/** 동일 여부를 검사한다 */
	public static bool ExIsEquals(this Bounds a_stSender, Bounds a_stRhs)
	{
		return a_stSender.min.ExIsEquals(a_stRhs.min) && a_stSender.max.ExIsEquals(a_stRhs.max);
	}

	/** 동일 여부를 검사한다 */
	public static bool ExIsEquals(this Vector2 a_stSender, Vector3 a_stRhs)
	{
		return a_stSender.ExTo3D().ExIsEquals(a_stRhs);
	}

	/** 동일 여부를 검사한다 */
	public static bool ExIsEquals(this Vector3 a_stSender, Vector3 a_stRhs)
	{
		return a_stSender.x.ExIsEquals(a_stRhs.x) && a_stSender.y.ExIsEquals(a_stRhs.y) && a_stSender.z.ExIsEquals(a_stRhs.z);
	}

	/** 최소 값을 반환한다 */
	public static float ExGetMinVal(this Vector2 a_stSender)
	{
		return a_stSender.x.ExIsLess(a_stSender.y) ? a_stSender.x : a_stSender.y;
	}

	/** 최소 값을 반환한다 */
	public static float ExGetMinVal(this Vector3 a_stSender)
	{
		float fMinVal = a_stSender.ExTo2D().ExGetMinVal();
		return fMinVal.ExIsLess(a_stSender.z) ? fMinVal : a_stSender.z;
	}

	/** 최소 값을 반환한다 */
	public static float ExGetMinVal(this Vector4 a_stSender)
	{
		float fMinVal = a_stSender.ExTo3D().ExGetMinVal();
		return fMinVal.ExIsLess(a_stSender.w) ? fMinVal : a_stSender.w;
	}

	/** 최소 값을 반환한다 */
	public static int ExGetMinVal(this Vector2Int a_stSender)
	{
		return Mathf.Min(a_stSender.x, a_stSender.y);
	}

	/** 최소 값을 반환한다 */
	public static int ExGetMinVal(this Vector3Int a_stSender)
	{
		return Mathf.Min(a_stSender.ExTo2D().ExGetMinVal(), a_stSender.z);
	}

	/** 최대 값을 반환한다 */
	public static float ExGetMaxVal(this Vector2 a_stSender)
	{
		return a_stSender.x.ExIsGreat(a_stSender.y) ? a_stSender.x : a_stSender.y;
	}

	/** 최대 값을 반환한다 */
	public static float ExGetMaxVal(this Vector3 a_stSender)
	{
		float fMinVal = a_stSender.ExTo2D().ExGetMaxVal();
		return fMinVal.ExIsGreat(a_stSender.z) ? fMinVal : a_stSender.z;
	}

	/** 최대 값을 반환한다 */
	public static float ExGetMaxVal(this Vector4 a_stSender)
	{
		float fMinVal = a_stSender.ExTo3D().ExGetMaxVal();
		return fMinVal.ExIsGreat(a_stSender.w) ? fMinVal : a_stSender.w;
	}

	/** 최대 값을 반환한다 */
	public static int ExGetMaxVal(this Vector2Int a_stSender)
	{
		return Mathf.Max(a_stSender.x, a_stSender.y);
	}

	/** 최대 값을 반환한다 */
	public static int ExGetMaxVal(this Vector3Int a_stSender)
	{
		return Mathf.Max(a_stSender.ExTo2D().ExGetMaxVal(), a_stSender.z);
	}

	/** 기록 정보를 반환한다 */
	public static STRecordInfo ExGetRecordInfo(this STRecordInfo a_stSender, long a_nIntRecord, double a_dblRealRecord)
	{
		a_stSender.m_nIntRecord = a_nIntRecord;
		a_stSender.m_dblRealRecord = a_dblRealRecord;

		return a_stSender;
	}

	/** 기록 정보를 반환한다 */
	public static STRecordInfo ExGetExtraRecordInfo(this STRecordInfo a_stSender, long a_nIntRecord, double a_dblRealRecord)
	{
		return a_stSender.ExGetRecordInfo(a_stSender.m_nIntRecord + a_nIntRecord, a_stSender.m_dblRealRecord + a_dblRealRecord);
	}

	/** 정렬 순서 정보를 반환한다 */
	public static STSortingOrderInfo ExGetSortingOrderInfo(this STSortingOrderInfo a_stSender, int a_nOrder)
	{
		a_stSender.m_nOrder = a_nOrder;
		return a_stSender;
	}

	/** 정렬 순서 정보를 반환한다 */
	public static STSortingOrderInfo ExGetExtraSortingOrderInfo(this STSortingOrderInfo a_stSender, int a_nOrder)
	{
		return a_stSender.ExGetSortingOrderInfo(a_stSender.m_nOrder + a_nOrder);
	}

	/** 레이어 마스크를 반환한다 */
	public static LayerMask ExGetLayerMask(this LayerMask a_stSender, int a_nVal)
	{
		a_stSender.value = a_nVal;
		return a_stSender;
	}

	/** X 축 간격을 반환한다 */
	public static float ExGetDeltaX(this Vector3 a_stSender, Vector3 a_stRhs)
	{
		return (a_stSender - a_stRhs).x;
	}

	/** Y 축 간격을 반환한다 */
	public static float ExGetDeltaY(this Vector3 a_stSender, Vector3 a_stRhs)
	{
		return (a_stSender - a_stRhs).y;
	}

	/** Z 축 간격을 반환한다 */
	public static float ExGetDeltaZ(this Vector3 a_stSender, Vector3 a_stRhs)
	{
		return (a_stSender - a_stRhs).z;
	}

	/** 비율 벡터를 반환한다 */
	public static Vector3 ExGetScaleVec(this Vector2 a_stSender, Vector3 a_stScale, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		return a_stSender.ExTo3D(a_fZ).ExGetScaleVec(a_stScale);
	}

	/** 비율 벡터를 반환한다 */
	public static Vector3 ExGetScaleVec(this Vector3 a_stSender, Vector3 a_stScale)
	{
		return new Vector3(a_stSender.x * a_stScale.x, a_stSender.y * a_stScale.y, a_stSender.z * a_stScale.z);
	}

	/** 직교 벡터를 반환한다 */
	public static Vector3 ExGetOrthogonalVec(this Vector2 a_stSender, EOrthogonal a_eOrthogonal, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		return a_stSender.ExTo3D(a_fZ).ExGetOrthogonalVec(a_eOrthogonal);
	}

	/** 직교 벡터를 반환한다 */
	public static Vector3 ExGetOrthogonalVec(this Vector3 a_stSender, EOrthogonal a_eOrthogonal)
	{
		return (a_eOrthogonal == EOrthogonal.CW) ? new Vector3(-a_stSender.y, a_stSender.x, a_stSender.z) : new Vector3(a_stSender.y, -a_stSender.x, a_stSender.z);
	}

	/** 기준점 위치를 반환한다 */
	public static Vector3 ExGetPivotPos(this Vector3 a_stSender, Vector3 a_stSrcPivot, Vector3 a_stDestPivot, Vector3 a_stSize)
	{
		var stDelta = a_stDestPivot - a_stSrcPivot;
		return a_stSender + new Vector3(a_stSize.x * -stDelta.x, a_stSize.y * -stDelta.y, a_stSize.z * -stDelta.z);
	}

	/** UI 기준점 보정 위치를 반환한다 */
	public static Vector3 ExGetUIsPivotPos(this Vector3 a_stSender, Vector3 a_stSrcPivot, Vector3 a_stDestPivot, Vector3 a_stSize)
	{
		return a_stSender.ExGetPivotPos(a_stDestPivot, a_stSrcPivot, a_stSize);
	}

	/** 자식을 반환한다 */
	public static List<GameObject> ExGetChildren(this Scene a_stSender, List<GameObject> a_oOutObjList = null)
	{
		var oObjs = a_stSender.GetRootGameObjects();
		a_oOutObjList = a_oOutObjList ?? new List<GameObject>();

		for(int i = 0; i < oObjs.Length; ++i)
		{
			a_oOutObjList.AddRange(oObjs[i].ExGetChildren());
		}

		return a_oOutObjList;
	}

	/** 크기 형식 문자열을 반환한다 */
	public static string ExGetSizeFmtStr(this string a_oSender, int a_nSize)
	{
		CFunc.Assert(a_oSender != null);
		return string.Format(KCDefine.B_TEXT_FMT_SIZE, a_nSize, a_oSender);
	}

	/** 색상 형식 문자열을 반환한다 */
	public static string ExGetColorFmtStr(this string a_oSender, Color a_stColor, bool a_bIsEnableAlpha = true)
	{
		CFunc.Assert(a_oSender != null);
		return string.Format(KCDefine.B_TEXT_FMT_COLOR, a_stColor.ExToColorStr(a_bIsEnableAlpha), a_oSender);
	}

	/** 픽셀을 변경한다 */
	public static void ExSetPixels(this Texture2D a_oSender, Color a_stColor, int a_nMipLevel = KCDefine.B_VAL_0_INT, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 텍스처가 존재 할 경우
		if(a_oSender != null)
		{
			for(int i = 0; i < a_oSender.height; ++i)
			{
				for(int j = 0; j < a_oSender.width; ++j)
				{
					a_oSender.SetPixel(j, i, a_stColor);
				}
			}

			a_oSender.Apply();
		}
	}

	/** 픽셀을 변경한다 */
	public static void ExSetPixels(this Texture2D a_oSender, List<Color> a_oColorList, int a_nMipLevel = KCDefine.B_VAL_0_INT, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oColorList != null));

		// 텍스처가 존재 할 경우
		if(a_oSender != null && a_oColorList != null)
		{
			a_oSender.SetPixels(a_oColorList.ToArray(), a_nMipLevel);
			a_oSender.Apply();
		}
	}

	/** 활성화 여부를 변경한다 */
	public static void ExSetEnable(this Behaviour a_oSender, bool a_bIsEnable, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.enabled = a_bIsEnable;
		}
	}

	/** 활성화 여부를 변경한다 */
	public static void ExSetEnable(this LayoutGroup a_oSender, bool a_bIsEnable, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 레이아웃이 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.enabled = a_bIsEnable;
			a_oSender.GetComponent<ContentSizeFitter>()?.ExSetEnable(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 태그를 변경한다 */
	public static void ExSetTag(this Component a_oSender, string a_oTag, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oTag != null));

		// 컴포넌트가 존재 할 경우
		if(a_oSender != null && a_oTag != null && !a_oSender.CompareTag(a_oTag))
		{
			a_oSender.tag = a_oTag;
		}
	}

	/** 정렬 순서를 변경한다 */
	public static void ExSetSortingOrder(this Canvas a_oSender, STSortingOrderInfo a_stOrderInfo, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid()));

		// 캔버스가 존재 할 경우
		if(a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid())
		{
			a_oSender.sortingOrder = a_stOrderInfo.m_nOrder;
			a_oSender.sortingLayerName = a_stOrderInfo.m_oLayer;
		}
	}

	/** 정렬 순서를 변경한다 */
	public static void ExSetSortingOrder(this Renderer a_oSender, STSortingOrderInfo a_stOrderInfo, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid()));

		// 렌더러가 존재 할 경우
		if(a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid())
		{
			a_oSender.sortingOrder = a_stOrderInfo.m_nOrder;
			a_oSender.sortingLayerName = a_stOrderInfo.m_oLayer;
		}
	}

	/** 정렬 순서를 변경한다 */
	public static void ExSetSortingOrder(this TextMeshPro a_oSender, STSortingOrderInfo a_stOrderInfo, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid()));

		// 렌더러가 존재 할 경우
		if(a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid())
		{
			a_oSender.sortingOrder = a_stOrderInfo.m_nOrder;
			a_oSender.sortingLayerID = SortingLayer.NameToID(a_stOrderInfo.m_oLayer);
		}
	}

	/** 스크롤 위치를 변경한다 */
	public static void ExSetScrollPos(this EnhancedScroller a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 스크롤러가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.SetScrollPositionImmediately(Mathf.Clamp(a_fVal, KCDefine.B_VAL_0_REAL, a_oSender.ScrollSize));
		}
	}

	/** 델리게이트를 변경한다 */
	public static void ExSetDelegate(this EnhancedScroller a_oSender, IEnhancedScrollerDelegate a_oDelegate, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oDelegate != null));

		// 스크롤러가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.Delegate = a_oDelegate;
		}
	}

	/** 데이터를 다시 로드한다 */
	public static void ExReloadData(this EnhancedScroller a_oSender, int a_nDataIdx, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 스크롤러가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.ReloadData();
			a_oSender.ExSetScrollPos(a_oSender.GetScrollPositionForDataIndex(a_nDataIdx, EnhancedScroller.CellViewPositionEnum.Before), a_bIsAssert);
		}
	}

	/** 자식 객체를 탐색한다 */
	public static GameObject ExFindChild(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsEnableSubName = false)
	{
		CFunc.Assert(a_oSender != null && a_oName.ExIsValid());
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.DescendantsAndSelf() : a_oSender.Descendants();

		foreach(var oObj in oEnumerator)
		{
			bool bIsEquals = oObj.name.Equals(a_oName);

			// 이름이 동일 할 경우
			if(bIsEquals || (a_bIsEnableSubName && oObj.name.Contains(a_oName)))
			{
				return oObj;
			}
		}

		return null;
	}

	/** 자식 객체를 탐색한다 */
	public static List<GameObject> ExFindChildren(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsEnableSubName = false)
	{
		var oObjList = new List<GameObject>();
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.DescendantsAndSelf() : a_oSender.Descendants();

		foreach(var oObj in oEnumerator)
		{
			bool bIsEquals = oObj.name.Equals(a_oName);

			// 이름이 동일 할 경우
			if(bIsEquals || (a_bIsEnableSubName && oObj.name.Contains(a_oName)))
			{
				oObjList.ExAddVal(oObj);
			}
		}

		return oObjList;
	}

	/** 부모 객체를 탐색한다 */
	public static GameObject ExFindParent(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsEnableSubName = false)
	{
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.AncestorsAndSelf() : a_oSender.Ancestors();

		foreach(var oObj in oEnumerator)
		{
			bool bIsEquals = oObj.name.Equals(a_oName);

			// 이름이 동일 할 경우
			if(bIsEquals || (a_bIsEnableSubName && oObj.name.Contains(a_oName)))
			{
				return oObj;
			}
		}

		return null;
	}

	/** 부모 객체를 탐색한다 */
	public static List<GameObject> ExFindParents(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsEnableSubName = false)
	{
		var oObjList = new List<GameObject>();
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.AncestorsAndSelf() : a_oSender.Ancestors();

		foreach(var oObj in oEnumerator)
		{
			bool bIsEquals = oObj.name.Equals(a_oName);

			// 이름이 동일 할 경우
			if(bIsEquals || (a_bIsEnableSubName && oObj.name.Contains(a_oName)))
			{
				oObjList.ExAddVal(oObj);
			}
		}

		return oObjList;
	}

	/** 객체를 순회한다 */
	public static void ExEnumerateRootObjs(this Scene a_stSender,
		System.Func<GameObject, bool> a_oCallback, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oCallback != null);

		// 객체 순회가 불가능 할 경우
		if(a_oCallback == null)
		{
			return;
		}

		var oObjs = a_stSender.GetRootGameObjects();

		for(int i = 0; i < oObjs.Length; ++i)
		{
			// 객체 순회가 불가능 할 경우
			if(!a_oCallback(oObjs[i]))
			{
				break;
			}
		}
	}
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponent<T>(this GameObject a_oSender,
		bool a_bIsEnable, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			(a_oSender.GetComponentInChildren<T>() as Behaviour)?.ExSetEnable(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponent<T>(this Scene a_stSender,
		string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetEnableComponent<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponent<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oName.ExIsValid()));

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetEnableComponent<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponents<T>(this GameObject a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			var oComponents = a_oSender.GetComponentsInChildren<T>();

			for(int i = 0; i < oComponents.Length; ++i)
			{
				(oComponents[i] as Behaviour)?.ExSetEnable(a_bIsEnable, a_bIsAssert);
			}
		}
	}

	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponents<T>(this Scene a_stSender, string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetEnableComponents<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 활성 여부를 변경한다 */
	public static void ExSetEnableComponents<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oName.ExIsValid()));

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetEnableComponents<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 상호 작용 여부를 변경한다 */
	public static void ExSetInteractable<T>(this GameObject a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.GetComponentInChildren<T>()?.ExSetInteractable(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 상호 작용 여부를 변경한다 */
	public static void ExSetInteractable<T>(this Scene a_stSender, string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetInteractable<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 상호 작용 여부를 변경한다 */
	public static void ExSetInteractable<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null && a_oName.ExIsValid());

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetInteractable<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTarget<T>(this GameObject a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.GetComponentInChildren<T>()?.ExSetRaycastTarget(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTarget<T>(this Scene a_stSender, string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetRaycastTarget<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTarget<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null && a_oName.ExIsValid());

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetRaycastTarget<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetInteractables<T>(this GameObject a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			var oComponents = a_oSender.GetComponentsInChildren<T>();

			for(int i = 0; i < oComponents.Length; ++i)
			{
				oComponents[i]?.ExSetInteractable(a_bIsEnable, a_bIsAssert);
			}
		}
	}

	/** 컴포넌트 상호 작용 여부를 변경한다 */
	public static void ExSetInteractables<T>(this Scene a_stSender, string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetInteractables<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 상호 작용 여부를 변경한다 */
	public static void ExSetInteractables<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Selectable
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oName.ExIsValid()));

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetInteractables<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTargets<T>(this GameObject a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			var oComponents = a_oSender.GetComponentsInChildren<T>();

			for(int i = 0; i < oComponents.Length; ++i)
			{
				oComponents[i]?.ExSetRaycastTarget(a_bIsEnable, a_bIsAssert);
			}
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTargets<T>(this Scene a_stSender, string a_oName, bool a_bIsEnable, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || a_oName.ExIsValid());

		// 이름이 유효 할 경우
		if(a_oName.ExIsValid())
		{
			a_stSender.ExFindChild(a_oName)?.ExSetRaycastTargets<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트 광선 추적 타겟 여부를 변경한다 */
	public static void ExSetRaycastTargets<T>(this GameObject a_oSender, string a_oName, bool a_bIsEnable, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Graphic
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oName.ExIsValid()));

		// 객체가 존재 할 경우
		if(a_oSender != null && a_oName.ExIsValid())
		{
			a_oSender.ExFindChild(a_oName, a_bIsIncludeSelf)?.ExSetRaycastTargets<T>(a_bIsEnable, a_bIsAssert);
		}
	}

	/** 컴포넌트를 탐색한다 */
	public static T ExFindComponent<T>(this Scene a_stSender, string a_oName, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oName.ExIsValid());
		return a_stSender.ExFindChild(a_oName, a_bIsEnableSubName)?.GetComponentInChildren<T>(a_bIsIncludeInactive);
	}

	/** 컴포넌트를 탐색한다 */
	public static T ExFindComponent<T>(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oSender != null && a_oName.ExIsValid());
		return a_oSender?.ExFindChild(a_oName, a_bIsIncludeSelf, a_bIsEnableSubName)?.GetComponentInChildren<T>(a_bIsIncludeInactive);
	}

	/** 컴포넌트를 탐색한다 */
	public static List<T> ExFindComponents<T>(this Scene a_stSender, string a_oName, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oName.ExIsValid());
		return a_stSender.ExFindChild(a_oName, a_bIsEnableSubName)?.GetComponentsInChildren<T>(a_bIsIncludeInactive).ToList();
	}

	/** 컴포넌트를 탐색한다 */
	public static List<T> ExFindComponents<T>(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oSender != null && a_oName.ExIsValid());
		return a_oSender?.ExFindChild(a_oName, a_bIsIncludeSelf, a_bIsEnableSubName)?.GetComponentsInChildren<T>(a_bIsIncludeInactive).ToList();
	}

	/** 부모 컴포넌트를 탐색한다 */
	public static T ExFindComponentInParent<T>(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oSender != null && a_oName.ExIsValid());
		return a_oSender?.ExFindParent(a_oName, a_bIsIncludeSelf, a_bIsEnableSubName)?.GetComponentInParent<T>(a_bIsIncludeInactive);
	}

	/** 부모 컴포넌트를 탐색한다 */
	public static List<T> ExFindComponentsInParent<T>(this GameObject a_oSender, string a_oName, bool a_bIsIncludeSelf = true, bool a_bIsIncludeInactive = false, bool a_bIsEnableSubName = false) where T : Component
	{
		CFunc.Assert(a_oSender != null && a_oName.ExIsValid());
		return a_oSender?.ExFindParent(a_oName, a_bIsIncludeSelf, a_bIsEnableSubName)?.GetComponentsInParent<T>(a_bIsIncludeInactive).ToList();
	}

	/** 배열을 순회한다 */
	public static void ExEnumerate<T>(this T[,] a_oSender,
		System.Func<T, Vector3Int, bool> a_oCallback, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 배열 순회가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null)
		{
			return;
		}

		for(int i = 0; i < a_oSender.GetLength(KCDefine.B_VAL_0_INT); ++i)
		{
			for(int j = 0; j < a_oSender.GetLength(KCDefine.B_VAL_1_INT); ++j)
			{
				// 배열 순회가 불가능 할 경우
				if(!a_oCallback(a_oSender[i, j], new Vector3Int(j, i, KCDefine.B_VAL_0_INT)))
				{
					goto EX_ENUMERATE_EXIT_ENUMERATE;
				}
			}
		}

EX_ENUMERATE_EXIT_ENUMERATE:
		return;
	}

	/** 컴포넌트를 순회한다 */
	public static void ExEnumerateComponents<T>(this Scene a_stSender,
		System.Func<T, bool> a_oCallback, bool a_bIsIncludeInactive = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oCallback != null);

		// 컴포넌트 순회가 불가능 할 경우
		if(a_oCallback == null)
		{
			return;
		}

		a_stSender.ExEnumerateRootObjs((a_oObj) =>
		{
			bool bIsTrue = true;

			a_oObj.ExEnumerateComponents<T>((a_oComponent) =>
			{
				return bIsTrue = a_oCallback(a_oComponent);
			}, a_bIsAssert);

			return bIsTrue;
		}, a_bIsAssert);
	}

	/** 컴포넌트를 순회한다 */
	public static void ExEnumerateComponents<T>(this GameObject a_oSender,
		System.Func<T, bool> a_oCallback, bool a_bIsIncludeInactive = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 컴포넌트 순회가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null)
		{
			return;
		}

		var oComponents = a_oSender.GetComponentsInChildren<T>(a_bIsIncludeInactive);

		for(int i = 0; i < oComponents.Length; ++i)
		{
			// 컴포넌트 순회가 불가능 할 경우
			if(!a_oCallback(oComponents[i]))
			{
				break;
			}
		}
	}

	/** 컴포넌트를 순회한다 */
	public static void ExEnumerateComponentsInParent<T>(this GameObject a_oSender,
		System.Func<T, bool> a_oCallback, bool a_bIsIncludeInactive = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 컴포넌트 순회가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null)
		{
			return;
		}

		var oComponents = a_oSender.GetComponentsInParent<T>(a_bIsIncludeInactive);

		for(int i = 0; i < oComponents.Length; ++i)
		{
			// 컴포넌트 순회가 불가능 할 경우
			if(!a_oCallback(oComponents[i]))
			{
				break;
			}
		}
	}
	#endregion // 제네릭 클래스 함수

	#region 조건부 클래스 함수
#if UNITY_EDITOR
	/** 스크립트 순서를 변경한다 */
	public static void ExSetScriptOrder(this MonoBehaviour a_oSender, int a_nOrder, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		bool bIsInvalidA = Application.isPlaying;
		bool bIsInvalidB = a_oSender == null || a_nOrder >= KCDefine.B_SCRIPT_O_INVALID;

		// 스크립트 순서 변경이 불가능 할 경우
		if(bIsInvalidA || bIsInvalidB)
		{
			return;
		}

		CAccess.SetScriptOrder(MonoScript.FromMonoBehaviour(a_oSender), a_nOrder, a_bIsAssert);
	}
#endif // #if UNITY_EDITOR

#if ADS_MODULE_ENABLE
	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EAdsPlatform a_eSender) {
		return a_eSender > EAdsPlatform.NONE && a_eSender < EAdsPlatform.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EBannerAdsPos a_eSender) {
		return a_eSender > EBannerAdsPos.NONE && a_eSender < EBannerAdsPos.MAX_VAL;
	}
#endif // #if ADS_MODULE_ENABLE
	#endregion // 조건부 클래스 함수
}

/** 접근자 확장 클래스 - 추가 */
public static partial class CAccessExtension
{
	#region 클래스 함수 (CExtension)
	/** 월드 => 로컬로 변환한다 */
	public static Vector3 ExToLocal(this Vector2 a_stSender, GameObject a_oParent, bool a_bIsCoord = true, float a_fZ = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oParent != null);
		return a_stSender.ExTo3D(a_fZ).ExToLocal(a_oParent, a_bIsCoord);
	}

	/** 월드 => 로컬로 변환한다 */
	public static Vector3 ExToLocal(this Vector3 a_stSender, GameObject a_oParent, bool a_bIsCoord = true)
	{
		CFunc.Assert(a_oParent != null);
		return a_oParent.transform.worldToLocalMatrix * a_stSender.ExTo4D(a_bIsCoord);
	}
	#endregion // 클래스 함수 (CExtension)
}
