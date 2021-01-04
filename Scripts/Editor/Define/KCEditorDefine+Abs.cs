using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#if UNITY_EDITOR
using UnityEditor;

#if NOTI_MODULE_ENABLE
using Unity.Notifications.iOS;
#endif			// #if NOTI_MODULE_ENABLE

//! 에디터 기본 상수
public static partial class KCEditorDefine {
	#region 기본
	// 시간
	public const float B_DELTA_T_HIERARCHY_UPDATE = 1.0f;
	public const float B_DELTA_T_SCENE_M_SCRIPT_UPDATE = 1.0f;
	public const float B_DELTA_T_EDITOR_SM_SCENE_UPDATE = 1.0f;

	// 계층 뷰
	public const float B_HIERARCHY_TEXT_OFFSET_X = 15.0f;
	public const float B_HIERARCHY_OUTLINE_OFFSET_X = 1.0f;

	// 크기 {
	public const int B_FONT_SIZE_FPS_C_STATIC_TEXT = 24;
	public const int B_FONT_SIZE_FPS_C_DYNAMIC_TEXT = 24;

	public const int B_FONT_SIZE_DEBUG_C_TEXT = 30;

	public const float B_WIDTH_OBJ_NEW_NAME_TEXT_FIELD = 300.0f;
	public const float B_WIDTH_EDITOR_W_APPLY_BTN = 100.0f;
	// 크기 }

	// 비율
	public const float B_SCALE_FILE_BROWSER_WINDOW = 1.25f;

	// 토큰
	public const string B_TOKEN_DEFINE_SYMBOL = ";";

	// 형식
	public const string B_SORTING_OI_FMT = "[{0}:{1}]";

	// 커맨드 라인
	public const string B_CMD_LINE_PARAMS_FMT_SHELL = "-c \"{0}\"";
	public const string B_CMD_LINE_PARAMS_FMT_CMD_PROMPT = "/c \"{0}\"";

	// 경고 팝업 {
	public const string B_ALERT_P_TITLE = "알림";
	public const string B_ALERT_P_OK_BTN_TEXT = "확인";
	public const string B_ALERT_P_CANCEL_BTN_TEXT = "취소";

	public const string B_ALERT_P_EXPORT_IMG_SUCCESS_MSG = "이미지를 추출했습니다.";

	public const string B_ALERT_P_EXPORT_TEXTURE_FAIL_MSG = "텍스처를 선택해주세요.";
	public const string B_ALERT_P_EXPORT_SPRITE_FAIL_MSG = "스프라이트를 선택해주세요.";
	// 경고 팝업 }

	// 이름 {
	public const string B_CLS_N_LOG_ENTRIES = "UnityEditorInternal.LogEntries";

	public const string B_OBJ_N_GAME_OBJ = "GameObj";
	public const string B_OBJ_N_OBJ_N_EDITOR_POPUP = "ObjNameEditorPopup";
	public const string B_OBJ_N_FILE_BROWSER_WINDOW = "SimpleFileBrowserWindow";

	public const string B_OBJ_N_TEXT = "Text";
	public const string B_OBJ_N_LOCALIZE_TEXT = "LocalizeText";

	public const string B_OBJ_N_IMG = "Img";
	public const string B_OBJ_N_RAW_IMG = "RawImg";

	public const string B_OBJ_N_TEXT_BTN = "TextBtn";
	public const string B_OBJ_N_TEXT_SCALE_BTN = "TextScaleBtn";

	public const string B_OBJ_N_LOCALIZE_TEXT_BTN = "LocalizeTextBtn";
	public const string B_OBJ_N_LOCALIZE_TEXT_SCALE_BTN = "LocalizeTextScaleBtn";

	public const string B_OBJ_N_IMG_BTN = "ImgBtn";
	public const string B_OBJ_N_IMG_SCALE_BTN = "ImgScaleBtn";

	public const string B_OBJ_N_IMG_TEXT_BTN = "ImgTextBtn";
	public const string B_OBJ_N_IMG_TEXT_SCALE_BTN = "ImgTextScaleBtn";

	public const string B_OBJ_N_IMG_LOCALIZE_TEXT_BTN = "ImgLocalizeTextBtn";
	public const string B_OBJ_N_IMG_LOCALIZE_TEXT_SCALE_BTN = "ImgLocalizeTextScaleBtn";

	public const string B_OBJ_N_SCROLL_VIEW = "ScrollView";
	public const string B_OBJ_N_PAGE_SCROLL_VIEW = "PageScrollView";

	public const string B_OBJ_N_PARTICLE_FX = "ParticleFX";

	public const string B_OBJ_N_TOUCH_RESPONDER = "TouchResponder";
	public const string B_OBJ_N_DRAG_RESPONDER = "DragResponder";

	public const string B_OBJ_N_SCENE_EDITOR_CAMERA = "SceneCamera";
	public const string B_OBJ_N_SCENE_EDITOR_LIGHT = "SceneLight";
	
	public const string B_PROPERTY_N_CATEGORY = "applicationCategoryType";
	public const string B_PROPERTY_N_REQUIRE_AR_KIT_SUPPORT = "requiresARKitSupport";
	public const string B_PROPERTY_N_APPLE_ENABLE_PRO_MOTION = "appleEnableProMotion";
	public const string B_PROPERTY_N_AUTO_ADD_CAPABILITIES = "automaticallyDetectAndAddCapabilities";
	public const string B_PROPERTY_N_VALIDATE_APP_BUNDLE_SIZE = "validateAppBundleSize";
	public const string B_PROPERTY_N_APP_BUNDLE_SIZE_TO_VALIDATE = "appBundleSizeToValidate";
	public const string B_PROPERTY_N_SUPPORTED_ASPECT_RATIO_MODE = "supportedAspectRatioMode";

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

	public const string B_PROPERTY_N_DEBUG_C_LOG_ITEM_PREFAB = "logItemPrefab";
	public const string B_SCENE_N_PATTERN = "t:Example t:Scene";

