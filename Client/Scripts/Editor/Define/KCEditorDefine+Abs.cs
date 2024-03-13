using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using System.IO;
using UnityEngine.Rendering;
using UnityEditor;
using UnityEditor.Build;

/** 에디터 기본 상수 */
public static partial class KCEditorDefine
{
	#region 기본
	// 기타 {
	public const string B_TOKEN_CLIENT = "Client";
	public const string B_TOKEN_APPLE_M_SERIES = "APPLE M";
	public const string B_TOKEN_REPLACE_UNITY_VERSION = "/*** UnityVersion */";

	public const string B_SORTING_OI_FMT = "[{0}:{1}]";
	// 기타 }

	// 이름 {
	public const string B_DIR_N_SCENES = "Scenes";
	public const string B_DIR_N_RESOURCES = "Resources";

	public const string B_EDITOR_SCENE_N_PATTERN_A = "EditorMenu";
	public const string B_EDITOR_SCENE_N_PATTERN_B = "EditorScene";

	public const string B_OBJ_N_SCENE_EDITOR_POPUP = "SceneEditorPopup";
	public const string B_CLS_N_UNITY_PLAYER_ACTIVITY = "com.unity3d.player.UnityPlayerActivity";

	public const string B_MODULE_N_LOCALIZE_SETTINGS = "com.unity.localization.settings";
	public const string B_MODULE_N_ADAPTIVE_PERFORMANCE_SETTINGS = "com.unity.adaptiveperformance.loader_settings";
	public const string B_MODULE_N_ADAPTIVE_PERFORMANCE_PROVIDER_SETTINGS = "com.unity.adaptiveperformance.simulator.provider_settings";
	public const string B_MODULE_N_ADAPTIVE_PERFORMANCE_SAMSUNG_PROVIDER_SETTINGS = "com.unity.adaptiveperformance.samsung.android.provider_settings";

	public const string B_PROPERTY_N_CATEGORY = "applicationCategoryType";
	public const string B_PROPERTY_N_REQUIRE_AR_KIT_SUPPORTS = "requiresARKitSupport";
	public const string B_PROPERTY_N_APPLE_ENABLE_PRO_MOTION = "appleEnableProMotion";
	public const string B_PROPERTY_N_AUTO_ADD_CAPABILITIES = "automaticallyDetectAndAddCapabilities";

	public const string B_PROPERTY_N_VALIDATE_APP_BUNDLE_SIZE = "validateAppBundleSize";
	public const string B_PROPERTY_N_APP_BUNDLE_SIZE_TO_VALIDATE = "appBundleSizeToValidate";
	public const string B_PROPERTY_N_SUPPORTED_ASPECT_RATIO_MODE = "supportedAspectRatioMode";

	public const string B_PROPERTY_N_ATLAS_WIDTH = "atlasWidth";
	public const string B_PROPERTY_N_ATLAS_HEIGHT = "atlasHeight";
	public const string B_PROPERTY_N_ATLAS_RENDER_MODE = "atlasRenderMode";
	public const string B_PROPERTY_N_CLEAR_DYNAMIC_DATA_ON_BUILD = "clearDynamicDataOnBuild";

	public const string B_PROPERTY_N_SORTING_LAYER = "sortingLayerName";
	public const string B_PROPERTY_N_SORTING_ORDER = "sortingOrder";

	public const string B_PROPERTY_N_TAG_M_TAG = "tags";
	public const string B_PROPERTY_N_TAG_M_NAME = "name";
	public const string B_PROPERTY_N_TAG_M_UNIQUE_ID = "uniqueID";
	public const string B_PROPERTY_N_TAG_M_SORTING_LAYER = "m_SortingLayers";

	public const string B_PROPERTY_N_SND_M_GLOBAL_VOLUME = "m_Volume";
	public const string B_PROPERTY_N_SND_M_ROLLOFF_SCALE = "Rolloff Scale";
	public const string B_PROPERTY_N_SND_M_DOPPLER_FACTOR = "Doppler Factor";
	public const string B_PROPERTY_N_SND_M_DISABLE_AUDIO = "m_DisableAudio";
	public const string B_PROPERTY_N_SND_M_VIRTUALIZE_EFFECT = "m_VirtualizeEffects";
	public const string B_PROPERTY_N_SND_M_AMBISONIC_DECODER_PLUGIN = "m_AmbisonicDecoderPlugin";
	public const string B_PROPERTY_N_SND_M_ENABLE_OUTPUT_SUSPENSION = "m_EnableOutputSuspension";

	public const string B_PROPERTY_N_QUALITY_S_NAME = "name";
	public const string B_PROPERTY_N_QUALITY_S_SECOND = "second";
	public const string B_PROPERTY_N_QUALITY_S_SETTINGS = "m_QualitySettings";
	public const string B_PROPERTY_N_QUALITY_S_DEF_QUALITY = "m_PerPlatformDefaultQuality";

	public const string B_SCENE_N_PATTERN = "t:Example t:Scene";
	public const string B_ASSET_N_LIGHTING_SETTINGS_TEMPLATE = "T_LightingSettings";
	public const string B_ASSET_N_POST_PROCESSING_SETTINGS_TEMPLATE = "T_PostProcessingSettings";

	public const string B_FUNC_N_GET_LIGHTMAP_ENCODING_QUALITY = "GetLightmapEncodingQualityForPlatformGroup";
	public const string B_FUNC_N_GET_LIGHTMAP_STREAMING_ENABLE = "GetLightmapStreamingEnabledForPlatformGroup";
	public const string B_FUNC_N_GET_LIGHTMAP_STREAMING_PRIORITY = "GetLightmapStreamingPriorityForPlatformGroup";

	public const string B_FUNC_N_SET_COMPRESSION_TYPE = "SetCompressionType";
	public const string B_FUNC_N_SET_BATCHING_FOR_PLATFORM = "SetBatchingForPlatform";

	public const string B_FUNC_N_SET_LIGHTMAP_ENCODING_QUALITY = "SetLightmapEncodingQualityForPlatformGroup";
	public const string B_FUNC_N_SET_LIGHTMAP_STREAMING_ENABLE = "SetLightmapStreamingEnabledForPlatformGroup";
	public const string B_FUNC_N_SET_LIGHTMAP_STREAMING_PRIORITY = "SetLightmapStreamingPriorityForPlatformGroup";
	// 이름 }

	// 경로 {
	public const string B_DIR_P_ASSETS = "Assets/";
	public const string B_DIR_P_PACKAGES = "Packages/";

	public const string B_DIR_P_AUTO = "01-Auto/";
	public const string B_DIR_P_ENGINE = "02-Engine/";

	public const string B_DIR_P_PROJ = "00-Projects/";
	public const string B_DIR_P_UNITY_PROJ = "41-UnityProject/";
	public const string B_DIR_P_SUB_UNITY_PROJ = "42-SubUnityProject/";

	public const string B_DIR_P_UNITY_PROJ_EDITOR = "91-UnityProjectEditor/";
	public const string B_DIR_P_SUB_UNITY_PROJ_EDITOR = "92-SubUnityProjectEditor/";

	public const string B_DIR_P_PROJ_SETTINGS = "ProjectSettings/";
	public const string B_DIR_P_EDITOR_DEF_RESOURCES = "Editor Default Resources/";

	public const string B_DIR_P_EXPORT_BASE = "Export/";
	public const string B_DIR_P_EDITOR_SCRIPTS = "Scripts/Editor/";
	public const string B_DIR_P_RUNTIME_SCRIPTS = "Scripts/Runtime/";
	public const string B_DIR_P_EDITOR_SCENE_SCRIPTS = "Scripts/Editor/EditorScene";

