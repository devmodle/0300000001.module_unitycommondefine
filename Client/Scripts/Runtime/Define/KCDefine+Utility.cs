using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DG.Tweening;

/** 상수 - 유틸리티 */
public static partial class KCDefine
{
	#region 프로퍼티
	public static string U_DATA_P_COMMON_APP_INFO => $"{KCDefine.B_DIR_P_WRITABLE}CommonAppInfo.bytes";
	public static string U_DATA_P_COMMON_USER_INFO => $"{KCDefine.B_DIR_P_WRITABLE}CommonUserInfo.bytes";
	public static string U_DATA_P_COMMON_GAME_INFO => $"{KCDefine.B_DIR_P_WRITABLE}CommonGameInfo.bytes";

#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
	public static string U_IMG_P_SCREENSHOT => $"{Application.identifier}/Screenshot.png";
#else
	public static string U_IMG_P_SCREENSHOT => $"{KCDefine.B_DIR_P_WRITABLE}Screenshot.png";
#endif // #if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
	#endregion // 프로퍼티

	#region 기본
	// 개수 {
	public const int U_MAX_NUM_LAYERS = 32;
	public const int U_MAX_NUM_FX_SNDS = 15;
	public const int U_MAX_NUM_GOOGLE_SHEET_ROWS = 10000;

	public const int U_MAX_NUM_LEVEL_INFOS = 9999;
	public const int U_MAX_NUM_STAGE_INFOS = 999;
	public const int U_MAX_NUM_CHAPTER_INFOS = 99;
	// 개수 }

	// 크기 {
	public const int U_SIZE_GAME_OBJS_POOL_50 = 50;
	public const int U_SIZE_GAME_OBJS_POOL_150 = 150;
	public const int U_SIZE_GAME_OBJS_POOL_250 = 250;

	public const int U_SIZE_DOTWEEN_ANI = byte.MaxValue;
	public const int U_SIZE_DOTWEEN_SEQUENCE_ANI = sbyte.MaxValue;

	public const int U_DEF_SIZE_FONT = 28;
	public const int U_DEF_MIN_SIZE_FONT = 14;
	public const int U_DEF_MAX_SIZE_FONT = 18;
	// 크기 }

	// 비율 {
	public const float U_SCALE_POPUP = 1.0f;
	public const float U_MIN_SCALE_POPUP = 0.001f;

	public const float U_SCALE_TOUCH = 1.05f;
	public const float U_SCALE_PAGE_SCROLL = 0.35f;
	public const float U_SCALE_INDICATOR_IMG = 0.25f;
	// 비율 }

	// 시간 {
	public const float U_DELAY_DEF = 0.15f;
	public const float U_DELAY_INIT = 0.15f;

	public const float U_DELAY_POPUP_SHOW_ANI = KCDefine.B_DELTA_T_INTERMEDIATE;
	public const float U_MIN_DELAY_FX_SNDS = 0.05f;

	public const float U_DURATION_ANI = 0.15f;
	public const float U_DURATION_POPUP_ANI = 0.15f;

	public const float U_DURATION_LIGHT_VIBRATE = 0.05f;
	public const float U_DURATION_MEDIUM_VIBRATE = 0.1f;
	public const float U_DURATION_HEAVY_VIBRATE = 0.15f;

	public const float U_TIMEOUT_ASYNC_TASK = 30.0f;
	public const float U_TIMEOUT_NETWORK_CONNECTION = 30.0f;

	public const float B_DELTA_T_SCHEDULE_M_CALLBACK = 0.15f;
	// 시간 }

	// 단위 {
	public const float U_INTENSITY_VIBRATE = 1.0f;
	public const float U_DEPTH_MAIN_CAMERA = 0.0f;
	public const float U_MAX_PERCENT_ASYNC_OPERATION = 0.9f;

	public const float U_DISTANCE_CAMERA_FAR_PLANE = 100000.0f * KCDefine.B_UNIT_SCALE;
	public const float U_DISTANCE_CAMERA_NEAR_PLANE = 1.0f * KCDefine.B_UNIT_SCALE;

	public const float U_UNIT_TABLET_INCHES = 6.5f;
	public const float U_UNIT_SCROLL_SENSITIVITY = 250.0f;
	// 단위 }

	// 레이어
	public const int U_LAYER_DEF = 0;
	public const int U_LAYER_TRANSPARENT_FX = 1;
	public const int U_LAYER_IGNORE_RAYCAST = 2;
	public const int U_LAYER_WATER = 4;
	public const int U_LAYER_UIS = 5;
	public const int U_LAYER_CUSTOM = 11;

	// 애니메이션
	public const Ease U_EASE_DEF = Ease.OutQuad;
	public const Ease U_EASE_UNSET = Ease.Unset;
	public const Ease U_EASE_LINEAR = Ease.Linear;

	// 식별자 {
	public const string U_ADS_ID_TEST_DEVICE = "TestDevice";

	public const string U_KEY_IS_RANDOM = "IsRandom";
	public const string U_KEY_IS_OVERLAY = "IsOverlay";
	public const string U_KEY_IS_PROJECTILE = "IsProjectile";
	public const string U_KEY_IS_CLEAR_TARGET = "IsClearTarget";

	public const string U_KEY_DEVICE_CMD = "Cmd";
	public const string U_KEY_DEVICE_MSG = "Msg";

	public const string U_KEY_VER = "Ver";
	public const string U_KEY_NAME = "Name";
	public const string U_KEY_DESC = "Desc";
	public const string U_KEY_RATE = "Rate";
	public const string U_KEY_REPLACE = "Replace";
	public const string U_KEY_RES_PATH = "ResPath";
	public const string U_KEY_REWARD_QUALITY = "RewardQuality";

	public const string U_KEY_NOEX_T = "NOEX_T";
	public const string U_KEY_NOEX_ST = "NOEX_ST";
	public const string U_KEY_NOEX_KT = "NOEX_KT";
	public const string U_KEY_NOEX_SKT = "NOEX_SKT";
	public const string U_KEY_NOEX_DSKT = "NOEX_DSKT";

	public const string U_KEY_FX = "FX";
	public const string U_KEY_CALC = "Calc";
	public const string U_KEY_ORDER = "Order";
	public const string U_KEY_TUTORIAL = "Tutorial";

	public const string U_KEY_LEVEL_EPISODE = "LevelEpisode";
	public const string U_KEY_STAGE_EPISODE = "StageEpisode";
	public const string U_KEY_CHAPTER_EPISODE = "ChapterEpisode";

	public const string U_KEY_ID = "ID";
	public const string U_KEY_PREV_ID = "PrevID";
	public const string U_KEY_NEXT_ID = "NextID";

	public const string U_KEY_SND = "Snd";
	public const string U_KEY_FONT = "Font";
	public const string U_KEY_SIZE = "Size";
	public const string U_KEY_IMG = "Image";
	public const string U_KEY_TEX = "Texture";
	public const string U_KEY_SPRITE = "Sprite";

	public const string U_KEY_PRODUCT_IDX = "ProductIdx";
	public const string U_KEY_MAX_APPLY_TIMES = "MaxApplyTimes";
	public const string U_KEY_NUM_SUB_EPISODES = "NumSubEpisodes";
	public const string U_KEY_MAX_NUM_ENEMY_OBJS = "MaxNumEnemyObjs";

	public const string U_KEY_VAL_INFO = "ValInfo";
	public const string U_KEY_TIME_INFO = "TimeInfo";

	public const string U_KEY_DIFFICULTY = "Difficulty";
	public const string U_KEY_PRODUCT_TYPE = "ProductType";
	public const string U_KEY_PURCHASE_TYPE = "PurchaseType";
	public const string U_KEY_EPISODE_KINDS = "EpisodeKinds";
	public const string U_KEY_ABILITY_VAL_TYPE = "AbilityValType";

	public const string U_KEY_CALC_KINDS = "CalcKinds";
	public const string U_KEY_PREV_CALC_KINDS = "PrevCalcKinds";
	public const string U_KEY_NEXT_CALC_KINDS = "NextCalcKinds";