	public const string B_SCENE_N_PATTERN_EDITOR_A = "EditorMenu";
	public const string B_SCENE_N_PATTERN_EDITOR_B = "EditorScene";

	public const string B_FUNC_N_SET_COMPRESSION_TYPE = "SetCompressionType";
	public const string B_FUNC_N_SET_LIGHTMAP_ENCODING_QUALITY = "SetLightmapEncodingQualityForPlatformGroup";
	public const string B_FUNC_N_SET_LIGHTMAP_STREAMING_ENABLE = "SetLightmapStreamingEnabledForPlatformGroup";
	public const string B_FUNC_N_SET_LIGHTMAP_STREAMING_PRIORITY = "SetLightmapStreamingPriorityForPlatformGroup";

	// 맥 {
	public const string B_FUNC_N_MAC_DEBUG_BUILD = "BuildMacDebug";
	public const string B_FUNC_N_MAC_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildMacWithAutoPlayDebug";

	public const string B_FUNC_N_MAC_RELEASE_BUILD = "BuildMacRelease";
	public const string B_FUNC_N_MAC_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildMacWithAutoPlayRelease";
	public const string B_FUNC_N_MAC_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildMacWithAutoPlayDisableFPSRelease";
	// 맥 }

	// 윈도우즈 {
	public const string B_FUNC_N_WINDOWS_DEBUG_BUILD = "BuildWindowsDebug";
	public const string B_FUNC_N_WINDOWS_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildWindowsWithAutoPlayDebug";

	public const string B_FUNC_N_WINDOWS_RELEASE_BUILD = "BuildWindowsRelease";
	public const string B_FUNC_N_WINDOWS_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildWindowsWithAutoPlayRelease";
	public const string B_FUNC_N_WINDOWS_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildWindowsWithAutoPlayDisableFPSRelease";
	// 윈도우즈 }

	// iOS {
	public const string B_FUNC_N_IOS_DEBUG_BUILD = "BuildiOSDebug";
	public const string B_FUNC_N_IOS_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildiOSWithAutoPlayDebug";

	public const string B_FUNC_N_IOS_RELEASE_BUILD = "BuildiOSRelease";
	public const string B_FUNC_N_IOS_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildiOSWithAutoPlayRelease";
	public const string B_FUNC_N_IOS_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildiOSWithAutoPlayDisableFPSRelease";

	public const string B_FUNC_N_IOS_ADHOC_BUILD = "BuildiOSAdhoc";
	public const string B_FUNC_N_IOS_ADHOC_WITH_ROBO_TEST_BUILD = "BuildiOSWithRoboTestAdhoc";

	public const string B_FUNC_N_IOS_STORE_BUILD = "BuildiOSStore";
	// iOS }

	// 구글 {
	public const string B_FUNC_N_GOOGLE_DEBUG_BUILD = "BuildGoogleDebug";
	public const string B_FUNC_N_GOOGLE_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildGoogleWithAutoPlayDebug";

	public const string B_FUNC_N_GOOGLE_RELEASE_BUILD = "BuildGoogleRelease";
	public const string B_FUNC_N_GOOGLE_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildGoogleWithAutoPlayRelease";
	public const string B_FUNC_N_GOOGLE_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildGoogleWithAutoPlayDisableFPSRelease";

	public const string B_FUNC_N_GOOGLE_ADHOC_BUILD = "BuildGoogleAdhoc";
	public const string B_FUNC_N_GOOGLE_ADHOC_WITH_ROBO_TEST_BUILD = "BuildGoogleWithRoboTestAdhoc";

	public const string B_FUNC_N_GOOGLE_STORE_BUILD = "BuildGoogleStore";
	public const string B_FUNC_N_GOOGLE_STORE_TEST_BUILD = "BuildGoogleStoreTest";
	// 구글 }

	// 윈 스토어 {
	public const string B_FUNC_N_ONE_STORE_DEBUG_BUILD = "BuildOneStoreDebug";
	public const string B_FUNC_N_ONE_STORE_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildOneStoreWithAutoPlayDebug";

	public const string B_FUNC_N_ONE_STORE_RELEASE_BUILD = "BuildOneStoreRelease";
	public const string B_FUNC_N_ONE_STORE_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildOneStoreWithAutoPlayRelease";
	public const string B_FUNC_N_ONE_STORE_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildOneStoreWithAutoPlayDisableFPSRelease";

	public const string B_FUNC_N_ONE_STORE_ADHOC_BUILD = "BuildOneStoreAdhoc";
	public const string B_FUNC_N_ONE_STORE_ADHOC_WITH_ROBO_TEST_BUILD = "BuildOneStoreWithRoboTestAdhoc";

	public const string B_FUNC_N_ONE_STORE_STORE_BUILD = "BuildOneStoreStore";
	public const string B_FUNC_N_ONE_STORE_STORE_TEST_BUILD = "BuildOneStoreStoreTest";
	// 윈 스토어 }

	// 갤럭시 스토어 {
	public const string B_FUNC_N_GALAXY_STORE_DEBUG_BUILD = "BuildGalaxyStoreDebug";
	public const string B_FUNC_N_GALAXY_STORE_DEBUG_WITH_AUTO_PLAY_BUILD = "BuildGalaxyStoreWithAutoPlayDebug";

	public const string B_FUNC_N_GALAXY_STORE_RELEASE_BUILD = "BuildGalaxyStoreRelease";
	public const string B_FUNC_N_GALAXY_STORE_RELEASE_WITH_AUTO_PLAY_BUILD = "BuildGalaxyStoreWithAutoPlayRelease";
	public const string B_FUNC_N_GALAXY_STORE_RELEASE_WITH_AUTO_PLAY_DISABLE_FPS_BUILD = "BuildGalaxyStoreWithAutoPlayDisableFPSRelease";

	public const string B_FUNC_N_GALAXY_STORE_ADHOC_BUILD = "BuildGalaxyStoreAdhoc";
	public const string B_FUNC_N_GALAXY_STORE_ADHOC_WITH_ROBO_TEST_BUILD = "BuildGalaxyStoreWithRoboTestAdhoc";