	public const string B_DIR_P_ENGINE_RESOURCES = "02-Engine/Resources/";
	public const string B_DIR_P_ENGINE_EDITOR_SCRIPTS = "02-Engine/Scripts/Editor/";
	public const string B_DIR_P_ENGINE_RUNTIME_SCRIPTS = "02-Engine/Scripts/Runtime/";

	public const string B_TOOL_P_SHELL = "/bin/zsh";
	public const string B_TOOL_P_CMD_PROMPT = "cmd.exe";
	// 경로 }
	#endregion // 기본

	#region 런타임 상수
	// 이름 {
	public static readonly List<string> B_OBJ_N_ROOT_UIS_LIST = new List<string>() {
		KCDefine.U_OBJ_N_SCENE_UIS_ROOT
	};

	public static readonly List<string> B_OBJ_N_ROOT_OBJ_LIST = new List<string>() {
		KCDefine.U_OBJ_N_SCENE_BASE, KCDefine.U_OBJ_N_SCENE_OBJS_ROOT
	};

	public static readonly List<string> B_OBJ_N_ROOT_PREFAB_OBJ_LIST = new List<string>() {
		KCDefine.U_OBJ_N_SCENE_UIS_ROOT
	};

	public static readonly List<string> B_OBJ_N_STATIC_OBJ_LIST = new List<string>() {
		KCDefine.U_OBJ_N_SCENE_STATIC_OBJS, KCDefine.U_OBJ_N_SCENE_ADDITIONAL_LIGHTS, KCDefine.U_OBJ_N_SCENE_REFLECTION_PROBES, KCDefine.U_OBJ_N_SCENE_LIGHT_PROBE_GROUPS,
	};

	public static readonly List<string> B_OBJ_N_SCENE_EDITOR_LIGHT_LIST = new List<string>() {
		"SceneLight", "PreRenderLight"
	};

	public static readonly List<string> B_OBJ_N_SCENE_EDITOR_CAMERA_LIST = new List<string>() {
		"SceneCamera", "Main Camera", "Preview Camera", "Preview Scene Camera"
	};

	public static readonly List<NamedBuildTarget> B_NAMED_BUILD_TARGET_LIST = new List<NamedBuildTarget>() {
		NamedBuildTarget.iOS, NamedBuildTarget.Android, NamedBuildTarget.Standalone
	};

	public static readonly Dictionary<string, string> B_DIR_N_SCENE_DICT = new Dictionary<string, string>()
	{
		[KCDefine.B_SCENE_N_INIT] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_SETUP] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_LATE_SETUP] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),

		[KCDefine.B_SCENE_N_TITLE] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_MAIN] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_PLAY] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),

		[KCDefine.B_SCENE_N_RESULT] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_LOADING] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_OVERLAY] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_TEST] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),

		[KCDefine.B_SCENE_N_MENU] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		[KCDefine.B_SCENE_N_LEVEL_EDITOR] = Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH)
	};
	// 이름 }

	// 경로 {
	public static readonly string B_DIR_P_AUTO_SCENES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Scenes/";
	public static readonly string B_DIR_P_AUTO_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Scripts/";
	public static readonly string B_DIR_P_AUTO_RESOURCES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Resources/";

	public static readonly string B_DIR_P_UNITY_PROJ_SCENES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scenes/";
	public static readonly string B_DIR_P_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/";
	public static readonly string B_DIR_P_UNITY_PROJ_RESOURCES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Resources/";

	public static readonly string B_DIR_P_SUB_UNITY_PROJ_SCENES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scenes/";
	public static readonly string B_DIR_P_SUB_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/";
	public static readonly string B_DIR_P_SUB_UNITY_PROJ_RESOURCES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Resources/";

	public static readonly string B_DIR_P_UNITY_PROJ_EDITOR_SCENES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scenes/";
	public static readonly string B_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/";
	public static readonly string B_DIR_P_UNITY_PROJ_EDITOR_RESOURCES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Resources/";

	public static readonly string B_DIR_P_SUB_UNITY_PROJ_EDITOR_SCENES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scenes/";
	public static readonly string B_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/";
	public static readonly string B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Resources/";

	public static readonly string B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/";
	public static readonly string B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/";

	public static readonly string B_DIR_P_TEMPLATES = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Templates/";
	public static readonly string B_DIR_P_RES_PREFABS = $"{KCEditorDefine.B_DIR_P_ASSETS}Resources/Prefabs/";

	public static readonly string B_ABS_DIR_P_ASSETS = $"{Application.dataPath}/";
	public static readonly string B_ABS_DIR_P_EXTERNAL_UNITY_ENGINE = $"{EditorApplication.applicationPath}/";

	public static readonly string B_ABS_DIR_P_EXTERNAL_DATAS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../ExternalDatas/";
	public static readonly string B_ABS_DIR_P_EXTERNAL_TABLES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../../Tables/";
	public static readonly string B_ABS_DIR_P_EXTERNAL_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../../Scripts/";
	public static readonly string B_ABS_DIR_P_EXTERNAL_PACKAGES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../Packages/";
	public static readonly string B_ABS_DIR_P_EXTERNAL_PROJ_SETTINGS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../ProjectSettings/";

	public static readonly string B_ABS_DIR_P_AUTO_SCENES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Scenes/";
	public static readonly string B_ABS_DIR_P_AUTO_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Scripts/";
	public static readonly string B_ABS_DIR_P_AUTO_RESOURCES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}Resources/";

	public static readonly string B_ABS_DIR_P_UNITY_PROJ_SCENES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scenes/";
	public static readonly string B_ABS_DIR_P_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/";
	public static readonly string B_ABS_DIR_P_UNITY_PROJ_RESOURCES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Resources/";

	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_SCENES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scenes/";
	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/";
	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Resources/";

	public static readonly string B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCENES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scenes/";
	public static readonly string B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/";
	public static readonly string B_ABS_DIR_P_UNITY_PROJ_EDITOR_RESOURCES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Resources/";

	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCENES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scenes/";
	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/";
	public static readonly string B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Resources/";

	public static readonly string B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/";
	public static readonly string B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/";

#if SAMPLE_PROJ
	public static readonly string B_ABS_DIR_P_TEMPLATES = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PACKAGES}.module.unitycommon/Client/Templates/";
	public static readonly string B_ABS_DIR_P_STUDY_TEMPLATES = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PACKAGES}.module.unitystudy/Client/Templates/";
#else
	public static readonly string B_ABS_DIR_P_TEMPLATES = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PACKAGES}.module.unitycommon@{KCEditorDefine.B_VER_UNITY_MODULE}/Client/Templates/";
	public static readonly string B_ABS_DIR_P_STUDY_TEMPLATES = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PACKAGES}.module.unitystudy@{KCEditorDefine.B_VER_UNITY_MODULE}/Client/Templates/";