	public const string U_KEY_REWARD_KINDS = "RewardKinds";
	public const string U_KEY_PREV_REWARD_KINDS = "PrevRewardKinds";
	public const string U_KEY_NEXT_REWARD_KINDS = "NextRewardKinds";

	public const string U_KEY_MISSION_KINDS = "MissionKinds";
	public const string U_KEY_PREV_MISSION_KINDS = "PrevMissionKinds";
	public const string U_KEY_NEXT_MISSION_KINDS = "NextMissionKinds";

	public const string U_KEY_ITEM_KINDS = "ItemKinds";
	public const string U_KEY_PREV_ITEM_KINDS = "PrevItemKinds";
	public const string U_KEY_NEXT_ITEM_KINDS = "NextItemKinds";

	public const string U_KEY_SKILL_KINDS = "SkillKinds";
	public const string U_KEY_PREV_SKILL_KINDS = "PrevSkillKinds";
	public const string U_KEY_NEXT_SKILL_KINDS = "NextSkillKinds";

	public const string U_KEY_FX_APPLY_KINDS = "FXApplyKinds";
	public const string U_KEY_SKILL_APPLY_KINDS = "SkillApplyKinds";
	public const string U_KEY_ACTION_SKILL_KINDS = "ActionSkillKinds";

	public const string U_KEY_OBJ_KINDS = "ObjKinds";
	public const string U_KEY_PREV_OBJ_KINDS = "PrevObjKinds";
	public const string U_KEY_NEXT_OBJ_KINDS = "NextObjKinds";

	public const string U_KEY_FX_KINDS = "FXKinds";
	public const string U_KEY_PREV_FX_KINDS = "PrevFXKinds";
	public const string U_KEY_NEXT_FX_KINDS = "NextFXKinds";

	public const string U_KEY_ABILITY_KINDS = "AbilityKinds";
	public const string U_KEY_PREV_ABILITY_KINDS = "PrevAbilityKinds";
	public const string U_KEY_NEXT_ABILITY_KINDS = "NextAbilityKinds";

	public const string U_KEY_TUTORIAL_KINDS = "TutorialKinds";
	public const string U_KEY_PREV_TUTORIAL_KINDS = "PrevTutorialKinds";
	public const string U_KEY_NEXT_TUTORIAL_KINDS = "NextTutorialKinds";

	public const string U_KEY_RES_KINDS = "ResKinds";
	public const string U_KEY_PREV_RES_KINDS = "PrevResKinds";
	public const string U_KEY_NEXT_RES_KINDS = "NextResKinds";

	public const string U_KEY_PRODUCT_KINDS = "ProductKinds";
	public const string U_KEY_PREV_PRODUCT_KINDS = "PrevProductKinds";
	public const string U_KEY_NEXT_PRODUCT_KINDS = "NextProductKinds";

	public const string U_KEY_FMT_ID = "ID_{0:00}";
	public const string U_KEY_FMT_PREV_ID = "PrevID_{0:00}";
	public const string U_KEY_FMT_NEXT_ID = "NextID_{0:00}";

	public const string U_KEY_FMT_FLAGS = "Flags_{0:00}";
	public const string U_KEY_FMT_PRICE = "Price_{0:00}";

	public const string U_KEY_FMT_RES_KINDS = "ResKinds_{0:00}";
	public const string U_KEY_FMT_REWARD_KINDS = "RewardKinds_{0:00}";

	public const string U_KEY_FMT_GAME_ITEM_KINDS = "GameItemKinds_{0:00}";
	public const string U_KEY_FMT_BOOSTER_ITEM_KINDS = "BoosterItemKinds_{0:00}";

	public const string U_KEY_FMT_MISSION_KINDS = "MissionKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_MISSION_KINDS = "ExtraMissionKinds_{0:00}";

	public const string U_KEY_FMT_ITEM_KINDS = "ItemKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_ITEM_KINDS = "ExtraItemKinds_{0:00}";

	public const string U_KEY_FMT_SKILL_KINDS = "SkillKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_SKILL_KINDS = "ExtraSkillKinds_{0:00}";

	public const string U_KEY_FMT_OBJ_KINDS = "ObjKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_OBJ_KINDS = "ExtraObjKinds_{0:00}";

	public const string U_KEY_FMT_FX_KINDS = "FXKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_FX_KINDS = "ExtraFXKinds_{0:00}";

	public const string U_KEY_FMT_ABILITY_KINDS = "AbilityKinds_{0:00}";
	public const string U_KEY_FMT_EXTRA_ABILITY_KINDS = "ExtraAbilityKinds_{0:00}";

	public const string U_KEY_FMT_STRS = "Str_{0:00}";
	public const string U_KEY_FMT_TUTORIAL_MSG = "TUTORIAL_MSG_{0:00}_{1:00}";
	public const string U_KEY_FMT_RECORD_VAL_INFO = "RecordValInfo_{0:00}";

	public const string U_KEY_FMT_PAY_TARGET_INFO = "PayTargetInfo_{0:00}";
	public const string U_KEY_FMT_ACQUIRE_TARGET_INFO = "AcquireTargetInfo_{0:00}";

	public const string U_KEY_FMT_CLEAR_TARGET_INFO = "ClearTargetInfo_{0:00}";
	public const string U_KEY_FMT_UNLOCK_TARGET_INFO = "UnlockTargetInfo_{0:00}";

	public const string U_KEY_FMT_DROP_ITEM_TARGET_INFO = "DropItemTargetInfo_{0:00}";
	public const string U_KEY_FMT_EQUIP_ITEM_TARGET_INFO = "EquipItemTargetInfo_{0:00}";
	public const string U_KEY_FMT_ATTACH_ITEM_TARGET_INFO = "AttachItemTargetInfo_{0:00}";

	public const string U_KEY_FMT_SKILL_TARGET_INFO = "SkillTargetInfo_{0:00}";
	public const string U_KEY_FMT_PLAYER_OBJ_TARGET_INFO = "PlayerObjTargetInfo_{0:00}";
	public const string U_KEY_FMT_ENEMY_OBJ_TARGET_INFO = "EnemyObjTargetInfo_{0:00}";

	public const string U_KEY_FMT_ABILITY_TARGET_INFO = "AbilityTargetInfo_{0:00}";
	public const string U_KEY_FMT_EXTRA_ABILITY_TARGET_INFO = "ExtraAbilityTargetInfo_{0:00}";

	public const string U_KEY_SERVICES_M_UPDATE_APPLE_LOGIN_STATE_CALLBACK = "ServicesMUpdateAppleLoginStateCallback";
	public const string U_KEY_SERVICES_M_UPDATE_FAIL_APPLE_LOGIN_STATE_CALLBACK = "ServicesMUpdateFailAppleLoginStateCallback";

	public const string U_KEY_SERVICES_M_LOGIN_WITH_APPLE_CALLBACK = "ServicesMLoginWithAppleCallback";
	public const string U_KEY_SERVICES_M_LOGIN_FAIL_WITH_APPLE_CALLBACK = "ServicesMLoginFailWithAppleCallback";
	public const string U_KEY_SERVICES_M_LOGOUT_WITH_APPLE_CALLBACK = "ServicesMLogoutWithAppleCallback";
	// 식별자 }

	// 이름 {
	public const string U_OBJ_N_SCENE_UIS = "UIs";
	public const string U_OBJ_N_SCENE_UIS_BASE = "Canvas";
	public const string U_OBJ_N_SCENE_UIS_ROOT = "UIsRoot";
	public const string U_OBJ_N_SCENE_TEST_UIS = "TestUIs";
	public const string U_OBJ_N_SCENE_PIVOT_UIS = "PivotUIs";
	public const string U_OBJ_N_SCENE_ANCHOR_UIS = "AnchorUIs";
	public const string U_OBJ_N_SCENE_MID_EDITOR_UIS = "MID_EDITOR_UIS";
	public const string U_OBJ_N_SCENE_STRETCH_ANCHOR_UIS = "StretchAnchorUIs";
	public const string U_OBJ_N_SCENE_DESIGN_RESOLUTION_GUIDE_UIS = "DesignResolutionGuideUIs";

