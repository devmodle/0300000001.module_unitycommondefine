using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using TMPro;

/** 접근자 확장 클래스 - UI */
public static partial class CAccessExtension {
	#region 클래스 접근 함수
	/** 월드 위치를 반환한다 */
	public static Vector3 ExGetWorldPos(this PointerEventData a_oSender) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.ExGetWorldPos(KCDefine.B_DESIGN_SCREEN_SIZE);
	}

	/** 월드 위치를 반환한다 */
	public static Vector3 ExGetWorldPos(this PointerEventData a_oSender, Vector3 a_stScreenSize) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.position.ExTo3D().ExGetWorldPos(a_stScreenSize);
	}

	/** 로컬 위치를 반환한다 */
	public static Vector3 ExGetLocalPos(this PointerEventData a_oSender, GameObject a_oParent) {
		CFunc.Assert(a_oSender != null && a_oParent != null);
		return a_oSender.ExGetLocalPos(a_oParent, KCDefine.B_DESIGN_SCREEN_SIZE);
	}

	/** 로컬 위치를 반환한다 */
	public static Vector3 ExGetLocalPos(this PointerEventData a_oSender, GameObject a_oParent, Vector3 a_stScreenSize) {
		CFunc.Assert(a_oSender != null && a_oParent != null);
		return a_oSender.ExGetWorldPos(a_stScreenSize).ExToLocal(a_oParent);
	}

	/** 앵커 위치를 반환한다 */
	public static Vector3 ExGetAnchorPos(this PointerEventData a_oSender, GameObject a_oParent) {
		CFunc.Assert(a_oSender != null && a_oParent != null);
		return a_oSender.position.ExTo3D().ExToLocal(a_oParent);
	}

	/** 월드 간격을 반환한다 */
	public static Vector3 ExGetWorldPosDelta(this PointerEventData a_oSender) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.ExGetWorldPosDelta(KCDefine.B_DESIGN_SCREEN_SIZE);
	}

	/** 월드 간격을 반환한다 */
	public static Vector3 ExGetWorldPosDelta(this PointerEventData a_oSender, Vector3 a_stScreenSize) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.pointerPressRaycast.screenPosition.ExTo3D().ExGetWorldPos(a_stScreenSize) - a_oSender.pointerCurrentRaycast.screenPosition.ExTo3D().ExGetWorldPos(a_stScreenSize);
	}

	/** 로컬 간격을 반환한다 */
	public static Vector3 ExGetLocalPosDelta(this PointerEventData a_oSender, GameObject a_oParent) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.ExGetLocalPosDelta(a_oParent, KCDefine.B_DESIGN_SCREEN_SIZE);
	}

	/** 로컬 간격을 반환한다 */
	public static Vector3 ExGetLocalPosDelta(this PointerEventData a_oSender, GameObject a_oParent, Vector3 a_stScreenSize) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.pointerPressRaycast.screenPosition.ExTo3D().ExGetWorldPos(a_stScreenSize).ExToLocal(a_oParent) - a_oSender.pointerCurrentRaycast.screenPosition.ExTo3D().ExGetWorldPos(a_stScreenSize).ExToLocal(a_oParent);
	}

	/** 앵커 간격을 반환한다 */
	public static Vector3 ExGetAnchorPosDelta(this PointerEventData a_oSender, GameObject a_oParent) {
		CFunc.Assert(a_oSender != null);
		return a_oSender.pointerPressRaycast.screenPosition.ExTo3D().ExToLocal(a_oParent) - a_oSender.pointerCurrentRaycast.screenPosition.ExTo3D().ExToLocal(a_oParent);
	}

	/** 스크롤 뷰 정규 위치를 반환한다 */
	public static Vector3 ExGetNormPos(this ScrollRect a_oSender, 
		GameObject a_oViewport, GameObject a_oContents, Vector3 a_stPos) {

		CFunc.Assert(a_oSender != null && a_oViewport != null && a_oContents != null);
		return new Vector3(a_oSender.ExGetNormPosH(a_oViewport, a_oContents, a_stPos), a_oSender.ExGetNormPosV(a_oViewport, a_oContents, a_stPos), KCDefine.B_VAL_0_REAL);
	}

	/** 스크롤 뷰 수직 정규 위치를 반환한다 */
	public static float ExGetNormPosV(this ScrollRect a_oSender, 
		GameObject a_oViewport, GameObject a_oContents, Vector3 a_stPos) {

		CFunc.Assert(a_oSender != null && a_oViewport != null && a_oContents != null);
		return Mathf.Clamp01((a_stPos.y - (a_oViewport.transform as RectTransform).rect.height) / ((a_oContents.transform as RectTransform).rect.height - (a_oViewport.transform as RectTransform).rect.height));
	}

	/** 스크롤 뷰 수평 정규 위치를 반환한다 */
	public static float ExGetNormPosH(this ScrollRect a_oSender, 
		GameObject a_oViewport, GameObject a_oContents, Vector3 a_stPos) {

		CFunc.Assert(a_oSender != null && a_oViewport != null && a_oContents != null);
		return Mathf.Clamp01((a_stPos.x - (a_oViewport.transform as RectTransform).rect.width) / ((a_oContents.transform as RectTransform).rect.width - (a_oViewport.transform as RectTransform).rect.width));
	}

	/** 상호 작용 여부를 변경한다 */
	public static void ExSetInteractable(this Selectable a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상호 작용 여부 변경이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.interactable = a_bIsEnable;
	}

	/** 상호 작용 여부를 변경한다 */
	public static void ExSetRaycastTarget(this Graphic a_oSender, bool a_bIsEnable, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상호 작용 여부 변경이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.raycastTarget = a_bIsEnable;
	}

	/** 월드 위치를 반환한다 */
	private static Vector3 ExGetWorldPos(this Vector3 a_stSender, Vector3 a_stScreenSize) {
		float fNormPosX = ((a_stSender.x * KCDefine.B_VAL_2_REAL) / CAccess.DeviceScreenSize.x) - KCDefine.B_VAL_1_REAL;
		float fNormPosY = ((a_stSender.y * KCDefine.B_VAL_2_REAL) / CAccess.DeviceScreenSize.y) - KCDefine.B_VAL_1_REAL;

		float fScreenWidth = a_stScreenSize.y * (CAccess.DeviceScreenSize.x / CAccess.DeviceScreenSize.y);

		return new Vector3(fNormPosX * (fScreenWidth / KCDefine.B_VAL_2_REAL), 
			fNormPosY * (a_stScreenSize.y / KCDefine.B_VAL_2_REAL), a_stSender.z) * KCDefine.B_UNIT_SCALE;
	}
	#endregion // 클래스 접근 함수
}

