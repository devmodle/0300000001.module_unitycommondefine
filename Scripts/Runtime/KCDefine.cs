using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

//! 기본 상수
public static partial class KCDefine {
	#region 기본
	// 인덱스
	public const int INDEX_INVALID = -1;

	// 비교 결과
	public const int COMPARE_RESULT_LESS = -1;
	public const int COMPARE_RESULT_EQUALS = 0;
	public const int COMPARE_RESULT_GREATE = 1;

	// 개수
	public const int MAX_NUM_BACKUP_FILES = 50;

	// 횟수
	public const int TIMES_INT_INFINITE = -1;
	public const uint TIMES_UINT_INFINITE = uint.MaxValue;

	// 시간 {
	public const float DELTA_TIME_ASYNC_OPERATION = 0.15f;
	public const float DELTA_TIME_INTERMEDIATE = float.Epsilon;

	public const double DELTA_TIME_UTC_TO_PST = -8.0;
	// 시간 }

	// 플래그
	public const BindingFlags BINDING_FLAG_PUBLIC_INSTANCE = BindingFlags.Public | BindingFlags.Instance;
	public const BindingFlags BINDING_FLAG_NON_PUBLIC_STATIC = BindingFlags.NonPublic | BindingFlags.Static;

	// 디바이스 {
#if PORTRAIT_ENABLE
	public const int SCREEN_WIDTH = 720;
	public const int SCREEN_HEIGHT = 1280;
#else
	public const int SCREEN_WIDTH = 1280;
	public const int SCREEN_HEIGHT = 720;
#endif			// #if PORTRAIT_ENABLE

	public const float UNIT_SCALE = 0.01f;
	public const float REF_PIXELS_UNIT = 1.0f;
	public const float DEF_FIXED_DELTA_TIME = 0.02f;

	public const float WORLD_SCREEN_WIDTH = KCDefine.SCREEN_WIDTH * KCDefine.UNIT_SCALE;
	public const float WORLD_SCREEN_HEIGHT = KCDefine.SCREEN_HEIGHT * KCDefine.UNIT_SCALE;
	
	public const string EMPTY_STRING = "";
	public const string UNKNOWN_ERROR_MSG = "Unknown";
	public const string UNKNOWN_DEVICE_ID = "Unknown";
	public const string VERSION_STRING_FORMAT = "Ver.{0}";
	// 디바이스 }

	// 국가 코드
	public const string KOREA_COUNTRY_CODE = "KR";
	public const string UNKNOWN_COUNTRY_CODE = "Unknown";

	// 이름 {
	public const string DIR_NAME_BACKUP = "Backup";

	public const string PLATFORM_NAME_MAC = "Mac";
	public const string PLATFORM_NAME_WINDOWS = "Windows";

	public const string PLATFORM_NAME_IOS = "iOS";

	public const string PLATFORM_NAME_GOOGLE = "Google";
	public const string PLATFORM_NAME_ONE_STORE = "OneStore";
	public const string PLATFORM_NAME_GALAXY_STORE = "GalaxyStore";
	// 이름 }

	// 씬 이름 {
	public const string SCENE_NAME_SAMPLE = "SampleScene";

	public const string B_SCENE_NAME_INIT = "00.InitScene";
	public const string B_SCENE_NAME_SETUP = "00.SetupScene";
	public const string B_SCENE_NAME_START = "01.StartScene";
	public const string B_SCENE_NAME_LOADING = "01.LoadingScene";
	public const string B_SCENE_NAME_SPLASH = "01.SplashScene";
	public const string B_SCENE_NAME_AGREE = "01.AgreeScene";
	public const string B_SCENE_NAME_INTRO = "01.IntroScene";
	// 씬 이름 }

	// 키
	public const string KEY_JSON_ROOT_DATA = "Root";

	// 토큰
	public const string TOKEN_CSV_STRING = ",";
	public const string TOKEN_POST_STRING = "&";
	public const string TOKEN_VERSION_NUMBER = ".";

	// 빌드 모드
	public const string BUILD_MODE_DEBUG = "Debug";
	public const string BUILD_MODE_RELEASE = "Release";

	// 명령어
	public const string CMD_GET_DEVICE_ID = "GetDeviceID";
	public const string CMD_GET_COUNTRY_CODE = "GetCountryCode";
	public const string CMD_GET_SYSTEM_VERSION = "GetSystemVersion";
	public const string CMD_GET_STORE_VERSION = "GetStoreVersion";
	public const string CMD_SET_BUILD_MODE = "SetBuildMode";
	public const string CMD_SHOW_ALERT = "ShowAlert";
	public const string CMD_SHOW_TOAST = "ShowToast";
	public const string CMD_VIBRATE = "Vibrate";
	public const string CMD_ACTIVITY_INDICATOR = "ActivityIndicator";

