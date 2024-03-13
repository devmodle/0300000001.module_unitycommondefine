using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if DEBUG || DEVELOPMENT_BUILD
/** 상수 - 디버그 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 이름 {
	public const string U_OBJ_N_SCREEN_FPS_INFO_UIS = "FPSInfoUIs";
	public const string U_OBJ_N_SCREEN_DEBUG_INFO_UIS = "DebugInfoUIs";

	public const string U_OBJ_N_SCREEN_FPS_TEXT = "FPSText";
	public const string U_OBJ_N_SCREEN_FRAME_TIME_TEXT = "FrameTimeText";
	public const string U_OBJ_N_SCREEN_DEVICE_INFO_TEXT = "DeviceInfoText";

	public const string U_OBJ_N_SCREEN_STATIC_DEBUG_TEXT = "StaticDebugText";
	public const string U_OBJ_N_SCREEN_DYNAMIC_DEBUG_TEXT = "DynamicDebugText";

	public const string U_OBJ_N_SCREEN_FPS_INFO_BTN = "FPSInfoBtn";
	public const string U_OBJ_N_SCREEN_DEBUG_INFO_BTN = "DebugInfoBtn";

	public const string U_OBJ_N_SCREEN_TIME_SCALE_UP_BTN = "TimeScaleUpBtn";
	public const string U_OBJ_N_SCREEN_TIME_SCALE_DOWN_BTN = "TimeScaleDownBtn";
	// 이름 }

	// 형식 {
	public const string U_TEXT_FMT_STATIC_DEBUG_MSG = "{0}\n\n{1}";
	public const string U_TEXT_FMT_DYNAMIC_DEBUG_MSG = "{0}\n\n{1}";

	public const string U_TEXT_FMT_FPS = "FPS: <color=orange>{0:0.0}</color> <color=green>[{1:0.0}]</color>";
	public const string U_TEXT_FMT_FRAME_TIME = "Frame Time: <color=orange>{0:0.0}</color> ms";
	public const string U_TEXT_FMT_DEVICE_INFO = "Graphics Device: <color=orange>{0}</color> <color=green>[{1}]</color>";

	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_A = "Screen Size: <color=orange>{0:0.0}</color>, <color=orange>{1:0.0}</color>\n";
	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_B = "Canvas Size: <color=orange>{0:0.0}</color>, <color=orange>{1:0.0}</color>\n";
	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_C = "SafeArea Offset: <color=orange>{0:0.0}</color>, <color=orange>{1:0.0}</color>, <color=orange>{2:0.0}</color>, <color=orange>{3:0.0}</color>\n";
	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_D = "Quality Level: <color=orange>{0}</color>, Target Frame Rate: <color=orange>{1}</color>\n";
	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_E = "Persistent Data Path: <color=orange>{0}</color>";
	public const string U_TEXT_FMT_STATIC_DEBUG_INFO_F = "\nScreen DPI: <color=orange>{0:0.0}</color>, Banner Ads Height: <color=orange>{1:0.0}</color>";

	public const string U_TEXT_FMT_DYNAMIC_DEBUG_INFO_A = "Used Heap: <color=orange>{0:0.0}</color> MB, GPU Alloc: <color=orange>{1:0.0}</color> MB\n";
	public const string U_TEXT_FMT_DYNAMIC_DEBUG_INFO_B = "Mono Heap: <color=orange>{0:0.0}</color> MB, Mono Used: <color=orange>{1:0.0}</color> MB\n";
	public const string U_TEXT_FMT_DYNAMIC_DEBUG_INFO_C = "Temp Alloc: <color=orange>{0:0.0}</color> MB, Total Alloc: <color=orange>{1:0.0}</color> MB\n";
	public const string U_TEXT_FMT_DYNAMIC_DEBUG_INFO_D = "Reserved: <color=orange>{0:0.0}</color> MB, Unused Reserved: <color=orange>{1:0.0}</color> MB\n";
	public const string U_TEXT_FMT_DYNAMIC_DEBUG_INFO_E = "Time Scale: <color=orange>{0:0.00}</color>";
	// 형식 }
	#endregion // 컴파일 상수
}
#endif // #if DEBUG || DEVELOPMENT_BUILD
