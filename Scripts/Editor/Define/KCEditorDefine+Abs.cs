using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#if UNITY_EDITOR
using UnityEditor;

#if LOCAL_NOTI_MODULE_ENABLE
using Unity.Notifications.iOS;
#endif			// #if LOCAL_NOTI_MODULE_ENABLE

//! 에디터 기본 상수
public static partial class KCEditorDefine {
	#region 기본
	// 시간
	public const float B_DELTA_TIME_HIERARCHY_UPDATE = 1.0f;
	public const float B_DELTA_TIME_SCRIPT_M_SCENE_UPDATE = 1.0f;
	public const float B_DELTA_TIME_EDITOR_SM_SCENE_UPDATE = 1.0f;

	// 계층 뷰
	public const float B_HIERARCHY_WIDTH = 250.0f;
	public const float B_HIERARCHY_OFFSET_X = 125.0f;

	// 크기 {
	public const int B_FONT_SIZE_FPS_C_STATIC_TEXT = 24;
	public const int B_FONT_SIZE_FPS_C_DYNAMIC_TEXT = 24;

	public const int B_FONT_SIZE_DEBUG_C_TEXT = 30;

	public const float B_WIDTH_EDITOR_W_NAME_TEXT_FIELD = 300.0f;
	public const float B_WIDTH_EDITOR_W_APPLY_BTN = 100.0f;
	// 크기 }

	// 비율
	public const float B_SCALE_FILE_BROWSER_WINDOW = 1.5f;

	// 토큰
	public const string B_TOKEN_DEFINE_SYMBOL = ";";

	// 형식
	public const string B_SORTING_ORDER_INFO_FORMAT = "[{0}:{1}]";

	// 커맨드 라인
	public const string B_CMDLINE_PARAM_FORMAT_SHELL = "-c \"{0}\"";
	public const string B_CMDLINE_PARAM_FORMAT_CMD_PROMPT = "/c \"{0}\"";

	// 알림 팝업 {
	public const string B_ALERT_P_TITLE = "알림";
	public const string B_ALERT_P_OK_BTN_TEXT = "확인";
	public const string B_ALERT_P_CANCEL_BTN_TEXT = "취소";

	public const string B_ALERT_P_EXPORT_IMG_SUCCESS_MSG = "이미지를 추출했습니다.";

	public const string B_ALERT_P_EXPORT_TEXTURE_FAIL_MSG = "텍스처를 선택해주세요.";
	public const string B_ALERT_P_EXPORT_SPRITE_FAIL_MSG = "스프라이트를 선택해주세요.";
	// 알림 팝업 }

	// 이름 {
	public const string B_CLS_NAME_LOG_ENTRIES = "UnityEditorInternal.LogEntries";

	public const string B_OBJ_NAME_GAME_OBJ = "GameObj";
	public const string B_OBJ_NAME_OBJ_NAME_EDITOR_POPUP = "ObjNameEditorPopup";
	public const string B_OBJ_NAME_FILE_BROWSER_WINDOW = "SimpleFileBrowserWindow";

	public const string B_OBJ_NAME_TEXT = "Text";
	public const string B_OBJ_NAME_LOCALIZE_TEXT = "LocalizeText";

	public const string B_OBJ_NAME_IMG = "Img";
	public const string B_OBJ_NAME_RAW_IMG = "RawImg";

	public const string B_OBJ_NAME_TEXT_BTN = "TextBtn";
	public const string B_OBJ_NAME_TEXT_SCALE_BTN = "TextScaleBtn";

	public const string B_OBJ_NAME_LOCALIZE_TEXT_BTN = "LocalizeTextBtn";
	public const string B_OBJ_NAME_LOCALIZE_TEXT_SCALE_BTN = "LocalizeTextScaleBtn";

	public const string B_OBJ_NAME_IMG_BTN = "ImgBtn";
	public const string B_OBJ_NAME_IMG_SCALE_BTN = "ImgScaleBtn";

	public const string B_OBJ_NAME_IMG_TEXT_BTN = "ImgTextBtn";
	public const string B_OBJ_NAME_IMG_TEXT_SCALE_BTN = "ImgTextScaleBtn";

	public const string B_OBJ_NAME_IMG_LOCALIZE_TEXT_BTN = "ImgLocalizeTextBtn";
	public const string B_OBJ_NAME_IMG_LOCALIZE_TEXT_SCALE_BTN = "ImgLocalizeTextScaleBtn";

	public const string B_OBJ_NAME_SCROLL_VIEW = "ScrollView";
	public const string B_OBJ_NAME_PAGE_SCROLL_VIEW = "PageScrollView";

