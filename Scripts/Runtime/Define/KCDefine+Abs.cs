using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

//! 기본 상수
public static partial class KCDefine {
	#region 기본
	// 유닛 {
	public const int B_UNIT_SEC_TO_MILLISEC = 1000;
	public const int B_UNIT_NORM_VALUE_TO_BYTE = 255;

	public const float B_UNIT_BYTE_TO_KILO_BYTE = 1024.0f;
	public const float B_UNIT_BYTE_TO_MEGA_BYTE = 1024.0f * 1024.0f;

	public const float B_UNIT_SCALE = 0.01f;
	public const float B_REF_PIXELS_UNIT = 1.0f;
	// 유닛 }

	// 값 {
	public const int B_VALUE_INT_0 = 0;
	public const int B_VALUE_INT_1 = 1;

	public const long B_VALUE_LONG_0 = 0L;
	public const long B_VALUE_LONG_1 = 1L;
	
	public const float B_VALUE_FLOAT_0 = 0.0f;
	public const float B_VALUE_FLOAT_1 = 1.0f;

	public const double B_VALUE_DOUBLE_0 = 0.0;
	public const double B_VALUE_DOUBLE_1 = 1.0;
	// 값 }

	// 인덱스
	public const int B_INDEX_INVALID = -1;

	// 빌드 번호
	public const int B_MIN_BUILD_NUMBER = 1;

	// 비교 결과
	public const int B_COMPARE_RESULT_LESS = -1;
	public const int B_COMPARE_RESULT_EQUALS = 0;
	public const int B_COMPARE_RESULT_GREATE = 1;

	// 개수
	public const int B_MAX_NUM_BACKUP_FILES = 50;

	// 횟수
	public const int B_TIMES_INT_ONCE = 1;
	public const int B_TIMES_INT_INFINITE = -1;

	public const uint B_TIMES_UINT_ONCE = 1;
	public const uint B_TIMES_UINT_INFINITE = uint.MaxValue;

	// 시간 {
	public const float B_DELTA_TIME_INFINITE = float.MaxValue;
	public const float B_DELTA_TIME_INTERMEDIATE = float.Epsilon;
	public const float B_DELTA_TIME_ASYNC_OPERATION = 0.25f;

	public const double B_DELTA_TIME_UTC_TO_PST = -8.0;
	// 시간 }

	// 플래그 {
	public const BindingFlags B_BINDING_FLAG_PUBLIC_INSTANCE = BindingFlags.Public | BindingFlags.Instance;

	public const BindingFlags B_BINDING_FLAG_PUBLIC_STATIC = BindingFlags.Public | BindingFlags.Static;
	public const BindingFlags B_BINDING_FLAG_NON_PUBLIC_STATIC = BindingFlags.NonPublic | BindingFlags.Static;
	// 플래그 }

	// 디바이스 {
#if MODE_PORTRAIT_ENABLE
	public const int B_SCREEN_WIDTH = 720;
	public const int B_SCREEN_HEIGHT = 1280;
#else
	public const int B_SCREEN_WIDTH = 1280;
	public const int B_SCREEN_HEIGHT = 720;
#endif			// #if MODE_PORTRAIT_ENABLE

	public const int B_DEF_TARGET_FRAME_RATE = 30;

	public const float B_DEF_DPI = 160.0f;
	public const float B_EDITOR_DPI = 320.0f;
	public const float B_DEF_FIXED_DELTA_TIME = 0.02f;

	public const float B_WORLD_SCREEN_WIDTH = KCDefine.B_SCREEN_WIDTH * KCDefine.B_UNIT_SCALE;
	public const float B_WORLD_SCREEN_HEIGHT = KCDefine.B_SCREEN_HEIGHT * KCDefine.B_UNIT_SCALE;
	
	public const string B_EMPTY_STRING = "";
	public const string B_UNKNOWN_STRING = "Unknown";
	public const string B_NEW_LINE_STRING = "\n";

	public const string B_STRING_INT_0 = "0";
	public const string B_STRING_INT_1 = "1";

	public const string B_STRING_FLOAT_0 = "0.0";
	public const string B_STRING_FLOAT_1 = "1.0";

	public const string B_UNKNOWN_LANGUAGE = KCDefine.B_UNKNOWN_STRING;
	public const string B_UNKNOWN_ERROR_MSG = KCDefine.B_UNKNOWN_STRING;
	public const string B_UNKNOWN_DEVICE_ID = KCDefine.B_UNKNOWN_STRING;

	public const string B_VERSION_STRING_FORMAT = "Ver.{0}";
	// 디바이스 }