	public const string B_FUNC_N_GALAXY_STORE_STORE_BUILD = "BuildGalaxyStoreStore";
	public const string B_FUNC_N_GALAXY_STORE_STORE_TEST_BUILD = "BuildGalaxyStoreStoreTest";
	// 갤럭시 스토어 }
	// 이름 }

	// 경로 {
	public const string B_TOOL_P_SHELL = "/bin/zsh";
	public const string B_TOOL_P_CMD_PROMPT = "cmd.exe";

	public const string B_DIR_P_ASSETS = "Assets/";
	public const string B_DIR_P_PACKAGES = "Packages/";
	public const string B_DIR_P_AUTO_CREATE = "00.AutoCreate/";
	public const string B_DIR_P_UNITY_PROJ = "01.UnityProject/";
	public const string B_DIR_P_UNITY_PROJ_EDITOR = "02.UnityProjectEditor/";
	public const string B_DIR_P_PROJ_SETTINGS = "ProjectSettings/";

	public const string B_DIR_P_EXPORT_IMG_BASE = "Export/Images/";
	public const string B_ASSET_P_FMT_LIGHTING_SETTINGS = "{0}/{1}Settings.lighting";

	public const string B_OBJ_P_FILE_BROWSER_UI = "SimpleFileBrowserCanvas";
	// 경로 }
	
	// 에디터 옵션 {
	public const string B_EDITOR_OPTS_IOS_REMOTE_DEVICE = "Any iOS Device";
	public const string B_EDITOR_OPTS_ANDROID_REMOTE_DEVICE = "Any Android Device";
	public const string B_EDITOR_OPTS_DISABLE_REMOTE_DEVICE = "None";

	public const string B_EDITOR_OPTS_REMOTE_COMPRESSION = "JPEG";
	public const string B_EDITOR_OPTS_REMOTE_RESOLUTION = "Downsize";
	public const string B_EDITOR_OPTS_VERSION_CONTROL = "Visible Meta Files";
	public const string B_EDITOR_OPTS_JOYSTIC_SRC = "Remote";

#if GPU_LIGHTMAPPER_ENABLE
	public const LightingSettings.Lightmapper B_EDITOR_OPTS_LIGHTMAPPER = LightingSettings.Lightmapper.ProgressiveGPU;
#else
	public const LightingSettings.Lightmapper B_EDITOR_OPTS_LIGHTMAPPER = LightingSettings.Lightmapper.ProgressiveCPU;
#endif			// #if GPU_LIGHTMAPPER_ENABLE

#if LIGHTMAP_SHADOW_BAKE_ENABLE
#if UNIVERSAL_PIPELINE_MODULE_ENABLE
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.Subtractive;
#else
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.Shadowmask;
#endif			// #if UNIVERSAL_PIPELINE_MODULE_ENABLE
#else
	public const MixedLightingMode B_EDITOR_OPTS_LIGHTMAP_BAKE_MODE = MixedLightingMode.IndirectOnly;
#endif			// #if LIGHTMAP_SHADOW_BAKE_ENABLE
	// 에디터 옵션 }

	// 젠킨스 {
	public const string B_JENKINS_KEY_BRANCH = "Branch";
	public const string B_JENKINS_KEY_SRC = "Src";
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

	public const string B_JENKINS_BUILD_PARAMS_TOKEN = " ";
	public const string B_JENKINS_PIPELINE_GROUP_NAME = "job/00001.Common/job/01.Pipelines/job";

	public const string B_JENKINS_BUILD_DATA_FMT = "--data {0}={1}";
	public const string B_JENKINS_BUILD_CMD_FMT = "curl -X POST {0} --user {1}:{2} --data token={3}";

	public const string B_JENKINS_SRC_FMT = "{0}/{1}";
	public const string B_JENKINS_PROJ_P_FMT = "{0}/{1}/{2}";
	public const string B_JENKINS_ANALYTICS_FMT = "{0}/00.Analytics";

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
	public const string B_WINDOWS_BUILD_PATH = "Builds/Standalone/Windows/WindowsBuildOutput.exe";

	// iOS {
	public const string B_IOS_DEV_IPA_EXPORT_METHOD = "development";
	public const string B_IOS_ADHOC_IPA_EXPORT_METHOD = "ad-hoc";
	public const string B_IOS_STORE_IPA_EXPORT_METHOD = "app-store";

	public const string B_IOS_BUILD_PATH = "Builds/iOS";
	public const string B_IOS_INFO_PLIST_P_FMT = "{0}/Info.plist";

	public const string B_IOS_ENCRYPTION_ENABLE_KEY = "ITSAppUsesNonExemptEncryption";
	// iOS }

	// 안드로이드 {
	public const string B_ANDROID_APK_BUILD_FILE_EXTENSION = "apk";
	public const string B_ANDROID_AAB_BUILD_FILE_EXTENSION = "aab";

	public const string B_ANDROID_BUILD_P_FMT = "Builds/Android/{0}/{1}.{2}";
	public const string B_ANDROID_BUILD_FILE_N_FMT = "{0}BuildOutput";
	// 안드로이드 }
	#endregion			// 기본

	#region 런타임 상수
	// 계층 뷰
	public static readonly Color B_HIERARCHY_TEXT_COLOR = new Color(1.0f, 0.27f, 0.0f, 1.0f);
	public static readonly Color B_HIERARCHY_OUTLINE_COLOR = Color.black;

	// 색상
	public static readonly Color B_COLOR_UNITY_LOGO_BG = Color.black;

	// 크기
	public static readonly Vector2 B_SIZE_DEBUG_C_LOG_ITEM = new Vector2(0.0f, 80.0f);
	public static readonly Vector2 B_MIN_SIZE_EDITOR_WINDOW = new Vector2(350.0f, 350.0f);

	// 위치
	public static readonly Vector2 B_POS_FPS_C_STATIC_TEXT = new Vector2(-10.0f, 0.0f);
	public static readonly Vector2 B_POS_FPS_C_DYNAMIC_TEXT = new Vector2(-10.0f, 140.0f);