	public const string B_OBJ_NAME_TOUCH_RESPONDER = "TouchResponder";
	public const string B_OBJ_NAME_DRAG_RESPONDER = "DragResponder";

	public const string B_OBJ_NAME_SCENE_EDITOR_CAMERA = "SceneCamera";
	public const string B_OBJ_NAME_SCENE_EDITOR_LIGHT = "SceneLight";
	
	public const string B_PROPERTY_NAME_CATEGORY = "applicationCategoryType";
	public const string B_PROPERTY_NAME_REQUIRE_AR_KIT_SUPPORT = "requiresARKitSupport";
	public const string B_PROPERTY_NAME_APPLE_ENABLE_PRO_MOTION = "appleEnableProMotion";
	public const string B_PROPERTY_NAME_AUTO_ADD_CAPABILITIES = "automaticallyDetectAndAddCapabilities";
	public const string B_PROPERTY_NAME_VALIDATE_APP_BUNDLE_SIZE = "validateAppBundleSize";
	public const string B_PROPERTY_NAME_APP_BUNDLE_SIZE_TO_VALIDATE = "appBundleSizeToValidate";
	public const string B_PROPERTY_NAME_SUPPORTED_ASPECT_RATIO_MODE = "supportedAspectRatioMode";

	public const string B_PROPERTY_NAME_SORTING_LAYER = "sortingLayerName";
	public const string B_PROPERTY_NAME_SORTING_ORDER = "sortingOrder";

	public const string B_PROPERTY_NAME_TAG_M_TAG = "tags";
	public const string B_PROPERTY_NAME_TAG_M_NAME = "name";
	public const string B_PROPERTY_NAME_TAG_M_UNIQUE_ID = "uniqueID";
	public const string B_PROPERTY_NAME_TAG_M_SORTING_LAYER = "m_SortingLayers";

	public const string B_PROPERTY_NAME_SND_M_GLOBAL_VOLUME = "m_Volume";
	public const string B_PROPERTY_NAME_SND_M_ROLLOFF_SCALE = "Rolloff Scale";
	public const string B_PROPERTY_NAME_SND_M_DOPPLER_FACTOR = "Doppler Factor";
	public const string B_PROPERTY_NAME_SND_M_DISABLE_AUDIO = "m_DisableAudio";
	public const string B_PROPERTY_NAME_SND_M_VIRTUALIZE_EFFECT = "m_VirtualizeEffects";

	public const string B_PROPERTY_NAME_DEBUG_C_LOG_ITEM_PREFAB = "logItemPrefab";
	
	public const string B_FUNC_NAME_LOG_ENTRIES_CLEAR = "Clear";
	public const string B_FUNC_NAME_LOG_ENTRIES_GET_COUNT = "GetCount";

	public const string B_FUNC_NAME_SET_COMPRESSION_TYPE = "SetCompressionType";
	public const string B_FUNC_NAME_SET_LIGHTMAP_ENCODING_QUALITY = "SetLightmapEncodingQualityForPlatformGroup";
	public const string B_FUNC_NAME_SET_LIGHTMAP_STREAMING_ENABLE = "SetLightmapStreamingEnabledForPlatformGroup";
	public const string B_FUNC_NAME_SET_LIGHTMAP_STREAMING_PRIORITY = "SetLightmapStreamingPriorityForPlatformGroup";

	public const string B_SCENE_NAME_PATTERN = "t:Example t:Scene";

	public const string B_SCENE_NAME_PATTERN_EDITOR_A = "EditorMenu";
	public const string B_SCENE_NAME_PATTERN_EDITOR_B = "EditorScene";
	// 이름 }

	// 경로 {
	public const string B_TOOL_PATH_SHELL = "/bin/zsh";
	public const string B_TOOL_PATH_CMD_PROMPT = "cmd.exe";

	public const string B_DIR_PATH_ASSETS = "Assets/";
	public const string B_DIR_PATH_PACKAGES = "Packages/";
	public const string B_DIR_PATH_AUTO_CREATE = "00.AutoCreate/";
	public const string B_DIR_PATH_PROJ_SETTINGS = "ProjectSettings/";

	public const string B_DIR_PATH_EXPORT_IMG_BASE = "Export/Images/";
	public const string B_ASSET_PATH_FORMAT_LIGHTING_SETTINGS = "{0}/{1}Settings.lighting";

	public const string B_OBJ_PATH_FILE_BROWSER_UI = "SimpleFileBrowserCanvas";
	// 경로 }
	