	// 국가 코드
	public const string B_KOREA_COUNTRY_CODE = "KR";
	public const string B_UNKNOWN_COUNTRY_CODE = "Unknown";

	// 플랫폼 {
	public const string B_PLATFORM_MAC = "Mac";
	public const string B_PLATFORM_WINDOWS = "Windows";

	public const string B_PLATFORM_IOS = "iOS";
	public const string B_PLATFORM_ANDROID = "Android";

	public const string B_PLATFORM_GOOGLE = "Google";
	public const string B_PLATFORM_ONE_STORE = "OneStore";
	public const string B_PLATFORM_GALAXY_STORE = "GalaxyStore";
	// 플랫폼 }

	// 이름
	public const string B_DIR_NAME_BACKUP = "Backup";

	// 씬 이름 {
	public const string B_SCENE_NAME_SAMPLE = "00.SampleScene";

	public const string B_SCENE_NAME_INIT = "00.InitScene";
	public const string B_SCENE_NAME_SETUP = "01.SetupScene";
	public const string B_SCENE_NAME_AGREE = "01.AgreeScene";
	public const string B_SCENE_NAME_LATE_SETUP = "01.LateSetupScene";
	
	public const string B_SCENE_NAME_START = "01.StartScene";
	public const string B_SCENE_NAME_SPLASH = "01.SplashScene";
	public const string B_SCENE_NAME_PERMISSION = "01.PermissionScene";
	public const string B_SCENE_NAME_LOADING = "01.LoadingScene";
	public const string B_SCENE_NAME_INTRO = "01.IntroScene";
	public const string B_SCENE_NAME_MENU = "01.MenuScene";
	// 씬 이름 }

	// 키
	public const string B_KEY_JSON_ROOT_DATA = "Root";

	// 토큰
	public const string B_TOKEN_CSV_STRING = ",";
	public const string B_TOKEN_POST_STRING = "&";
	public const string B_TOKEN_VERSION_NUMBER = ".";

	// 빌드 모드
	public const string B_BUILD_MODE_DEBUG = "Debug";
	public const string B_BUILD_MODE_RELEASE = "Release";

	// 명령어 {
	public const string B_CMD_INIT = "Init";

	public const string B_CMD_GET_DEVICE_ID = "GetDeviceID";
	public const string B_CMD_GET_COUNTRY_CODE = "GetCountryCode";
	public const string B_CMD_GET_STORE_VERSION = "GetStoreVersion";

	public const string B_CMD_SHOW_ALERT = "ShowAlert";
	public const string B_CMD_SHOW_TOAST = "ShowToast";

	public const string B_CMD_VIBRATE = "Vibrate";
	public const string B_CMD_TRACKING = "Tracking";
	public const string B_CMD_INDICATOR = "Indicator";

	public const string B_CMD_INIT_ADS = "InitAds";
	public const string B_CMD_LOAD_RESUME_ADS = "LoadResumeAds";
	public const string B_CMD_SHOW_RESUME_ADS = "ShowResumeAds";
	// 명령어 }

	// 경로 {
	public const string B_DIR_PATH_ICONS = "Icons/";
	public const string B_DIR_PATH_FONTS = "Fonts/";
	public const string B_DIR_PATH_DATAS = "Datas/";
	public const string B_DIR_PATH_IMAGES = "Images/";
	public const string B_DIR_PATH_SOUNDS = "Sounds/";
	public const string B_DIR_PATH_TABLES = "Tables/";
	public const string B_DIR_PATH_PREFABS = "Prefabs/";
	public const string B_DIR_PATH_TEXTURES = "Textures/";
	public const string B_DIR_PATH_MATERIALS = "Materials/";
	public const string B_DIR_PATH_PIPELINES = "Pipelines/";
	public const string B_DIR_PATH_SCRIPTABLES = "Scriptables/";
	public const string B_DIR_PATH_SPRITE_ATLASES = "SpriteAtlases/";
	public const string B_DIR_PATH_SETTINGS = "Settings/";

	public const string B_DIR_PATH_GLOBAL = "Global/";
	public const string B_DIR_PATH_UTILITY = "Utility/";
	public const string B_DIR_PATH_TUTORIAL = "Tutorial/";
	public const string B_DIR_PATH_INIT_SCENE = "InitScene/";
	public const string B_DIR_PATH_SETUP_SCENE = "SetupScene/";
	public const string B_DIR_PATH_START_SCENE = "StartScene/";
	public const string B_DIR_PATH_LOADING_SCENE = "LoadingScene/";
	public const string B_DIR_PATH_SPLASH_SCENE = "SplashScene/";
	public const string B_DIR_PATH_AGREE_SCENE = "AgreeScene/";
	public const string B_DIR_PATH_INTRO_SCENE = "IntroScene/";

