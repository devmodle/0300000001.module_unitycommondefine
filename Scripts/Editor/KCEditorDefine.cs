using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;

//! 에디터 기본 상수
public static partial class KCEditorDefine {
	#region 기본
	// 시간
	public const float DELTA_TIME_HIERARCHY_UPDATE = 1.0f;
	public const float DELTA_TIME_EDITOR_SM_SCENE_UPDATE = 0.25f;

	// 계층 뷰
	public const float HIERARCHY_WIDTH = 250.0f;
	public const float HIERARCHY_OFFSET_X = 125.0f;

	// 크기 {
	public const float WIDTH_EDITOR_W_NAME_TEXT_FIELD = 100.0f;
	public const float TOTAL_WIDTH_EDITOR_W_NAME_TEXT_FIELD = 200.0f;

	public const float WIDTH_EDITOR_W_APPLY_BTN = 100.0f;
	// 크기 }

	// 토큰
	public const string TOKEN_EXTENSION = ";";
	public const string TOKEN_DEFINE_SYMBOL = ";";

	// 형식
	public const string SORTING_ORDER_INFO_FORMAT = "[{0}:{1}]";

	// 커맨드 라인
	public const string CMDLINE_PARAMETER_FORMAT_SHELL = "-c \"{0}\"";
	public const string CMDLINE_PARAMETER_FORMAT_CMD_PROMPT = "/c \"{0}\"";

	// 알림 팝업 {
	public const string ALERT_P_TITLE = "알림";
	public const string ALERT_P_OK_BTN_TEXT = "확인";
	public const string ALERT_P_CANCEL_BTN_TEXT = "취소";

	public const string ALERT_P_EXPORT_IMG_SUCCESS_MSG = "이미지를 추출했습니다.";

	public const string ALERT_P_EXPORT_TEXTURE_FAIL_MSG = "텍스처를 선택해주세요.";
	public const string ALERT_P_EXPORT_SPRITE_FAIL_MSG = "스프라이트를 선택해주세요.";
	// 알림 팝업 }

	// 이름 {
	public const string OBJ_NAME_GAME_OBJ = "GameObj";
	public const string OBJ_NAME_OBJ_NAME_EDITOR_POPUP = "ObjNameEditorPopup";

	public const string OBJ_NAME_TEXT = "Text";
	public const string OBJ_NAME_LOCALIZE_TEXT = "LocalizeText";

	public const string OBJ_NAME_IMG = "Img";
	public const string OBJ_NAME_RAW_IMG = "RawImg";

	public const string OBJ_NAME_TEXT_BTN = "TextBtn";
	public const string OBJ_NAME_TEXT_SCALE_BTN = "TextScaleBtn";

	public const string OBJ_NAME_LOCALIZE_TEXT_BTN = "LocalizeTextBtn";
	public const string OBJ_NAME_LOCALIZE_TEXT_SCALE_BTN = "LocalizeTextScaleBtn";

	public const string OBJ_NAME_IMG_BTN = "ImgBtn";
	public const string OBJ_NAME_IMG_SCALE_BTN = "ImgScaleBtn";

	public const string OBJ_NAME_IMG_TEXT_BTN = "ImgTextBtn";
	public const string OBJ_NAME_IMG_TEXT_SCALE_BTN = "ImgTextScaleBtn";

	public const string OBJ_NAME_IMG_LOCALIZE_TEXT_BTN = "ImgLocalizeTextBtn";
	public const string OBJ_NAME_IMG_LOCALIZE_TEXT_SCALE_BTN = "ImgLocalizeTextScaleBtn";

	public const string OBJ_NAME_SCROLL_VIEW = "ScrollView";
	public const string OBJ_NAME_PAGE_SCROLL_VIEW = "PageScrollView";

	public const string OBJ_NAME_TOUCH_RESPONDER = "TouchResponder";
	public const string OBJ_NAME_DRAG_RESPONDER = "DragResponder";

	public const string OBJ_NAME_SCENE_EDITOR_CAMERA = "SceneCamera";
	public const string OBJ_NAME_SCENE_EDITOR_LIGHT = "SceneLight";
	