	public const string U_OBJ_N_SCENE_UP_UIS = "UpUIs";
	public const string U_OBJ_N_SCENE_DOWN_UIS = "DownUIs";
	public const string U_OBJ_N_SCENE_LEFT_UIS = "LeftUIs";
	public const string U_OBJ_N_SCENE_RIGHT_UIS = "RightUIs";

	public const string U_OBJ_N_SCENE_STRETCH_UP_UIS = "StretchUpUIs";
	public const string U_OBJ_N_SCENE_STRETCH_DOWN_UIS = "StretchDownUIs";
	public const string U_OBJ_N_SCENE_STRETCH_LEFT_UIS = "StretchLeftUIs";
	public const string U_OBJ_N_SCENE_STRETCH_RIGHT_UIS = "StretchRightUIs";

	public const string U_OBJ_N_SCENE_POPUP_UIS = "PopupUIs";
	public const string U_OBJ_N_SCENE_TOPMOST_UIS = "TopmostUIs";
	public const string U_OBJ_N_SCENE_ABS_UIS = "AbsUIs";

	public const string U_OBJ_N_SCENE_BASE = "Base";
	public const string U_OBJ_N_SCENE_OBJS = "Objs";
	public const string U_OBJ_N_SCENE_OBJS_ROOT = "ObjsRoot";
	public const string U_OBJ_N_SCENE_PIVOT_OBJS = "PivotObjs";
	public const string U_OBJ_N_SCENE_ANCHOR_OBJS = "AnchorObjs";
	public const string U_OBJ_N_SCENE_STATIC_OBJS = "StaticObjs";

	public const string U_OBJ_N_SCENE_EVENT_SYSTEM = "EventSystem";
	public const string U_OBJ_N_SCENE_ADDITIONAL_LIGHTS = "AdditionalLights";
	public const string U_OBJ_N_SCENE_ADDITIONAL_CAMERAS = "AdditionalCameras";
	public const string U_OBJ_N_SCENE_REFLECTION_PROBES = "ReflectionProbes";
	public const string U_OBJ_N_SCENE_LIGHT_PROBE_GROUPS = "LightProbeGroups";

	public const string U_OBJ_N_SCENE_UP_OBJS = "UpObjs";
	public const string U_OBJ_N_SCENE_DOWN_OBJS = "DownObjs";
	public const string U_OBJ_N_SCENE_LEFT_OBJS = "LeftObjs";
	public const string U_OBJ_N_SCENE_RIGHT_OBJS = "RightObjs";

	public const string U_OBJ_N_SCENE_MAIN_LIGHT = "MainLight";
	public const string U_OBJ_N_SCENE_MAIN_CAMERA = "MainCamera";
	public const string U_OBJ_N_SCENE_MANAGER = "SceneManager";

	public const string U_OBJ_N_SCREEN_DEBUG_UIS = "ScreenDebugUIs";
	public const string U_OBJ_N_SCREEN_BLIND_UIS = "ScreenBlindUIs";
	public const string U_OBJ_N_SCREEN_POPUP_UIS = "ScreenPopupUIs";
	public const string U_OBJ_N_SCREEN_TOPMOST_UIS = "ScreenTopmostUIs";
	public const string U_OBJ_N_SCREEN_ABS_UIS = "ScreenAbsUIs";

	public const string U_OBJ_N_VIEWPORT = "VIEWPORT";
	public const string U_OBJ_N_CONTENTS = "CONTENTS";
	public const string U_OBJ_N_CONTENTS_UIS = "CONTENTS_UIS";
	public const string U_OBJ_N_AB_T_UIS_SET_UIS = "SET_UIS";

	public const string U_OBJ_N_UP_BLIND_IMG = "UP_BLIND_IMG";
	public const string U_OBJ_N_DOWN_BLIND_IMG = "DOWN_BLIND_IMG";
	public const string U_OBJ_N_LEFT_BLIND_IMG = "LEFT_BLIND_IMG";
	public const string U_OBJ_N_RIGHT_BLIND_IMG = "RIGHT_BLIND_IMG";

	public const string U_OBJ_N_DESC_UIS = "DESC_UIS";
	public const string U_OBJ_N_PAGE_UIS = "PAGE_UIS";
	public const string U_OBJ_N_PAGINATION = "PAGINATION";

	public const string U_OBJ_N_BLIND_UIS = "BLIND_UIS";
	public const string U_OBJ_N_CLEAR_UIS = "CLEAR_UIS";
	public const string U_OBJ_N_CLEAR_FAIL_UIS = "CLEAR_FAIL_UIS";

	public const string U_OBJ_N_SEL_UIS = "SEL_UIS";
	public const string U_OBJ_N_NORM_UIS = "NORM_UIS";
	public const string U_OBJ_N_LOCK_UIS = "LOCK_UIS";
	public const string U_OBJ_N_PRICE_UIS = "PRICE_UIS";
	public const string U_OBJ_N_REWARD_UIS = "REWARD_UIS";
	public const string U_OBJ_N_DIFFICULTY_UIS = "DIFFICULTY_UIS";

	public const string U_OBJ_N_GAUGE_UIS = "GAUGE_UIS";
	public const string U_OBJ_N_HP_GAUGE_UIS = "HP_GAUGE_UIS";
	public const string U_OBJ_N_MP_GAUGE_UIS = "MP_GAUGE_UIS";
	public const string U_OBJ_N_EXP_GAUGE_UIS = "EXP_GAUGE_UIS";

	public const string U_OBJ_N_LOGIN_UIS = "LOGIN_UIS";
	public const string U_OBJ_N_LOGOUT_UIS = "LOGOUT_UIS";

	public const string U_OBJ_N_ADS_PRICE_UIS = "ADS_PRICE_UIS";
	public const string U_OBJ_N_TARGET_PRICE_UIS = "TARGET_PRICE_UIS";
	public const string U_OBJ_N_PURCHASE_PRICE_UIS = "PURCHASE_PRICE_UIS";

	public const string U_OBJ_N_TOP_MENU_UIS = "TOP_MENU_UIS";
	public const string U_OBJ_N_BOTTOM_MENU_UIS = "BOTTOM_MENU_UIS";

	public const string U_OBJ_N_MSG_TEXT = "MSG_TEXT";
	public const string U_OBJ_N_VAL_TEXT = "VAL_TEXT";
	public const string U_OBJ_N_PAGE_TEXT = "PAGE_TEXT";
	public const string U_OBJ_N_TITLE_TEXT = "TITLE_TEXT";

	public const string U_OBJ_N_NAME_TEXT = "NAME_TEXT";
	public const string U_OBJ_N_DESC_TEXT = "DESC_TEXT";

	public const string U_OBJ_N_LV_TEXT = "LV_TEXT";
	public const string U_OBJ_N_HP_TEXT = "HP_TEXT";
	public const string U_OBJ_N_MP_TEXT = "MP_TEXT";
	public const string U_OBJ_N_EXP_TEXT = "EXP_TEXT";

	public const string U_OBJ_N_LEVEL_TEXT = "LEVEL_TEXT";
	public const string U_OBJ_N_STAGE_TEXT = "STAGE_TEXT";
	public const string U_OBJ_N_CHAPTER_TEXT = "CHAPTER_TEXT";

	public const string U_OBJ_N_VER_TEXT = "VER_TEXT";
	public const string U_OBJ_N_NUM_TEXT = "NUM_TEXT";
	public const string U_OBJ_N_TIME_TEXT = "TIME_TEXT";
	public const string U_OBJ_N_TIMES_TEXT = "TIMES_TEXT";

	public const string U_OBJ_N_PRICE_TEXT = "PRICE_TEXT";
	public const string U_OBJ_N_STATE_TEXT = "STATE_TEXT";
	public const string U_OBJ_N_LOADING_TEXT = "LOADING_TEXT";
	public const string U_OBJ_N_COUNTDOWN_TEXT = "COUNTDOWN_TEXT";

