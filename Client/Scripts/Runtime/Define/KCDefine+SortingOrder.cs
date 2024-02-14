using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 정렬 순서 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 정렬 순서 {
	public const int B_SORTING_O_ABS = sbyte.MaxValue * 50;
	public const int B_SORTING_O_DEF = sbyte.MaxValue * 0;

	public const int B_SORTING_O_TOP = sbyte.MaxValue * 30;
	public const int B_SORTING_O_TOPMOST = sbyte.MaxValue * 40;

	public const int B_SORTING_O_FOREGROUND = sbyte.MaxValue * 10;
	public const int B_SORTING_O_OVERGROUND = sbyte.MaxValue * 20;

	public const int B_SORTING_O_BACKGROUND = sbyte.MaxValue * -10;
	public const int B_SORTING_O_UNDERGROUND = sbyte.MaxValue * -20;

	public const int B_SORTING_O_UIS = sbyte.MaxValue * 0;
	public const int B_SORTING_O_OVERLAY_UIS = sbyte.MaxValue * 1;

	public const int B_SORTING_O_SCREEN_POPUP_UIS = sbyte.MaxValue * 20;
	public const int B_SORTING_O_SCREEN_TOPMOST_UIS = sbyte.MaxValue * 30;

	public const int B_SORTING_O_SCREEN_ABS_UIS = sbyte.MaxValue * 40;
	public const int B_SORTING_O_SCREEN_BLIND_UIS = sbyte.MaxValue * 50;
	public const int B_SORTING_O_SCREEN_DEBUG_UIS = sbyte.MaxValue * 60;
	// 정렬 순서 }

	// 정렬 레이어 {
	public const string B_SORTING_L_ABS = "Abs";
	public const string B_SORTING_L_DEF = "Default";

	public const string B_SORTING_L_TOP = "Top";
	public const string B_SORTING_L_TOPMOST = "Topmost";

	public const string B_SORTING_L_FOREGROUND = "Foreground";
	public const string B_SORTING_L_OVERGROUND = "Overground";

	public const string B_SORTING_L_BACKGROUND = "Background";
	public const string B_SORTING_L_UNDERGROUND = "Underground";

	public const string B_SORTING_L_OVERLAY_ABS = "OverlayAbs";
	public const string B_SORTING_L_OVERLAY_DEF = "OverlayDefault";

	public const string B_SORTING_L_OVERLAY_TOP = "OverlayTop";
	public const string B_SORTING_L_OVERLAY_TOPMOST = "OverlayTopmost";

	public const string B_SORTING_L_OVERLAY_FOREGROUND = "OverlayForeground";
	public const string B_SORTING_L_OVERLAY_OVERGROUND = "OverlayOverground";

	public const string B_SORTING_L_OVERLAY_BACKGROUND = "OverlayBackground";
	public const string B_SORTING_L_OVERLAY_UNDERGROUND = "OverlayUnderground";
	// 정렬 레이어 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 정렬 순서 {
	public static readonly STSortingOrderInfo B_SORTING_OI_ABS = new STSortingOrderInfo(KCDefine.B_SORTING_O_ABS, KCDefine.B_SORTING_L_ABS);
	public static readonly STSortingOrderInfo B_SORTING_OI_DEF = new STSortingOrderInfo(KCDefine.B_SORTING_O_DEF, KCDefine.B_SORTING_L_DEF);

	public static readonly STSortingOrderInfo B_SORTING_OI_TOP = new STSortingOrderInfo(KCDefine.B_SORTING_O_TOP, KCDefine.B_SORTING_L_TOP);
	public static readonly STSortingOrderInfo B_SORTING_OI_TOPMOST = new STSortingOrderInfo(KCDefine.B_SORTING_O_TOPMOST, KCDefine.B_SORTING_L_TOPMOST);

	public static readonly STSortingOrderInfo B_SORTING_OI_FOREGROUND = new STSortingOrderInfo(KCDefine.B_SORTING_O_FOREGROUND, KCDefine.B_SORTING_L_FOREGROUND);
	public static readonly STSortingOrderInfo B_SORTING_OI_OVERGROUND = new STSortingOrderInfo(KCDefine.B_SORTING_O_OVERGROUND, KCDefine.B_SORTING_L_OVERGROUND);

	public static readonly STSortingOrderInfo B_SORTING_OI_BACKGROUND = new STSortingOrderInfo(KCDefine.B_SORTING_O_BACKGROUND, KCDefine.B_SORTING_L_BACKGROUND);
	public static readonly STSortingOrderInfo B_SORTING_OI_UNDERGROUND = new STSortingOrderInfo(KCDefine.B_SORTING_O_UNDERGROUND, KCDefine.B_SORTING_L_UNDERGROUND);

	public static readonly STSortingOrderInfo B_SORTING_OI_UIS_CANVAS = new STSortingOrderInfo(KCDefine.B_SORTING_O_UIS, KCDefine.B_SORTING_L_DEF);
	public static readonly STSortingOrderInfo B_SORTING_OI_RESULT_UIS_CANVAS = new STSortingOrderInfo(KCDefine.B_SORTING_O_OVERLAY_UIS, KCDefine.B_SORTING_L_DEF);
	public static readonly STSortingOrderInfo B_SORTING_OI_OVERLAY_UIS_CANVAS = new STSortingOrderInfo(KCDefine.B_SORTING_O_OVERLAY_UIS + 10, KCDefine.B_SORTING_L_DEF);
	// 정렬 순서 }

	// 정렬 레이어
	public static readonly List<string> B_SORTING_LAYER_LIST = new List<string>() {
		KCDefine.B_SORTING_L_UNDERGROUND, 
		KCDefine.B_SORTING_L_BACKGROUND, 
		KCDefine.B_SORTING_L_DEF, 
		KCDefine.B_SORTING_L_FOREGROUND, 
		KCDefine.B_SORTING_L_OVERGROUND, 
		KCDefine.B_SORTING_L_TOP, 
		KCDefine.B_SORTING_L_TOPMOST, 
		KCDefine.B_SORTING_L_ABS, 
		
		KCDefine.B_SORTING_L_OVERLAY_UNDERGROUND, 
		KCDefine.B_SORTING_L_OVERLAY_BACKGROUND, 
		KCDefine.B_SORTING_L_OVERLAY_DEF, 
		KCDefine.B_SORTING_L_OVERLAY_FOREGROUND, 
		KCDefine.B_SORTING_L_OVERLAY_OVERGROUND, 
		KCDefine.B_SORTING_L_OVERLAY_TOP, 
		KCDefine.B_SORTING_L_OVERLAY_TOPMOST, 
		KCDefine.B_SORTING_L_OVERLAY_ABS
	};
	#endregion // 런타임 상수
}
