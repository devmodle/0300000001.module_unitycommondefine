using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.Linq;
using Unity.Linq;

/** 접근자 확장 클래스 - 게임 객체 */
public static partial class CExtensionAccess
{
	#region 클래스 접근 함수
	/** 기준점을 반환한다 */
	public static Vector3 ExGetPivot(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		return (a_oSender.transform as RectTransform).pivot;
	}

	/** 크기 반격을 반환한다 */
	public static Vector3 ExGetSizeDelta(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null && (a_oSender.transform as RectTransform) != null);
		return (a_oSender.transform as RectTransform).sizeDelta.ExTo3D();
	}

	/** 앵커 위치를 반환한다 */
	public static Vector3 ExGetAnchorPos(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null && (a_oSender.transform as RectTransform) != null);
		return (a_oSender.transform as RectTransform).anchoredPosition.ExTo3D();
	}

	/** 최소 앵커를 반환한다 */
	public static Vector3 ExGetAnchorMin(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null && (a_oSender.transform as RectTransform) != null);
		return (a_oSender.transform as RectTransform).anchorMin.ExTo3D();
	}

	/** 최대 앵커를 반환한다 */
	public static Vector3 ExGetAnchorMax(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null && (a_oSender.transform as RectTransform) != null);
		return (a_oSender.transform as RectTransform).anchorMax.ExTo3D();
	}

	/** 계층 경로를 반환한다 */
	public static string ExGetHierarchyPath(this GameObject a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		var oParentList = a_oSender.ExGetParents();

		var oStrBuilder = new System.Text.StringBuilder();

		for(int i = oParentList.Count - 1; i >= KCDefine.B_VAL_0_INT; --i)
		{
			string oPostfix = (i <= KCDefine.B_VAL_0_INT) ? string.Empty : KCDefine.B_TOKEN_SLASH;
			oStrBuilder.AppendFormat(KCDefine.B_TEXT_FMT_2_COMBINE, oParentList[i].name, oPostfix);
		}

		return oStrBuilder.ToString();
	}

	/** 자식을 반환한다 */
	public static List<GameObject> ExGetChildren(this GameObject a_oSender, bool a_bIsIncludeSelf = true)
	{
		CFunc.Assert(a_oSender != null);
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.DescendantsAndSelf() : a_oSender.Descendants();

		return oEnumerator.ToList();
	}

	/** 부모를 반환한다 */
	public static List<GameObject> ExGetParents(this GameObject a_oSender, bool a_bIsIncludeSelf = true)
	{
		CFunc.Assert(a_oSender != null);
		var oEnumerator = a_bIsIncludeSelf ? a_oSender.AncestorsAndSelf() : a_oSender.Ancestors();

		return oEnumerator.ToList();
	}

	/** 레이어를 변경한다 */
	public static void ExSetLayer(this GameObject a_oSender,
		int a_nLayer, bool a_bIsCascade = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 레이어 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.layer = a_nLayer;

		// 계층 적용 모드가 아닐 경우
		if(!a_bIsCascade)
		{
			return;
		}

		foreach(var oObj in a_oSender.Descendants())
		{
			oObj.layer = a_nLayer;
		}
	}

	/** 로컬 비율을 변경한다 */
	public static void ExSetLocalScale(this GameObject a_oSender, Vector3 a_stScale, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.transform.localScale = a_stScale;
		}
	}

	/** 로컬 X 축 비율을 변경한다 */
	public static void ExSetLocalScaleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalScale(new Vector3(a_fVal, a_oSender.transform.localScale.y, a_oSender.transform.localScale.z), a_bIsAssert);
	}

	/** 로컬 Y 축 비율을 변경한다 */
	public static void ExSetLocalScaleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalScale(new Vector3(a_oSender.transform.localScale.x, a_fVal, a_oSender.transform.localScale.z), a_bIsAssert);
	}

	/** 로컬 Z 축 비율을 변경한다 */
	public static void ExSetLocalScaleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalScale(new Vector3(a_oSender.transform.localScale.x, a_oSender.transform.localScale.y, a_fVal), a_bIsAssert);
	}

	/** 월드 각도를 변경한다 */
	public static void ExSetWorldAngle(this GameObject a_oSender, Vector3 a_stAngle, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.transform.eulerAngles = a_stAngle;
		}
	}

	/** 월드 X 축 각도를 변경한다 */
	public static void ExSetWorldAngleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldAngle(new Vector3(a_fVal, a_oSender.transform.eulerAngles.y, a_oSender.transform.eulerAngles.z), a_bIsAssert);
	}

	/** 월드 Y 축 각도를 변경한다 */
	public static void ExSetWorldAngleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldAngle(new Vector3(a_oSender.transform.eulerAngles.x, a_fVal, a_oSender.transform.eulerAngles.z), a_bIsAssert);
	}

	/** 월드 Z 축 각도를 변경한다 */
	public static void ExSetWorldAngleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldAngle(new Vector3(a_oSender.transform.eulerAngles.x, a_oSender.transform.eulerAngles.y, a_fVal), a_bIsAssert);
	}

	/** 로컬 각도를 변경한다 */
	public static void ExSetLocalAngle(this GameObject a_oSender, Vector3 a_stAngle, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.transform.localEulerAngles = a_stAngle;
		}
	}

	/** 로컬 X 축 각도를 변경한다 */
	public static void ExSetLocalAngleX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalAngle(new Vector3(a_fVal, a_oSender.transform.localEulerAngles.y, a_oSender.transform.localEulerAngles.z), a_bIsAssert);
	}

	/** 로컬 Y 축 각도를 변경한다 */
	public static void ExSetLocalAngleY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalAngle(new Vector3(a_oSender.transform.localEulerAngles.x, a_fVal, a_oSender.transform.localEulerAngles.z), a_bIsAssert);
	}

	/** 로컬 Z 축 각도를 변경한다 */
	public static void ExSetLocalAngleZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalAngle(new Vector3(a_oSender.transform.localEulerAngles.x, a_oSender.transform.localEulerAngles.y, a_fVal), a_bIsAssert);
	}

	/** 월드 위치를 변경한다 */
	public static void ExSetWorldPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.transform.position = a_stPos;
		}
	}

	/** 월드 X 축 위치를 변경한다 */
	public static void ExSetWorldPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldPos(new Vector3(a_fVal, a_oSender.transform.position.y, a_oSender.transform.position.z), a_bIsAssert);
	}

	/** 월드 Y 축 위치를 변경한다 */
	public static void ExSetWorldPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldPos(new Vector3(a_oSender.transform.position.x, a_fVal, a_oSender.transform.position.z), a_bIsAssert);
	}

	/** 월드 Z 축 위치를 변경한다 */
	public static void ExSetWorldPosZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetWorldPos(new Vector3(a_oSender.transform.position.x, a_oSender.transform.position.y, a_fVal), a_bIsAssert);
	}

	/** 로컬 위치를 변경한다 */
	public static void ExSetLocalPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 객체가 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.transform.localPosition = a_stPos;
		}
	}

	/** 로컬 X 축 위치를 변경한다 */
	public static void ExSetLocalPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalPos(new Vector3(a_fVal, a_oSender.transform.localPosition.y, a_oSender.transform.localPosition.z), a_bIsAssert);
	}

	/** 로컬 Y 축 위치를 변경한다 */
	public static void ExSetLocalPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalPos(new Vector3(a_oSender.transform.localPosition.x, a_fVal, a_oSender.transform.localPosition.z), a_bIsAssert);
	}

	/** 로컬 Z 축 위치를 변경한다 */
	public static void ExSetLocalPosZ(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);
		a_oSender?.ExSetLocalPos(new Vector3(a_oSender.transform.localPosition.x, a_oSender.transform.localPosition.y, a_fVal), a_bIsAssert);
	}

	/** 기준점을 변경한다 */
	public static void ExSetPivot(this GameObject a_oSender, Vector3 a_stPivot, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 객체가 존재 할 경우
		if(a_oSender != null && (a_oSender.transform as RectTransform) != null)
		{
			(a_oSender.transform as RectTransform).pivot = a_stPivot;
		}
	}

	/** 크기 간격을 변경한다 */
	public static void ExSetSizeDelta(this GameObject a_oSender, Vector3 a_stSize, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 객체가 존재 할 경우
		if(a_oSender != null && (a_oSender.transform as RectTransform) != null)
		{
			(a_oSender.transform as RectTransform).sizeDelta = a_stSize;
		}
	}

	/** X 축 크기 간격을 변경한다 */
	public static void ExSetSizeDeltaX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		a_oSender?.ExSetSizeDelta(new Vector3(a_fVal, (a_oSender.transform as RectTransform).sizeDelta.y, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** Y 축 크기 간격을 변경한다 */
	public static void ExSetSizeDeltaY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		a_oSender?.ExSetSizeDelta(new Vector3((a_oSender.transform as RectTransform).sizeDelta.x, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 앵커 위치를 변경한다 */
	public static void ExSetAnchorPos(this GameObject a_oSender, Vector3 a_stPos, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 객체가 존재 할 경우
		if(a_oSender != null && (a_oSender.transform as RectTransform) != null)
		{
			(a_oSender.transform as RectTransform).anchoredPosition = a_stPos;
		}
	}

	/** X 축 앵커 위치를 변경한다 */
	public static void ExSetAnchorPosX(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));
		a_oSender?.ExSetAnchorPos(new Vector3(a_fVal, (a_oSender.transform as RectTransform).anchoredPosition.y, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** Y 축 앵커 위치를 변경한다 */
	public static void ExSetAnchorPosY(this GameObject a_oSender, float a_fVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));
		a_oSender?.ExSetAnchorPos(new Vector3((a_oSender.transform as RectTransform).anchoredPosition.x, a_fVal, KCDefine.B_VAL_0_REAL), a_bIsAssert);
	}

	/** 최소 앵커를 변경한다 */
	public static void ExSetAnchorMin(this GameObject a_oSender, Vector3 a_stAnchor, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 앵커 변경이 불가능 할 경우
		if(a_oSender == null || (a_oSender.transform as RectTransform) == null)
		{
			return;
		}

		(a_oSender.transform as RectTransform).anchorMin = a_stAnchor;
	}

	/** 최대 앵커를 변경한다 */
	public static void ExSetAnchorMax(this GameObject a_oSender, Vector3 a_stAnchor, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && (a_oSender.transform as RectTransform) != null));

		// 앵커 변경이 불가능 할 경우
		if(a_oSender == null || (a_oSender.transform as RectTransform) == null)
		{
			return;
		}

		(a_oSender.transform as RectTransform).anchorMax = a_stAnchor;
	}

	/** 부모를 변경한다 */
	public static void ExSetParent(this GameObject a_oSender, GameObject a_oParent, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 부모 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.transform.SetParent(a_oParent?.transform, false);
	}
	#endregion // 클래스 접근 함수
}