#endif // #if SAMPLE_PROJ

	public static readonly string B_ABS_DIR_P_PLUGINS = $"{Application.dataPath}/Plugins/";
	public static readonly string B_ABS_DIR_P_IOS_PLUGINS = $"{KCEditorDefine.B_ABS_DIR_P_PLUGINS}iOS/";
	public static readonly string B_ABS_DIR_P_ANDROID_PLUGINS = $"{KCEditorDefine.B_ABS_DIR_P_PLUGINS}Android/";
	public static readonly string B_ABS_DIR_P_UNITY_PACKAGES = $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_PACKAGES}UnityPackages/";

	public static readonly string B_ABS_PKGS_P_DOTWEEN_PRO = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_DOTWEEN_PRO_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_APPLE_SIGN_IN = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_APPLE_SIGN_IN_PKGS}.unitypackage";

	public static readonly string B_ABS_PKGS_P_NGUI = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_NGUI_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_2D_TOOLKIT = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_2D_TOOLKIT_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_SPRITE_TRAIL = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_SPRITE_TRAIL_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_SND_MANAGER_PRO = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_SND_MANAGER_PRO_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_ULTIMATE_STATUS_BAR = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_ULTIMATE_STATUS_BAR_PKGS}.unitypackage";

	public static readonly string B_ABS_PKGS_P_BUILD_REPORT_TOOL = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_BUILD_REPORT_TOOL_PKGS}.unitypackage";
	public static readonly string B_ABS_PKGS_P_ODIN_INSPECTOR_AND_SERIALIZER = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Packages/UnityPackages/{KCEditorDefine.B_NAME_ODIN_INSPECTOR_AND_SERIALIZER_PKGS}.unitypackage";

	public static readonly string B_ASSET_P_SAMPLE_SCENE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Scenes/{KCDefine.B_SCENE_N_SAMPLE}.unity";
	public static readonly string B_ASSET_P_MENU_SAMPLE_SCENE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityStudy/Client/Scenes/{KCDefine.B_SCENE_N_MENU_SAMPLE}.unity";
	public static readonly string B_ASSET_P_STUDY_SAMPLE_SCENE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityStudy/Client/Scenes/{KCDefine.B_SCENE_N_RESEARCH_SAMPLE}.unity";
	public static readonly string B_ASSET_P_EDITOR_SAMPLE_SCENE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Scenes/{KCDefine.B_SCENE_N_EDITOR_SAMPLE}.unity";

	public static readonly string B_ASSET_P_SAMPLE_SCENE_TEMPLATE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Scenes/{KCDefine.B_SCENE_N_SAMPLE}.scenetemplate";
	public static readonly string B_ASSET_P_MENU_SAMPLE_SCENE_TEMPLATE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityStudy/Client/Scenes/{KCDefine.B_SCENE_N_MENU_SAMPLE}.scenetemplate";
	public static readonly string B_ASSET_P_STUDY_SAMPLE_SCENE_TEMPLATE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityStudy/Client/Scenes/{KCDefine.B_SCENE_N_RESEARCH_SAMPLE}.scenetemplate";
	public static readonly string B_ASSET_P_EDITOR_SAMPLE_SCENE_TEMPLATE = $"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommon/Client/Scenes/{KCDefine.B_SCENE_N_EDITOR_SAMPLE}.scenetemplate";

	public static readonly string B_ASSET_P_TAG_MANAGER = $"{KCEditorDefine.B_DIR_P_PROJ_SETTINGS}TagManager.asset";
	public static readonly string B_ASSET_P_SND_MANAGER = $"{KCEditorDefine.B_DIR_P_PROJ_SETTINGS}AudioManager.asset";
	public static readonly string B_ASSET_P_QUALITY_SETTINGS = $"{KCEditorDefine.B_DIR_P_PROJ_SETTINGS}QualitySettings.asset";

	public static readonly string B_ASSET_P_OPTS_INFO_TABLE = $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_OPTS_INFO_TABLE}.asset";
	public static readonly string B_ASSET_P_BUILD_INFO_TABLE = $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_BUILD_INFO_TABLE}.asset";
	public static readonly string B_ASSET_P_PROJ_INFO_TABLE = $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_PROJ_INFO_TABLE}.asset";
	public static readonly string B_ASSET_P_LOCALIZE_INFO_TABLE = $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_LOCALIZE_INFO_TABLE}.asset";
	public static readonly string B_ASSET_P_DEFINE_SYMBOL_INFO_TABLE = $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_DEFINE_SYMBOL_INFO_TABLE}.asset";

	public static readonly string B_ASSET_P_FMT_SCRIPTABLE_OBJ = $"{KCEditorDefine.B_DIR_P_ASSETS}{"{0}.asset"}";
	public static readonly string B_ASSET_P_FMT_DEFINE_S_OUTPUT = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../Builds/DefineSymbols/{"{0}DefineSymbols.txt"}";

	public static readonly string B_IMG_P_FMT_EXPORT = $"{KCEditorDefine.B_DIR_P_EXPORT_BASE}{"Images/{0}.png"}";
	public static readonly string B_TEX_P_FMT_EXPORT = $"{KCEditorDefine.B_DIR_P_EXPORT_BASE}{"Textures/{0}.png"}";
	public static readonly string B_DATA_P_BUILD_METHOD = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../Builds/BuildMethod.txt";

	public static readonly string B_ICON_P_IOS_APP_76x76 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon76x76";
	public static readonly string B_ICON_P_IOS_APP_120x120 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon120x120";
	public static readonly string B_ICON_P_IOS_APP_152x152 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon152x152";
	public static readonly string B_ICON_P_IOS_APP_167x167 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon167x167";
	public static readonly string B_ICON_P_IOS_APP_180x180 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon180x180";
	public static readonly string B_ICON_P_IOS_APP_1024x1024 = $"{KCDefine.B_DIR_P_ICONS}iOS/App/Icon1024x1024";

	public static readonly string B_ICON_P_IOS_NOTI_20x20 = $"{KCDefine.B_DIR_P_ICONS}iOS/Notification/Icon20x20";
	public static readonly string B_ICON_P_IOS_NOTI_40x40 = $"{KCDefine.B_DIR_P_ICONS}iOS/Notification/Icon40x40";
	public static readonly string B_ICON_P_IOS_NOTI_60x60 = $"{KCDefine.B_DIR_P_ICONS}iOS/Notification/Icon60x60";

	public static readonly string B_ICON_P_ANDROID_APP_36x36 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon36x36";
	public static readonly string B_ICON_P_ANDROID_APP_48x48 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon48x48";
	public static readonly string B_ICON_P_ANDROID_APP_72x72 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon72x72";
	public static readonly string B_ICON_P_ANDROID_APP_96x96 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon96x96";
	public static readonly string B_ICON_P_ANDROID_APP_144x144 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon144x144";
	public static readonly string B_ICON_P_ANDROID_APP_192x192 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon192x192";
	public static readonly string B_ICON_P_ANDROID_APP_512x512 = $"{KCDefine.B_DIR_P_ICONS}Android/App/Icon512x512";

	public static readonly string B_ICON_P_ANDROID_NOTI_24x24 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon24x24";
	public static readonly string B_ICON_P_ANDROID_NOTI_36x36 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon36x36";
	public static readonly string B_ICON_P_ANDROID_NOTI_48x48 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon48x48";
	public static readonly string B_ICON_P_ANDROID_NOTI_72x72 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon72x72";
	public static readonly string B_ICON_P_ANDROID_NOTI_96x96 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon96x96";
	public static readonly string B_ICON_P_ANDROID_NOTI_256x256 = $"{KCDefine.B_DIR_P_ICONS}Android/Notification/Icon256x256";

	public static readonly string B_ICON_P_STANDALONE_APP_1024x1024 = $"{KCDefine.B_DIR_P_ICONS}Standalone/App/Icon1024x1024";

	public static readonly List<string> B_SEARCH_P_SCENE_LIST = new List<string>() {
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH)
	};

	public static readonly List<string> B_SEARCH_P_PREFAB_SCENE_LIST = new List<string>() {
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_AUTO_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH),
		Path.GetDirectoryName(KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR_SCENES).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH)
	};

	public static readonly List<string> B_SEARCH_P_SPRITE_ATLAS_LIST = new List<string>() {
		$"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}",
		$"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}"
	};

	public static readonly List<string> B_ASSET_P_SPRITE_ATLAS_LIST = new List<string>() {
		KCDefine.U_ASSET_P_SPRITE_ATLAS_01,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_02,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_03,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_04,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_05,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_06,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_07,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_08,
		KCDefine.U_ASSET_P_SPRITE_ATLAS_09,

		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_01,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_02,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_03,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_04,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_05,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_06,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_07,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_08,
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_09,

		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_01,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_02,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_03,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_04,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_05,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_06,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_07,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_08,
		KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_09
	};

	public static readonly List<LogType> B_LOG_TYPE_LIST = new List<LogType>() {
		LogType.Log, LogType.Warning, LogType.Error, LogType.Assert, LogType.Exception
	};

	public static readonly List<BuildTarget> B_BUILD_TARGET_LIST = new List<BuildTarget>() {
		BuildTarget.iOS, BuildTarget.Android, BuildTarget.StandaloneOSX, BuildTarget.StandaloneWindows, BuildTarget.StandaloneWindows64
	};

	public static readonly List<BuildTargetGroup> B_BUILD_TARGET_GROUP_LIST = new List<BuildTargetGroup>() {
		BuildTargetGroup.iOS, BuildTargetGroup.Android, BuildTargetGroup.Standalone
	};

	public static readonly List<TextureImporterType> B_ENABLE_SRGB_TEX_TYPE_LIST = new List<TextureImporterType>() {
		TextureImporterType.Default, TextureImporterType.Sprite
	};

	public static readonly List<TextureImporterType> B_ENABLE_ALPHA_TRANSPARENCY_TEX_TYPE_LIST = new List<TextureImporterType>() {
		TextureImporterType.Default, TextureImporterType.Sprite, TextureImporterType.GUI, TextureImporterType.Cursor, TextureImporterType.Cookie
	};

	public static readonly List<TextureImporterType> B_IGNORE_RGBA_32_FMT_TEX_TYPE_LIST = new List<TextureImporterType>() {
		TextureImporterType.SingleChannel
	};

	public static readonly List<TextureImporterType> B_IGNORE_WRAP_MODE_TEX_TYPE_LIST = new List<TextureImporterType>() {
		TextureImporterType.NormalMap, TextureImporterType.Lightmap, TextureImporterType.DirectionalLightmap, TextureImporterType.Shadowmask
	};

	public static readonly List<TextureImporterType> B_IGNORE_FILTER_MODE_TEX_TYPE_LIST = new List<TextureImporterType>()
	{
		// Do Something
	};

	public static readonly List<TextureImporterType> B_IGNORE_NON_POT_SCALE_TEX_TYPE_LIST = new List<TextureImporterType>() {
		TextureImporterType.GUI, TextureImporterType.Sprite
	};

	public static readonly List<(string, string)> B_DIR_P_TABLE_INFO_LIST = new List<(string, string)>() {
		(Path.GetDirectoryName(KCDefine.U_RUNTIME_TABLE_P_G_LEVEL_INFO).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH), Path.GetDirectoryName($"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH)),

#if AB_TEST_ENABLE
		(Path.GetDirectoryName(KCDefine.U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_A).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH), Path.GetDirectoryName($"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_A}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH)),
		(Path.GetDirectoryName(KCDefine.U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_B).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH), Path.GetDirectoryName($"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_B}").Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH))
#endif // #if AB_TEST_ENABLE
	};

	public static readonly List<(string, string)> B_FILE_P_TABLE_INFO_LIST = new List<(string, string)>() {
		(KCDefine.U_RUNTIME_TABLE_P_G_ETC_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_MISSION_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_MISSION_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_REWARD_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_REWARD_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_RES_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_RES_INFO}.json"),

		(KCDefine.U_RUNTIME_TABLE_P_G_ITEM_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ITEM_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_SKILL_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_SKILL_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_OBJ_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_OBJ_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_ABILITY_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ABILITY_INFO}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_PRODUCT_INFO, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_PRODUCT_INFO}.json"),

