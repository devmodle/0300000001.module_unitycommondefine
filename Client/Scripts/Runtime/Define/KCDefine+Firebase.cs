using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if FIREBASE_MODULE_ENABLE
/** 상수 - 파이어 베이스 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 기타
	public const string U_NODE_FIREBASE_USER_INFOS = "UserInfos";
	public const string U_NODE_FIREBASE_TARGET_INFOS = "TargetInfos";
	public const string U_NODE_FIREBASE_PURCHASE_INFOS = "PurchaseInfos";

	// 식별자
	public const string U_KEY_FIREBASE_M_INIT_CALLBACK = "FirebaseMInitCallback";
	public const string U_KEY_FIREBASE_M_LOGOUT_CALLBACK = "FirebaseMLogoutCallback";

#if FIREBASE_AUTH_ENABLE
	// 식별자 {
	public const string U_PROVIDER_ID_FIREBASE_M_APPLE_LOGIN = "apple.com";

	public const string U_KEY_FIREBASE_M_LOGIN_CALLBACK = "FirebaseMLoginCallback";
	public const string U_KEY_FIREBASE_M_RECEIVE_GAME_CENTER_CREDENTIAL_CALLBACK = "FirebaseMReceiveGameCenterCredentialCallback";
	// 식별자 }
#endif // #if FIREBASE_AUTH_ENABLE

#if FIREBASE_DB_ENABLE
	// 식별자
	public const string U_KEY_FIREBASE_M_LOAD_DATAS_CALLBACK = "FirebaseMLoadDatasCallback";
	public const string U_KEY_FIREBASE_M_SAVE_DATAS_CALLBACK = "FirebaseMSaveDatasCallback";
#endif // #if FIREBASE_DB_ENABLE

#if FIREBASE_MSG_ENABLE
	// 식별자
	public const string U_KEY_FIREBASE_M_TOKEN_CALLBACK = "FirebaseMTokenCallback";
	public const string U_KEY_FIREBASE_M_NOTI_MSG_CALLBACK = "FirebaseMNotiMsgCallback";
	public const string U_KEY_FIREBASE_M_LOAD_MSG_TOKEN_CALLBACK = "FirebaseMLoadMsgTokenCallback";
#endif // #if FIREBASE_MSG_ENABLE

#if FIREBASE_CONFIG_ENABLE
	// 식별자
	public const string U_KEY_FIREBASE_M_SETUP_DEF_CONFIGS_CALLBACK = "FirebaseMSetupDefConfigsCallback";
	public const string U_KEY_FIREBASE_M_LOAD_CONFIGS_CALLBACK = "FirebaseMLoadConfigsCallback";
#endif // #if FIREBASE_CONFIG_ENABLE

#if FIREBASE_STORAGE_ENABLE
	// 식별자
	public const string U_KEY_FIREBASE_M_LOAD_FILES_CALLBACK = "FirebaseMLoadFilesCallback";
#endif // #if FIREBASE_STORAGE_ENABLE
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 단위
	public static readonly System.TimeSpan U_TIMEOUT_FIREBASE_SESSION = new System.TimeSpan(0, 0, 60);
	#endregion // 런타임 상수
}
#endif // #if FIREBASE_MODULE_ENABLE