	public const string PROPERTY_NAME_CATEGORY = "applicationCategoryType";
	public const string PROPERTY_NAME_OPTIMIZE_FRAME_PACING = "optimizedFramePacing";
	public const string PROPERTY_NAME_REQUIRE_AR_KIT_SUPPORT = "requiresARKitSupport";
	public const string PROPERTY_NAME_APPLE_ENABLE_PRO_MOTION = "appleEnableProMotion";
	public const string PROPERTY_NAME_AUTO_ADD_CAPABILITIES = "automaticallyDetectAndAddCapabilities";
	public const string PROPERTY_NAME_VALIDATE_APP_BUNDLE_SIZE = "validateAppBundleSize";
	public const string PROPERTY_NAME_APP_BUNDLE_SIZE_TO_VALIDATE = "appBundleSizeToValidate";
	public const string PROPERTY_NAME_SUPPORTED_ASPECT_RATIO_MODE = "supportedAspectRatioMode";

	public const string PROPERTY_NAME_SORTING_LAYER = "sortingLayerName";
	public const string PROPERTY_NAME_SORTING_ORDER = "sortingOrder";

	public const string PROPERTY_NAME_TAG_M_TAG = "tags";
	public const string PROPERTY_NAME_TAG_M_NAME = "name";
	public const string PROPERTY_NAME_TAG_M_UNIQUE_ID = "uniqueID";
	public const string PROPERTY_NAME_TAG_M_SORTING_LAYER = "m_SortingLayers";

	public const string PROPERTY_NAME_SND_M_GLOBAL_VOLUME = "m_Volume";
	public const string PROPERTY_NAME_SND_M_ROLLOFF_SCALE = "Rolloff Scale";
	public const string PROPERTY_NAME_SND_M_DOPPLER_FACTOR = "Doppler Factor";
	public const string PROPERTY_NAME_SND_M_DISABLE_AUDIO = "m_DisableAudio";
	public const string PROPERTY_NAME_SND_M_VIRTUALIZE_EFFECT = "m_VirtualizeEffects";

	public const string PROPERTY_NAME_ENABLE_BAKE_LIGHTMAPS = "m_GISettings.m_EnableBakedLightmaps";
	public const string PROPERTY_NAME_ENABLE_REALTIME_LIGHTMAPS = "m_GISettings.m_EnableRealtimeLightmaps";

	public const string FUNC_NAME_GET_LIGHTMAP_SETTINGS = "GetLightmapSettings";
	public const string FUNC_NAME_SET_COMPRESSION_TYPE = "SetCompressionType";
	public const string FUNC_NAME_SET_LIGHTMAP_ENCODING_QUALITY = "SetLightmapEncodingQualityForPlatformGroup";
	public const string FUNC_NAME_SET_LIGHTMAP_STREAMING_ENABLE = "SetLightmapStreamingEnabledForPlatformGroup";
	public const string FUNC_NAME_SET_LIGHTMAP_STREAMING_PRIORITY = "SetLightmapStreamingPriorityForPlatformGroup";

	public const string SCENE_NAME_PATTERN = "t:Example t:Scene";

	public const string SCENE_NAME_PATTERN_EDITOR_A = "EditorMenu";
	public const string SCENE_NAME_PATTERN_EDITOR_B = "EditorScene";
	// 이름 }

	// 경로 {
	public const string TOOL_PATH_SHELL = "/bin/zsh";
	public const string TOOL_PATH_CMD_PROMPT = "cmd.exe";

	public const string DIR_PATH_ASSETS = "Assets/";
	public const string DIR_PATH_AUTO_CREATE = "00.AutoCreate/";
	public const string DIR_PATH_PROJECT_SETTINGS = "ProjectSettings/";

	public const string DIR_PATH_EXPORT_IMG_BASE = "Export/Images/";
	// 경로 }
	
	// 에디터 옵션 {
	public const string EDITOR_OPTION_IOS_REMOTE_DEVICE = "Any iOS Device";
	public const string EDITOR_OPTION_ANDROID_REMOTE_DEVICE = "Any Android Device";
	public const string EDITOR_OPTION_DISABLE_REMOTE_DEVICE = "None";

	public const string EDITOR_OPTION_REMOTE_COMPRESSION = "JPEG";
	public const string EDITOR_OPTION_REMOTE_RESOLUTION = "Downsize";
	public const string EDITOR_OPTION_VERSION_CONTROL = "Visible Meta Files";
	public const string EDITOR_OPTION_JOYSTIC_SOURCE = "Remote";
	// 에디터 옵션 }