#if AB_TEST_ENABLE
		(KCDefine.U_RUNTIME_TABLE_P_G_ETC_INFO_SET_A, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_A}.json"),
		(KCDefine.U_RUNTIME_TABLE_P_G_ETC_INFO_SET_B, $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_B}.json")
#endif // #if AB_TEST_ENABLE
	};

	public static readonly List<(string, string)> B_DATA_P_INFO_LIST = new List<(string, string)>() {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_AUTO}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_PROJ}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}README.md"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_README.md", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}README.md"),

		// 01-Auto
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_Privacy_{SystemLanguage.Korean}.txt", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_RESOURCES}{KCDefine.LSS_DATA_P_PRIVACY}.txt"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Datas/T_Services_{SystemLanguage.Korean}.txt", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_RESOURCES}{KCDefine.LSS_DATA_P_SERVICES}.txt"),

		// 04.UnityPackages {
#if SAMPLE_PROJ || DEVELOPMENT_PROJ
#if UNITY_EDITOR_WIN
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Analytics/Windows/Doxyfile", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../../Doxyfile")
#else
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Options/Analytics/Mac/Silicon/Doxyfile", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../../Doxyfile")
#endif // #if UNITY_EDITOR_WIN
#endif // #if SAMPLE_PROJ || DEVELOPMENT_PROJ
		// 04.UnityPackages }
	};

	public static readonly List<(string, string)> B_SCRIPT_P_INFO_LIST = new List<(string, string)>() {
#if SAMPLE_PROJ || DEVELOPMENT_PROJ
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/DSYMUploader.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/DSYMUploader.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleBranchEraser.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleBranchEraser.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleBranchMerger.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleBranchMerger.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleBranchSwitcher.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleBranchSwitcher.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleCmdExecuter.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleCmdExecuter.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleCommonImporter.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleCommonImporter.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleEraser.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleEraser.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleGC.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleGC.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleImporter.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleImporter.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModulePluginImporter.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModulePluginImporter.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleRemoteURLUpdater.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleRemoteURLUpdater.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleResearchImporter.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleResearchImporter.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleTagUpdater.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleTagUpdater.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleUpdater.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleUpdater.py"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Scripts/Python/UnityModuleUploader.py", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_SCRIPTS}Python/UnityModuleUploader.py"),
#endif // #if SAMPLE_PROJ || DEVELOPMENT_PROJ

		// 01-Auto {
		// 에디터 상수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Editor/Define/T_KEditorDefine+Abs.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Editor/Global/Define/KEditorDefine+Abs.cs"),

		// 에디터 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Editor/Factory/T_EditorFactory.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Editor/Global/Factory/EditorFactory.cs"),

		// 에디터 씬 관리자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Editor/Scene/T_CEditorSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Editor/EditorScene/CEditorSceneManager.cs"),

		// 유틸리티
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Cloud/T_CloudScript.js", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}Scripts/Cloud/CloudScript.js"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/External/T_CMsgPackRegister.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Utility/External/CMsgPackRegister.cs"),

#if SCENE_TEMPLATES_ENABLE || SCENE_TEMPLATES_MODULE_ENABLE
		// 씬 관리자 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Scene/T_CSubInitSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/SubInitScene/CSubInitSceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Scene/T_CSubSetupSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/SubSetupScene/CSubSetupSceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Scene/T_CSubLateSetupSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/SubLateSetupScene/CSubLateSetupSceneManager.cs"),

#if RESEARCH_ENABLE || RESEARCH_MODULE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_STUDY_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Scene/T_CSSubMenuSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/SubMenuScene/CSSubMenuSceneManager.cs"),
#endif // #if RESEARCH_ENABLE || RESEARCH_MODULE_ENABLE
		// 씬 관리자 }
#endif // #if SCENE_TEMPLATES_ENABLE || SCENE_TEMPLATES_MODULE_ENABLE