	// 에디터 옵션 {
	public const string B_EDITOR_OPTS_IOS_REMOTE_DEVICE = "Any iOS Device";
	public const string B_EDITOR_OPTS_ANDROID_REMOTE_DEVICE = "Any Android Device";
	public const string B_EDITOR_OPTS_DISABLE_REMOTE_DEVICE = "None";

	public const string B_EDITOR_OPTS_REMOTE_COMPRESSION = "JPEG";
	public const string B_EDITOR_OPTS_REMOTE_RESOLUTION = "Downsize";
	public const string B_EDITOR_OPTS_VERSION_CONTROL = "Visible Meta Files";
	public const string B_EDITOR_OPTS_JOYSTIC_SOURCE = "Remote";

#if GPU_LIGHTMAPPER_ENABLE
	public const LightingSettings.Lightmapper B_EDITOR_OPTS_LIGHTMAPPER = LightingSettings.Lightmapper.ProgressiveGPU;
#else
	public const LightingSettings.Lightmapper B_EDITOR_OPTS_LIGHTMAPPER = LightingSettings.Lightmapper.ProgressiveCPU;
#endif			// #if GPU_LIGHTMAPPER_ENABLE

#if LIGHTMAP_SHADOW_BAKE_ENABLE
#if UNIVERSAL_PIPELINE_ENABLE
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.Subtractive;
#else
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.Shadowmask;
#endif			// #if UNIVERSAL_PIPELINE_ENABLE
#else
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.IndirectOnly;
#endif			// #if LIGHTMAP_SHADOW_BAKE_ENABLE
	// 에디터 옵션 }

	// 젠킨스 {
	public const string B_JENKINS_KEY_BRANCH = "Branch";
	public const string B_JENKINS_KEY_SOURCE = "Source";
	public const string B_JENKINS_KEY_PROJ_NAME = "ProjName";
	public const string B_JENKINS_KEY_PROJ_PATH = "ProjPath";
	public const string B_JENKINS_KEY_DIST_PATH = "DistPath";
	public const string B_JENKINS_KEY_BUNDLE_ID = "BundleID";
	public const string B_JENKINS_KEY_PROFILE_ID = "ProfileID";
	public const string B_JENKINS_KEY_PLATFORM = "Platform";
	public const string B_JENKINS_KEY_ANALYTICS = "Analytics";
	public const string B_JENKINS_KEY_BUILD_MODE = "BuildMode";
	public const string B_JENKINS_KEY_BUILD_FUNC = "BuildFunc";
	public const string B_JENKINS_KEY_PIPELINE_NAME = "PipelineName";
	public const string B_JENKINS_KEY_IPA_EXPORT_METHOD = "IPAExportMethod";
	public const string B_JENKINS_KEY_BUILD_FILE_EXTENSION = "BuildFileExtension";

	public const string B_JENKINS_BUILD_PARAM_TOKEN = " ";
	public const string B_JENKINS_PIPELINE_GROUP_NAME = "job/00001.Common/job/01.Pipelines/job";

	public const string B_JENKINS_BUILD_DATA_FORMAT = "--data {0}={1}";
	public const string B_JENKINS_BUILD_CMD_FORMAT = "curl -X POST {0} --user {1}:{2} --data token={3}";

	public const string B_JENKINS_SOURCE_FORMAT = "{0}/{1}";
	public const string B_JENKINS_PROJ_PATH_FORMAT = "{0}/{1}/{2}";
	public const string B_JENKINS_ANALYTICS_FORMAT = "{0}/00.Analytics";

	public const string B_JENKINS_STANDALONE_BUILD_PROJ_NAME = "41.Standalone";
	public const string B_JENKINS_IOS_BUILD_PROJ_NAME = "01.iOS";
	public const string B_JENKINS_ANDROID_BUILD_PROJ_NAME = "11.Android";

	public const string B_JENKINS_DEBUG_BUILD_FUNC = "Debug";
	public const string B_JENKINS_RELEASE_BUILD_FUNC = "Release";
	public const string B_JENKINS_ADHOC_BUILD_FUNC = "Adhoc";
	public const string B_JENKINS_ADHOC_UPLOAD_BUILD_FUNC = "AdhocUpload";
	public const string B_JENKINS_STORE_BUILD_FUNC = "Store";
	public const string B_JENKINS_STORE_TEST_BUILD_FUNC = "StoreTest";
	public const string B_JENKINS_STORE_UPLOAD_BUILD_FUNC = "StoreUpload";

	public const string B_JENKINS_STANDALONE_DEBUG_PIPELINE_NAME = "41.StandaloneDebug";
	public const string B_JENKINS_STANDALONE_RELEASE_PIPELINE_NAME = "42.StandaloneRelease";

