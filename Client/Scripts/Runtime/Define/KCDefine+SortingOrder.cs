using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 정렬 순서 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 정렬 순서 {
	public const int G_SORTING_O_ABS = sbyte.MaxValue * 50;
	public const int G_SORTING_O_DEF = sbyte.MaxValue * 0;

	public const int G_SORTING_O_TOP = sbyte.MaxValue * 30;
	public const int G_SORTING_O_TOPMOST = sbyte.MaxValue * 40;

	public const int G_SORTING_O_FOREGROUND = sbyte.MaxValue * 10;
	public const int G_SORTING_O_OVERGROUND = sbyte.MaxValue * 20;

	public const int G_SORTING_O_BACKGROUND = sbyte.MaxValue * -10;
	public const int G_SORTING_O_UNDERGROUND = sbyte.MaxValue * -20;

	public const int G_SORTING_O_UIS = sbyte.MaxValue * 0;
	public const int G_SORTING_O_UIS_OVERLAY = sbyte.MaxValue * 1;

	public const int G_SORTING_O_UIS_POPUP_SCREEN = sbyte.MaxValue * 20;
	public const int G_SORTING_O_UIS_TOPMOST_SCREEN = sbyte.MaxValue * 30;

	public const int G_SORTING_O_UIS_ABS_SCREEN = sbyte.MaxValue * 40;
	public const int G_SORTING_O_UIS_BLIND_SCREEN = sbyte.MaxValue * 50;
	public const int G_SORTING_O_UIS_DEBUG_SCREEN = sbyte.MaxValue * 60;
	// 정렬 순서 }

	// 정렬 레이어 {
	public const string G_SORTING_L_ABS = "Abs";
	public const string G_SORTING_L_DEF = "Default";

	public const string G_SORTING_L_TOP = "Top";
	public const string G_SORTING_L_TOPMOST = "Topmost";

	public const string G_SORTING_L_FOREGROUND = "Foreground";
	public const string G_SORTING_L_OVERGROUND = "Overground";

	public const string G_SORTING_L_BACKGROUND = "Background";
	public const string G_SORTING_L_UNDERGROUND = "Underground";

	public const string G_SORTING_L_ABS_OVERLAY = "AbsOverlay";
	public const string G_SORTING_L_DEF_OVERLAY = "DefaultOverlay";

	public const string G_SORTING_L_TOP_OVERLAY = "TopOverlay";
	public const string G_SORTING_L_TOPMOST_OVERLAY = "TopmostOverlay";

	public const string G_SORTING_L_FOREGROUND_OVERLAY = "ForegroundOverlay";
	public const string G_SORTING_L_OVERGROUND_OVERLAY = "OvergroundOverlay";

	public const string G_SORTING_L_BACKGROUND_OVERLAY = "BackgroundOverlay";
	public const string G_SORTING_L_UNDERGROUND_OVERLAY = "UndergroundOverlay";
	// 정렬 레이어 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 정렬 순서 {
	public static readonly STSortingOrderInfo G_SORTING_OI_ABS = new STSortingOrderInfo(KCDefine.G_SORTING_O_ABS, KCDefine.G_SORTING_L_ABS);
	public static readonly STSortingOrderInfo G_SORTING_OI_DEF = new STSortingOrderInfo(KCDefine.G_SORTING_O_DEF, KCDefine.G_SORTING_L_DEF);

	public static readonly STSortingOrderInfo G_SORTING_OI_TOP = new STSortingOrderInfo(KCDefine.G_SORTING_O_TOP, KCDefine.G_SORTING_L_TOP);
	public static readonly STSortingOrderInfo G_SORTING_OI_TOPMOST = new STSortingOrderInfo(KCDefine.G_SORTING_O_TOPMOST, KCDefine.G_SORTING_L_TOPMOST);

	public static readonly STSortingOrderInfo G_SORTING_OI_FOREGROUND = new STSortingOrderInfo(KCDefine.G_SORTING_O_FOREGROUND, KCDefine.G_SORTING_L_FOREGROUND);
	public static readonly STSortingOrderInfo G_SORTING_OI_OVERGROUND = new STSortingOrderInfo(KCDefine.G_SORTING_O_OVERGROUND, KCDefine.G_SORTING_L_OVERGROUND);

	public static readonly STSortingOrderInfo G_SORTING_OI_BACKGROUND = new STSortingOrderInfo(KCDefine.G_SORTING_O_BACKGROUND, KCDefine.G_SORTING_L_BACKGROUND);
	public static readonly STSortingOrderInfo G_SORTING_OI_UNDERGROUND = new STSortingOrderInfo(KCDefine.G_SORTING_O_UNDERGROUND, KCDefine.G_SORTING_L_UNDERGROUND);

	public static readonly STSortingOrderInfo G_SORTING_OI_CANVAS_UIS = new STSortingOrderInfo(KCDefine.G_SORTING_O_UIS, KCDefine.G_SORTING_L_DEF);
	public static readonly STSortingOrderInfo G_SORTING_OI_CANVAS_UIS_RESULT = new STSortingOrderInfo(KCDefine.G_SORTING_O_UIS_OVERLAY, KCDefine.G_SORTING_L_DEF);
	public static readonly STSortingOrderInfo G_SORTING_OI_CANVAS_UIS_OVERLAY = new STSortingOrderInfo(KCDefine.G_SORTING_O_UIS_OVERLAY + 10, KCDefine.G_SORTING_L_DEF);
	// 정렬 순서 }

	// 정렬 레이어
	public static readonly List<string> G_LIST_LAYER_SORTING = new List<string>()
	{
		KCDefine.G_SORTING_L_UNDERGROUND,
		KCDefine.G_SORTING_L_BACKGROUND,
		KCDefine.G_SORTING_L_DEF,
		KCDefine.G_SORTING_L_FOREGROUND,
		KCDefine.G_SORTING_L_OVERGROUND,
		KCDefine.G_SORTING_L_TOP,
		KCDefine.G_SORTING_L_TOPMOST,
		KCDefine.G_SORTING_L_ABS,

		KCDefine.G_SORTING_L_UNDERGROUND_OVERLAY,
		KCDefine.G_SORTING_L_BACKGROUND_OVERLAY,
		KCDefine.G_SORTING_L_DEF_OVERLAY,
		KCDefine.G_SORTING_L_FOREGROUND_OVERLAY,
		KCDefine.G_SORTING_L_OVERGROUND_OVERLAY,
		KCDefine.G_SORTING_L_TOP_OVERLAY,
		KCDefine.G_SORTING_L_TOPMOST_OVERLAY,
		KCDefine.G_SORTING_L_ABS_OVERLAY
	};
	#endregion // 런타임 상수
}
