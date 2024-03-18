using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using DG.Tweening;

/** 확장 클래스 - 게임 객체 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this GameObject a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localScale = Vector3.one;
		a_oSender.transform.localEulerAngles = Vector3.zero;
		a_oSender.transform.localPosition = Vector3.zero;
	}

	/** X 축 크기 간격을 추가한다 */
	public static void ExAddSizeDeltaX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddSizeDelta(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** Y 축 크기 간격을 추가한다 */
	public static void ExAddSizeDeltaY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddSizeDelta(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 크기 간격을 추가한다 */
	public static void ExAddSizeDelta(this GameObject a_oSender, Vector3 a_stSize, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 크기 간격 추가가 불가능 할 경우
		if(a_oSender == null || (a_oSender.transform as RectTransform) == null)
		{
			return;
		}

		(a_oSender.transform as RectTransform).sizeDelta += a_stSize.ExTo2D();
	}

	/** X 축 앵커 위치를 추가한다 */
	public static void ExAddAnchorPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddAnchorPos(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** Y 축 앵커 위치를 추가한다 */
	public static void ExAddAnchorPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddAnchorPos(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 앵커 위치를 추가한다 */
	public static void ExAddAnchorPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 앵커 위치 추가가 불가능 할 경우
		if(a_oSender == null || (a_oSender.transform as RectTransform) == null)
		{
			return;
		}

		(a_oSender.transform as RectTransform).anchoredPosition += a_stPos.ExTo2D();
	}

	/** 비율 애니메이션을 시작한다 */
	public static Sequence ExStartScaleAnim(this GameObject a_oSender, Vector3 a_stScale, float a_fDuration, System.Action<GameObject, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oSender != null);
		return CFactory.MakeSequence(a_oSender.transform.DOScale(a_stScale, a_fDuration).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}

	/** 월드 이동 애니메이션을 시작한다 */
	public static Sequence ExStartWorldMoveAnim(this GameObject a_oSender, Vector3 a_stPos, float a_fDuration, System.Action<GameObject, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oSender != null);
		return CFactory.MakeSequence(a_oSender.transform.DOMove(a_stPos, a_fDuration).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}

	/** 로컬 이동 애니메이션을 시작한다 */
	public static Sequence ExStartLocalMoveAnim(this GameObject a_oSender, Vector3 a_stPos, float a_fDuration, System.Action<GameObject, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oSender != null);
		return CFactory.MakeSequence(a_oSender.transform.DOLocalMove(a_stPos, a_fDuration).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}

	/** 월드 경로 애니메이션을 시작한다 */
	public static Tween ExStartWorldPathAnim(this GameObject a_oSender, List<Vector3> a_oPosList, float a_fDuration, System.Action<GameObject, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, bool a_bIsRealtime = false, bool a_bIsLinearPath = false, float a_fDelay = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oSender != null && a_oPosList != null);
		return CFactory.MakeSequence(a_oSender.transform.DOPath(a_oPosList.ToArray(), a_fDuration, a_bIsLinearPath ? PathType.Linear : PathType.CatmullRom).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}

	/** 로컬 경로 애니메이션을 시작한다 */
	public static Tween ExStartLocalPathAnim(this GameObject a_oSender, List<Vector3> a_oPosList, float a_fDuration, System.Action<GameObject, Sequence> a_oCallback, Ease a_eEase = KCDefine.U_EASE_DEF, bool a_bIsRealtime = false, bool a_bIsLinearPath = false, float a_fDelay = KCDefine.B_VAL_0_REAL)
	{
		CFunc.Assert(a_oSender != null && a_oPosList != null);
		return CFactory.MakeSequence(a_oSender.transform.DOLocalPath(a_oPosList.ToArray(), a_fDuration, a_bIsLinearPath ? PathType.Linear : PathType.CatmullRom).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime), (a_oAnimSender) => a_oCallback?.Invoke(a_oSender, a_oAnimSender), a_fDelay, a_bIsRealtime: a_bIsRealtime);
	}
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 컴포넌트를 추가한다 */
	public static T ExAddComponent<T>(this GameObject a_oSender, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return null;
		}

		return a_oSender.TryGetComponent(out T oComponent) ? oComponent : a_oSender.AddComponent<T>();
	}

	/** 컴포넌트를 제거한다 */
	public static void ExRemoveComponent<T>(this GameObject a_oSender, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트 제거가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		CExtension.RemoveObj(a_oSender.GetComponentInChildren<T>(), false, a_bIsAssert);
	}

	/** 컴포넌트를 제거한다 */
	public static void ExRemoveComponents<T>(this GameObject a_oSender, 
		bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트 제거가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.ExEnumerateComponents<T>((a_oComponent) =>
		{
			// 컴포넌트 제거가 가능 할 경우
			if(a_bIsIncludeSelf || a_oSender != a_oComponent.gameObject)
			{
				CExtension.RemoveObj(a_oComponent, false, a_bIsAssert);
			}

			return true;
		});
	}

	/** 컴포넌트를 제거한다 */
	public static void ExRemoveComponentInParent<T>(this GameObject a_oSender, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트 제거가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		CExtension.RemoveObj(a_oSender.GetComponentInParent<T>(), false, a_bIsAssert);
	}

	/** 컴포넌트를 제거한다 */
	public static void ExRemoveComponentsInParent<T>(this GameObject a_oSender, bool a_bIsIncludeSelf = true, bool a_bIsAssert = true) where T : Component
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 컴포넌트 제거가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.ExEnumerateComponentsInParent<T>((a_oComponent) =>
		{
			// 컴포넌트 제거가 가능 할 경우
			if(a_bIsIncludeSelf || a_oSender != a_oComponent.gameObject)
			{
				CExtension.RemoveObj(a_oComponent, false, a_bIsAssert);
			}

			return true;
		});
	}
	#endregion // 제네릭 클래스 함수
}