	public const string B_JENKINS_IOS_DEBUG_PIPELINE_NAME = "01.iOSDebug";
	public const string B_JENKINS_IOS_RELEASE_PIPELINE_NAME = "02.iOSRelease";
	public const string B_JENKINS_IOS_ADHOC_PIPELINE_NAME = "03.iOSAdhoc";
	public const string B_JENKINS_IOS_STORE_PIPELINE_NAME = "04.iOSStore";

	public const string B_JENKINS_ANDROID_DEBUG_PIPELINE_NAME = "11.AndroidDebug";
	public const string B_JENKINS_ANDROID_RELEASE_PIPELINE_NAME = "12.AndroidRelease";
	public const string B_JENKINS_ANDROID_ADHOC_PIPELINE_NAME = "13.AndroidAdhoc";
	public const string B_JENKINS_ANDROID_STORE_PIPELINE_NAME = "14.AndroidStore";
	// 젠킨스 }

	// 맥
	public const string B_MAC_BUILD_PATH = "Builds/Standalone/Mac/MacBuildOutput.app";

	// 윈도우즈
	public const string B_WINDOWS_BUILD_PATH = "Builds/Standalone/Windows";

	// iOS {
	public const string B_IOS_DEV_IPA_EXPORT_METHOD = "development";
	public const string B_IOS_ADHOC_IPA_EXPORT_METHOD = "ad-hoc";
	public const string B_IOS_STORE_IPA_EXPORT_METHOD = "app-store";

	public const string B_IOS_BUILD_PATH = "Builds/iOS";
	public const string B_IOS_INFO_PLIST_PATH_FORMAT = "{0}/Info.plist";

	public const string B_IOS_ENCRYPTION_ENABLE_KEY = "ITSAppUsesNonExemptEncryption";
	// iOS }

	// 안드로이드 {
	public const string B_ANDROID_APK_BUILD_FILE_EXTENSION = "apk";
	public const string B_ANDROID_AAB_BUILD_FILE_EXTENSION = "aab";

	public const string B_ANDROID_BUILD_PATH_FORMAT = "Builds/Android/{0}/{1}.{2}";
	public const string B_ANDROID_BUILD_FILENAME_FORMAT = "{0}BuildOutput";
	// 안드로이드 }
	#endregion			// 기본

	#region 런타임 상수
	// 계층 뷰
	public static readonly Color B_HIERARCHY_TEXT_COLOR = new Color(1.0f, 0.27f, 0.0f, 1.0f);

	// 색상
	public static readonly Color B_COLOR_UNITY_LOGO_BG = Color.black;

	// 크기
	public static readonly Vector2 B_SIZE_DEBUG_C_LOG_ITEM = new Vector2(0.0f, 80.0f);
	public static readonly Vector2 B_MIN_SIZE_EDITOR_WINDOW = new Vector2(350.0f, 350.0f);

	// 위치
	public static readonly Vector2 B_POS_FPS_C_STATIC_TEXT = new Vector2(-10.0f, 0.0f);
	public static readonly Vector2 B_POS_FPS_C_DYNAMIC_TEXT = new Vector2(-10.0f, 140.0f);

	// 경로 {
	public static readonly string B_DIR_PATH_AUTO_CREATE_RESES = string.Format("{0}{1}Resources/", KCEditorDefine.B_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE);
	
	public static readonly string B_DIR_PATH_FILTER_FPS_COUNTER = string.Format("{0}UnityModule.Common.Externals/Resources", KCEditorDefine.B_DIR_PATH_PACKAGES);
	public static readonly string B_DIR_PATH_FILTER_DEBUG_CONSOLE = string.Format("{0}UnityModule.Common.Externals/Resources", KCEditorDefine.B_DIR_PATH_PACKAGES);
	public static readonly string B_DIR_PATH_FILTER_DEBUG_LOG_ITEM = string.Format("{0}UnityModule.Common.Externals/Resources", KCEditorDefine.B_DIR_PATH_PACKAGES);

	public static readonly string B_ABS_DIR_PATH_ASSETS = string.Format("{0}/", Application.dataPath);
	public static readonly string B_ABS_DIR_PATH_PACKAGES = string.Format("{0}../Packages/", KCEditorDefine.B_ABS_DIR_PATH_ASSETS);
	public static readonly string B_ABS_DIR_PATH_UNITY_ENGINE = string.Format("{0}/", EditorApplication.applicationPath);

