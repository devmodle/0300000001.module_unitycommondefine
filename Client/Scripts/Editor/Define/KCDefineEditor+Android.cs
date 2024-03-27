using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEngine.Rendering;
using UnityEditor;

/** 에디터 안드로이드 상수 */
public static partial class KCDefineEditor
{
	#region 상수
	// 단위
	public const int B_UNITS_VALIDATE_APP_BUNDLE_SIZE = 150;

	// 토큰 {
	public const string B_TOKEN_LOCAL_NDK_PATH_ANDROID = "# ndk.dir=";
	public const string B_TOKEN_GRADLE_NDK_PATH_ANDROID = "ndkPath \"";

	public const string B_TOKEN_LIBRARY_MANIFEST_ANDROID = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<manifest xmlns:android=\"http://schemas.android.com/apk/res/android\" package=\"lkstudio.dante.android.custom\">\n</manifest>";
	public const string B_TOKEN_LIBRARY_PROPERTIES_ANDROID = "android.library=true";
	// 토큰 }

	// 이름 {
	public const string B_BUILD_FILE_N_FMT_ANDROID = "{0}BuildOutput.{1}";

	public const string B_BUILD_FILE_EXTENSION_ANDROID_APK = "apk";
	public const string B_BUILD_FILE_EXTENSION_ANDROID_AAB = "aab";
	// 이름 }

	// 경로
	public const string B_BUILD_P_FMT_ANDROID = "Builds/Android/{0}/{1}";
	public const string B_BUILD_OUTPUT_P_FMT_ANDROID = "Builds/Android/{0}/{0}BuildOutput.{1}";
	#endregion // 상수

	#region 런타임 상수
	// 기타
	public static readonly List<GraphicsDeviceType> B_GRAPHICS_DEVICE_TYPE_LIST_ANDROID = new List<GraphicsDeviceType>() {
		GraphicsDeviceType.Vulkan, GraphicsDeviceType.OpenGLES3
	};

	// 경로 {
	public static readonly string B_ABS_BUILD_P_FMT_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../Builds/Android/{"{0}"}";

	public static readonly string B_SRC_PLUGIN_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/Android/app/build/outputs/aar/app-release.aar";
	public static readonly string B_DEST_PLUGIN_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}CustomAndroidNativePlugin.aar";

	public static readonly string B_SRC_MANIFEST_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/AndroidManifest.xml";
	public static readonly string B_DEST_MANIFEST_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}AndroidManifest.xml";
	public static readonly string B_ORIGIN_SRC_MANIFEST_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/AndroidManifest.xml";

	public static readonly string B_SRC_MAIN_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/mainTemplate.gradle";
	public static readonly string B_DEST_MAIN_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}mainTemplate.gradle";
	public static readonly string B_ORIGIN_SRC_MAIN_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/mainTemplate.gradle";

	public static readonly string B_SRC_LAUNCHER_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/launcherTemplate.gradle";
	public static readonly string B_DEST_LAUNCHER_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}launcherTemplate.gradle";
	public static readonly string B_ORIGIN_SRC_LAUNCHER_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/launcherTemplate.gradle";

	public static readonly string B_SRC_BASE_PROJ_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/baseProjectTemplate.gradle";
	public static readonly string B_DEST_BASE_PROJ_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}baseProjectTemplate.gradle";
	public static readonly string B_ORIGIN_SRC_BASE_PROJ_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/baseProjectTemplate.gradle";

	public static readonly string B_SRC_SETTINGS_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/settingsTemplate.gradle";
	public static readonly string B_DEST_SETTINGS_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}settingsTemplate.gradle";
	public static readonly string B_ORIGIN_SRC_SETTINGS_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/settingsTemplate.gradle";

	public static readonly string B_SRC_GRADLE_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_PACKAGES}Options/Android/gradleTemplate.properties";
	public static readonly string B_DEST_GRADLE_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}gradleTemplate.properties";
	public static readonly string B_ORIGIN_SRC_GRADLE_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/gradleTemplate.properties";

#if UNITY_EDITOR_WIN
	public static readonly string B_SRC_UNITY_PLUGIN_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_UNITY_ENGINE}../Data/PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar";
#else
	public static readonly string B_SRC_UNITY_PLUGIN_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_EXTERNAL_UNITY_ENGINE}../PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar";
#endif // #if UNITY_EDITOR_WIN

	public static readonly string B_DEST_UNITY_PLUGIN_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/Android/unityLibrary/libs/unity-classes.jar";
	public static readonly string B_ORIGIN_SRC_BUILD_GRADLE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/Android/unityLibrary/build.gradle";

#if UNITY_EDITOR_WIN
	public static readonly string B_SRC_LOCAL_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/localWindows.properties";
	public static readonly string B_DEST_LOCAL_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/Android/local.properties";
#else
	public static readonly string B_SRC_LOCAL_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Android/localMac.properties";
	public static readonly string B_DEST_LOCAL_TEMPLATE_P_ANDROID = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/Android/local.properties";
#endif // #if UNITY_EDITOR_WIN
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