	// 젠킨스 {
	public const string JENKINS_KEY_BRANCH = "Branch";
	public const string JENKINS_KEY_SOURCE = "Source";
	public const string JENKINS_KEY_PROJECT_NAME = "ProjectName";
	public const string JENKINS_KEY_PROJECT_PATH = "ProjectPath";
	public const string JENKINS_KEY_DISTRIBUTION_PATH = "DistributionPath";
	public const string JENKINS_KEY_BUNDLE_ID = "BundleID";
	public const string JENKINS_KEY_PROFILE_ID = "ProfileID";
	public const string JENKINS_KEY_PLATFORM = "Platform";
	public const string JENKINS_KEY_ANALYTICS = "Analytics";
	public const string JENKINS_KEY_BUILD_MODE = "BuildMode";
	public const string JENKINS_KEY_BUILD_FUNC = "BuildFunc";
	public const string JENKINS_KEY_PIPELINE_NAME = "PipelineName";
	public const string JENKINS_KEY_IPA_EXPORT_METHOD = "IPAExportMethod";
	public const string JENKINS_KEY_BUILD_FILE_EXTENSION = "BuildFileExtension";

	public const string JENKINS_PIPELINE_GROUP_NAME = "job/00001.Common/job/01.Pipelines/job";
	public const string JENKINS_BUILD_PARAMETER_TOKEN = " ";

	public const string JENKINS_BUILD_DATA_FORMAT = "--data {0}={1}";
	public const string JENKINS_BUILD_CMD_FORMAT = "curl -X POST {0} --user {1}:{2} --data token={3}";

	public const string JENKINS_SOURCE_FORMAT = "{0}/{1}";
	public const string JENKINS_PROJECT_PATH_FORMAT = "{0}/{1}/{2}";
	public const string JENKINS_ANALYTICS_FORMAT = "{0}/00.Analytics";

	public const string JENKINS_STANDALONE_BUILD_PROJECT_NAME = "41.Standalone";
	public const string JENKINS_IOS_BUILD_PROJECT_NAME = "01.iOS";
	public const string JENKINS_ANDROID_BUILD_PROJECT_NAME = "11.Android";

	public const string JENKINS_DEBUG_BUILD_FUNC = "Debug";
	public const string JENKINS_RELEASE_BUILD_FUNC = "Release";
	public const string JENKINS_ADHOC_BUILD_FUNC = "Adhoc";
	public const string JENKINS_STORE_BUILD_FUNC = "Store";

	public const string JENKINS_STANDALONE_DEBUG_PIPELINE_NAME = "41.StandaloneDebug";
	public const string JENKINS_STANDALONE_RELEASE_PIPELINE_NAME = "42.StandaloneRelease";

	public const string JENKINS_IOS_DEBUG_PIPELINE_NAME = "01.iOSDebug";
	public const string JENKINS_IOS_RELEASE_PIPELINE_NAME = "02.iOSRelease";
	public const string JENKINS_IOS_ADHOC_PIPELINE_NAME = "03.iOSAdhoc";
	public const string JENKINS_IOS_STORE_PIPELINE_NAME = "04.iOSStore";

	public const string JENKINS_ANDROID_DEBUG_PIPELINE_NAME = "11.iOSDebug";
	public const string JENKINS_ANDROID_RELEASE_PIPELINE_NAME = "12.iOSRelease";
	public const string JENKINS_ANDROID_ADHOC_PIPELINE_NAME = "13.iOSAdhoc";
	public const string JENKINS_ANDROID_STORE_PIPELINE_NAME = "14.iOSStore";
	// 젠킨스 }

	// 맥
	public const string MAC_BUILD_PATH = "Builds/Standalone/Mac/MacBuildOutput.app";

	// 윈도우즈
	public const string WINDOWS_BUILD_PATH = "Builds/Standalone/Windows";

	// iOS {
	public const string IOS_DEV_IPA_EXPORT_METHOD = "development";
	public const string IOS_ADHOC_IPA_EXPORT_METHOD = "ad-hoc";
	public const string IOS_STORE_IPA_EXPORT_METHOD = "app-store";