	// 경로 {
	public static readonly string B_DATA_P_BUILD_FUNC = $"{Application.dataPath}/../BuildFuncName.txt";

	public static readonly string B_DIR_P_AUTO_CREATE_RESES = string.Format("{0}{1}Resources/", KCEditorDefine.B_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE);
	public static readonly string B_DIR_P_UNITY_PROJ_RESES = string.Format("{0}{1}Resources/", KCEditorDefine.B_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ);
	
	public static readonly string B_DIR_P_FILTER_FPS_COUNTER = string.Format("{0}{1}{2}External", KCEditorDefine.B_DIR_P_AUTO_CREATE_RESES, KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_UTILITY);
	public static readonly string B_DIR_P_FILTER_DEBUG_CONSOLE = string.Format("{0}{1}{2}External", KCEditorDefine.B_DIR_P_AUTO_CREATE_RESES, KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_UTILITY);
	public static readonly string B_DIR_P_FILTER_DEBUG_LOG_ITEM = string.Format("{0}{1}{2}External", KCEditorDefine.B_DIR_P_AUTO_CREATE_RESES, KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_UTILITY);

	public static readonly string B_DIR_P_SCENES = string.Format("{0}{1}Scenes", KCEditorDefine.B_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ);
	public static readonly string B_DIR_P_AUTO_SCENES = string.Format("{0}{1}Scenes", KCEditorDefine.B_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE);
	public static readonly string B_DIR_P_EDITOR_SCENES = string.Format("{0}{1}Scenes", KCEditorDefine.B_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ_EDITOR);