	public static readonly string B_ABS_DIR_PATH_SAMPLE_SCENE = string.Format("{0}.UnityModule.Common/Scenes/SampleScene.unity", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ABS_DIR_PATH_STUDY_SAMPLE_SCENE = string.Format("{0}.UnityModule.Study/Scenes/SampleScene.unity", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);

	public static readonly string B_ABS_DIR_PATH_PLUGINS = string.Format("{0}/Plugins/", Application.dataPath);
	public static readonly string B_ABS_DIR_PATH_IOS_PLUGINS = string.Format("{0}iOS/", KCEditorDefine.B_ABS_DIR_PATH_PLUGINS);
	public static readonly string B_ABS_DIR_PATH_ANDROID_PLUGINS = string.Format("{0}Android/", KCEditorDefine.B_ABS_DIR_PATH_PLUGINS);

	public static readonly string B_ABS_DIR_PATH_TEMPLATES = string.Format("{0}.UnityModule.Common/Templates/", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ABS_DIR_PATH_DATA_TEMPLATES = string.Format("{0}Datas/", KCEditorDefine.B_ABS_DIR_PATH_TEMPLATES);
	public static readonly string B_ABS_DIR_PATH_PREFAB_TEMPLATES = string.Format("{0}Prefabs/", KCEditorDefine.B_ABS_DIR_PATH_TEMPLATES);
	public static readonly string B_ABS_DIR_PATH_SCRIPT_TEMPLATES = string.Format("{0}Scripts/", KCEditorDefine.B_ABS_DIR_PATH_TEMPLATES);
	public static readonly string B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES = string.Format("{0}Scriptables/", KCEditorDefine.B_ABS_DIR_PATH_TEMPLATES);
	public static readonly string B_ABS_DIR_PATH_TABLE_TEMPLATES = string.Format("{0}Tables/", KCEditorDefine.B_ABS_DIR_PATH_TEMPLATES);

	public static readonly string B_DIR_PATH_SCENES = string.Format("{0}01.UnityProject/Scenes", KCEditorDefine.B_DIR_PATH_ASSETS);
	public static readonly string B_DIR_PATH_AUTO_SCENES = string.Format("{0}{1}Scenes", KCEditorDefine.B_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE);
	public static readonly string B_DIR_PATH_EDITOR_SCENES = string.Format("{0}01.UnityProject_Editor/Scenes", KCEditorDefine.B_DIR_PATH_ASSETS);

	public static readonly string B_ASSET_PATH_TAG_MANAGER = string.Format("{0}TagManager.asset", KCEditorDefine.B_DIR_PATH_PROJ_SETTINGS);
	public static readonly string B_ASSET_PATH_SND_MANAGER = string.Format("{0}AudioManager.asset", KCEditorDefine.B_DIR_PATH_PROJ_SETTINGS);
	public static readonly string B_ASSET_PATH_DEFINE_SYMBOL_TABLE = string.Format("{0}{1}{2}G_DefineSymbolTable.asset", KCEditorDefine.B_DIR_PATH_AUTO_CREATE_RESES, KCDefine.B_DIR_PATH_SCRIPTABLES, KCDefine.B_DIR_PATH_GLOBAL_BASE);
	
	public static readonly string B_ASSET_PATH_FORMAT_SCRIPTABLE_OBJ = string.Format("{0}{1}", KCEditorDefine.B_DIR_PATH_ASSETS, "{0}.asset");
	public static readonly string B_ASSET_PATH_FORMAT_DEFINE_SYMBOL_OUTPUT = string.Format("{0}/BuildOutput/{1}", KCDefine.B_DIR_PATH_WRITABLE, "{0}DefineSymbol.txt");

	public static readonly string B_IMG_PATH_FORMAT_TEXTURE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.B_DIR_PATH_EXPORT_IMG_BASE, "Textures/{0}.png");
	public static readonly string B_IMG_PATH_FORMAT_SPRITE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.B_DIR_PATH_EXPORT_IMG_BASE, "Sprites/{0}.png");

	public static readonly string B_DATA_PATH_UNITY_PKGS = string.Format("{0}manifest.json", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);

	public static readonly KeyValuePair<string, string>[] B_PATH_DATA_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_Service_{1}.txt", KCEditorDefine.B_ABS_DIR_PATH_DATA_TEMPLATES, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_SERVICE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}T_Personal_{1}.txt", KCEditorDefine.B_ABS_DIR_PATH_DATA_TEMPLATES, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_PERSONAL_TEXT)),