	public const string IOS_BUILD_PATH = "Builds/iOS";
	public const string IOS_INFO_PLIST_PATH_FORMAT = "{0}/Info.plist";

	public const string IOS_ENCRYPTION_ENABLE_KEY = "ITSAppUsesNonExemptEncryption";
	// iOS }

	// 안드로이드 {
	public const string ANDROID_APK_BUILD_FILE_EXTENSION = "apk";
	public const string ANDROID_AAB_BUILD_FILE_EXTENSION = "aab";

	public const string ANDROID_BUILD_PATH_FORMAT = "Builds/Android/{0}/{1}.{2}";
	public const string ANDROID_BUILD_FILENAME_FORMAT = "{0}BuildOutput";
	// 안드로이드 }
	#endregion			// 기본

	#region 런타임 상수
	// 계층 뷰
	public static readonly Color HIERARCHY_TEXT_COLOR = new Color(1.0f, 0.27f, 0.0f, 1.0f);

	// 색상
	public static readonly Color COLOR_UNITY_LOGO_BG = new Color(0.137f, 0.121f, 0.125f, 1.0f);

	// 크기
	public static readonly Vector2 MIN_SIZE_EDITOR_WINDOW = new Vector2(350.0f, 350.0f);

	// 경로 {
	public static readonly string DIR_PATH_AUTO_CREATE_RESES = string.Format("{0}{1}Resources", KCEditorDefine.DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE);