#if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 접근자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Access/T_Access.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Access/Access.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Access/T_AccessExtension.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Access/AccessExtension.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Factory/T_Factory.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Factory/Factory.cs"),

		// 확장 클래스
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Extension/T_Extension.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Extension/Extension.cs"),

		// 함수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Function/T_Func.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Function/Func.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Scripts/Runtime/Function/T_LogFunc.cs", $"{KCEditorDefine.B_ABS_DIR_P_AUTO_SCRIPTS}Runtime/Global/Function/LogFunc.cs"),
#endif // #if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 01-Auto }

		// 41-UnityProject {
		// 에디터 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Editor/Factory/T_EditorFactory+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Editor/Global/Factory/EditorFactory+Global.cs"),

		// 에디터 유틸리티
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Editor/Build/T_CBuildProcessor.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Editor/Global/Utility/Build/CBuildProcessor.cs"),

#if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 엔진 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/T_CEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/CEngine.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CEComponent.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEComponent.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CEObjComponent.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEObjComponent.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CEController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEController.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+Engine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+EngineType.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+EngineType.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+EngineEnum.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+EngineEnum.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Access/T_Access+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/Access+Engine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Access/T_AccessExtension+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/AccessExtension+Engine.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Factory/T_Factory+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Factory/Factory+Engine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Extension/T_Extension+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Extension/Extension+Engine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Function/T_Func+Engine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/Func+Engine.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Object/T_CEItem.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEItem.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Object/T_CESkill.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CESkill.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Object/T_CEObj.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEObj.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Object/T_CEFX.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEFX.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CEItemController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEItemController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CESkillController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CESkillController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CEObjController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEObjController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CEFXController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEFXController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CECellObjController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CECellObjController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CEPlayerObjController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEPlayerObjController.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Controller/T_CEEnemyObjController.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEEnemyObjController.cs"),
		// 엔진 }

		// 기본
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CBaseInfo.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CBaseInfo.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CPSComponent.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CPSComponent.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Base/T_CMissionPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CMissionPopup.cs"),

		// 상수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+Type.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+Type.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+Enum.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+Enum.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+Global.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+Log.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+Log.cs"),

		// 접근자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Access/T_Access+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/Access+Global.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Access/T_AccessExtension+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/AccessExtension+Global.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Factory/T_Factory+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Factory/Factory+Global.cs"),

		// 확장 클래스
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Extension/T_Extension+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Extension/Extension+Global.cs"),

		// 함수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Function/T_Func+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/Func+Global.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Function/T_LogFunc+Global.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/LogFunc+Global.cs"),

		// 효과
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Etc/T_CStoreUIsHandler.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Etc/CStoreUIsHandler.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Etc/T_CDifficultyUIsHandler.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Etc/CDifficultyUIsHandler.cs"),

		// 팝업
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CStorePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CStorePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CSettingsPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CSettingsPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CSyncPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CSyncPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CDailyMissionPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CDailyMissionPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CFreeRewardPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CFreeRewardPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CDailyRewardPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CDailyRewardPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CCoinsBoxBuyPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CCoinsBoxBuyPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CRewardAcquirePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CRewardAcquirePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CCoinsBoxAcquirePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CCoinsBoxAcquirePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CContinuePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CContinuePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CReadyPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CReadyPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CResultPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CResultPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CResumePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CResumePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CPausePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CPausePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CProductBuyPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CProductBuyPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CFocusPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CFocusPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Popup/T_CTutorialPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CTutorialPopup.cs"),

		// 씬 관리자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubTitleSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubTitleScene/CSubTitleSceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubMainSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubMainScene/CSubMainSceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubPlaySceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubPlayScene/CSubPlaySceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubResultSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubResultScene/CSubResultSceneManager.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubLoadingSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubLoadingScene/CSubLoadingSceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubOverlaySceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubOverlayScene/CSubOverlaySceneManager.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubTestSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_SCRIPTS}Runtime/SubTestScene/CSubTestSceneManager.cs"),
#endif // #if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 41-UnityProject }
		
		// 42-SubUnityProject {
#if EXTRA_SCRIPT_ENABLE || EXTRA_SCRIPT_MODULE_ENABLE
		// 에디터 상수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Editor/Define/T_KEditorDefine+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Editor/Global/Define/KEditorDefine+SubGlobal.cs"),

		// 에디터 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Editor/Factory/T_EditorFactory+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Editor/Global/Factory/EditorFactory+SubGlobal.cs"),

		// 임포터
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Editor/Importer/T_CSubAssetProcessor.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Editor/Global/Importer/CSubAssetProcessor.cs"),

		// 상수 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubType.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubType.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubEnum.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubEnum.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubGlobal.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubValTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubValTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubGameCenter.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubGameCenter.cs"),
		// 상수 }

		// 접근자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Access/T_Access+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/Access+SubGlobal.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Access/T_AccessExtension+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/AccessExtension+SubGlobal.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Factory/T_Factory+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Factory/Factory+SubGlobal.cs"),

		// 확장 클래스
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Extension/T_Extension+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Extension/Extension+SubGlobal.cs"),

		// 함수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Function/T_Func+Popup.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/Func+Popup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Function/T_Func+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/Func+SubGlobal.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Function/T_LogFunc+SubGlobal.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/LogFunc+SubGlobal.cs"),

		// 씬 관리자 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubTitleSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubTitleScene/CSubTitleSceneManager+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubMainSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubMainScene/CSubMainSceneManager+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubPlaySceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubPlayScene/CSubPlaySceneManager+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubResultSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubResultScene/CSubResultSceneManager+Sub.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubLoadingSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubLoadingScene/CSubLoadingSceneManager+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubOverlaySceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubOverlayScene/CSubOverlaySceneManager+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Scene/T_CSubTestSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/SubTestScene/CSubTestSceneManager+Sub.cs"),
		// 씬 관리자 }
#endif // #if EXTRA_SCRIPT_ENABLE || EXTRA_SCRIPT_MODULE_ENABLE