#if FIREBASE_MODULE_ENABLE && FIREBASE_REMOTE_CONFIG_ENABLE
		new KeyValuePair<string, string>(string.Format("{0}T_GameConfig.json", KCEditorDefine.B_ABS_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.json", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_DATA_PATH_G_GAME_CONFIG)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_BuildVersionConfig.json", KCEditorDefine.B_ABS_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.json", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_DATA_PATH_G_BUILD_VERSION_CONFIG))
#endif			// #if FIREBASE_MODULE_ENABLE && FIREBASE_REMOTE_CONFIG_ENABLE
	};
	
	public static readonly KeyValuePair<string, string>[] B_PATH_SCRIPT_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}Editor/Define/T_KEditorDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Define/KEditorDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Build/T_CBuildProcessHandler.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Utility/Build/CBuildProcessHandler.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Scene/T_CEditorSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/EditorScene/CEditorSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Scene/T_CEditorSceneManager+Setup.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/EditorScene/CEditorSceneManager+Setup.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+InitScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+InitScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SetupScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+SetupScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StartScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+StartScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+LoadingScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+LoadingScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SplashScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+SplashScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+AgreeScene.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+AgreeScene.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StringTable.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+StringTable.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+ValueTable.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+ValueTable.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+GameCenter.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+GameCenter.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Type.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+Type.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),
			
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Base/T_CBaseInfo.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Base/CBaseInfo.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_Func.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Function/Func.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_LogFunc.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Function/LogFunc.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CAppInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CAppInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CUserInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CUserInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CGameInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CGameInfoStorage.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/External/T_CMsgPackRegister.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/External/CMsgPackRegister.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubInitSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubInitScene/CSubInitSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubSetupScene/CSubSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubStartSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubStartScene/CSubStartSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubLoadingSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubLoadingScene/CSubLoadingSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSplashSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubSplashScene/CSubSplashSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubAgreeSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubAgreeScene/CSubAgreeSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubLateSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubLateSetupScene/CSubLateSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubIntroSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubIntroScene/CSubIntroSceneManager.cs", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE))
	};
	
	public static readonly KeyValuePair<string, string>[] B_PATH_PREFAB_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_Text.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_TEXT_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_Img.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_IMAGE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_RawImg.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_IMAGE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_RAW_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeText.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_TEXT_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_LOCALIZE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_IMG_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ScrollView.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_SCROLL_VIEW_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_PageScrollView.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_SCROLL_VIEW_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_PAGE_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_DragResponder.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_RESPONDER_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_DRAG_RESPONDER)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TouchResponder.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_RESPONDER_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_TOUCH_RESPONDER)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_AlertPopup.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_POPUP_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_ALERT_POPUP)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ToastPopup.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_POPUP_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_TOAST_POPUP)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_BGSnd.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_SOUND_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_BG_SND)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_FXSnd.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_SOUND_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_OBJ_PATH_FX_SND)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LoadingText.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_START_SCENE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.SS_OBJ_PATH_LOADING_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LoadingImgObj.prefab", KCEditorDefine.B_ABS_DIR_PATH_PREFAB_TEMPLATES, KCDefine.B_DIR_PATH_START_SCENE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.SS_OBJ_PATH_LOADING_IMG_OBJ)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Externals/OmniSARTechnologies/LiteFPSCounter/Prefabs/LiteFPSCounter.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}.UnityModule.Common.Externals/Resources/{1}.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES, KCDefine.U_OBJ_PATH_FPS_COUNTER)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Externals/SmartTimersManager/TimerManager/TimersManager.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}.UnityModule.Common.Externals/Resources/{1}.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES, KCDefine.U_OBJ_PATH_TIMER_MANAGER)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Plugins/IngameDebugConsole/IngameDebugConsole.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}.UnityModule.Common.Externals/Resources/{1}.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES, KCDefine.U_OBJ_PATH_DEBUG_CONSOLE)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Plugins/IngameDebugConsole/Prefabs/DebugLogItem.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}.UnityModule.Common.Externals/Resources/{1}.prefab", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES, KCDefine.U_OBJ_PATH_DEBUG_LOG_ITEM))
	};

	public static readonly KeyValuePair<string, string>[] B_PATH_TABLE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ValueTable_Common.csv", KCEditorDefine.B_ABS_DIR_PATH_TABLE_TEMPLATES, KCDefine.B_DIR_PATH_VALUE_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_TABLE_PATH_G_COMMON_VALUE)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common.csv", KCEditorDefine.B_ABS_DIR_PATH_TABLE_TEMPLATES, KCDefine.B_DIR_PATH_STRING_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_TABLE_PATH_G_COMMON_STRING)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_TABLE_TEMPLATES, KCDefine.B_DIR_PATH_STRING_INFO_BASE, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_TABLE_PATH_G_KOREAN_COMMON_STRING)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_TABLE_TEMPLATES, KCDefine.B_DIR_PATH_STRING_INFO_BASE, SystemLanguage.English),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_TABLE_PATH_G_ENGLISH_COMMON_STRING))
	};

	public static readonly KeyValuePair<string, string>[] B_PATH_SCRIPTABLE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_BuildInfoTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_BUILD_INFO_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_BuildOptsTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_BUILD_OPTS_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}T_DefineSymbolTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_DEFINE_SYMBOL_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_DeviceInfoTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_DEVICE_INFO_TABLE)),
		
		new KeyValuePair<string, string>(string.Format("{0}T_ProjInfoTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_PROJ_INFO_TABLE)),

#if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE
		new KeyValuePair<string, string>(string.Format("{0}T_PluginInfoTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_PLUGIN_INFO_TABLE)),
#endif			// #if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE

#if PURCHASE_MODULE_ENABLE			
		new KeyValuePair<string, string>(string.Format("{0}T_ProductInfoTable.asset", KCEditorDefine.B_ABS_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.U_ASSET_PATH_G_PRODUCT_INFO_TABLE))
#endif			// #if PURCHASE_MODULE_ENABLE
	};

	public static readonly KeyValuePair<string, string>[] B_PATH_SCENE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_INIT)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_SETUP)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_START)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_LOADING)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_SPLASH)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_AGREE)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_LATE_SETUP)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_INTRO)),