	public static readonly string B_ABS_DIR_P_ASSETS = string.Format("{0}/", Application.dataPath);
	public static readonly string B_ABS_DIR_P_PACKAGES = string.Format("{0}../Packages/", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_ABS_DIR_P_UNITY_ENGINE = string.Format("{0}/", EditorApplication.applicationPath);

	public static readonly string B_ABS_DIR_P_SAMPLE_SCENE = string.Format("{0}.UnityModule.Common/Scenes/{1}.unity", KCEditorDefine.B_ABS_DIR_P_PACKAGES, KCDefine.B_SCENE_N_SAMPLE);
	public static readonly string B_ABS_DIR_P_STUDY_SAMPLE_SCENE = string.Format("{0}.UnityModule.Study/Scenes/{1}.unity", KCEditorDefine.B_ABS_DIR_P_PACKAGES, KCDefine.B_SCENE_N_SAMPLE);

	public static readonly string B_ABS_DIR_P_PLUGINS = string.Format("{0}/Plugins/", Application.dataPath);
	public static readonly string B_ABS_DIR_P_IOS_PLUGINS = string.Format("{0}iOS/", KCEditorDefine.B_ABS_DIR_P_PLUGINS);
	public static readonly string B_ABS_DIR_P_ANDROID_PLUGINS = string.Format("{0}Android/", KCEditorDefine.B_ABS_DIR_P_PLUGINS);

	public static readonly string B_ABS_DIR_P_TEMPLATES = string.Format("{0}.UnityModule.Common/Templates/", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ABS_DIR_P_UNITY_PACKAGES = string.Format("{0}.UnityModule.Common/UnityPackages/", KCEditorDefine.B_ABS_DIR_P_PACKAGES);

	public static readonly string B_ABS_DIR_P_ICON_TEMPLATES = string.Format("{0}Icons/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_FONT_TEMPLATES = string.Format("{0}Fonts/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_DATA_TEMPLATES = string.Format("{0}Datas/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_PREFAB_TEMPLATES = string.Format("{0}Prefabs/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_SCRIPT_TEMPLATES = string.Format("{0}Scripts/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_SCRIPTABLE_TEMPLATES = string.Format("{0}Scriptables/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_SPRITE_ATLAS_TEMPLATES = string.Format("{0}SpriteAtlases/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_PIPELINE_TEMPLATES = string.Format("{0}Pipelines/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_TABLE_TEMPLATES = string.Format("{0}Tables/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);
	public static readonly string B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES = string.Format("{0}AssemblyDefines/", KCEditorDefine.B_ABS_DIR_P_TEMPLATES);

	public static readonly string B_ABS_DIR_P_STUDY_TEMPLATES = string.Format("{0}.UnityModule.Study/Templates/", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ABS_DIR_P_STUDY_SCRIPT_TEMPLATES = string.Format("{0}Scripts/", KCEditorDefine.B_ABS_DIR_P_STUDY_TEMPLATES);

	public static readonly string B_ABS_PKG_P_2D_TOOLKIT = string.Format("{0}/2DToolkit-v2.5.8.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_BITMAP_FONT_IMPORTER = string.Format("{0}/BitmapFontImporter-v2.4.1.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_BUILD_REPORT_TOOL = string.Format("{0}/BuildReportTool-v3.5.2.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_NGUI = string.Format("{0}/NGUI-v2020.2.0.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_ODIN_INSPECTOR = string.Format("{0}/OdinInspector-v3.0.3.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_ZENJECT = string.Format("{0}/Zenject-v9.2.0.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);
	public static readonly string B_ABS_PKG_P_SPINE = string.Format("{0}/Spine-v3.8.0.unitypackage", KCEditorDefine.B_ABS_DIR_P_UNITY_PACKAGES);

	public static readonly string B_ASSET_P_TAG_MANAGER = string.Format("{0}TagManager.asset", KCEditorDefine.B_DIR_P_PROJ_SETTINGS);
	public static readonly string B_ASSET_P_SND_MANAGER = string.Format("{0}AudioManager.asset", KCEditorDefine.B_DIR_P_PROJ_SETTINGS);

	public static readonly string B_ASSET_P_BUILD_INFO_TABLE = string.Format("{0}{1}.asset", KCEditorDefine.B_DIR_P_UNITY_PROJ_RESES, KCDefine.U_ASSET_P_G_BUILD_INFO_TABLE);
	public static readonly string B_ASSET_P_BUILD_OPTS_TABLE = string.Format("{0}{1}.asset", KCEditorDefine.B_DIR_P_UNITY_PROJ_RESES, KCDefine.U_ASSET_P_G_BUILD_OPTS_TABLE);
	public static readonly string B_ASSET_P_PROJ_INFO_TABLE = string.Format("{0}{1}.asset", KCEditorDefine.B_DIR_P_UNITY_PROJ_RESES, KCDefine.U_ASSET_P_G_PROJ_INFO_TABLE);
	public static readonly string B_ASSET_P_DEFINE_SYMBOL_TABLE = string.Format("{0}{1}.asset", KCEditorDefine.B_DIR_P_UNITY_PROJ_RESES, KCDefine.U_ASSET_P_G_DEFINE_SYMBOL_TABLE);
	
	public static readonly string B_ASSET_P_FMT_SCRIPTABLE_OBJ = string.Format("{0}{1}", KCEditorDefine.B_DIR_P_ASSETS, "{0}.asset");
	public static readonly string B_ASSET_P_FMT_DEFINE_S_OUTPUT = string.Format("{0}/BuildOutput/{1}", KCDefine.B_DIR_P_WRITABLE, "{0}DefineSymbol.txt");

	public static readonly string B_IMG_P_FMT_TEXTURE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.B_DIR_P_EXPORT_IMG_BASE, "Textures/{0}.png");
	public static readonly string B_IMG_P_FMT_SPRITE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.B_DIR_P_EXPORT_IMG_BASE, "Sprites/{0}.png");

	public static readonly string B_DATA_P_UNITY_PKGS = string.Format("{0}manifest.json", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ICON_P_STANDALONE_APP = string.Format("{0}Standalone/App/Icon", KCDefine.B_DIR_P_ICONS);

	public static readonly string B_ICON_P_IOS_APP_76x76 = string.Format("{0}iOS/App/Icon76x76", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_APP_120x120 = string.Format("{0}iOS/App/Icon120x120", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_APP_152x152 = string.Format("{0}iOS/App/Icon152x152", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_APP_167x167 = string.Format("{0}iOS/App/Icon167x167", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_APP_180x180 = string.Format("{0}iOS/App/Icon180x180", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_APP_1024x1024 = string.Format("{0}iOS/App/Icon1024x1024", KCDefine.B_DIR_P_ICONS);

	public static readonly string B_ICON_P_IOS_NOTI_20x20 = string.Format("{0}iOS/Notification/Icon20x20", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_NOTI_40x40 = string.Format("{0}iOS/Notification/Icon40x40", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_IOS_NOTI_60x60 = string.Format("{0}iOS/Notification/Icon60x60", KCDefine.B_DIR_P_ICONS);

	public static readonly string B_ICON_P_ANDROID_APP_36x36 = string.Format("{0}Android/App/Icon36x36", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_48x48 = string.Format("{0}Android/App/Icon48x48", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_72x72 = string.Format("{0}Android/App/Icon72x72", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_96x96 = string.Format("{0}Android/App/Icon96x96", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_144x144 = string.Format("{0}Android/App/Icon144x144", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_192x192 = string.Format("{0}Android/App/Icon192x192", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_APP_512x512 = string.Format("{0}Android/App/Icon512x512", KCDefine.B_DIR_P_ICONS);

	public static readonly string B_ICON_P_ANDROID_NOTI_24x24 = string.Format("{0}Android/Notification/Icon24x24", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_NOTI_36x36 = string.Format("{0}Android/Notification/Icon36x36", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_NOTI_48x48 = string.Format("{0}Android/Notification/Icon48x48", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_NOTI_72x72 = string.Format("{0}Android/Notification/Icon72x72", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_NOTI_96x96 = string.Format("{0}Android/Notification/Icon96x96", KCDefine.B_DIR_P_ICONS);
	public static readonly string B_ICON_P_ANDROID_NOTI_256x256 = string.Format("{0}Android/Notification/Icon256x256", KCDefine.B_DIR_P_ICONS);

	public static readonly KeyValuePair<string, string>[] B_DATA_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_README.md", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES),
			string.Format("{0}{1}README.md", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}T_Services_{1}.txt", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.AS_DATA_P_SERVICES)),

		new KeyValuePair<string, string>(string.Format("{0}T_Privacy_{1}.txt", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.AS_DATA_P_PRIVACY)),

#if FIREBASE_MODULE_ENABLE
		new KeyValuePair<string, string>(string.Format("{0}T_CustomDependencies.xml.t", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES),
			string.Format("{0}Editor/CustomDependencies.xml", KCEditorDefine.B_ABS_DIR_P_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}T_GameConfig.json", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.json", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_DATA_P_G_GAME_CONFIG)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_BuildVersionConfig.json", KCEditorDefine.B_ABS_DIR_P_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.json", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_DATA_P_G_BUILD_VERSION_CONFIG))
#endif			// #if FIREBASE_MODULE_ENABLE
	};
	
	public static readonly KeyValuePair<string, string>[] B_SCRIPT_P_INFOS = new KeyValuePair<string, string>[] {
		// 00.AutoCreate {
		// 에디터 상수
		new KeyValuePair<string, string>(string.Format("{0}Editor/Define/T_KEditorDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Define/KEditorDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		// 에디터 씬 관리자 {
		new KeyValuePair<string, string>(string.Format("{0}Editor/Scene/T_CEditorSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/EditorScene/CEditorSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Scene/T_CEditorSceneManager+Setup.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/EditorScene/CEditorSceneManager+Setup.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),
		// 에디터 씬 관리자 }

		// 에디터 유틸리티 {
		new KeyValuePair<string, string>(string.Format("{0}Editor/Build/T_CBuildProcessHandler.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Utility/Build/CBuildProcessHandler.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/External/T_CMsgPackRegister.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/External/CMsgPackRegister.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),
		// 에디터 유틸리티 }

		// 씬 관리자 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubInitSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubInitScene/CSubInitSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubSetupScene/CSubSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubAgreeSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubAgreeScene/CSubAgreeSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubLateSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubLateSetupScene/CSubLateSetupSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE)),
		// 씬 관리자 }
		// 00.AutoCreate }

		// 01.UnityProject {
		// 상수 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+Abs.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+InitScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+InitScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SetupScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+SetupScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+AgreeScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+AgreeScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+LateSetupScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+LateSetupScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StartScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+StartScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SplashScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+SplashScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+PermissionScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+PermissionScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+LoadingScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+LoadingScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),		

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+IntroScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+IntroScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Type.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+Type.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Enum.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+Enum.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StringTable.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+StringTable.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+ValueTable.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+ValueTable.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+GameCenter.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+GameCenter.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 상수 }

		// 접근자 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Access/T_Access.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Access/Access.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Access/T_AccessExtension.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Access/AccessExtension.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Access/T_Access+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Access/Access+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Access/T_AccessExtension+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Access/AccessExtension+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 접근자 }

		// 팩토리 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Factory/T_Factory.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Factory/Factory.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Factory/T_Factory+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Factory/Factory+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 팩토리 }

		// 확장 클래스 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Extension/T_Extension.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Extension/Extension.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Extension/T_Extension+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Extension/Extension+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 확장 클래스 }

		// 함수 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_Func.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Function/Func.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_LogFunc.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Function/LogFunc.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_Func+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Function/Func+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Function/T_LogFunc+Global.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Function/LogFunc+Global.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 함수 }

		// 저장소 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Base/T_CBaseInfo.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Base/CBaseInfo.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CAppInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CAppInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CUserInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CUserInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Storage/T_CGameInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/Storage/CGameInfoStorage.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 저장소 }

		// 씬 관리자 {
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubLoadingSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubLoadingScene/CSubLoadingSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSplashSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubSplashScene/CSubSplashSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubPermissionSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubPermissionScene/CSubPermissionSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubStartSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubStartScene/CSubStartSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubIntroSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubIntroScene/CSubIntroSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),
		// 씬 관리자 }

#if STUDY_ENABLE || STUDY_MODULE_ENABLE
		// 상수
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+MenuScene.cs", KCEditorDefine.B_ABS_DIR_P_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/Global/Define/KDefine+MenuScene.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ)),

		// 씬 관리자
		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubMenuSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_STUDY_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/00.AutoCreate/SubMenuScene/CSubMenuSceneManager.cs", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ))
#endif			// #if STUDY_ENABLE || STUDY_MODULE_ENABLE
		// 01.UnityProject }
	};
	
	public static readonly KeyValuePair<string, string>[] B_PREFAB_P_INFOS = new KeyValuePair<string, string>[] {
		// 00.AutoCreate {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_Text.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_TEXT_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_Img.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_IMAGE_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_RawImg.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_IMAGE_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_RAW_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeText.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_TEXT_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_LOCALIZE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextScaleBtn.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_BUTTON_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_IMG_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ScrollView.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_SCROLL_VIEW_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_PageScrollView.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_SCROLL_VIEW_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_PAGE_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ParticleFX.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_FX_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_PARTICLE_FX)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Externals/OmniSARTechnologies/LiteFPSCounter/Prefabs/LiteFPSCounter.prefab", KCEditorDefine.B_ABS_DIR_P_PACKAGES),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_FPS_COUNTER)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Externals/SmartTimersManager/TimerManager/TimersManager.prefab", KCEditorDefine.B_ABS_DIR_P_PACKAGES),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_TIMER_MANAGER)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Plugins/IngameDebugConsole/IngameDebugConsole.prefab", KCEditorDefine.B_ABS_DIR_P_PACKAGES),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_DEBUG_CONSOLE)),

		new KeyValuePair<string, string>(string.Format("{0}.UnityModule.Common.Externals/Plugins/IngameDebugConsole/Prefabs/DebugLogItem.prefab", KCEditorDefine.B_ABS_DIR_P_PACKAGES),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.U_OBJ_P_DEBUG_LOG_ITEM)),
		// 00.AutoCreate }

		// 01.UnityProject {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_LandscapeAgreePopup.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_POPUP_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.AS_OBJ_P_LANDSCAPE_AGREE_POPUP)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_PortraitAgreePopup.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_POPUP_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.AS_OBJ_P_PORTRAIT_AGREE_POPUP)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_AlertPopup.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_POPUP_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_ALERT_POPUP)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ToastPopup.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_POPUP_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_TOAST_POPUP)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_BGSnd.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_SOUND_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_BG_SND)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_FXSnd.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_SOUND_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_FX_SND)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LoadingText.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_START_SCENE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.SS_OBJ_P_LOADING_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LoadingImgObj.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_START_SCENE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.SS_OBJ_P_LOADING_IMG_OBJ)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_DragResponder.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_RESPONDER_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_DRAG_RESPONDER)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TouchResponder.prefab", KCEditorDefine.B_ABS_DIR_P_PREFAB_TEMPLATES, KCDefine.B_DIR_P_RESPONDER_ROOT),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_OBJ_P_G_TOUCH_RESPONDER))
		// 01.UnityProject }
	};

	public static readonly KeyValuePair<string, string>[] B_TABLE_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ValueTable_Common.csv", KCEditorDefine.B_ABS_DIR_P_TABLE_TEMPLATES, KCDefine.B_DIR_P_VALUE_INFO_ROOT),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_TABLE_P_G_COMMON_VALUE)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common.csv", KCEditorDefine.B_ABS_DIR_P_TABLE_TEMPLATES, KCDefine.B_DIR_P_STRING_INFO_ROOT),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_TABLE_P_G_COMMON_STRING)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_{2}.csv", KCEditorDefine.B_ABS_DIR_P_TABLE_TEMPLATES, KCDefine.B_DIR_P_STRING_INFO_ROOT, SystemLanguage.Korean),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_TABLE_P_G_KOREAN_COMMON_STRING)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_{2}.csv", KCEditorDefine.B_ABS_DIR_P_TABLE_TEMPLATES, KCDefine.B_DIR_P_STRING_INFO_ROOT, SystemLanguage.English),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_TABLE_P_G_ENGLISH_COMMON_STRING))
	};

	public static readonly KeyValuePair<string, string>[] B_ASSET_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_ThaiFont.ttf", KCEditorDefine.B_ABS_DIR_P_FONT_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.ttf", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_FONT_P_G_THAI)),

		new KeyValuePair<string, string>(string.Format("{0}T_BuildInfoTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_BUILD_INFO_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_BuildOptsTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_BUILD_OPTS_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}T_DefineSymbolTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_DEFINE_SYMBOL_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_DeviceInfoTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_DEVICE_INFO_TABLE)),
		
		new KeyValuePair<string, string>(string.Format("{0}T_ProjInfoTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_PROJ_INFO_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}T_SpriteAtlas_01.spriteatlas.t", KCEditorDefine.B_ABS_DIR_P_SPRITE_ATLAS_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.spriteatlas", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_SPRITE_ATLAS_01)),

#if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE
		new KeyValuePair<string, string>(string.Format("{0}T_PluginInfoTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_PLUGIN_INFO_TABLE)),
#endif			// #if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE

#if PURCHASE_MODULE_ENABLE			
		new KeyValuePair<string, string>(string.Format("{0}T_ProductInfoTable.asset", KCEditorDefine.B_ABS_DIR_P_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_ASSET_P_G_PRODUCT_INFO_TABLE))
#endif			// #if PURCHASE_MODULE_ENABLE
	};

	public static readonly KeyValuePair<string, string>[] B_PIPELINE_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_UniversalRPAsset.asset", KCEditorDefine.B_ABS_DIR_P_PIPELINE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_PIPELINE_P_G_UNIVERSAL_RP)),

		new KeyValuePair<string, string>(string.Format("{0}T_UniversalRPRenderer.asset", KCEditorDefine.B_ABS_DIR_P_PIPELINE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.U_PIPELINE_P_G_UNIVERSAL_RP_RENDERER))
	};

	public static readonly KeyValuePair<string, string>[] B_SCENE_P_INFOS = new KeyValuePair<string, string>[] {
		// 00.AutoCreate {
		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.B_SCENE_N_INIT)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.B_SCENE_N_SETUP)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.B_SCENE_N_AGREE)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_AUTO_CREATE, KCDefine.B_SCENE_N_LATE_SETUP)),
		// 00.AutoCreate }

		// 01.UnityProject {
		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_START)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_SPLASH)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_PERMISSION)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_LOADING)),

		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_INTRO)),
			
#if STUDY_MODULE_ENABLE
		new KeyValuePair<string, string>(KCEditorDefine.B_ABS_DIR_P_STUDY_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/00.AutoCreate/{2}.unity", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCDefine.B_SCENE_N_MENU))
#endif			// #if STUDY_MODULE_ENABLE
		// 01.UnityProject }
	};

	public static readonly KeyValuePair<string, string>[] B_ASSEMBLY_DEFINE_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.IronSrc.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}IronSource/UnityModule.IronSrc.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.IronSrc.Editor.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}IronSource/Editor/UnityModule.IronSrc.Editor.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.Flurry.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}Plugins/FlurrySDK/UnityModule.Flurry.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.Tenjin.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}Tenjin/UnityModule.Tenjin.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.Singular.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}Code/UnityModule.Singular.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.GooglePlayGames.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}GooglePlayGames/UnityModule.GooglePlayGames.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.GooglePlayGames.Editor.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}GooglePlayGames/Editor/UnityModule.GooglePlayGames.Editor.asmdef", KCEditorDefine.B_ABS_DIR_P_ASSETS)),

		new KeyValuePair<string, string>(string.Format("{0}T_UnityModule.UnityPurchasing.asmdef.t", KCEditorDefine.B_ABS_DIR_P_ASSEMBLY_DEFINE_TEMPLATES),
			string.Format("{0}UnityPurchasing/generated/UnityModule.UnityPurchasing.asmdef", KCEditorDefine.B_ABS_DIR_P_PLUGINS))
	};

	public static readonly KeyValuePair<string, string>[] B_ICON_P_INFOS = new KeyValuePair<string, string>[] {
		// 독립 플랫폼
		new KeyValuePair<string, string>(string.Format("{0}Standalone/App/T_Icon.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_STANDALONE_APP)),

		// iOS {
		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon76x76.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_76x76)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon120x120.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_120x120)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon152x152.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_152x152)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon167x167.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_167x167)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon180x180.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_180x180)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/App/T_Icon1024x1024.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_APP_1024x1024)),
		// iOS }

		// 안드로이드 {
		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon36x36.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_36x36)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon48x48.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_48x48)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon72x72.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_72x72)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon96x96.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_96x96)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon144x144.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_144x144)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon192x192.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_192x192)),

		new KeyValuePair<string, string>(string.Format("{0}Android/App/T_Icon512x512.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_APP_512x512)),
		// 안드로이드 }

#if NOTI_MODULE_ENABLE
		// iOS {
		new KeyValuePair<string, string>(string.Format("{0}iOS/Notification/T_Icon20x20.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_NOTI_20x20)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/Notification/T_Icon40x40.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_NOTI_40x40)),

		new KeyValuePair<string, string>(string.Format("{0}iOS/Notification/T_Icon60x60.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_IOS_NOTI_60x60)),
		// iOS }

		// 안드로이드 {
		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon24x24.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_24x24)),

		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon36x36.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_36x36)),

		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon48x48.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_48x48)),

		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon72x72.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_72x72)),

		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon96x96.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_96x96)),

		new KeyValuePair<string, string>(string.Format("{0}Android/Notification/T_Icon256x256.png", KCEditorDefine.B_ABS_DIR_P_ICON_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_256x256))
		// 안드로이드 }