#if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 엔진 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/T_CEngine+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/CEngine+Sub.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CEComponent+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEComponent+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CEObjComponent+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEObjComponent+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CEController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEController+Sub.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubEngine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubEngineType.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubEngineType.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Define/T_KDefine+SubEngineEnum.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Define/KDefine+SubEngineEnum.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Access/T_Access+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/Access+SubEngine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Access/T_AccessExtension+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Access/AccessExtension+SubEngine.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Factory/T_Factory+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Factory/Factory+SubEngine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Extension/T_Extension+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Extension/Extension+SubEngine.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Function/T_Func+SubEngine.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Function/Func+SubEngine.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Object/T_CEItem+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEItem+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Object/T_CESkill+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CESkill+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Object/T_CEObj+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEObj+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Object/T_CEFX+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEFX+Sub.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CEItemController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEItemController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CESkillController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CESkillController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CEObjController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEObjController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CEFXController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEFXController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CECellObjController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CECellObjController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CEPlayerObjController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEPlayerObjController+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_ENGINE}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Controller/T_CEEnemyObjController+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Controller/CEEnemyObjController+Sub.cs"),
		// 엔진 }

		// 기본
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CSubPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CSubPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CSubAlertPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CSubAlertPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CPSComponent+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CPSComponent+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Base/T_CMissionPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CMissionPopup+Sub.cs"),

		// 효과
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Etc/T_CStoreUIsHandler+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Etc/CStoreUIsHandler+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Etc/T_CDifficultyUIsHandler+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Etc/CDifficultyUIsHandler+Sub.cs"),

		// 테이블 {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CEtcInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CEtcInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CLevelInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CLevelInfoTable.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CCalcInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CCalcInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CMissionInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CMissionInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CRewardInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CRewardInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CEpisodeInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CEpisodeInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CTutorialInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CTutorialInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CResInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CResInfoTable.cs"),

		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CItemInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CItemInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CSkillInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CSkillInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CObjInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CObjInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CFXInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CFXInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CAbilityInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CAbilityInfoTable.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Table/T_CProductTradeInfoTable.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Table/CProductTradeInfoTable.cs"),
		// 테이블 }

		// 저장소
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Storage/T_CAppInfoStorage.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Storage/CAppInfoStorage.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Storage/T_CUserInfoStorage.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Storage/CUserInfoStorage.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Storage/T_CGameInfoStorage.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Storage/CGameInfoStorage.cs"),

		// 팝업
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CStorePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CStorePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CSettingsPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CSettingsPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CSyncPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CSyncPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CDailyMissionPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CDailyMissionPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CFreeRewardPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CFreeRewardPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CDailyRewardPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CDailyRewardPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CCoinsBoxBuyPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CCoinsBoxBuyPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CRewardAcquirePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CRewardAcquirePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CCoinsBoxAcquirePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CCoinsBoxAcquirePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CContinuePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CContinuePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CReadyPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CReadyPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CResultPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CResultPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CResumePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CResumePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CPausePopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CPausePopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CProductBuyPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CProductBuyPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CFocusPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CFocusPopup+Sub.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/Popup/T_CTutorialPopup+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Popup/CTutorialPopup+Sub.cs"),

		// 스크롤러 셀 뷰
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/ScrollView/T_CLevelScrollerCellView.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/ScrollView/CLevelScrollerCellView.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/ScrollView/T_CStageScrollerCellView.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/ScrollView/CStageScrollerCellView.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Scripts/Runtime/ScrollView/T_CChapterScrollerCellView.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/ScrollView/CChapterScrollerCellView.cs"),
#endif // #if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 42-SubUnityProject }

		// 91-UnityProjectEditor {
#if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 상수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+Editor.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+Editor.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+EditorType.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+EditorType.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+EditorEnum.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+EditorEnum.cs"),

		// 접근자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Access/T_Access+Editor.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Access/Access+Editor.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Factory/T_Factory+Editor.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Factory/Factory+Editor.cs"),

		// 함수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Function/T_Func+Editor.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Function/Func+Editor.cs"),

		// 씬 관리자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR}Scripts/Runtime/Scene/T_CSubLevelEditorSceneManager.cs", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/SubLevelEditorScene/CSubLevelEditorSceneManager.cs"),
#endif // #if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 91-UnityProjectEditor }

		// 92-SubUnityProjectEditor {
#if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 기본
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Base/T_CSubEditorInputPopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Utility/Base/CSubEditorInputPopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Base/T_CSubEditorCreatePopup.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Utility/Base/CSubEditorCreatePopup.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Base/T_CSubEditorScrollerCellView.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Utility/Base/CSubEditorScrollerCellView.cs"),

		// 상수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+SubEditor.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+SubEditor.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+SubEditorType.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+SubEditorType.cs"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Define/T_KDefine+SubEditorEnum.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Define/KDefine+SubEditorEnum.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Access/T_Access+SubEditor.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Access/Access+SubEditor.cs"),

		// 팩토리
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Factory/T_Factory+SubEditor.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Factory/Factory+SubEditor.cs"),

		// 함수
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Function/T_Func+SubEditor.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/Global/Function/Func+SubEditor.cs"),

		// 씬 관리자
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Scripts/Runtime/Scene/T_CSubLevelEditorSceneManager+Sub.cs", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_EDITOR_SCRIPTS}Runtime/SubLevelEditorScene/CSubLevelEditorSceneManager+Sub.cs")
#endif // #if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 92-SubUnityProjectEditor }
	};

	public static readonly List<(string, string)> B_PREFAB_P_INFO_LIST = new List<(string, string)>() {
		// 01-Auto {
		($"{KCEditorDefine.B_DIR_P_PACKAGES}Module.UnityCommonExternals/Client/Runtime/Etc/SmartTimersManager/TimerManager/TimersManager.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TIMER_MANAGER}.prefab"),

#if PREFAB_TEMPLATES_ENABLE || PREFAB_TEMPLATES_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Text/T_Text.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TEXT}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_TextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_TextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Text/T_TMPText.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_TEXT}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Text/T_TMPTextMesh.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_TEXT_MESH}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Text/T_LocalizeText.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_LOCALIZE_TEXT}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_LocalizeTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_LOCALIZE_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_LocalizeTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_LOCALIZE_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Text/T_TMPLocalizeText.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_LOCALIZE_TEXT}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPLocalizeTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_LOCALIZE_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPLocalizeTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_LOCALIZE_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Image/T_Img.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Image/T_MaskImg.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_MASK_IMG}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Image/T_FocusImg.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_FOCUS_IMG}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Image/T_GaugeImg.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_GAUGE_IMG}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/T_ImgBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/T_ImgScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_ImgTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_ImgTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPImgTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_IMG_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPImgTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_IMG_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_ImgLocalizeTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_LOCALIZE_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/Text/T_ImgLocalizeTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_IMG_LOCALIZE_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPImgLocalizeTextBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_IMG_LOCALIZE_TEXT_BTN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Button/TextMeshPro/T_TMPImgLocalizeTextScaleBtn.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_IMG_LOCALIZE_TEXT_SCALE_BTN}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_Toggle.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TOGGLE}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_Dropdown.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_DROPDOWN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_InputField.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_INPUT_FIELD}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_TMPToggle.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_TOGGLE}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_TMPDropdown.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_DROPDOWN}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Input/T_TMPInputField.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TMP_INPUT_FIELD}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/ScrollView/T_ScrollView.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_SCROLL_VIEW}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/ScrollView/T_RecycleView.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_RECYCLE_VIEW}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/ScrollView/T_PageView.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_PAGE_VIEW}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/FX/T_LineFX.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_LINE_FX}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/FX/T_ParticleFX.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_PARTICLE_FX}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/FX/T_ReflectionProbe.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_REFLECTION_PROBE}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/FX/T_LightProbeGroup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_LIGHT_PROBE_GROUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/2D/T_Sprite.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_SPRITE}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/2D/T_TargetObj.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TARGET_OBJ}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Popup/T_TrackingDescPopup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.LSS_OBJ_P_TRACKING_DESC_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Popup/T_PortraitAgreePopup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.LSS_OBJ_P_PORTRAIT_AGREE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Popup/T_LandscapeAgreePopup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.LSS_OBJ_P_LANDSCAPE_AGREE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_G_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_FocusPopup.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_G_FOCUS_POPUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/Sound/T_BGSnd.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_BG_SND}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/Sound/T_FXSnds.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_FX_SNDS}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Responder/T_DragResponder.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_DRAG_RESPONDER}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Responder/T_TouchResponder.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_TOUCH_RESPONDER}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Responder/T_TouchResponder.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_INDICATOR_TOUCH_RESPONDER}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/UI/Responder/T_TouchResponder.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.U_OBJ_P_SCREEN_FADE_TOUCH_RESPONDER}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/{KCDefine.B_DIR_P_SETUP_SCENE}T_LoadingText.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.SS_OBJ_P_LOADING_TEXT}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}Prefabs/{KCDefine.B_DIR_P_SETUP_SCENE}T_LoadingGauge.prefab", $"{KCEditorDefine.B_DIR_P_AUTO_RESOURCES}{KCDefine.SS_OBJ_P_LOADING_GAUGE}.prefab"),
#endif // #if PREFAB_TEMPLATES_ENABLE || PREFAB_TEMPLATES_MODULE_ENABLE
		// 01-Auto }

		// 42-SubUnityProject {
#if PREFAB_TEMPLATES_ENABLE || PREFAB_TEMPLATES_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_AlertPopup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_ALERT_POPUP}.prefab"),
#endif // #if PREFAB_TEMPLATES_ENABLE || PREFAB_TEMPLATES_MODULE_ENABLE

#if(POPUP_PREFAB_TEMPLATES_ENABLE || POPUP_PREFAB_TEMPLATES_MODULE_ENABLE) && (UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE)
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_STORE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_SETTINGS_POPUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_SYNC_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_DAILY_MISSION_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_FREE_REWARD_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_DAILY_REWARD_POPUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_COINS_BOX_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_REWARD_ACQUIRE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_COINS_BOX_ACQUIRE_POPUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_CONTINUE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_READY_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_RESULT_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_RESUME_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_PAUSE_POPUP}.prefab"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_Popup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_PRODUCT_BUY_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_FocusPopup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_FOCUS_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ}Prefabs/UI/Popup/T_FocusPopup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_OBJ_P_G_TUTORIAL_POPUP}.prefab"),
#endif // #if (POPUP_PREFAB_TEMPLATES_ENABLE || POPUP_PREFAB_TEMPLATES_MODULE_ENABLE) && (UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE)
		// 42-SubUnityProject }

		// 92-SubUnityProjectEditor {