	public const string U_OBJ_N_RECORD_TEXT = "RECORD_TEXT";
	public const string U_OBJ_N_BEST_RECORD_TEXT = "BEST_RECORD_TEXT";

	public const string U_OBJ_N_NUM_COINS_TEXT = "NUM_COINS_TEXT";
	public const string U_OBJ_N_NUM_MARKS_TEXT = "NUM_MARKS_TEXT";
	public const string U_OBJ_N_NUM_MARKS_STATE_TEXT = "NUM_MARKS_STATE_TEXT";

	public const string U_OBJ_N_BG_IMG = "BG_IMG";
	public const string U_OBJ_N_FX_IMG = "FX_IMG";
	public const string U_OBJ_N_SEL_IMG = "SEL_IMG";
	public const string U_OBJ_N_GLOW_IMG = "GLOW_IMG";
	public const string U_OBJ_N_COINS_IMG = "COINS_IMG";

	public const string U_OBJ_N_BLIND_IMG = "BLIND_IMG";
	public const string U_OBJ_N_SPLASH_IMG = "SPLASH_IMG";
	public const string U_OBJ_N_FOREGROUND_IMG = "FOREGROUND_IMG";

	public const string U_OBJ_N_MARK_IMG = "MARK_IMG";
	public const string U_OBJ_N_CHECK_IMG = "CHECK_IMG";
	public const string U_OBJ_N_RIBBON_IMG = "RIBBON_IMG";
	public const string U_OBJ_N_PERCENT_IMG = "PERCENT_IMG";
	public const string U_OBJ_N_COMPLETE_IMG = "COMPLETE_IMG";

	public const string U_OBJ_N_LOCK_IMG = "LOCK_IMG";
	public const string U_OBJ_N_ICON_IMG = "ICON_IMG";
	public const string U_OBJ_N_ITEM_IMG = "ITEM_IMG";
	public const string U_OBJ_N_REWARD_IMG = "REWARD_IMG";

	public const string U_OBJ_N_OK_BTN = "OK_BTN";
	public const string U_OBJ_N_BACK_BTN = "BACK_BTN";
	public const string U_OBJ_N_CANCEL_BTN = "CANCEL_BTN";
	public const string U_OBJ_N_OPEN_BTN = "OPEN_BTN";
	public const string U_OBJ_N_CLOSE_BTN = "CLOSE_BTN";

	public const string U_OBJ_N_A_SET_BTN = "A_SET_BTN";
	public const string U_OBJ_N_B_SET_BTN = "B_SET_BTN";

	public const string U_OBJ_N_AGREE_BTN = "AGREE_BTN";
	public const string U_OBJ_N_PRIVACY_BTN = "PRIVACY_BTN";
	public const string U_OBJ_N_SERVICES_BTN = "SERVICES_BTN";

	public const string U_OBJ_N_LOGIN_BTN = "LOGIN_BTN";
	public const string U_OBJ_N_LOGOUT_BTN = "LOGOUT_BTN";

	public const string U_OBJ_N_LOAD_BTN = "LOAD_BTN";
	public const string U_OBJ_N_SAVE_BTN = "SAVE_BTN";
	public const string U_OBJ_N_PLAY_BTN = "PLAY_BTN";
	public const string U_OBJ_N_COPY_BTN = "COPY_BTN";
	public const string U_OBJ_N_STORE_BTN = "STORE_BTN";
	public const string U_OBJ_N_SETTINGS_BTN = "SETTINGS_BTN";

	public const string U_OBJ_N_PREV_BTN = "PREV_BTN";
	public const string U_OBJ_N_NEXT_BTN = "NEXT_BTN";
	public const string U_OBJ_N_RETRY_BTN = "RETRY_BTN";
	public const string U_OBJ_N_LEAVE_BTN = "LEAVE_BTN";
	public const string U_OBJ_N_FINISH_BTN = "FINISH_BTN";
	public const string U_OBJ_N_CONTINUE_BTN = "CONTINUE_BTN";

	public const string U_OBJ_N_ADS_BTN = "ADS_BTN";
	public const string U_OBJ_N_PAUSE_BTN = "PAUSE_BTN";
	public const string U_OBJ_N_SHARE_BTN = "SHARE_BTN";
	public const string U_OBJ_N_ACQUIRE_BTN = "ACQUIRE_BTN";
	public const string U_OBJ_N_RANKING_BTN = "RANKING_BTN";
	public const string U_OBJ_N_PURCHASE_BTN = "PURCHASE_BTN";
	public const string U_OBJ_N_RESTORE_BTN = "RESTORE_BTN";
	public const string U_OBJ_N_REMOVE_ADS_BTN = "REMOVE_ADS_BTN";

	public const string U_OBJ_N_SND_BTN = "SND_BTN";
	public const string U_OBJ_N_BG_SND_BTN = "BG_SND_BTN";
	public const string U_OBJ_N_FX_SNDS_BTN = "FX_SNDS_BTN";
	public const string U_OBJ_N_VIBRATE_BTN = "VIBRATE_BTN";

	public const string U_OBJ_N_NOTI_BTN = "NOTI_BTN";
	public const string U_OBJ_N_REVIEW_BTN = "REVIEW_BTN";
	public const string U_OBJ_N_SUPPORTS_BTN = "SUPPORTS_BTN";

	public const string U_OBJ_N_SYNC_BTN = "SYNC_BTN";
	public const string U_OBJ_N_LOCALIZE_BTN = "LOCALIZE_BTN";
	public const string U_OBJ_N_MORE_APPS_BTN = "MORE_APPS_BTN";

	public const string U_OBJ_N_POPUP = "POPUP";
	public const string U_OBJ_N_GAME_OBJ = "GAME_OBJ";
	public const string U_OBJ_N_ALERT_POPUP = "ALERT_POPUP";
	public const string U_OBJ_N_FOCUS_POPUP = "FOCUS_POPUP";

	public const string U_OBJ_N_TEXT = "TEXT";
	public const string U_OBJ_N_LOCALIZE_TEXT = "LOCALIZE_TEXT";

	public const string U_OBJ_N_TMP_TEXT = "TMP_TEXT";
	public const string U_OBJ_N_TMP_TEXT_MESH = "TMP_TEXT_MESH";
	public const string U_OBJ_N_TMP_LOCALIZE_TEXT = "TMP_LOCALIZE_TEXT";

	public const string U_OBJ_N_IMG = "IMG";
	public const string U_OBJ_N_MASK_IMG = "MASK_IMG";
	public const string U_OBJ_N_FOCUS_IMG = "FOCUS_IMG";
	public const string U_OBJ_N_GAUGE_IMG = "GAUGE_IMG";

	public const string U_OBJ_N_TEXT_BTN = "TEXT_BTN";
	public const string U_OBJ_N_TEXT_SCALE_BTN = "TEXT_SCALE_BTN";

	public const string U_OBJ_N_TMP_TEXT_BTN = "TMP_TEXT_BTN";
	public const string U_OBJ_N_TMP_TEXT_SCALE_BTN = "TMP_TEXT_SCALE_BTN";

	public const string U_OBJ_N_LOCALIZE_TEXT_BTN = "LOCALIZE_TEXT_BTN";
	public const string U_OBJ_N_LOCALIZE_TEXT_SCALE_BTN = "LOCALIZE_TEXT_SCALE_BTN";

	public const string U_OBJ_N_TMP_LOCALIZE_TEXT_BTN = "TMP_LOCALIZE_TEXT_BTN";
	public const string U_OBJ_N_TMP_LOCALIZE_TEXT_SCALE_BTN = "TMP_LOCALIZE_TEXT_SCALE_BTN";

	public const string U_OBJ_N_IMG_BTN = "IMG_BTN";
	public const string U_OBJ_N_IMG_SCALE_BTN = "IMG_SCALE_BTN";

	public const string U_OBJ_N_IMG_TEXT_BTN = "IMG_TEXT_BTN";
	public const string U_OBJ_N_IMG_TEXT_SCALE_BTN = "IMG_TEXT_SCALE_BTN";