/** 확장 클래스 - 게임 객체 (월드) */
public static partial class CExtension
{
	#region 클래스 함수
	/** 월드 X 축 각도를 추가한다 */
	public static void ExAddWorldAngleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngle(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 월드 Y 축 각도를 추가한다 */
	public static void ExAddWorldAngleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngle(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 월드 Z 축 각도를 추가한다 */
	public static void ExAddWorldAngleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngle(new Vector3(KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL, a_fVal), a_bIsAssert);
	}

	/** 월드 각도를 추가한다 */
	public static void ExAddWorldAngle(this GameObject a_oSender, Vector3 a_stAngle, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 월드 각도 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.eulerAngles += a_stAngle;
	}

	/** 월드 X 축 각도를 추가한다 */
	public static void ExAddWorldAngleAxisX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngleAxis(Vector3.right, a_fVal, a_bIsAssert);
	}

	/** 월드 Y 축 각도를 추가한다 */
	public static void ExAddWorldAngleAxisY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngleAxis(Vector3.up, a_fVal, a_bIsAssert);
	}

	/** 월드 Z 축 각도를 추가한다 */
	public static void ExAddWorldAngleAxisZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldAngleAxis(Vector3.forward, a_fVal, a_bIsAssert);
	}

	/** 월드 축 각도를 추가한다 */
	public static void ExAddWorldAngleAxis(this GameObject a_oSender, Vector3 a_stAxis, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 월드 축 각도 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.rotation = Quaternion.AngleAxis(a_fVal, a_stAxis.normalized) * a_oSender.transform.rotation;
	}

	/** 월드 X 축 위치를 추가한다 */
	public static void ExAddWorldPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPos(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 월드 Y 축 위치를 추가한다 */
	public static void ExAddWorldPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPos(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 월드 Z 축 위치를 추가한다 */
	public static void ExAddWorldPosZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPos(new Vector3(KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL, a_fVal), a_bIsAssert);
	}

	/** 월드 위치를 추가한다 */
	public static void ExAddWorldPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 월드 위치 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.position += a_stPos;
	}

	/** 월드 X 축 위치를 추가한다 */
	public static void ExAddWorldPosAxisX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPosAxis(Vector3.right, a_fVal, a_bIsAssert);
	}

	/** 월드 Y 축 위치를 추가한다 */
	public static void ExAddWorldPosAxisY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPosAxis(Vector3.up, a_fVal, a_bIsAssert);
	}

	/** 월드 Z 축 위치를 추가한다 */
	public static void ExAddWorldPosAxisZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddWorldPosAxis(Vector3.forward, a_fVal, a_bIsAssert);
	}

	/** 월드 축 위치를 추가한다 */
	public static void ExAddWorldPosAxis(this GameObject a_oSender, Vector3 a_stAxis, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 월드 축 위치 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.position += a_stAxis.normalized * a_fVal;
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - 게임 객체 (로컬) */
public static partial class CExtension
{
	#region 클래스 함수
	/** 로컬 X 축 비율을 추가한다 */
	public static void ExAddLocalScaleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalScale(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Y 축 비율을 추가한다 */
	public static void ExAddLocalScaleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalScale(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Z 축 비율을 추가한다 */
	public static void ExAddLocalScaleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalScale(new Vector3(KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL, a_fVal), a_bIsAssert);
	}

	/** 로컬 비율을 추가한다 */
	public static void ExAddLocalScale(this GameObject a_oSender, Vector3 a_stScale, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 로컬 비율 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localScale += a_stScale;
	}

	/** 로컬 X 축 각도를 추가한다 */
	public static void ExAddLocalAngleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngle(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Y 축 각도를 추가한다 */
	public static void ExAddLocalAngleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngle(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Z 축 각도를 추가한다 */
	public static void ExAddLocalAngleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngle(new Vector3(KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL, a_fVal), a_bIsAssert);
	}

	/** 로컬 각도를 추가한다 */
	public static void ExAddLocalAngle(this GameObject a_oSender, Vector3 a_stAngle, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 로컬 각도 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localEulerAngles += a_stAngle;
	}

	/** 로컬 X 축 각도를 추가한다 */
	public static void ExAddLocalAngleAxisX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngleAxis(a_oSender.transform.right, a_fVal, a_bIsAssert);
	}

	/** 로컬 Y 축 각도를 추가한다 */
	public static void ExAddLocalAngleAxisY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngleAxis(a_oSender.transform.up, a_fVal, a_bIsAssert);
	}

	/** 로컬 Z 축 각도를 추가한다 */
	public static void ExAddLocalAngleAxisZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalAngleAxis(a_oSender.transform.forward, a_fVal, a_bIsAssert);
	}

	/** 로컬 축 각도를 추가한다 */
	public static void ExAddLocalAngleAxis(this GameObject a_oSender, Vector3 a_stAxis, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 로컬 축 각도 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localRotation = Quaternion.AngleAxis(a_fVal, a_stAxis) * a_oSender.transform.localRotation;
	}

	/** 로컬 X 축 위치를 추가한다 */
	public static void ExAddLocalPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPos(new Vector3(a_fVal, KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Y 축 위치를 추가한다 */
	public static void ExAddLocalPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPos(new Vector3(KCDefine.B_VAL_0_REAL, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 로컬 Z 축 위치를 추가한다 */
	public static void ExAddLocalPosZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPos(new Vector3(KCDefine.B_VAL_0_REAL, KCDefine.B_VAL_0_REAL, a_fVal), a_bIsAssert);
	}

	/** 로컬 위치를 추가한다 */
	public static void ExAddLocalPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 로컬 위치 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localPosition += a_stPos;
	}

	/** 로컬 X 축 위치를 추가한다 */
	public static void ExAddLocalPosAxisX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPosAxis(a_oSender.transform.right, a_fVal);
	}

	/** 로컬 Y 축 위치를 추가한다 */
	public static void ExAddLocalPosAxisY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPosAxis(a_oSender.transform.up, a_fVal);
	}

	/** 로컬 Z 축 위치를 추가한다 */
	public static void ExAddLocalPosAxisZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExAddLocalPosAxis(a_oSender.transform.forward, a_fVal);
	}

	/** 로컬 축 위치를 추가한다 */
	public static void ExAddLocalPosAxis(this GameObject a_oSender, Vector3 a_stAxis, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 로컬 축 위치 추가가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.localPosition += a_stAxis.normalized * a_fVal;
	}
	#endregion // 클래스 함수
}