#if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Prefabs/{KCDefine.B_DIR_P_EDITOR_SCENE}T_EditorInputPopup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.ES_OBJ_P_EDITOR_INPUT_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Prefabs/{KCDefine.B_DIR_P_EDITOR_SCENE}T_EditorCreatePopup.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.ES_OBJ_P_EDITOR_CREATE_POPUP}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Prefabs/{KCDefine.B_DIR_P_EDITOR_SCENE}T_EditorScrollerCellView.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.ES_OBJ_P_EDITOR_SCROLLER_CELL_VIEW}.prefab"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}Prefabs/{KCDefine.B_DIR_P_LEVEL_EDITOR_SCENE}T_REUIsPageUIs02ScrollCellView.prefab", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.LES_OBJ_P_RE_UIS_PAGE_UIS_02_SCROLLER_CELL_VIEW}.prefab")
#endif // #if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 92-SubUnityProjectEditor }
	};

	public static readonly List<(string, string)> B_TABLE_P_INFO_LIST = new List<(string, string)>() {
#if SAMPLE_PROJ || DEVELOPMENT_PROJ
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_EtcInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}A/G_EtcInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}B/G_EtcInfoTable.xlsx"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/MissionInfo/G_MissionInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_MissionInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/RewardInfo/G_RewardInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_RewardInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ResourceInfo/G_ResInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_ResInfoTable.xlsx"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ItemInfo/G_ItemInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_ItemInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/SkillInfo/G_SkillInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_SkillInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ObjectInfo/G_ObjInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_ObjInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/AbilityInfo/G_AbilityInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_AbilityInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ProductInfo/G_ProductInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_ProductInfoTable.xlsx"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/VersionInfo/G_VerInfoTable.xlsx", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_TABLES}G_VerInfoTable.xlsx"),
#endif // #if SAMPLE_PROJ || DEVELOPMENT_PROJ

		// 03.UnityProject
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ValueInfo/G_ValTable_Common.csv", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_COMMON_VAL}.csv"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/StringInfo/G_StrTable_Common.csv", $"{KCEditorDefine.B_ABS_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_COMMON_STR}.csv"),

		// 42-SubUnityProject {
#if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/StringInfo/G_StrTable_Common_{SystemLanguage.Korean}.csv", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_KOREAN_COMMON_STR}.csv"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/StringInfo/G_StrTable_Common_{SystemLanguage.English}.csv", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ENGLISH_COMMON_STR}.csv"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/MissionInfo/G_MissionInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_MISSION_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/MissionInfo/G_MissionInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_MISSION_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/RewardInfo/G_RewardInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_REWARD_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/RewardInfo/G_RewardInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_REWARD_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ResourceInfo/G_ResInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_RES_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ResourceInfo/G_ResInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_RES_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ItemInfo/G_ItemInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ITEM_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ItemInfo/G_ItemInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ITEM_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/SkillInfo/G_SkillInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_SKILL_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/SkillInfo/G_SkillInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_SKILL_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ObjectInfo/G_ObjInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_OBJ_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ObjectInfo/G_ObjInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_OBJ_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/AbilityInfo/G_AbilityInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ABILITY_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/AbilityInfo/G_AbilityInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ABILITY_INFO}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ProductInfo/G_ProductInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_PRODUCT_INFO}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/ProductInfo/G_ProductInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_PRODUCT_INFO}.json"),

#if MSG_PACK_SERIALIZE_DESERIALIZE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO, 1)}.bytes"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO, 1)}.bytes"),
#elif NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO, 1)}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO, 1)}.json"),
#endif // #if MSG_PACK_SERIALIZE_DESERIALIZE_ENABLE

#if AB_TEST_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_A}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_A}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_B}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_B}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_A}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_A}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_B}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/EtcInfo/G_EtcInfoTable.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_B}.json"),

#if MSG_PACK_SERIALIZE_DESERIALIZE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A, 1)}.bytes"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B, 1)}.bytes"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A, 1)}.bytes"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.bytes", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B, 1)}.bytes")
#elif NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A, 1)}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B, 1)}.json"),

		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A, 1)}.json"),
		($"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../UnityPackages/Client/Templates/Tables/LevelInfo/G_LevelInfo_000000001.json", $"{KCEditorDefine.B_ABS_DIR_P_SUB_UNITY_PROJ_RESOURCES}{string.Format(KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B, 1)}.json"),
#endif // #if MSG_PACK_SERIALIZE_DESERIALIZE_ENABLE
#endif // #if AB_TEST_ENABLE
#endif // #if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 42-SubUnityProject }
	};

	public static readonly List<(string, string)> B_ASSET_P_INFO_LIST = new List<(string, string)>() {
		// 41-UnityProject {
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_OptsInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_OPTS_INFO_TABLE}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_BuildInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_BUILD_INFO_TABLE}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_DefineSymbolInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_DEFINE_SYMBOL_INFO_TABLE}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_ProjInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_PROJ_INFO_TABLE}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_DeviceInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_DEVICE_INFO_TABLE}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_LocalizeInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_LOCALIZE_INFO_TABLE}.asset"),

		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_LightingSettings.lighting", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_NORM_QUALITY_LIGHTING_SETTINGS}.lighting"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_LightingSettings.lighting", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_HIGH_QUALITY_LIGHTING_SETTINGS}.lighting"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_LightingSettings.lighting", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_ULTRA_QUALITY_LIGHTING_SETTINGS}.lighting"),

#if POST_PROCESSING_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_PostProcessingSettings.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_NORM_QUALITY_POST_PROCESSING_SETTINGS}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_PostProcessingSettings.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_HIGH_QUALITY_POST_PROCESSING_SETTINGS}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Settings/T_PostProcessingSettings.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_ULTRA_QUALITY_POST_PROCESSING_SETTINGS}.asset"),
#endif // #if POST_PROCESSING_MODULE_ENABLE