	public const string U_OBJ_N_TMP_IMG_TEXT_BTN = "TMP_IMG_TEXT_BTN";
	public const string U_OBJ_N_TMP_IMG_TEXT_SCALE_BTN = "TMP_IMG_TEXT_SCALE_BTN";

	public const string U_OBJ_N_IMG_LOCALIZE_TEXT_BTN = "IMG_LOCALIZE_TEXT_BTN";
	public const string U_OBJ_N_IMG_LOCALIZE_TEXT_SCALE_BTN = "IMG_LOCALIZE_TEXT_SCALE_BTN";

	public const string U_OBJ_N_TMP_IMG_LOCALIZE_TEXT_BTN = "TMP_IMG_LOCALIZE_TEXT_BTN";
	public const string U_OBJ_N_TMP_IMG_LOCALIZE_TEXT_SCALE_BTN = "TMP_IMG_LOCALIZE_TEXT_SCALE_BTN";

	public const string U_OBJ_N_DROP = "DROP";
	public const string U_OBJ_N_INPUT = "INPUT";

	public const string U_OBJ_N_TOGGLE = "TOGGLE";
	public const string U_OBJ_N_DROPDOWN = "DROPDOWN";
	public const string U_OBJ_N_INPUT_FIELD = "INPUT_FIELD";

	public const string U_OBJ_N_TMP_TOGGLE = "TMP_TOGGLE";
	public const string U_OBJ_N_TMP_DROPDOWN = "TMP_DROPDOWN";
	public const string U_OBJ_N_TMP_INPUT_FIELD = "TMP_INPUT_FIELD";

	public const string U_OBJ_N_PAGE_VIEW = "PAGE_VIEW";
	public const string U_OBJ_N_SCROLL_VIEW = "SCROLL_VIEW";
	public const string U_OBJ_N_RECYCLE_VIEW = "RECYCLE_VIEW";

	public const string U_OBJ_N_LEVEL_SCROLL_VIEW = "LEVEL_SCROLL_VIEW";
	public const string U_OBJ_N_STAGE_SCROLL_VIEW = "STAGE_SCROLL_VIEW";
	public const string U_OBJ_N_CHAPTER_SCROLL_VIEW = "CHAPTER_SCROLL_VIEW";

	public const string U_OBJ_N_BG_SPRITE = "BG_SPRITE";
	public const string U_OBJ_N_TARGET_SPRITE = "TARGET_SPRITE";
	public const string U_OBJ_N_TARGET_PARTICLE_FX = "TARGET_PARTICLE_FX";

	public const string U_OBJ_N_SPRITE = "SPRITE";
	public const string U_OBJ_N_LINE_FX = "LINE_FX";
	public const string U_OBJ_N_TARGET_OBJ = "TARGET_OBJ";
	public const string U_OBJ_N_PARTICLE_FX = "PARTICLE_FX";
	public const string U_OBJ_N_REFLECTION_PROBE = "REFLECTION_PROBE";
	public const string U_OBJ_N_LIGHT_PROBE_GROUP = "LIGHT_PROBE_GROUP";

	public const string U_OBJ_N_DRAG_RESPONDER = "DRAG_RESPONDER";
	public const string U_OBJ_N_TOUCH_RESPONDER = "TOUCH_RESPONDER";

	public const string U_OBJ_N_INDICATOR_TOUCH_RESPONDER = "INDICATOR_TOUCH_RESPONDER";
	public const string U_OBJ_N_SCREEN_FADE_TOUCH_RESPONDER = "SCREEN_FADE_TOUCH_RESPONDER";

	public const string U_OBJ_N_FMT_TOGGLE = "TOGGLE_{0:00}";
	public const string U_OBJ_N_FMT_NUM_TEXT = "NUM_TEXT_{0:00}";
	public const string U_OBJ_N_FMT_MARK_IMG = "MARK_IMG_{0:00}";
	public const string U_OBJ_N_FMT_PAGE_UIS = "PAGE_UIS_{0:00}";
	public const string U_OBJ_N_FMT_POPUP_TOUCH_RESPONDER = "POPUP_TOUCH_RESPONDER_{0}";

	public const string U_IMG_N_TEX = "Tex";
	public const string U_IMG_N_SPRITE = "Sprite";
	public const string U_IMG_N_CLONE_SPRITE = "(Clone)";

	public const string U_FUNC_N_ON_DRAG = "OnDrag";
	public const string U_FUNC_N_ON_POINTER_UP = "OnPointerUp";
	public const string U_FUNC_N_ON_POINTER_DOWN = "OnPointerDown";
	public const string U_FUNC_N_ON_POINTER_ENTER = "OnPointerEnter";
	public const string U_FUNC_N_ON_POINTER_EXIT = "OnPointerExit";

	public const string U_FUNC_N_INIT = "Init";
	public const string U_FUNC_N_RESET_ANI = "ResetAni";
	public const string U_FUNC_N_RESET_LOCALIZE = "ResetLocalize";
	public const string U_FUNC_N_RESET_DIFFICULTY = "ResetDifficulty";
	public const string U_FUNC_N_UPDATE_UIS_STATE = "UpdateUIsState";

	public const string U_INPUT_N_VERTICAL = "Vertical";
	public const string U_INPUT_N_HORIZONTAL = "Horizontal";

	public const string U_PROPERTY_N_TEXT = "text";
	public const string U_PROPERTY_N_FONT = "font";
	public const string U_PROPERTY_N_COLOR = "color";
	public const string U_PROPERTY_N_SPRITE = "sprite";

	public const string U_MAT_N_DEF_SKYBOX = "Default-Skybox";
	public const string U_ICON_N_ANDROID_NOTI_SMALL = "smallnotiicon";
	public const string U_ICON_N_ANDROID_NOTI_LARGE = "largenotiicon";
	// 이름 }

	// 경로
	public const string U_IMG_P_DEF = "DefImg";
	public const string U_MESH_P_DEF = "DefMesh";

	// 씬 관리자
	public const string U_KEY_FMT_SCENE_M_TOUCH_RESPONDER = "SceneMTouchResponder_{0}";

	// 사운드 관리자
	public const string U_OBJ_N_SND_M_BG_SND = "BGSnd";
	public const string U_OBJ_N_SND_M_FX_SNDS = "FXSnds";

	// 입력 모듈 {
	public const int U_THRESHOLD_INPUT_M_MOVE = 10;

	public const float U_RATE_INPUT_M_MOVE_REPEAT = 0.1f;
	public const float U_DELAY_INPUT_M_MOVE_REPEAT = 0.5f;
	public const float U_UNIT_INPUT_M_INPUT_ACTIONS_PER_SEC = 10.0f;
	// 입력 모듈 }

	// 서비스 관리자 {
	public const string U_KEY_SERVICES_M_RECEIPT = "json";
	public const string U_KEY_SERVICES_M_PAYLOAD = "Payload";
	public const string U_KEY_SERVICES_M_SIGNATURE = "signature";

	public const string U_KEY_SERVICES_M_INIT_CALLBACK = "ServicesMInitCallback";
	public const string U_KEY_SERVICES_M_LOAD_GOOGLE_SHEET_CALLBACK = "ServicesMLoadGoogleSheetCallback";
	public const string U_KEY_SERVICES_M_SAVE_GOOGLE_SHEET_CALLBACK = "ServicesMSaveGoogleSheetCallback";
	// 서비스 관리자 }
	#endregion // 기본