	// 경로 {
	public const string DIR_PATH_FONTS = "Fonts/";
	public const string DIR_PATH_DATAS = "Datas/";
	public const string DIR_PATH_IMAGES = "Images/";
	public const string DIR_PATH_SOUNDS = "Sounds/";
	public const string DIR_PATH_TABLES = "Tables/";
	public const string DIR_PATH_PREFABS = "Prefabs/";
	public const string DIR_PATH_TEXTURES = "Textures/";
	public const string DIR_PATH_MATERIALS = "Materials/";
	public const string DIR_PATH_PIPELINES = "Pipelines/";
	public const string DIR_PATH_SCRIPTABLES = "Scriptables/";
	public const string DIR_PATH_SPRITE_ATLASES = "SpriteAtlases/";

	public const string DIR_PATH_GLOBAL_BASE = "Global/";
	public const string DIR_PATH_UTILITY_BASE = "Utility/";
	public const string DIR_PATH_TUTORIAL_BASE = "Tutorial/";
	public const string DIR_PATH_INIT_SCENE_BASE = "InitScene/";
	public const string DIR_PATH_SETUP_SCENE_BASE = "SetupScene/";
	public const string DIR_PATH_LOADING_SCENE_BASE = "LoadingScene/";
	public const string DIR_PATH_SPLASH_SCENE_BASE = "SplashScene/";
	public const string DIR_PATH_AGREE_SCENE_BASE = "AgreeScene/";
	public const string DIR_PATH_INTRO_SCENE_BASE = "IntroScene/";

	public const string DIR_PATH_TEXT_BASE = "Text/";
	public const string DIR_PATH_IMAGE_BASE = "Image/";
	public const string DIR_PATH_BUTTON_BASE = "Button/";
	public const string DIR_PATH_SCROLL_VIEW_BASE = "ScrollView/";
	public const string DIR_PATH_POPUP_BASE = "Popup/";
	public const string DIR_PATH_RESPONDER_BASE = "Responder/";
	public const string DIR_PATH_SOUND_BASE = "Sound/";
	public const string DIR_PATH_STRING_INFO_BASE = "StringInfo/";
	public const string DIR_PATH_VALUE_INFO_BASE = "ValueInfo/";
	// 경로 }

	// 형식 {
	public const string SIZE_FORMAT_STRING = "<size={0}>{1}</size>";
	public const string COLOR_FORMAT_STRING = "<color=#{0}>{1}</color>";
	public const string DICTIONARY_FORMAT_STRING = "[{0}]{1}";

	public const string NAME_FORMAT_BACKUP = "yyyy_MM_dd HH_mm_ss";
	public const string FILENAME_FORMAT_BACKUP = "{0} ({1})";

	public const string DATE_TIME_FORMAT_YYYY_MM_DD = "yyyyMMdd";
	public const string DATE_TIME_FORMAT_YYYY_MM_DD_HH_MM_SS = "yyyyMMdd HH:mm:ss";
	// 형식 }

	// URL
	public const string MAIL_URL_FORMAT = "mailto:{0}?subject={1}&body={2}";
	#endregion			// 기본

	#region 런타임 상수
	// 디바이스 {
#if PORTRAIT_ENABLE
	public static readonly int DESKTOP_WINDOW_WIDTH = (int)((Screen.currentResolution.height * 0.9f) * (KCDefine.SCREEN_WIDTH / (float)KCDefine.SCREEN_HEIGHT));
	public static readonly int DESKTOP_WINDOW_HEIGHT = (int)(Screen.currentResolution.height * 0.9f);
#else
	public static readonly int DESKTOP_WINDOW_WIDTH = (int)(Screen.currentResolution.width * 0.9f);
	public static readonly int DESKTOP_WINDOW_HEIGHT = (int)((Screen.currentResolution.width * 0.9f) * (KCDefine.SCREEN_HEIGHT / (float)KCDefine.SCREEN_WIDTH));
#endif			// #if PORTRAIT_ENABLE

	public static readonly Vector2 SCREEN_SIZE = new Vector2(KCDefine.SCREEN_WIDTH, KCDefine.SCREEN_HEIGHT);
	public static readonly Vector2 WORLD_SCREEN_SIZE = new Vector2(KCDefine.WORLD_SCREEN_WIDTH, KCDefine.WORLD_SCREEN_HEIGHT);
	// 디바이스 }

	// 색상 {
	public static readonly Color LOG_COLOR_INFO = Color.black;
	public static readonly Color LOG_COLOR_WARNING = new Color(0xff / 255.0f, 0xa5 / 255.0f, 0.0f, 1.0f);
	public static readonly Color LOG_COLOR_ERROR = Color.red;

	public static readonly Color LOG_COLOR_SETUP = Color.blue;
	public static readonly Color LOG_COLOR_PLUGIN = Color.yellow;
	public static readonly Color LOG_COLOR_PLATFORM_INFO = Color.red;
	// 색상 }

	// 앵커 {
	public static readonly Vector2 ANCHOR_TOP_LEFT = new Vector2(0.0f, 1.0f);
	public static readonly Vector2 ANCHOR_TOP_CENTER = new Vector2(0.5f, 1.0f);
	public static readonly Vector2 ANCHOR_TOP_RIGHT = new Vector2(1.0f, 1.0f);