	public static readonly string ABSOLUTE_DIR_PATH_ASSETS = string.Format("{0}/", Application.dataPath);
	public static readonly string ABSOLUTE_DIR_PATH_UNITY_ENGINE = string.Format("{0}/", EditorApplication.applicationPath);
	public static readonly string ABSOLUTE_DIR_PATH_SAMPLE_SCENE = string.Format("{0}00.Application/00.Unity.Module.Common/Scenes/SampleScene.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string B_ABSOLUTE_DIR_PATH_STUDY_SAMPLE_SCENE = string.Format("{0}00.Application/00.Unity.Module.Study/Scenes/SampleScene.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string ABSOLUTE_DIR_PATH_TEMPLATES = string.Format("{0}00.Application/00.Unity.Module.Common/Templates/", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string ABSOLUTE_DIR_PATH_DATA_TEMPLATES = string.Format("{0}Datas/", KCEditorDefine.ABSOLUTE_DIR_PATH_TEMPLATES);
	public static readonly string ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES = string.Format("{0}Prefabs/", KCEditorDefine.ABSOLUTE_DIR_PATH_TEMPLATES);
	public static readonly string ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES = string.Format("{0}Scripts/", KCEditorDefine.ABSOLUTE_DIR_PATH_TEMPLATES);
	public static readonly string ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES = string.Format("{0}Scriptables/", KCEditorDefine.ABSOLUTE_DIR_PATH_TEMPLATES);
	public static readonly string ABSOLUTE_DIR_PATH_TABLE_TEMPLATES = string.Format("{0}Tables/", KCEditorDefine.ABSOLUTE_DIR_PATH_TEMPLATES);

	public static readonly string ASSET_PATH_TAG_MANAGER = string.Format("{0}TagManager.asset", KCEditorDefine.DIR_PATH_PROJECT_SETTINGS);
	public static readonly string ASSET_PATH_SND_MANAGER = string.Format("{0}AudioManager.asset", KCEditorDefine.DIR_PATH_PROJECT_SETTINGS);

	public static readonly string DIR_PATH_SCENES = string.Format("{0}01.UnityProject/Scenes", KCEditorDefine.DIR_PATH_ASSETS);
	public static readonly string DIR_PATH_AUTO_SCENES = string.Format("{0}{1}Scenes", KCEditorDefine.DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE);
	public static readonly string DIR_PATH_EDITOR_SCENES = string.Format("{0}01.UnityProject_Editor/Scenes", KCEditorDefine.DIR_PATH_ASSETS);

	public static readonly string IMG_PATH_FORMAT_TEXTURE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.DIR_PATH_EXPORT_IMG_BASE, "Textures/{0}.png");
	public static readonly string IMG_PATH_FORMAT_SPRITE_TO_IMG = string.Format("{0}{1}", KCEditorDefine.DIR_PATH_EXPORT_IMG_BASE, "Sprites/{0}.png");

	public static readonly string PATH_FORMAT_SCRIPTABLE_OBJ = string.Format("{0}{1}", KCEditorDefine.DIR_PATH_ASSETS, "{0}.asset");
	public static readonly string ASSET_PATH_FORMAT_DEFINE_SYMBOL_OUTPUT = string.Format("{0}/BuildOutput/{1}", KCDefine.DIR_PATH_WRITABLE, "{0}DefineSymbol.txt");
		
	public static readonly KeyValuePair<string, string>[] PATH_DATA_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_Service_KO.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_KOREAN_SERVICE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}T_Personal_KO.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_KOREAN_PERSONAL_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}T_Service_EN.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_ENGLISH_SERVICE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}T_Personal_EN.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_DATA_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.AS_DATA_PATH_ENGLISH_PERSONAL_TEXT))
	};
	
	public static readonly KeyValuePair<string, string>[] PATH_SCRIPT_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}Editor/Define/T_KACEditorDefine.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Define/KACEditorDefine.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Build/T_CPlatformBuildHandler.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Utility/Build/CPlatformBuildHandler.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Editor/Manager/T_CScriptManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Editor/Global/Utility/Manager/CScriptManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+InitScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+InitScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SetupScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+SetupScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StartScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+StartScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+LoadingScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+LoadingScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+SplashScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+SplashScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+AgreeScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+AgreeScene.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+StringTable.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+StringTable.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+ValueTable.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+ValueTable.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Define/T_KDefine+GameCenter.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Define/KDefine+GameCenter.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/External/T_CMessagePackRegister.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/Global/Utility/External/CMessagePackRegister.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubInitSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubInitScene/CSubInitSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSetupSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubSetupScene/CSubSetupSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubStartSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubStartScene/CSubStartSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubLoadingSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubLoadingScene/CSubLoadingSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubSplashSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubSplashScene/CSubSplashSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubAgreeSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubAgreeScene/CSubAgreeSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE)),

		new KeyValuePair<string, string>(string.Format("{0}Runtime/Scene/T_CSubIntroSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPT_TEMPLATES),
			string.Format("{0}{1}Scripts/Runtime/SubIntroScene/CSubIntroSceneManager.cs", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE))
	};
	
	public static readonly KeyValuePair<string, string>[] PATH_PREFAB_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_Text.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_TEXT_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_Img.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_IMAGE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_RawImg.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_IMAGE_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_RAW_IMG)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TextScaleBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeText.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_TEXT_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_LOCALIZE_TEXT)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_LocalizeTextScaleBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgScaleBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgTextScaleBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_LOCALIZE_TEXT_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ImgLocalizeTextScaleBtn.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_BUTTON_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_IMG_LOCALIZE_TEXT_SCALE_BTN)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_ScrollView.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_SCROLL_VIEW_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_PageScrollView.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_SCROLL_VIEW_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_PAGE_SCROLL_VIEW)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_DragResponder.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_RESPONDER_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_DRAG_RESPONDER)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_TouchResponder.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_RESPONDER_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_TOUCH_RESPONDER)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_AlertPopup.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_POPUP_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_ALERT_POPUP)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ToastPopup.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_POPUP_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_TOAST_POPUP)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_BGSnd.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_SOUND_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_BG_SND)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_FXSnd.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_PREFAB_TEMPLATES, KCDefine.DIR_PATH_SOUND_BASE),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_FX_SND)),

		new KeyValuePair<string, string>(string.Format("{0}00.Application/00.Unity.Module.Common.Externals/Externals/SmartTimersManager/TimerManager/TimersManager.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_SS_TIMER_MANAGER)),

#if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
		new KeyValuePair<string, string>(string.Format("{0}00.Application/00.Unity.Module.Common.Externals/Externals/OmniSARTechnologies/LiteFPSCounter/Prefabs/LiteFPSCounter.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS),
			string.Format("{0}{1}Resources/{2}.prefab", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.OBJ_PATH_SS_FPS_COUNTER)),
#endif			// #if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	};

	public static readonly KeyValuePair<string, string>[] PATH_TABLE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}{1}T_ValueTable_Common.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_TABLE_TEMPLATES, KCDefine.DIR_PATH_VALUE_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.TABLE_PATH_G_COMMON_VALUE_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_TABLE_TEMPLATES, KCDefine.DIR_PATH_STRING_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.TABLE_PATH_G_COMMON_STRING_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_KO.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_TABLE_TEMPLATES, KCDefine.DIR_PATH_STRING_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.TABLE_PATH_G_KOREAN_COMMON_STRING_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}{1}T_StringTable_Common_EN.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_TABLE_TEMPLATES, KCDefine.DIR_PATH_STRING_INFO_BASE),
			string.Format("{0}{1}Resources/{2}.csv", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.TABLE_PATH_G_ENGLISH_COMMON_STRING_TABLE))
	};

	public static readonly KeyValuePair<string, string>[] PATH_SCRIPTABLE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(string.Format("{0}T_BuildInfoTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_BUILD_INFO_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_BuildOptionTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_BUILD_OPTION_TABLE)),

		new KeyValuePair<string, string>(string.Format("{0}T_DefineSymbolTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_DEFINE_SYMBOL_TABLE)),
			
		new KeyValuePair<string, string>(string.Format("{0}T_DeviceInfoTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_DEVICE_INFO_TABLE)),
		
		new KeyValuePair<string, string>(string.Format("{0}T_ProjectInfoTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_PROJECT_INFO_TABLE)),

#if ADS_ENABLE || TENJIN_ENABLE || FLURRY_ENABLE || FIREBASE_ENABLE
		new KeyValuePair<string, string>(string.Format("{0}T_PluginInfoTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_PLUGIN_INFO_TABLE)),
#endif			// #if ADS_ENABLE || TENJIN_ENABLE || FLURRY_ENABLE || FIREBASE_ENABLE

#if PURCHASE_ENABLE			
		new KeyValuePair<string, string>(string.Format("{0}T_ProductInfoTable.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_SCRIPTABLE_TEMPLATES),
			string.Format("{0}{1}Resources/{2}.asset", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.SCRIPTABLE_PATH_G_PRODUCT_INFO_TABLE))
#endif			// #if PURCHASE_ENABLE
	};

	public static readonly KeyValuePair<string, string>[] PATH_SCENE_FILEPATH_INFOS = new KeyValuePair<string, string>[] {
		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_INIT)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_SETUP)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_START)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_LOADING)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_SPLASH)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_AGREE)),

		new KeyValuePair<string, string>(KCEditorDefine.ABSOLUTE_DIR_PATH_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_INTRO)),

#if STUDY_MODULE_ENABLE
		new KeyValuePair<string, string>(KCEditorDefine.B_ABSOLUTE_DIR_PATH_STUDY_SAMPLE_SCENE,
			string.Format("{0}{1}Scenes/{2}.unity", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, KCEditorDefine.DIR_PATH_AUTO_CREATE, KCDefine.B_SCENE_NAME_MENU))
#endif			// #if STUDY_MODULE_ENABLE
	};
	// 경로 }

	// 에디터 옵션
	public static readonly string[] EDITOR_OPTION_EXTENSIONS = new string[] {
		"txt", "xml", "fnt", "cd", "asmdef", "rsp", "asmref"
	};

	// 젠킨스
	public static readonly string JENKINS_STANDALONE_PIPELINE = string.Format("{0}/41.Standalone", KCEditorDefine.JENKINS_PIPELINE_GROUP_NAME);
	public static readonly string JENKINS_IOS_PIPELINE = string.Format("{0}/01.iOS", KCEditorDefine.JENKINS_PIPELINE_GROUP_NAME);
	public static readonly string JENKINS_ANDROID_PIPELINE = string.Format("{0}/11.Android", KCEditorDefine.JENKINS_PIPELINE_GROUP_NAME);

	// 독립 플랫폼
	public static readonly string STANDALONE_ABSOLUTE_BUILD_PATH_FORMAT = string.Format("{0}../Builds/Standalone/{1}", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, "{0}");

	// 맥
	public static readonly GraphicsDeviceType[] MAC_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Metal, GraphicsDeviceType.OpenGLCore
	};

	// 윈도우즈
	public static readonly GraphicsDeviceType[] WINDOWS_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
#if DIRECT_3D_12_ENABLE
		GraphicsDeviceType.Direct3D12, 
#endif			// #if DIRECT_3D_12_ENABLE
		
		GraphicsDeviceType.Direct3D11
	};

	// iOS {
	public static readonly string IOS_ABSOLUTE_BUILD_PATH = string.Format("{0}../Builds/iOS", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string IOS_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/iOS/Classes/Plugin/", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string IOS_DEST_PLUGIN_PATH = string.Format("{0}Plugins/iOS/CustomiOSPlugin/", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly GraphicsDeviceType[] IOS_DEVICE_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Metal
	};

	public static readonly GraphicsDeviceType[] IOS_SIMULATOR_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.OpenGLES2
	};
	// iOS }

	// 안드로이드 {
	public static readonly string ANDROID_ABSOLUTE_BUILD_PATH_FORMAT = string.Format("{0}../Builds/Android/{1}", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS, "{0}");

	public static readonly string ANDROID_SRC_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/plugin/build/intermediates/packaged-classes/release/classes.jar", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string ANDROID_DEST_PLUGIN_PATH = string.Format("{0}Plugins/Android/libs/CustomAndroidPlugin.jar", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string ANDROID_SRC_MANIFEST_PATH = string.Format("{0}../Packages/Builds/Options/Android/AndroidManifest.xml", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string ANDROID_DEST_MANIFEST_PATH = string.Format("{0}Plugins/Android/AndroidManifest.xml", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string ANDROID_SRC_MAIN_TEMPLATE_PATH = string.Format("{0}../Packages/Builds/Options/Android/mainTemplate.gradle", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string ANDROID_DEST_MAIN_TEMPLATE_PATH = string.Format("{0}Plugins/Android/mainTemplate.gradle", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string ANDROID_SRC_PROGUARD_PATH = string.Format("{0}../Packages/Builds/Options/Android/proguard-user.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);
	public static readonly string ANDROID_DEST_PROGUARD_PATH = string.Format("{0}Plugins/Android/proguard-user.txt", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly string ANDROID_SRC_UNITY_PLUGIN_PATH = string.Format("{0}../PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar", KCEditorDefine.ABSOLUTE_DIR_PATH_UNITY_ENGINE);
	public static readonly string ANDROID_DEST_UNITY_PLUGIN_PATH = string.Format("{0}../PluginProjects/Android/plugin/libs/classes.jar", KCEditorDefine.ABSOLUTE_DIR_PATH_ASSETS);

	public static readonly GraphicsDeviceType[] ANDROID_GRAPHICS_DEVICE_TYPES = new GraphicsDeviceType[] {
		GraphicsDeviceType.Vulkan, GraphicsDeviceType.OpenGLES3, GraphicsDeviceType.OpenGLES2
	};
	// 안드로이드 }
	#endregion			// 런타임 상수

	#region 조건부 상수
#if UNITY_IOS
	// 경로
	public const string PATH_CAPABILITY_ENTITLEMENTS_IOS = "Capabilities.entitlements";
#endif			// #if UNITY_IOS

#if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	// 크기
	public const int FONT_SIZE_STATIC_TEXT = 24;
	public const int FONT_SIZE_DYNAMIC_TEXT = 24;

	// 이름
	public const string OBJ_NAME_STATIC_TEXT = "StaticInfoText";
	public const string OBJ_NAME_DYNAMIC_TEXT = "DynamicInfoText";
#endif			// #if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)

#if FILE_BROWSER_ENABLE
	// 비율
	public const float SCALE_FILE_BROWSER_WINDOW = 1.25f;

	// 이름
	public const string OBJ_NAME_FILE_BROWSER_WINDOW = "SimpleFileBrowserWindow";

	// 경로
	public const string OBJ_PATH_FILE_BROWSER_UI = "SimpleFileBrowserCanvas";
#endif			// #if FILE_BROWSER_ENABLE
	#endregion			// 조건부 상수

	#region 조건부 런타임 상수
#if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	// 위치
	public static readonly Vector2 POSITION_STATIC_TEXT = new Vector2(-10.0f, 0.0f);
	public static readonly Vector2 POSITION_DYNAMIC_TEXT = new Vector2(-10.0f, 140.0f);
#endif			// #if FPS_ENABLE || (DEBUG || DEVELOPMENT_BUILD)
	#endregion			// 조건부 런타임 상수
}
