using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 경로 */
public static partial class KCDefine
{
	#region 프로퍼티
	public static string U_DATA_P_COMMON_APP_INFO => $"{KCDefine.B_DIR_P_WRITABLE}InfoAppCommon.bytes";
	public static string U_DATA_P_COMMON_USER_INFO => $"{KCDefine.B_DIR_P_WRITABLE}InfoUserCommon.bytes";
	public static string U_DATA_P_COMMON_GAME_INFO => $"{KCDefine.B_DIR_P_WRITABLE}InfoGameCommon.bytes";

#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
	public static string U_IMG_P_SCREENSHOT => $"{Application.identifier}/Screenshot.png";
#else
	public static string U_IMG_P_SCREENSHOT => $"{KCDefine.B_DIR_P_WRITABLE}Screenshot.png";
#endif // #if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)
	#endregion // 프로퍼티
}
