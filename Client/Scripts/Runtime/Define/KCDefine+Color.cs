using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 색상 */
public static partial class KCDefine {
	#region 런타임 상수
	// 색상 {
	public static readonly Color B_COLOR_NORM = Color.white;
	public static readonly Color B_COLOR_PRESS = new Color(0.75f, 0.75f, 0.75f, 1.0f);
	public static readonly Color B_COLOR_SEL = Color.white;
	public static readonly Color B_COLOR_HIGHLIGHT = Color.white;
	public static readonly Color B_COLOR_DISABLE = new Color(0.35f, 0.35f, 0.35f, 1.0f);
	public static readonly Color B_COLOR_TRANSPARENT = Color.clear;

	public static readonly Color B_COLOR_BLIND_UIS = Color.black;
	public static readonly Color B_COLOR_SCREEN_FADE_IN = Color.black;
	public static readonly Color B_COLOR_SCREEN_FADE_OUT = KCDefine.B_COLOR_TRANSPARENT;

	public static readonly Color B_COLOR_CLEAR = Color.black;
	public static readonly Color B_COLOR_POPUP_BLIND = new Color(0.0f, 0.0f, 0.0f, 0.95f);
	public static readonly Color B_COLOR_INDICATOR_BLIND = new Color(0.0f, 0.0f, 0.0f, 0.75f);
	// 색상 }
	#endregion // 런타임 상수
}