	#region 런타임 상수
	// 경로 {
	public static readonly string U_DATA_P_FMT_G_LEVEL_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}LevelInfo/G_LevelInfo_{"{0:000000000}"}";
	public static readonly string U_DATA_P_FMT_G_LEVEL_INFO_SET_A = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}A/LevelInfo/G_LevelInfo_{"{0:000000000}"}";
	public static readonly string U_DATA_P_FMT_G_LEVEL_INFO_SET_B = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}B/LevelInfo/G_LevelInfo_{"{0:000000000}"}";

	public static readonly string U_OBJ_P_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Text/U_Text";
	public static readonly string U_OBJ_P_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_TextBtn";
	public static readonly string U_OBJ_P_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_TextScaleBtn";

	public static readonly string U_OBJ_P_TMP_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Text/U_TMPText";
	public static readonly string U_OBJ_P_TMP_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPTextBtn";
	public static readonly string U_OBJ_P_TMP_TEXT_MESH = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Text/U_TMPTextMesh";
	public static readonly string U_OBJ_P_TMP_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPTextScaleBtn";

	public static readonly string U_OBJ_P_LOCALIZE_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Text/U_LocalizeText";
	public static readonly string U_OBJ_P_LOCALIZE_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_LocalizeTextBtn";
	public static readonly string U_OBJ_P_LOCALIZE_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_LocalizeTextScaleBtn";

	public static readonly string U_OBJ_P_TMP_LOCALIZE_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Text/U_TMPLocalizeText";
	public static readonly string U_OBJ_P_TMP_LOCALIZE_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPLocalizeTextBtn";
	public static readonly string U_OBJ_P_TMP_LOCALIZE_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPLocalizeTextScaleBtn";

	public static readonly string U_OBJ_P_IMG = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Image/U_Img";
	public static readonly string U_OBJ_P_MASK_IMG = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Image/U_MaskImg";
	public static readonly string U_OBJ_P_FOCUS_IMG = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Image/U_FocusImg";
	public static readonly string U_OBJ_P_GAUGE_IMG = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Image/U_GaugeImg";

	public static readonly string U_OBJ_P_IMG_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/U_ImgBtn";
	public static readonly string U_OBJ_P_IMG_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/U_ImgScaleBtn";

	public static readonly string U_OBJ_P_IMG_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_ImgTextBtn";
	public static readonly string U_OBJ_P_IMG_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_ImgTextScaleBtn";

	public static readonly string U_OBJ_P_TMP_IMG_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPImgTextBtn";
	public static readonly string U_OBJ_P_TMP_IMG_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPImgTextScaleBtn";

	public static readonly string U_OBJ_P_IMG_LOCALIZE_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_ImgLocalizeTextBtn";
	public static readonly string U_OBJ_P_IMG_LOCALIZE_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/Text/U_ImgLocalizeTextScaleBtn";

	public static readonly string U_OBJ_P_TMP_IMG_LOCALIZE_TEXT_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPImgLocalizeTextBtn";
	public static readonly string U_OBJ_P_TMP_IMG_LOCALIZE_TEXT_SCALE_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Button/TextMeshPro/U_TMPImgLocalizeTextScaleBtn";

	public static readonly string U_OBJ_P_TOGGLE = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_Toggle";
	public static readonly string U_OBJ_P_DROPDOWN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_Dropdown";
	public static readonly string U_OBJ_P_INPUT_FIELD = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_InputField";

	public static readonly string U_OBJ_P_TMP_TOGGLE = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_TMPToggle";
	public static readonly string U_OBJ_P_TMP_DROPDOWN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_TMPDropdown";
	public static readonly string U_OBJ_P_TMP_INPUT_FIELD = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Input/U_TMPInputField";

	public static readonly string U_OBJ_P_PAGE_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/ScrollView/U_PageView";
	public static readonly string U_OBJ_P_SCROLL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/ScrollView/U_ScrollView";
	public static readonly string U_OBJ_P_RECYCLE_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/ScrollView/U_RecycleView";

	public static readonly string U_OBJ_P_DRAG_RESPONDER = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Responder/U_DragResponder";
	public static readonly string U_OBJ_P_TOUCH_RESPONDER = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Responder/U_TouchResponder";
	public static readonly string U_OBJ_P_INDICATOR_TOUCH_RESPONDER = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Responder/U_IndicatorTouchResponder";
	public static readonly string U_OBJ_P_SCREEN_FADE_TOUCH_RESPONDER = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}UI/Responder/U_ScreenFadeTouchResponder";

	public static readonly string U_OBJ_P_SPRITE = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}2D/U_Sprite";
	public static readonly string U_OBJ_P_LINE_FX = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}FX/U_LineFX";
	public static readonly string U_OBJ_P_TARGET_OBJ = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}2D/U_TargetObj";
	public static readonly string U_OBJ_P_PARTICLE_FX = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}FX/U_ParticleFX";
	public static readonly string U_OBJ_P_TIMER_MANAGER = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}External/U_TimerManager";
	public static readonly string U_OBJ_P_REFLECTION_PROBE = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}FX/U_ReflectionProbe";
	public static readonly string U_OBJ_P_LIGHT_PROBE_GROUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}FX/U_LightProbeGroup";

	public static readonly string U_OBJ_P_BG_SND = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}Sound/U_BGSnd";
	public static readonly string U_OBJ_P_FX_SNDS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_UTILITY}Sound/U_FXSnds";

	public static readonly string U_OBJ_P_G_INFO_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}G_InfoText";
	public static readonly string U_OBJ_P_G_BACK_BTN = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}G_BackBtn";
	public static readonly string U_OBJ_P_G_MESH = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}G_Mesh";

	public static readonly string U_OBJ_P_G_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_Popup";
	public static readonly string U_OBJ_P_G_ALERT_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_AlertPopup";
	public static readonly string U_OBJ_P_G_STORE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_StorePopup";
	public static readonly string U_OBJ_P_G_SETTINGS_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_SettingsPopup";

	public static readonly string U_OBJ_P_G_SYNC_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_SyncPopup";
	public static readonly string U_OBJ_P_G_DAILY_MISSION_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_DailyMissionPopup";
	public static readonly string U_OBJ_P_G_FREE_REWARD_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_FreeRewardPopup";
	public static readonly string U_OBJ_P_G_DAILY_REWARD_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_DailyRewardPopup";

	public static readonly string U_OBJ_P_G_COINS_BOX_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_CoinsBoxBuyPopup";
	public static readonly string U_OBJ_P_G_REWARD_ACQUIRE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_RewardAcquirePopup";
	public static readonly string U_OBJ_P_G_COINS_BOX_ACQUIRE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_CoinsBoxAcquirePopup";

	public static readonly string U_OBJ_P_G_CONTINUE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_ContinuePopup";
	public static readonly string U_OBJ_P_G_READY_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_ReadyPopup";
	public static readonly string U_OBJ_P_G_RESULT_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_ResultPopup";
	public static readonly string U_OBJ_P_G_RESUME_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_ResumePopup";
	public static readonly string U_OBJ_P_G_PAUSE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_PausePopup";

	public static readonly string U_OBJ_P_G_PRODUCT_BUY_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_ProductBuyPopup";
	public static readonly string U_OBJ_P_G_FOCUS_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_FocusPopup";
	public static readonly string U_OBJ_P_G_TUTORIAL_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_TutorialPopup";

	public static readonly string U_ASSET_P_G_NORM_QUALITY_LIGHTING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_NormQualityLightingSettings";
	public static readonly string U_ASSET_P_G_HIGH_QUALITY_LIGHTING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_HighQualityLightingSettings";
	public static readonly string U_ASSET_P_G_ULTRA_QUALITY_LIGHTING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_UltraQualityLightingSettings";

	public static readonly string U_ASSET_P_G_NORM_QUALITY_POST_PROCESSING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_NormQualityPostProcessingSettings";
	public static readonly string U_ASSET_P_G_HIGH_QUALITY_POST_PROCESSING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_HighQualityPostProcessingSettings";
	public static readonly string U_ASSET_P_G_ULTRA_QUALITY_POST_PROCESSING_SETTINGS = $"{KCDefine.B_DIR_P_SETTINGS}{KCDefine.B_DIR_P_GLOBAL}G_UltraQualityPostProcessingSettings";

	public static readonly string U_ASSET_P_G_OPTS_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_OptsInfoTable";
	public static readonly string U_ASSET_P_G_BUILD_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_BuildInfoTable";
	public static readonly string U_ASSET_P_G_PROJ_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_ProjInfoTable";
	public static readonly string U_ASSET_P_G_LOCALIZE_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_LocalizeInfoTable";
	public static readonly string U_ASSET_P_G_DEFINE_SYMBOL_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_DefineSymbolInfoTable";
	public static readonly string U_ASSET_P_G_DEVICE_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_DeviceInfoTable";
	public static readonly string U_ASSET_P_G_PRODUCT_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_ProductInfoTable";

	public static readonly string U_ASSET_P_SPRITE_ATLAS_01 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_01";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_02 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_02";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_03 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_03";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_04 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_04";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_05 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_05";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_06 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_06";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_07 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_07";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_08 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_08";
	public static readonly string U_ASSET_P_SPRITE_ATLAS_09 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_UTILITY}U_SpriteAtlas_09";

	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_01 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_01";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_02 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_02";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_03 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_03";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_04 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_04";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_05 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_05";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_06 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_06";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_07 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_07";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_08 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_08";
	public static readonly string U_ASSET_P_G_SPRITE_ATLAS_09 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}G_SpriteAtlas_09";

	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_01 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_01";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_02 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_02";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_03 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_03";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_04 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_04";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_05 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_05";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_06 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_06";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_07 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_07";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_08 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_08";
	public static readonly string U_ASSET_P_ES_SPRITE_ATLAS_09 = $"{KCDefine.B_DIR_P_SPRITE_ATLASES}{KCDefine.B_DIR_P_GLOBAL}ES_SpriteAtlas_09";

	public static readonly string U_TABLE_P_G_LEVEL_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}LevelInfo/G_LevelInfoTable";
	public static readonly string U_TABLE_P_G_LEVEL_INFO_SET_A = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}A/LevelInfo/G_LevelInfoTable";
	public static readonly string U_TABLE_P_G_LEVEL_INFO_SET_B = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}B/LevelInfo/G_LevelInfoTable";

	public static readonly string U_TABLE_P_G_ETC_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_EtcInfoTable";
	public static readonly string U_TABLE_P_G_ETC_INFO_SET_A = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}A/G_EtcInfoTable";
	public static readonly string U_TABLE_P_G_ETC_INFO_SET_B = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}B/G_EtcInfoTable";

	public static readonly string U_TABLE_P_G_VER_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_VerInfoTable";
	public static readonly string U_TABLE_P_G_MISSION_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_MissionInfoTable";
	public static readonly string U_TABLE_P_G_REWARD_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_RewardInfoTable";
	public static readonly string U_TABLE_P_G_RES_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_ResInfoTable";

	public static readonly string U_TABLE_P_G_ITEM_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_ItemInfoTable";
	public static readonly string U_TABLE_P_G_SKILL_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_SkillInfoTable";
	public static readonly string U_TABLE_P_G_OBJ_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_ObjInfoTable";
	public static readonly string U_TABLE_P_G_ABILITY_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_AbilityInfoTable";
	public static readonly string U_TABLE_P_G_PRODUCT_INFO = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}G_ProductInfoTable";

	public static readonly string U_TABLE_P_G_COMMON_VAL = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}ValueInfo/G_ValTable_Common";
	public static readonly string U_TABLE_P_G_COMMON_STR = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}StringInfo/G_StrTable_Common";

	public static readonly string U_TABLE_P_FMT_G_COMMON_VAL = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}ValueInfo/{KCDefine.B_TEXT_FMT_2_UNDER_SCORE_COMBINE}";
	public static readonly string U_TABLE_P_FMT_G_COMMON_STR = $"{KCDefine.B_DIR_P_TABLES}{KCDefine.B_DIR_P_GLOBAL}StringInfo/{KCDefine.B_TEXT_FMT_2_UNDER_SCORE_COMBINE}";

	public static readonly string U_TABLE_P_FMT_G_LOCALIZE_COMMON_VAL = string.Format(KCDefine.U_TABLE_P_FMT_G_COMMON_VAL, "G_ValTable_Common", "{0}");
	public static readonly string U_TABLE_P_FMT_G_LOCALIZE_COMMON_STR = string.Format(KCDefine.U_TABLE_P_FMT_G_COMMON_STR, "G_StrTable_Common", "{0}");

	public static readonly string U_TABLE_P_G_KOREAN_COMMON_STR = string.Format(KCDefine.U_TABLE_P_FMT_G_LOCALIZE_COMMON_STR, SystemLanguage.Korean);
	public static readonly string U_TABLE_P_G_ENGLISH_COMMON_STR = string.Format(KCDefine.U_TABLE_P_FMT_G_LOCALIZE_COMMON_STR, SystemLanguage.English);

	public static readonly string U_BASE_TABLE_P_G_LOCALIZE_COMMON_VAL = KCDefine.U_TABLE_P_G_COMMON_VAL;
	public static readonly string U_BASE_TABLE_P_G_LOCALIZE_COMMON_STR = KCDefine.U_TABLE_P_G_COMMON_STR;

	public static readonly string U_FONT_P_G_DEF = $"Fonts & Materials/LiberationSans SDF";
	public static readonly string U_FONT_P_G_KOREAN = $"{KCDefine.B_DIR_P_FONTS}{KCDefine.B_DIR_P_GLOBAL}G_Korean";
	public static readonly string U_FONT_P_G_ENGLISH = $"{KCDefine.B_DIR_P_FONTS}{KCDefine.B_DIR_P_GLOBAL}G_English";

	public static readonly string U_SND_P_G_SFX_TOUCH_BEGIN = $"{KCDefine.B_DIR_P_SOUNDS}{KCDefine.B_DIR_P_GLOBAL}G_SFX_TouchBegin";
	public static readonly string U_SND_P_G_SFX_TOUCH_END = $"{KCDefine.B_DIR_P_SOUNDS}{KCDefine.B_DIR_P_GLOBAL}G_SFX_TouchEnd";

	public static readonly string U_SND_P_G_SFX_POPUP_SHOW = $"{KCDefine.B_DIR_P_SOUNDS}{KCDefine.B_DIR_P_GLOBAL}G_SFX_PopupShow";
	public static readonly string U_SND_P_G_SFX_POPUP_CLOSE = $"{KCDefine.B_DIR_P_SOUNDS}{KCDefine.B_DIR_P_GLOBAL}G_SFX_PopupClose";

	public static readonly string U_MAT_P_G_SKYBOX = $"{KCDefine.B_DIR_P_MATERIALS}{KCDefine.B_DIR_P_GLOBAL}G_Skybox";

	public static readonly string U_IMG_P_ARROW = $"{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Arrow";
	public static readonly string U_IMG_P_WHITE = $"{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}White";
	public static readonly string U_IMG_P_SPLASH = $"{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Splash";
	public static readonly string U_IMG_P_INDICATOR = $"{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Indicator";

	public static readonly string U_TEX_P_ARROW = $"{KCDefine.B_DIR_P_TEXTURES}U_SpriteAtlas_01{KCDefine.B_NAME_PATTERN_FILTER_SETUP_TEX_COMPRESS}/{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Arrow";
	public static readonly string U_TEX_P_WHITE = $"{KCDefine.B_DIR_P_TEXTURES}U_SpriteAtlas_01{KCDefine.B_NAME_PATTERN_FILTER_SETUP_TEX_COMPRESS}/{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}White";
	public static readonly string U_TEX_P_SPLASH = $"{KCDefine.B_DIR_P_TEXTURES}U_SpriteAtlas_01{KCDefine.B_NAME_PATTERN_FILTER_SETUP_TEX_COMPRESS}/{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Splash";
	public static readonly string U_TEX_P_INDICATOR = $"{KCDefine.B_DIR_P_TEXTURES}U_SpriteAtlas_01{KCDefine.B_NAME_PATTERN_FILTER_SETUP_TEX_COMPRESS}/{KCDefine.B_PREFIX_U_SPRITE_ATLAS_01}Indicator";

