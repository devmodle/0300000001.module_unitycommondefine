using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if GAME_CENTER_MODULE_ENABLE
/** 상수 - 게임 센터 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 식별자 {
	public const string U_KEY_GAME_CM_INIT_CALLBACK = "GameCMInitCallback";
	public const string U_KEY_GAME_CM_LOGIN_CALLBACK = "GameCMLoginCallback";
	public const string U_KEY_GAME_CM_LOGOUT_CALLBACK = "GameCMLogoutCallback";

	public const string U_KEY_GAME_CM_UPDATE_RECORD_CALLBACK = "GameCMUpdateRecordCallback";
	public const string U_KEY_GAME_CM_UPDATE_ACHIEVEMENT_CALLBACK = "GameCMUpdateAchievementCallback";
	public const string U_KEY_GAME_CM_RECEIVE_SERVER_SIDE_ACCESS_RESULT_CALLBACK = "GameCMReceiveServerSideAccessResultCallback";
	// 식별자 }
	#endregion // 컴파일 상수
}
#endif // #if GAME_CENTER_MODULE_ENABLE
