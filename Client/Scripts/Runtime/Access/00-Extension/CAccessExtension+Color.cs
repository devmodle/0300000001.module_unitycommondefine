using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 접근자 확장 클래스 - 색상 */
public static partial class CAccessExtension {
	#region 클래스 접근 함수
	/** 색상을 반환한다 */
	public static Color ExGetAlphaColor(this Color a_stSender, float a_fAlpha) {
		a_stSender.a = a_fAlpha;
		return a_stSender;
	}

	/** 일반 색상 블럭을 반환한다 */
	public static ColorBlock ExGetNormColorBlock(this ColorBlock a_stSender, Color a_stColor) {
		a_stSender.normalColor = a_stColor;
		return a_stSender;
	}

	/** 프레스 색상 블럭을 반환한다 */
	public static ColorBlock ExGetPressColorBlock(this ColorBlock a_stSender, Color a_stColor) {
		a_stSender.pressedColor = a_stColor;
		return a_stSender;
	}

	/** 선택 색상 블럭을 반환한다 */
	public static ColorBlock ExGetSelColorBlock(this ColorBlock a_stSender, Color a_stColor) {
		a_stSender.selectedColor = a_stColor;
		return a_stSender;
	}

	/** 하이라이트 색상 블럭을 반환한다 */
	public static ColorBlock ExGetHighlightColorBlock(this ColorBlock a_stSender, Color a_stColor) {
		a_stSender.highlightedColor = a_stColor;
		return a_stSender;
	}

	/** 비활성 색상 블럭을 반환한다 */
	public static ColorBlock ExGetDisableColorBlock(this ColorBlock a_stSender, Color a_stColor) {
		a_stSender.disabledColor = a_stColor;
		return a_stSender;
	}
	#endregion // 클래스 접근 함수
}