#if UNITY_EDITOR
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_A}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_B}.json";

	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_A}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_B}.json";

	public static readonly string U_RUNTIME_TABLE_P_G_MISSION_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_MISSION_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_REWARD_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_REWARD_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_RES_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_RES_INFO}.json";

	public static readonly string U_RUNTIME_TABLE_P_G_ITEM_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ITEM_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_SKILL_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_SKILL_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_OBJ_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_OBJ_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ABILITY_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ABILITY_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_PRODUCT_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_PRODUCT_INFO}.json";

	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO}.bytes";
	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A}.bytes";
	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B}.bytes";
#else
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_A}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_LEVEL_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_LEVEL_INFO_SET_B}.json";
	
	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_A}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ETC_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ETC_INFO_SET_B}.json";

	public static readonly string U_RUNTIME_TABLE_P_G_MISSION_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_MISSION_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_REWARD_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_REWARD_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_RES_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_RES_INFO}.json";

	public static readonly string U_RUNTIME_TABLE_P_G_ITEM_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ITEM_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_SKILL_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_SKILL_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_OBJ_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_OBJ_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_ABILITY_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_ABILITY_INFO}.json";
	public static readonly string U_RUNTIME_TABLE_P_G_PRODUCT_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_TABLE_P_G_PRODUCT_INFO}.json";

	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO}.bytes";
	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO_SET_A = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_A}.bytes";
	public static readonly string U_RUNTIME_DATA_P_FMT_G_LEVEL_INFO_SET_B = $"{KCDefine.B_ABS_DIR_P_RUNTIME_EXTERNAL_DATAS}{KCDefine.U_DATA_P_FMT_G_LEVEL_INFO_SET_B}.bytes";
