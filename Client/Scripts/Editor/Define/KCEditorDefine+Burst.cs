using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && BURST_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 버스트 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 식별자 {
	public const string B_KEY_BURST_AS_OPTIMIZE_FOR = "OptimizeFor";
	public const string B_KEY_BURST_AS_MONO_BEHAVIOUR = "MonoBehaviour";
	public const string B_KEY_BURST_AS_USE_PLATFORM_SDK_LINKER = "UsePlatformSDKLinker";

	public const string B_KEY_BURST_AS_ENABLE_OPTIMISATIONS = "EnableOptimisations";
	public const string B_KEY_BURST_AS_ENABLE_BURST_COMPILATION = "EnableBurstCompilation";
	public const string B_KEY_BURST_AS_ENABLE_SAFETY_CHECKS = "EnableSafetyChecks";
	public const string B_KEY_BURST_AS_ENABLE_DEBUG_IN_ALL_BUILDS = "EnableDebugInAllBuilds";
	// 식별자 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로 {
	public static readonly string B_DATA_P_IOS_BURST_AOT_SETTINGS = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_iOS.json";
	public static readonly string B_DATA_P_ANDROID_BURST_AOT_SETTINGS = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_Android.json";

	public static readonly string B_DATA_P_MAC_BURST_AOT_SETTINGS = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_StandaloneOSX.json";
	public static readonly string B_DATA_P_WNDS_BURST_AOT_SETTINGS = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS}BurstAotSettings_StandaloneWindows.json";
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && BURST_MODULE_ENABLE
