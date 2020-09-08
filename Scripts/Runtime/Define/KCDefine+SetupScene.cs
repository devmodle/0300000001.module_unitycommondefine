using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 설정 씬 상수
public static partial class KCDefine {
	#region 기본
	// 이름 {
	public const string SS_OBJ_NAME_POPUP_UI = "PopupUI";
	public const string SS_OBJ_NAME_TOPMOST_UI = "TopmostUI";
	public const string SS_OBJ_NAME_ABS_UI = "AbsUI";

	public const string SS_OBJ_NAME_TIMER_MANAGER = "TimerManager";
	// 이름 }
	#endregion			// 기본

	#region 런타임 상수
	// 경로
	public static readonly string SS_OBJ_PATH_SCREEN_DEBUG_UI = string.Format("{0}{1}SS_ScreenDebugUI", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_SETUP_SCENE_BASE);
	public static readonly string SS_OBJ_PATH_SCREEN_POPUP_UI = string.Format("{0}{1}SS_ScreenPopupUI", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_SETUP_SCENE_BASE);
	public static readonly string SS_OBJ_PATH_SCREEN_TOPMOST_UI = string.Format("{0}{1}SS_ScreenTopmostUI", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_SETUP_SCENE_BASE);
	public static readonly string SS_OBJ_PATH_SCREEN_ABS_UI = string.Format("{0}{1}SS_ScreenAbsUI", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_SETUP_SCENE_BASE);
	#endregion			// 런타임 상수

	#region 조건부 상수
#if LOGIC_TEST_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	// 이름
	public const string SS_OBJ_NAME_DEBUG_UI = "DebugUI";
#endif			// #if LOGIC_TEST_ENABLE || (DEBUG || DEVELOPMENT_BUILD)

#if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	// 이름
	public const string SS_OBJ_NAME_FPS_COUNTER = "FPSCounter";
#endif			// #if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	#endregion			// 조건부 상수
}