#endif // #if UNITY_EDITOR

	public static readonly List<string> U_ASSET_P_SPRITE_ATLAS_LIST = new List<string>() {
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
		KCDefine.U_ASSET_P_G_SPRITE_ATLAS_09
	};

	public static readonly List<string> U_ASSET_P_ES_SPRITE_ATLAS_LIST = new List<string>() {
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
	// 경로 }
	#endregion // 런타임 상수

	#region 조건부 상수
#if UNITY_EDITOR
	// 퀄리티
	public const int U_QUALITY_ASYNC_UPLOAD_TIME_SLICE = 2;
	public const int U_QUALITY_ASYNC_UPLOAD_BUFFER_SIZE = 16;
#endif // #if UNITY_EDITOR

#if PLAYFAB_MODULE_ENABLE
	// 개수
	public const int U_MAX_NUM_PLAYFAB_M_NOTICES = 10;
	public const int U_MAX_NUM_PLAYFAB_M_STATISTICS = 100;

	// 식별자
	public const string U_KEY_PLAYFAB_M_INIT_CALLBACK = "PlayfabMInitCallback";
	public const string U_KEY_PLAYFAB_M_LOGIN_CALLBACK = "PlayfabMLoginCallback";
	public const string U_KEY_PLAYFAB_M_LOGOUT_CALLBACK = "PlayfabMLogoutCallback";
	public const string U_KEY_PLAYFAB_M_LOAD_SERVER_TIME_CALLBACK = "PlayfabMLoadServerTimeCallback";
#endif // #if PLAYFAB_MODULE_ENABLE

#if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
	// 이름
	public const string U_COL_N_GOOGLE_SHEET_SRC = "B";
	public const string U_COL_N_GOOGLE_SHEET_DEST = "BZ";
#endif // #if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 상수

	#region 조건부 런타임 상수
#if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || APPS_FLYER_MODULE_ENABLE
	// 경로
	public static readonly string U_ASSET_P_G_PLUGIN_INFO_TABLE = $"{KCDefine.B_DIR_P_SCRIPTABLES}{KCDefine.B_DIR_P_GLOBAL}G_PluginInfoTable";
#endif // #if ADS_MODULE_ENABLE || FLURRY_MODULE_ENABLE || APPS_FLYER_MODULE_ENABLE

#if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
	// 이름
	public static readonly string U_CELL_N_FMT_GOOGLE_SHEET_SRC = $"{KCDefine.U_COL_N_GOOGLE_SHEET_SRC}{"{0}"}";
	public static readonly string U_CELL_N_FMT_GOOGLE_SHEET_DEST = $"{KCDefine.U_COL_N_GOOGLE_SHEET_DEST}{"{0}"}";
#endif // #if GOOGLE_SHEET_ENABLE && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 런타임 상수
}

/** 초기화 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본

	#region 런타임 상수
	// 경로
	public static readonly string IS_OBJ_P_SCREEN_BLIND_UIS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_INIT_SCENE}IS_ScreenBlindUIs";
	public static readonly string IS_OBJ_P_SCREEN_BLIND_IMG = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_INIT_SCENE}IS_ScreenBlindImg";
	#endregion // 런타임 상수
}

/** 설정 씬 상수 */
public static partial class KCDefine
{
	#region 기본
	// 이름
	public const string SS_OBJ_N_TIMER_MANAGER = "TimerManager";
	public const string SS_FUNC_N_SETUP_SCENE_EVENT = "OnReceiveSetupSceneEvent";
	#endregion // 기본

	#region 런타임 상수
	// 경로 {
	public static readonly string SS_OBJ_P_LOADING_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_LoadingText";
	public static readonly string SS_OBJ_P_LOADING_GAUGE = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_LoadingGauge";

	public static readonly string SS_OBJ_P_SCREEN_DEBUG_UIS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_ScreenDebugUIs";
	public static readonly string SS_OBJ_P_SCREEN_POPUP_UIS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_ScreenPopupUIs";
	public static readonly string SS_OBJ_P_SCREEN_TOPMOST_UIS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_ScreenTopmostUIs";
	public static readonly string SS_OBJ_P_SCREEN_ABS_UIS = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_SETUP_SCENE}SS_ScreenAbsUIs";
	// 경로 }
	#endregion // 런타임 상수
}

/** 지연 설정 씬 상수 */
public static partial class KCDefine
{
	#region 기본
	// 약관 동의 팝업
	public const string AS_OBJ_N_AGREE_POPUP = "AgreePopup";

	// 추적 설명 팝업
	public const string LSS_OBJ_N_TRACKING_DESC_POPUP = "TrackingDescPopup";
	#endregion // 기본

	#region 런타임 상수
	// 경로 {
	public static readonly string LSS_DATA_P_PRIVACY = $"{KCDefine.B_DIR_P_DATAS}{KCDefine.B_DIR_P_LATE_SETUP_SCENE}LSS_Privacy_{SystemLanguage.Korean}";
	public static readonly string LSS_DATA_P_SERVICES = $"{KCDefine.B_DIR_P_DATAS}{KCDefine.B_DIR_P_LATE_SETUP_SCENE}LSS_Services_{SystemLanguage.Korean}";

	public static readonly string LSS_OBJ_P_TRACKING_DESC_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_LATE_SETUP_SCENE}LSS_TrackingDescPopup";
	public static readonly string LSS_OBJ_P_PORTRAIT_AGREE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_LATE_SETUP_SCENE}LSS_PortraitAgreePopup";
	public static readonly string LSS_OBJ_P_LANDSCAPE_AGREE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_LATE_SETUP_SCENE}LSS_LandscapeAgreePopup";
	// 경로 }
	#endregion // 런타임 상수
}

/** 타이틀 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본
}

/** 메인 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본

	#region 런타임 상수
	// 경로
	public static readonly string MS_OBJ_P_LEVEL_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_MAIN_SCENE}MS_LevelScrollerCellView";
	public static readonly string MS_OBJ_P_STAGE_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_MAIN_SCENE}MS_StageScrollerCellView";
	public static readonly string MS_OBJ_P_CHAPTER_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_MAIN_SCENE}MS_ChapterScrollerCellView";
	#endregion // 런타임 상수
}

/** 플레이 씬 상수 */
public static partial class KCDefine
{
	#region 기본
	// 이름
	public const string PS_OBJ_N_FMT_CELL_OBJ_ROOT = "CELL_OBJ_ROOT_{0:00}";
	#endregion // 기본
}

/** 결과 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본
}

/** 로딩 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본
}

/** 중첩 씬 상수 */
public static partial class KCDefine
{
	#region 기본

	#endregion // 기본
}