	public static readonly Vector2 ANCHOR_MIDDLE_LEFT = new Vector2(0.0f, 0.5f);
	public static readonly Vector2 ANCHOR_MIDDLE_CENTER = new Vector2(0.5f, 0.5f);
	public static readonly Vector2 ANCHOR_MIDDLE_RIGHT = new Vector2(1.0f, 0.5f);

	public static readonly Vector2 ANCHOR_BOTTOM_LEFT = new Vector2(0.0f, 0.0f);
	public static readonly Vector2 ANCHOR_BOTTOM_CENTER = new Vector2(0.5f, 0.0f);
	public static readonly Vector2 ANCHOR_BOTTOM_RIGHT = new Vector2(1.0f, 0.0f);
	// 앵커 }

	// 비율
	public static readonly Vector3 SCALE_NORMAL = new Vector3(1.0f, 1.0f, 1.0f);

	// 위치 {
	public static readonly Vector3 POS_TOP_LEFT = new Vector3(0.0f, KCDefine.SCREEN_HEIGHT, 0.0f);
	public static readonly Vector3 POS_TOP_CENTER = new Vector3(KCDefine.SCREEN_WIDTH / 2.0f, KCDefine.SCREEN_HEIGHT, 0.0f);
	public static readonly Vector3 POS_TOP_RIGHT = new Vector3(KCDefine.SCREEN_WIDTH, KCDefine.SCREEN_HEIGHT, 0.0f);
	
	public static readonly Vector3 POS_MIDDLE_LEFT = new Vector3(0.0f, KCDefine.SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 POS_MIDDLE_CENTER = new Vector3(KCDefine.SCREEN_WIDTH / 2.0f, KCDefine.SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 POS_MIDDLE_RIGHT = new Vector3(KCDefine.SCREEN_WIDTH, KCDefine.SCREEN_HEIGHT / 2.0f, 0.0f);

	public static readonly Vector3 POS_BOTTOM_LEFT = Vector3.zero;
	public static readonly Vector3 POS_BOTTOM_CENTER = new Vector3(KCDefine.SCREEN_WIDTH / 2.0f, 0.0f, 0.0f);
	public static readonly Vector3 POS_BOTTOM_RIGHT = new Vector3(KCDefine.SCREEN_WIDTH, 0.0f, 0.0f);
	// 위치 }

	// 월드 위치 {
	public static readonly Vector3 WORLD_POS_TOP_LEFT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / -2.0f, KCDefine.WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 WORLD_POS_TOP_CENTER = new Vector3(0.0f, KCDefine.WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);
	public static readonly Vector3 WORLD_POS_TOP_RIGHT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / 2.0f, KCDefine.WORLD_SCREEN_HEIGHT / 2.0f, 0.0f);

	public static readonly Vector3 WORLD_POS_MIDDLE_LEFT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / -2.0f, 0.0f, 0.0f);
	public static readonly Vector3 WORLD_POS_MIDDLE_CENTER = Vector3.zero;
	public static readonly Vector3 WORLD_POS_MIDDLE_RIGHT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / 2.0f, 0.0f, 0.0f);

	public static readonly Vector3 WORLD_POS_BOTTOM_LEFT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / -2.0f, KCDefine.WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	public static readonly Vector3 WORLD_POS_BOTTOM_CENTER = new Vector3(0.0f, KCDefine.WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	public static readonly Vector3 WORLD_POS_BOTTOM_RIGHT = new Vector3(KCDefine.WORLD_SCREEN_WIDTH / 2.0f, KCDefine.WORLD_SCREEN_HEIGHT / -2.0f, 0.0f);
	// 월드 위치 }

	// 국가 코드
	public static readonly string[] EUROPEAN_UNION_COUNTRY_CODES = new string[] {
		"BE", "BG", "CZ", "DK", "DE", "EE", "IE", 
		"EL", "ES", "FR", "HR", "IT", "CY", "LV", 
		"LT", "LU", "HU", "MT", "NL", "AT", "PL", 
		"PT", "RO", "SI", "SK", "FI", "SE"
	};

	// 경로 {
	public static readonly string DIR_PATH_WRITABLE = string.Format("{0}/{1}/", Application.persistentDataPath, Application.identifier);

	public static readonly string DATA_PATH_LOG = string.Format("{0}Log.txt", KCDefine.DIR_PATH_WRITABLE);
	public static readonly string DATA_PATH_APP_INFO = string.Format("{0}AppInfo.bytes", KCDefine.DIR_PATH_WRITABLE);
	public static readonly string DATA_PATH_USER_INFO = string.Format("{0}UserInfo.bytes", KCDefine.DIR_PATH_WRITABLE);
	// 경로 }
	#endregion			// 런타임 상수

	#region 조건부 상수
#if STUDY_MODULE_ENABLE
	// 씬 이름
	public const string B_SCENE_NAME_MENU = "01.MenuScene";
#endif			// #if STUDY_MODULE_ENABLE
	#endregion			// 조건부 상수
}