#if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || APPS_FLYER_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_PluginInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_PLUGIN_INFO_TABLE}.asset"),
#endif // #if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || APPS_FLYER_MODULE_ENABLE

#if PURCHASE_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Scriptables/T_ProductInfoTable.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_PRODUCT_INFO_TABLE}.asset"),
#endif // #if PURCHASE_MODULE_ENABLE
		// 41-UnityProject }

		// 42-SubUnityProject
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_01}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_02}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_03}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_04}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_05}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_06}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_07}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_08}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_SPRITE_ATLAS_09}.spriteatlasv2"),

		// 92-SubUnityProjectEditor
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_01}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_02}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_03}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_04}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_05}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_06}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_07}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_08}.spriteatlasv2"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}SpriteAtlases/T_SpriteAtlas.spriteatlasv2", $"{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR_RESOURCES}{KCDefine.U_ASSET_P_ES_SPRITE_ATLAS_09}.spriteatlasv2")
	};

	public static readonly List<(string, string)> B_PIPELINE_P_INFO_LIST = new List<(string, string)>() {
		// 41-UnityProject {
#if URP_ENABLE || URP_MODULE_ENABLE
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Pipelines/T_URPAsset.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_NORM_QUALITY_URP}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Pipelines/T_URPAsset.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_HIGH_QUALITY_URP}.asset"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Pipelines/T_URPAsset.asset", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCDefine.U_ASSET_P_G_ULTRA_QUALITY_URP}.asset")
#endif // #if URP_ENABLE || URP_MODULE_ENABLE
		// 41-UnityProject }
	};

	public static readonly List<(string, string)> B_SCENE_P_INFO_LIST = new List<(string, string)>() {
		// 01-Auto {
#if SCENE_TEMPLATES_ENABLE || SCENE_TEMPLATES_MODULE_ENABLE
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_AUTO_SCENES}{KCDefine.B_SCENE_N_INIT}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_AUTO_SCENES}{KCDefine.B_SCENE_N_SETUP}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_AUTO_SCENES}{KCDefine.B_SCENE_N_LATE_SETUP}.unity"),

#if RESEARCH_ENABLE || RESEARCH_MODULE_ENABLE
		(KCEditorDefine.B_ASSET_P_MENU_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_AUTO_SCENES}{KCDefine.B_SCENE_N_MENU}.unity"),
#endif // #if RESEARCH_ENABLE || RESEARCH_MODULE_ENABLE
#endif // #if SCENE_TEMPLATES_ENABLE || SCENE_TEMPLATES_MODULE_ENABLE
		// 01-Auto }
		
		// 41-UnityProject {
#if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_TITLE}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_MAIN}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_PLAY}.unity"),

		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_LOADING}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_RESULT}.unity"),
		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_OVERLAY}.unity"),

		(KCEditorDefine.B_ASSET_P_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_SCENES}{KCDefine.B_SCENE_N_TEST}.unity"),
#endif // #if UTILITY_SCRIPT_TEMPLATES_ENABLE || UTILITY_SCRIPT_TEMPLATES_MODULE_ENABLE
		// 41-UnityProject }

		// 91-UnityProjectEditor {
#if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		(KCEditorDefine.B_ASSET_P_EDITOR_SAMPLE_SCENE, $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR_SCENES}{KCDefine.B_SCENE_N_LEVEL_EDITOR}.unity")
#endif // #if EDITOR_SCENE_TEMPLATES_ENABLE || EDITOR_SCENE_TEMPLATES_MODULE_ENABLE
		// 91-UnityProjectEditor }
	};

	public static readonly List<(string, string)> B_ASSEMBLY_DEFINE_P_INFO_LIST = new List<(string, string)>() {
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}AssemblyDefines/T_Module.UnityIronSrc.asmdef.t", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}IronSource/Module.UnityIronSrc.asmdef"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}AssemblyDefines/T_Module.UnityIronSrc.Editor.asmdef.t", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}IronSource/Editor/Module.UnityIronSrc.Editor.asmdef"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}AssemblyDefines/T_Module.UnityFlurry.asmdef.t", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}Plugins/FlurrySDK/Module.UnityFlurry.asmdef"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}AssemblyDefines/T_Module.UnityUnityPurchasing.asmdef.t", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}Scripts/UnityPurchasing/generated/Module.UnityUnityPurchasing.asmdef"),
		($"{KCEditorDefine.B_ABS_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_AUTO}AssemblyDefines/T_Module.UnityPlayfabParty.asmdef.t", $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}PlayFabPartySDK/Module.UnityPlayfabParty.asmdef")
	};

	public static readonly List<(string, string)> B_ICON_P_INFO_LIST = new List<(string, string)>() {
		// 41-UnityProject {
		// iOS
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon76x76.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_76x76}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon120x120.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_120x120}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon152x152.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_152x152}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon167x167.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_167x167}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon180x180.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_180x180}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/App/T_Icon1024x1024.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_APP_1024x1024}.png"),

		// 안드로이드
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon36x36.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_36x36}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon48x48.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_48x48}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon72x72.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_72x72}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon96x96.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_96x96}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon144x144.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_144x144}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon192x192.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_192x192}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/App/T_Icon512x512.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_APP_512x512}.png"),

		// 독립 플랫폼
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Standalone/App/T_Icon1024x1024.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_STANDALONE_APP_1024x1024}.png"),

		// Editor Default Resources
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}99-Extra/Resources/Textures/T_BG_OBJ_EMPTY_01.png", $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}ES_SpriteAtlas_01/LES_BG_OBJ_EMPTY_01.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}99-Extra/Resources/Textures/T_BG_OBJ_PLACEHOLDER_01.png", $"{KCEditorDefine.B_DIR_P_ASSETS}{KCEditorDefine.B_DIR_P_EDITOR_DEF_RESOURCES}{KCEditorDefine.B_DIR_P_SUB_UNITY_PROJ_EDITOR}ES_SpriteAtlas_01/LES_BG_OBJ_PLACEHOLDER_01.png"),

#if NOTI_MODULE_ENABLE
		// iOS
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/Notification/T_Icon20x20.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_NOTI_20x20}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/Notification/T_Icon40x40.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_NOTI_40x40}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/iOS/Notification/T_Icon60x60.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_IOS_NOTI_60x60}.png"),

		// 안드로이드
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon24x24.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_24x24}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon36x36.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_36x36}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon48x48.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_48x48}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon72x72.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_72x72}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon96x96.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_96x96}.png"),
		($"{KCEditorDefine.B_DIR_P_TEMPLATES}{KCEditorDefine.B_DIR_P_UNITY_PROJ}Icons/Android/Notification/T_Icon256x256.png", $"{KCEditorDefine.B_DIR_P_UNITY_PROJ_RESOURCES}{KCEditorDefine.B_ICON_P_ANDROID_NOTI_256x256}.png")
#endif // #if NOTI_MODULE_ENABLE
		// 41-UnityProject }
	};

	public static readonly List<(string, string)> B_ASSET_P_MOVE_INFO_LIST = new List<(string, string)>()
	{
#if MODULE_VER_2_7_0_OR_NEWER
		($"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEItem.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEItem.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CESkill.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CESkill.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEObj.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEObj.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEFX.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEFX.cs"),

		($"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEItem+Sub.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEItem+Sub.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CESkill+Sub.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CESkill+Sub.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEObj+Sub.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEObj+Sub.cs"),
		($"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Base/CEFX+Sub.cs", $"{KCEditorDefine.B_DIR_P_ENGINE_SUB_UNITY_PROJ_SCRIPTS}Runtime/Global/Utility/Object/CEFX+Sub.cs")
#endif // #if MODULE_VER_2_7_0_OR_NEWER
	};
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