	public const string B_DIR_PATH_TEXT_ROOT = "Text/";
	public const string B_DIR_PATH_IMAGE_ROOT = "Image/";
	public const string B_DIR_PATH_BUTTON_ROOT = "Button/";
	public const string B_DIR_PATH_SCROLL_VIEW_ROOT = "ScrollView/";
	public const string B_DIR_PATH_POPUP_ROOT = "Popup/";
	public const string B_DIR_PATH_RESPONDER_ROOT = "Responder/";
	public const string B_DIR_PATH_SOUND_ROOT = "Sound/";
	public const string B_DIR_PATH_EXTERNAL_ROOT = "External/";
	public const string B_DIR_PATH_STRING_INFO_ROOT = "StringInfo/";
	public const string B_DIR_PATH_VALUE_INFO_ROOT = "ValueInfo/";
	// 경로 }

	// 형식 {
	public const string B_SIZE_FORMAT_STRING = "<size={0}>{1}</size>";
	public const string B_COLOR_FORMAT_STRING = "<color=#{0}>{1}</color>";
	public const string B_DICTIONARY_FORMAT_STRING = "[{0}]{1}";

	public const string B_NAME_FORMAT_BACKUP = "yyyy_MM_dd HH_mm_ss";
	public const string B_FILE_NAME_FORMAT_BACKUP = "{0} ({1})";
	public const string B_FILE_NAME_FORMAT_LOCALIZE = "{0}_{1}";

	public const string B_DATE_TIME_FORMAT_YYYY_MM_DD = "yyyyMMdd";
	public const string B_DATE_TIME_FORMAT_YYYY_MM_DD_HH_MM_SS = "yyyyMMdd HH:mm:ss";
	// 형식 }

	// URL
	public const string B_MAIL_URL_FORMAT = "mailto:{0}?subject={1}&body={2}";
	public const string B_MAIL_URL_MSG_FORMAT = "Platform: {0}\nProcessor: {1}\nGraphics: {2} [{3}]\nOS: {4}\n\nPlease enter your inquiry: \n{5}";
	#endregion			// 기본

	#region 런타임 상수
	// 디바이스 {
#if MODE_PORTRAIT_ENABLE
	public static readonly int B_DESKTOP_WINDOW_WIDTH = (int)((Screen.currentResolution.height * 0.9f) * (KCDefine.B_SCREEN_WIDTH / (float)KCDefine.B_SCREEN_HEIGHT));
	public static readonly int B_DESKTOP_WINDOW_HEIGHT = (int)(Screen.currentResolution.height * 0.9f);
#else
	public static readonly int B_DESKTOP_WINDOW_WIDTH = (int)(Screen.currentResolution.width * 0.9f);
	public static readonly int B_DESKTOP_WINDOW_HEIGHT = (int)((Screen.currentResolution.width * 0.9f) * (KCDefine.B_SCREEN_HEIGHT / (float)KCDefine.B_SCREEN_WIDTH));
#endif			// #if MODE_PORTRAIT_ENABLE

	public static readonly Vector2 B_SCREEN_SIZE = new Vector2(KCDefine.B_SCREEN_WIDTH, KCDefine.B_SCREEN_HEIGHT);
	public static readonly Vector2 B_WORLD_SCREEN_SIZE = new Vector2(KCDefine.B_WORLD_SCREEN_WIDTH, KCDefine.B_WORLD_SCREEN_HEIGHT);
	// 디바이스 }

	// 색상 {
	public static readonly Color B_LOG_COLOR_WARNING = new Color(0xff / 255.0f, 0xa5 / 255.0f, 0.0f, 1.0f);
	public static readonly Color B_LOG_COLOR_ERROR = Color.red;

	public static readonly Color B_LOG_COLOR_SETUP = Color.magenta;
	public static readonly Color B_LOG_COLOR_PLUGIN = Color.yellow;
	public static readonly Color B_LOG_COLOR_PLATFORM_INFO = Color.red;
	// 색상 }

	// 앵커 {
	public static readonly Vector2 B_ANCHOR_TOP_LEFT = new Vector2(0.0f, 1.0f);
	public static readonly Vector2 B_ANCHOR_TOP_CENTER = new Vector2(0.5f, 1.0f);
	public static readonly Vector2 B_ANCHOR_TOP_RIGHT = new Vector2(1.0f, 1.0f);