#if STUDY_MODULE_ENABLE
		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_PATH_STUDY_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, KCEditorDefine.B_DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_MENU))
#endif			// #if STUDY_MODULE_ENABLE
	};

	public static readonly KeyValuePair<string, string>[] B_PATH_ASSEMBLY_DEFINITION_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Ads/Templates/T_UnityModule.IronSource.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}IronSource/UnityModule.IronSource.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Ads/Templates/T_UnityModule.IronSource.Editor.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}IronSource/Editor/UnityModule.IronSource.Editor.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Flurry/Templates/T_UnityModule.Flurry.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}Plugins/FlurrySDK/UnityModule.Flurry.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Tenjin/Templates/T_UnityModule.Tenjin.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}Tenjin/UnityModule.Tenjin.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Singular/Templates/T_UnityModule.Singular.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}Code/UnityModule.Singular.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.GameCenter/Templates/T_UnityModule.GooglePlayGames.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}GooglePlayGames/UnityModule.GooglePlayGames.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.GameCenter/Templates/T_UnityModule.GooglePlayGames.Editor.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}GooglePlayGames/Editor/UnityModule.GooglePlayGames.Editor.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Purchase/Templates/T_UnityModule.UnityPurchasing.asmdef.t", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES),
			string.Format("{0}Resources/UnityPurchasing/generated/UnityModule.UnityPurchasing.asmdef", KCEditorDefine.B_ABS_DIR_PATH_ASSETS))
	};
	// 경로 }

	// 에디터 옵션
	public static readonly string[] B_EDITOR_OPTS_EXTENSIONS = new string[] {
		"txt", "xml", "fnt", "cd", "asmdef", "rsp", "asmref"
	};

	// 젠킨스
	public static readonly string B_JENKINS_STANDALONE_PIPELINE = string.Format("{0}/41.Standalone", KCEditorDefine.B_JENKINS_PIPELINE_GROUP_NAME);
	public static readonly string B_JENKINS_IOS_PIPELINE = string.Format("{0}/01.iOS", KCEditorDefine.B_JENKINS_PIPELINE_GROUP_NAME);
	public static readonly string B_JENKINS_ANDROID_PIPELINE = string.Format("{0}/11.Android", KCEditorDefine.B_JENKINS_PIPELINE_GROUP_NAME);

	// 독립 플랫폼
	public static readonly string B_STANDALONE_ABS_BUILD_PATH_FORMAT = string.Format("{0}../Builds/Standalone/{1}", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, "{0}");

	// 맥
	public static readonly GraphicsDeviceType[] B_MAC_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Metal, GraphicsDeviceType.OpenGLCore
	};

	// 윈도우즈
	public static readonly GraphicsDeviceType[] B_WINDOWS_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
#if DIRECT_3D_12_ENABLE
		GraphicsDeviceType.Direct3D12, 
