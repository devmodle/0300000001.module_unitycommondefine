using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using TMPro;

/** 확장 클래스 - UI */
public static partial class CExtension {
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this Mask a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.showMaskGraphic = false;
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this Selectable a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		var stColorBlock = a_oSender.colors;
		stColorBlock.fadeDuration = KCDefine.U_DURATION_ANI;
		stColorBlock.colorMultiplier = KCDefine.B_VAL_1_REAL;

		a_oSender.colors = stColorBlock;
		a_oSender.colors = a_oSender.colors.ExGetNormColorBlock(KCDefine.B_COLOR_NORM);
		a_oSender.colors = a_oSender.colors.ExGetPressColorBlock(KCDefine.B_COLOR_PRESS);
		a_oSender.colors = a_oSender.colors.ExGetSelColorBlock(KCDefine.B_COLOR_SEL);
		a_oSender.colors = a_oSender.colors.ExGetHighlightColorBlock(KCDefine.B_COLOR_HIGHLIGHT);
		a_oSender.colors = a_oSender.colors.ExGetDisableColorBlock(KCDefine.B_COLOR_DISABLE);
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this HorizontalOrVerticalLayoutGroup a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		var oParent = a_oSender.transform.parent;
		var oLayoutGroupInParent = oParent.GetComponentInParent<HorizontalOrVerticalLayoutGroup>();

		var stSizeDelta = (oLayoutGroupInParent != null) ? a_oSender.gameObject.ExGetSizeDelta() : Vector3.zero;

		a_oSender.childScaleWidth = false;
		a_oSender.childScaleHeight = false;

		a_oSender.childControlWidth = true;
		a_oSender.childControlHeight = true;

		a_oSender.childForceExpandWidth = true;
		a_oSender.childForceExpandHeight = true;

		a_oSender.childAlignment = TextAnchor.UpperLeft;
		a_oSender.gameObject.ExSetSizeDelta(stSizeDelta, a_bIsAssert);

		// 크기 조정자 설정이 불가능 할 경우
		if(!a_oSender.TryGetComponent(out ContentSizeFitter oContentsSizeFitter)) {
			return;
		}

		oContentsSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		oContentsSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this Canvas a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.pixelPerfect = false;
		a_oSender.targetDisplay = KCDefine.B_VAL_0_INT;
		a_oSender.additionalShaderChannels = (AdditionalCanvasShaderChannels)int.MaxValue;
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this CanvasScaler a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
		a_oSender.referencePixelsPerUnit = KCDefine.B_UNIT_REF_PIXELS_PER_UNIT;
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this CanvasRenderer a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.cullTransparentMesh = true;
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - UI (텍스트) */
public static partial class CExtension {
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this Text a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.fontSize = (a_oSender.fontSize <= KCDefine.U_DEF_MIN_SIZE_FONT) ? 
			KCDefine.U_DEF_MIN_SIZE_FONT : a_oSender.fontSize;

		a_oSender.resizeTextMaxSize = (a_oSender.fontSize <= KCDefine.U_DEF_MAX_SIZE_FONT) ? 
			KCDefine.U_DEF_MAX_SIZE_FONT : a_oSender.fontSize;

		a_oSender.alignment = TextAnchor.MiddleLeft;
		a_oSender.resizeTextMinSize = KCDefine.U_DEF_MIN_SIZE_FONT;

		a_oSender.verticalOverflow = VerticalWrapMode.Truncate;
		a_oSender.horizontalOverflow = HorizontalWrapMode.Wrap;

		// 크기 보정자를 설정한다 {
		var stAnchorMin = a_oSender.rectTransform.anchorMin;
		var stAnchorMax = a_oSender.rectTransform.anchorMax;
		var oContentsSizeFitter = a_oSender.gameObject.ExAddComponent<ContentSizeFitter>();

		oContentsSizeFitter.verticalFit = stAnchorMin.y.ExIsEquals(stAnchorMax.y) ? 
			ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;

		oContentsSizeFitter.horizontalFit = stAnchorMin.x.ExIsEquals(stAnchorMax.x) ? 
			ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
		// 크기 보정자를 설정한다 }
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this TMP_Text a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.fontSize = (a_oSender.fontSize <= KCDefine.U_DEF_MIN_SIZE_FONT) ? 
			KCDefine.U_DEF_MIN_SIZE_FONT : a_oSender.fontSize;

		a_oSender.fontSizeMax = (a_oSender.fontSize <= KCDefine.U_DEF_MAX_SIZE_FONT) ? 
			KCDefine.U_DEF_MAX_SIZE_FONT : a_oSender.fontSize;

		a_oSender.fontSizeMin = KCDefine.U_DEF_MIN_SIZE_FONT;
		a_oSender.enableWordWrapping = true;

		a_oSender.overflowMode = TextOverflowModes.Truncate;
		a_oSender.verticalAlignment = VerticalAlignmentOptions.Middle;
		a_oSender.horizontalAlignment = HorizontalAlignmentOptions.Left;

