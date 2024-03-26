using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && BURST_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 버스트 */
public static partial class KCDefineEditor {
	#region 컴파일 상수
	// 식별자 {
	public const string G_BURST_KEY_FOR_OPTIMIZE = "OptimizeFor";
	public const string G_BURST_KEY_BEHAVIOUR_MONO = "MonoBehaviour";
	public const string G_BURST_KEY_LINKER_SDK_PLATFORM_USE = "UsePlatformSDKLinker";

	public const string G_BURST_KEY_ENABLE_OPTIMISATIONS = "EnableOptimisations";
	public const string G_BURST_KEY_ENABLE_COMPILATION_BURST = "EnableBurstCompilation";
	public const string G_BURST_KEY_ENABLE_CHECKS_SAFETY = "EnableSafetyChecks";
	public const string G_BURST_KEY_ENABLE_BUILDS_ALL_IN_DEBUG = "EnableDebugInAllBuilds";
	// 식별자 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로 {
	public static readonly string G_BURST_DATA_P_SETTINGS_AOT_IOS = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_iOS.json";
	public static readonly string G_BURST_DATA_P_SETTINGS_AOT_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_Android.json";

	public static readonly string G_BURST_DATA_P_SETTINGS_AOT_MAC = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_StandaloneOSX.json";
	public static readonly string G_BURST_DATA_P_SETTINGS_AOT_WNDS = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_StandaloneWindows.json";
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && BURST_MODULE_ENABLE