	public static readonly Vector2 B_ANCHOR_MIDDLE_LEFT = new Vector2(0.0f, 0.5f);
	public static readonly Vector2 B_ANCHOR_MIDDLE_CENTER = new Vector2(0.5f, 0.5f);
	public static readonly Vector2 B_ANCHOR_MIDDLE_RIGHT = new Vector2(1.0f, 0.5f);

	public static readonly Vector2 B_ANCHOR_BOTTOM_LEFT = new Vector2(0.0f, 0.0f);
	public static readonly Vector2 B_ANCHOR_BOTTOM_CENTER = new Vector2(0.5f, 0.0f);
	public static readonly Vector2 B_ANCHOR_BOTTOM_RIGHT = new Vector2(1.0f, 0.0f);
	// 앵커 }

	// 비율
	public static readonly Vector3 B_SCALE_NORM = new Vector3(1.0f, 1.0f, 1.0f);

	// 위치 {
	public static readonly Vector3 B_POS_TOP_LEFT = new Vector3(0.0f, KCDefine.B_SCREEN_HEIGHT, 0.0f);
	public static readonly Vector3 B_POS_TOP_CENTER = new Vector3(KCDefine.B_SCREEN_WIDTH / 2.0f, KCDefine.B_SCREEN_HEIGHT, 0.0f);
	public static readonly Vector3 B_POS_TOP_RIGHT = new Vector3(KCDefine.B_SCREEN_WIDTH, KCDefine.B_SCREEN_HEIGHT, 0.0f);
	
	public static readonly Vector3 B_POS_MIDDLE_LEFT = new Vector3(0.0f, KCDefine.B_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 B_POS_MIDDLE_CENTER = new Vector3(KCDefine.B_SCREEN_WIDTH / 2.0f, KCDefine.B_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 B_POS_MIDDLE_RIGHT = new Vector3(KCDefine.B_SCREEN_WIDTH, KCDefine.B_SCREEN_HEIGHT / 2.0f, 0.0f);

	public static readonly Vector3 B_POS_BOTTOM_LEFT = Vector3.zero;
	public static readonly Vector3 B_POS_BOTTOM_CENTER = new Vector3(KCDefine.B_SCREEN_WIDTH / 2.0f, 0.0f, 0.0f);
	public static readonly Vector3 B_POS_BOTTOM_RIGHT = new Vector3(KCDefine.B_SCREEN_WIDTH, 0.0f, 0.0f);
	// 위치 }

	// 월드 위치 {
	public static readonly Vector3 B_WORLD_POS_TOP_LEFT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / -2.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 B_WORLD_POS_TOP_CENTER = new Vector3(0.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 B_WORLD_POS_TOP_RIGHT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / 2.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);

	public static readonly Vector3 B_WORLD_POS_MIDDLE_LEFT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / -2.0f, 0.0f, 0.0f);
	public static readonly Vector3 B_WORLD_POS_MIDDLE_CENTER = Vector3.zero;
	public static readonly Vector3 B_WORLD_POS_MIDDLE_RIGHT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / 2.0f, 0.0f, 0.0f);

	public static readonly Vector3 B_WORLD_POS_BOTTOM_LEFT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / -2.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	public static readonly Vector3 B_WORLD_POS_BOTTOM_CENTER = new Vector3(0.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	public static readonly Vector3 B_WORLD_POS_BOTTOM_RIGHT = new Vector3(KCDefine.B_WORLD_SCREEN_WIDTH / 2.0f, KCDefine.B_WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	// 월드 위치 }

	// 국가 코드
	public static readonly string[] B_EU_COUNTRY_CODES = new string[] {
		"BE", "BG", "CZ", "DK", "DE", "EE", "IE", 
		"GR", "ES", "FR", "HR", "IT", "CY", "LV", 
		"LT", "LU", "HU", "MT", "NL", "AT", "PL", 
		"PT", "RO", "SI", "SK", "FI", "SE"
	};

	// 경로 {
	public static readonly string B_DIR_PATH_WRITABLE = string.Format("{0}/{1}/", Application.persistentDataPath, Application.identifier);
	
	public static readonly string B_DATA_PATH_LOG = string.Format("{0}Log.txt", KCDefine.B_DIR_PATH_WRITABLE);
	public static readonly string B_DATA_PATH_COMMON_APP_INFO = string.Format("{0}CommonAppInfo.bytes", KCDefine.B_DIR_PATH_WRITABLE);
	public static readonly string B_DATA_PATH_COMMON_USER_INFO = string.Format("{0}CommonUserInfo.bytes", KCDefine.B_DIR_PATH_WRITABLE);
	// 경로 }
	#endregion			// 런타임 상수
}