#endif			// #if DIRECT_3D_12_ENABLE
		
		GraphicsDeviceType.Direct3D11
	};

	// iOS {
	public static readonly string B_IOS_ABS_BUILD_PATH = string.Format("{0}../Builds/iOS", KCEditorDefine.B_ABS_DIR_PATH_ASSETS);

	public static readonly string B_IOS_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/iOS/Classes/Plugin/", KCEditorDefine.B_ABS_DIR_PATH_ASSETS);
	public static readonly string B_IOS_DEST_PLUGIN_PATH = string.Format("{0}CustomiOSPlugin/", KCEditorDefine.B_ABS_DIR_PATH_IOS_PLUGINS);

	public static readonly GraphicsDeviceType[] B_IOS_DEVICE_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Metal
	};
	// iOS }

	// 안드로이드 {
	public static readonly string B_ANDROID_ABS_BUILD_PATH_FORMAT = string.Format("{0}../Builds/Android/{1}", KCEditorDefine.B_ABS_DIR_PATH_ASSETS, "{0}");

	public static readonly string B_ANDROID_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/app/build/outputs/aar/app-release.aar", KCEditorDefine.B_ABS_DIR_PATH_ASSETS);
	public static readonly string B_ANDROID_DEST_PLUGIN_PATH = string.Format("{0}CustomAndroidPlugin.aar", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_MANIFEST_PATH = string.Format("{0}Options/Android/AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_MANIFEST_PATH = string.Format("{0}../UnityPackages/Options/Android/AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_DEST_MANIFEST_PATH = string.Format("{0}AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_MAIN_TEMPLATE_PATH = string.Format("{0}Options/Android/mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_MAIN_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Options/Android/mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_DEST_MAIN_TEMPLATE_PATH = string.Format("{0}mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_LAUNCHER_TEMPLATE_PATH = string.Format("{0}Options/Android/launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_LAUNCHER_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Options/Android/launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_DEST_LAUNCHER_TEMPLATE_PATH = string.Format("{0}launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_PROGUARD_PATH = string.Format("{0}Options/Android/proguard-user.txt", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_PROGUARD_PATH = string.Format("{0}../UnityPackages/Options/Android/proguard-user.txt", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_DEST_PROGUARD_PATH = string.Format("{0}proguard-user.txt", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_GRADLE_TEMPLATE_PATH = string.Format("{0}Options/Android/gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_GRADLE_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Options/Android/gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_PATH_PACKAGES);
	public static readonly string B_ANDROID_DEST_GRADLE_TEMPLATE_PATH = string.Format("{0}gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_PATH_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_UNITY_PLUGIN_PATH = string.Format("{0}../PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar", KCEditorDefine.B_ABS_DIR_PATH_UNITY_ENGINE);
	public static readonly string B_ANDROID_DEST_UNITY_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/app/libs/classes.jar", KCEditorDefine.B_ABS_DIR_PATH_ASSETS);

	public static readonly GraphicsDeviceType[] B_ANDROID_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Vulkan, GraphicsDeviceType.OpenGLES3, GraphicsDeviceType.OpenGLES2
	};
	// 안드로이드 }
	#endregion			// 런타임 상수

	#region 조건부 상수
#if UNITY_IOS
	// 프로퍼티
	public const string B_PROPERTY_NAME_ENABLE_BITCODE = "ENABLE_BITCODE";
	public const string B_PROPERTY_VALUE_ENABLE_BITCODE = "YES";
#endif			// #if UNITY_IOS

#if LOCAL_NOTI_MODULE_ENABLE
	public const PresentationOption B_PRESENT_OPTS_LOCAL_NOTI = PresentationOption.Alert | PresentationOption.Badge | PresentationOption.Sound;
	public const PresentationOption B_PRESENT_OPTS_REMOTE_NOTI = KCEditorDefine.B_PRESENT_OPTS_LOCAL_NOTI;
#endif			// #if LOCAL_NOTI_MODULE_ENABLE
	#endregion			// 조건부 상수

	#region 조건부 런타임 상수
#if UNITY_IOS
	// 경로
	public static readonly string B_PATH_CAPABILITY_ENTITLEMENTS_IOS = string.Format("{0}.entitlements", Application.productName);
#endif			// #if UNITY_IOS

#if LOCAL_NOTI_MODULE_ENABLE
	// 경로
	public static readonly string B_ASSET_PATH_NOTI_SETTINGS = string.Format("{0}NotificationsSettings.asset", KCEditorDefine.B_DIR_PATH_PROJ_SETTINGS);
#endif			// #if LOCAL_NOTI_MODULE_ENABLE
	#endregion			// 조건부 런타임 상수
}
#endif			// #if UNITY_EDITOR
