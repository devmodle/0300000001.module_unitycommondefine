using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 로그 상수
public static partial class KCDefine {
	#region 기본

	#endregion			// 기본

	#region 조건부 상수
#if FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FACEBOOK_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE
	// 이름
	public const string L_LOG_N_APP_LAUNCH = "AppLaunch";

	// 식별자 {
	public const string L_LOG_KEY_USER_ID = "UserID";
	public const string L_LOG_KEY_COUNTRY_CODE = "CountryCode";

	public const string L_LOG_KEY_DEVICE_ID = "DeviceID";
	public const string L_LOG_KEY_PLATFORM = "Platform";
	public const string L_LOG_KEY_USER_TYPE = "UserType";
	public const string L_LOG_KEY_LOG_TIME = "LogTime";
	public const string L_LOG_KEY_INSTALL_TIME = "InstallTime";

	public const string L_LOG_KEY_PARAMS_A = "ParamsA";
	public const string L_LOG_KEY_PARAMS_B = "ParamsB";
	public const string L_LOG_KEY_PARAMS_C = "ParamsC";
	public const string L_LOG_KEY_PARAMS_D = "ParamsD";
	public const string L_LOG_KEY_PARAMS_E = "ParamsE";
	public const string L_LOG_KEY_PARAMS_F = "ParamsF";
	// 식별자 }
#endif			// #if FLURRY_MODULE_ENABLE || TENJIN_MODULE_ENABLE || FACEBOOK_MODULE_ENABLE || FIREBASE_MODULE_ENABLE || SINGULAR_MODULE_ENABLE
	#endregion			// 조건부 상수
}