/** 접근자 확장 클래스 - UI (텍스트) */
public static partial class CAccessExtension {
	#region 클래스 접근 함수
	/** 텍스트를 변경한다 */
	public static void ExSetText(this Text a_oSender, 
		string a_oStr, STFontSetInfo a_stFontSetInfo, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stFontSetInfo.m_oPath.ExIsValid()));

		// 텍스트 변경이 불가능 할 경우
		if(a_oSender == null || !a_stFontSetInfo.m_oPath.ExIsValid()) {
			return;
		}

		a_oSender.text = a_oStr;
		a_oSender.font = Resources.Load<Font>(a_stFontSetInfo.m_oPath);
	}

	/** 텍스트를 변경한다 */
	public static void ExSetText(this TMP_Text a_oSender, 
		string a_oStr, STFontSetInfo a_stFontSetInfo, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stFontSetInfo.m_oPath.ExIsValid()));

		// 텍스트 변경이 불가능 할 경우
		if(a_oSender == null || !a_stFontSetInfo.m_oPath.ExIsValid()) {
			return;
		}

		a_oSender.text = a_oStr;
		a_oSender.font = Resources.Load<TMP_FontAsset>(a_stFontSetInfo.m_oPath);
	}
	#endregion // 클래스 접근 함수
}

/** 접근자 확장 클래스 - UI (버튼) */
public static partial class CAccessExtension {
	#region 클래스 접근 함수
	/** 일반 색상을 변경한다 */
	public static void ExSetNormColor(this Button a_oSender, Color a_stColor, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 색상 변경이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.colors = a_oSender.colors.ExGetNormColorBlock(a_stColor);
	}

	/** 선택 색상을 변경한다 */
	public static void ExSetSelColor(this Button a_oSender, Color a_stColor, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 색상 변경이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.colors = a_oSender.colors.ExGetSelColorBlock(a_stColor);
	}

	/** 비활성 색상을 변경한다 */
	public static void ExSetDisableColor(this Button a_oSender, Color a_stColor, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 색상 변경이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.colors = a_oSender.colors.ExGetDisableColorBlock(a_stColor);
	}
	#endregion // 클래스 접근 함수
}

/** 접근자 확장 클래스 - UI (입력 필드) */
public static partial class CAccessExtension {
	#region 클래스 접근 함수
	/** 텍스트를 변경한다 */
	public static void ExSetText(this InputField a_oSender, 
		string a_oStr, STFontSetInfo a_stFontSetInfo, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stFontSetInfo.m_oPath.ExIsValid()));

		// 텍스트 변경이 불가능 할 경우
		if(a_oSender == null || !a_stFontSetInfo.m_oPath.ExIsValid()) {
			return;
		}

		a_oSender.text = a_oStr;

		a_oSender.gameObject.ExEnumerateComponents<Text>((a_oText) => {
			a_oText.font = Resources.Load<Font>(a_stFontSetInfo.m_oPath);
			return true;
		}, true, a_bIsAssert);
	}

	/** 텍스트를 변경한다 */
	public static void ExSetText(this TMP_InputField a_oSender, 
		string a_oStr, STFontSetInfo a_stFontSetInfo, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stFontSetInfo.m_oPath.ExIsValid()));

		// 텍스트 변경이 불가능 할 경우
		if(a_oSender == null || !a_stFontSetInfo.m_oPath.ExIsValid()) {
			return;
		}

		a_oSender.text = a_oStr;
		a_oSender.fontAsset = Resources.Load<TMP_FontAsset>(a_stFontSetInfo.m_oPath);

		a_oSender.gameObject.ExEnumerateComponents<TMP_Text>((a_oText) => {
			a_oText.font = Resources.Load<TMP_FontAsset>(a_stFontSetInfo.m_oPath);
			return true;
		}, true, a_bIsAssert);
	}
	#endregion // 클래스 접근 함수
}