#endif			// #if NOTI_MODULE_ENABLE
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
	public static readonly string B_STANDALONE_ABS_BUILD_P_FMT = string.Format("{0}../Builds/Standalone/{1}", KCEditorDefine.B_ABS_DIR_P_ASSETS, "{0}");

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
	public static readonly string B_IOS_ABS_BUILD_PATH = string.Format("{0}../Builds/iOS", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_IOS_PLUGIN_PROJ_PTH = string.Format("{0}../PluginProjects/iOS", KCEditorDefine.B_ABS_DIR_P_ASSETS);

	public static readonly string B_IOS_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/iOS/Classes/Plugin/", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_IOS_DEST_PLUGIN_PATH = string.Format("{0}CustomiOSPlugin/", KCEditorDefine.B_ABS_DIR_P_IOS_PLUGINS);

	public static readonly GraphicsDeviceType[] B_IOS_DEVICE_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Metal
	};
	// iOS }

	// 안드로이드 {
	public static readonly string B_ANDROID_SRC_LIBRARY_PATH = string.Format("{0}../Temp/StagingArea/libs", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_ANDROID_ABS_BUILD_P_FMT = string.Format("{0}../Builds/Android/{1}", KCEditorDefine.B_ABS_DIR_P_ASSETS, "{0}");

	public static readonly string B_ANDROID_PLUGIN_PROJ_PATH = string.Format("{0}../PluginProjects/Android", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_ANDROID_PLUGIN_BUILD_CMD = string.Format("cd {0};./gradlew exportLibrary", KCEditorDefine.B_ANDROID_PLUGIN_PROJ_PATH);

	public static readonly string B_ANDROID_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/app/build/outputs/aar/app-release.aar", KCEditorDefine.B_ABS_DIR_P_ASSETS);
	public static readonly string B_ANDROID_DEST_PLUGIN_PATH = string.Format("{0}CustomAndroidPlugin.aar", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_MANIFEST_PATH = string.Format("{0}Options/Android/AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_MANIFEST_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_MANIFEST_PATH = string.Format("{0}AndroidManifest.xml", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_MAIN_TEMPLATE_PATH = string.Format("{0}Options/Android/mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_MAIN_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_MAIN_TEMPLATE_PATH = string.Format("{0}mainTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_LAUNCHER_TEMPLATE_PATH = string.Format("{0}Options/Android/launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_LAUNCHER_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_LAUNCHER_TEMPLATE_PATH = string.Format("{0}launcherTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_BASE_PROJ_TEMPLATE_PATH = string.Format("{0}Options/Android/baseProjectTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_BASE_PROJ_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/baseProjectTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_BASE_PROJ_TEMPLATE_PATH = string.Format("{0}baseProjectTemplate.gradle", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_PROGUARD_PATH = string.Format("{0}Options/Android/proguard-user.txt", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_PROGUARD_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/proguard-user.txt", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_PROGUARD_PATH = string.Format("{0}proguard-user.txt", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_GRADLE_TEMPLATE_PATH = string.Format("{0}Options/Android/gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_ORIGIN_SRC_GRADLE_TEMPLATE_PATH = string.Format("{0}../UnityPackages/Templates/Options/Android/gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_P_PACKAGES);
	public static readonly string B_ANDROID_DEST_GRADLE_TEMPLATE_PATH = string.Format("{0}gradleTemplate.properties", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS);

	public static readonly string B_ANDROID_SRC_UNITY_PLUGIN_PATH = string.Format("{0}../PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar", KCEditorDefine.B_ABS_DIR_P_UNITY_ENGINE);
	public static readonly string B_ANDROID_DEST_UNITY_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/app/libs/classes.jar", KCEditorDefine.B_ABS_DIR_P_ASSETS);

	public static readonly GraphicsDeviceType[] B_ANDROID_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Vulkan, GraphicsDeviceType.OpenGLES3, GraphicsDeviceType.OpenGLES2
	};
	// 안드로이드 }
	#endregion			// 런타임 상수

	#region 조건부 상수
#if UNITY_IOS
	// 프로퍼티 {
	public const string B_IOS_PROPERTY_N_ENABLE_BITCODE = "ENABLE_BITCODE";
	public const string B_IOS_PROPERTY_N_PREPROCESSOR_DEFINITIONS = "GCC_PREPROCESSOR_DEFINITIONS";

	public const string B_IOS_PROPERTY_VALUE_ENABLE_BITCODE = "YES";
	// 프로퍼티 }
#endif			// #if UNITY_IOS

#if NOTI_MODULE_ENABLE
	// 옵션
	public const PresentationOption B_PRESENT_OPTS_NOTI = PresentationOption.Alert | PresentationOption.Badge | PresentationOption.Sound;
	public const PresentationOption B_PRESENT_OPTS_REMOTE_NOTI = KCEditorDefine.B_PRESENT_OPTS_NOTI;
	
	// 이름
	public const string B_ACTIVITY_N_NOTI = "com.unity3d.player.UnityPlayerActivity";

	// 경로
	public static readonly KeyValuePair<string, string>[] B_NOTI_ICON_P_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_24x24),
			string.Format("{0}res/drawable-mdpi/icon24.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_36x36),
			string.Format("{0}res/drawable-hdpi/icon36.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_48x48),
			string.Format("{0}res/drawable-xhdpi/icon48.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_72x72),
			string.Format("{0}res/drawable-xxhdpi/icon72.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_96x96),
			string.Format("{0}res/drawable-xxxhdpi/icon96.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS)),

		new KeyValuePair<string, string>(string.Format("{0}{1}Resources/{2}.png", KCEditorDefine.B_ABS_DIR_P_ASSETS, KCEditorDefine.B_DIR_P_UNITY_PROJ, KCEditorDefine.B_ICON_P_ANDROID_NOTI_256x256),
			string.Format("{0}res/drawable/icon256.png", KCEditorDefine.B_ABS_DIR_P_ANDROID_PLUGINS))
	};
#endif			// #if NOTI_MODULE_ENABLE
	#endregion			// 조건부 상수

	#region 조건부 런타임 상수
#if UNITY_IOS
	// 경로
	public static readonly string B_IOS_CAPABILITY_ENTITLEMENTS_PATH = string.Format("{0}.entitlements", Application.productName);
#endif			// #if UNITY_IOS
	#endregion			// 조건부 런타임 상수
}
#endif			// #if UNITY_EDITOR