		// 크기 보정자를 설정한다 {
		var stAnchorMin = a_oSender.rectTransform.anchorMin;
		var stAnchorMax = a_oSender.rectTransform.anchorMax;
		var oContentsSizeFitter = a_oSender.gameObject.ExAddComponent<ContentSizeFitter>();

		oContentsSizeFitter.verticalFit = stAnchorMin.y.ExIsEquals(stAnchorMax.y) ? 
			ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;

		oContentsSizeFitter.horizontalFit = stAnchorMin.x.ExIsEquals(stAnchorMax.x) ? 
			ContentSizeFitter.FitMode.PreferredSize : ContentSizeFitter.FitMode.Unconstrained;
		// 크기 보정자를 설정한다 }
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - UI (이미지) */
public static partial class CExtension {
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this Image a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.pixelsPerUnitMultiplier = KCDefine.B_VAL_1_REAL;
	}

	/** 상태를 리셋한다 */
	public static void ExReset(this RawImage a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.pixelsPerUnitMultiplier = KCDefine.B_VAL_1_REAL;
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - UI (버튼) */
public static partial class CExtension {
	#region 클래스 함수
	/** 리스너를 추가한다 */
	public static void ExAddListener(this Button a_oSender, 
		UnityAction a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 리스너 추가가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null) {
			reutrn;
		}

		// 리셋 모드 일 경우
		if(a_bIsReset) {
			a_oSender.onClick.RemoveAllListeners();
		}

		a_oSender.onClick.AddListener(a_oCallback);
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this Slider a_oSender, 
		UnityAction<float> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 리스너 추가가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null) {
			reutrn;
		}

		// 리셋 모드 일 경우
		if(a_bIsReset) {
			a_oSender.onValueChanged.RemoveAllListeners();
		}

		a_oSender.onValueChanged.AddListener(a_oCallback);
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - UI (입력) */
public static partial class CExtension {
	#region 클래스 함수
	/** 리스너를 추가한다 */
	public static void ExAddListener(this Dropdown a_oSender, 
		UnityAction<int> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 드롭이 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onValueChanged.RemoveAllListeners();
			}

			a_oSender.onValueChanged.AddListener(a_oCallback);
		}
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this TMP_Dropdown a_oSender, 
		UnityAction<int> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 드롭이 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onValueChanged.RemoveAllListeners();
			}

			a_oSender.onValueChanged.AddListener(a_oCallback);
		}
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this InputField a_oSender, 
		UnityAction<string> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 입력 필드가 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onValueChanged.RemoveAllListeners();
			}

			a_oSender.onValueChanged.AddListener(a_oCallback);
		}
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this TMP_InputField a_oSender, 
		UnityAction<string> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 입력 필드가 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onValueChanged.RemoveAllListeners();
			}

			a_oSender.onValueChanged.AddListener(a_oCallback);
		}
	}

	/** 편집 종료 리스너를 추가한다 */
	public static void ExAddEndEditListener(this InputField a_oSender, 
		UnityAction<string> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 입력 필드가 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onEndEdit.RemoveAllListeners();
			}

			a_oSender.onEndEdit.AddListener(a_oCallback);
		}
	}

	/** 편집 종료 리스너를 추가한다 */
	public static void ExAddEndEditListener(this TMP_InputField a_oSender, 
		UnityAction<string> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {
			
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 입력 필드가 존재 할 경우
		if(a_oSender != null && a_oCallback != null) {
			// 리셋 모드 일 경우
			if(a_bIsReset) {
				a_oSender.onEndEdit.RemoveAllListeners();
			}

			a_oSender.onEndEdit.AddListener(a_oCallback);
		}
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - UI (스크롤 뷰) */
public static partial class CExtension {
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this ScrollRect a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.scrollSensitivity = KCDefine.U_UNIT_SCROLL_SENSITIVITY;
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this Scrollbar a_oSender, 
		UnityAction<float> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 리스너 추가가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null) {
			reutrn;
		}

		// 리셋 모드 일 경우
		if(a_bIsReset) {
			a_oSender.onValueChanged.RemoveAllListeners();
		}

		a_oSender.onValueChanged.AddListener(a_oCallback);
	}

	/** 리스너를 추가한다 */
	public static void ExAddListener(this SimpleScrollSnap a_oSender, 
		UnityAction<int, int> a_oCallback, bool a_bIsReset = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCallback != null));

		// 리스너 추가가 불가능 할 경우
		if(a_oSender == null || a_oCallback == null) {
			return;
		}

		// 리셋 모드 일 경우
		if(a_bIsReset) {
			a_oSender.OnPanelCentered.RemoveAllListeners();
		}

		a_oSender.OnPanelCentered.AddListener(a_oCallback);
	}
	#endregion // 클래스 함수
}
