using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if NOTI_MODULE_ENABLE
#if UNITY_IOS
using Unity.Notifications.iOS;
#elif UNITY_ANDROID
using Unity.Notifications.Android;
#endif // #if UNITY_IOS

/** 상수 - 알림 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 단위
	public const float G_NOTI_M_INTERVAL_CHECK_REQUEST = 0.15f;
	public const float G_NOTI_M_INTERVAL_CHECK_REQUEST_MAX = 0.5f;

	// 식별자
	public const string G_NOTI_M_KEY_CALLBACK_INIT = "NotiMCallbackInit";

#if UNITY_IOS
	// 기타
	public const PresentationOption G_NOTI_M_OPTS_PRESENTATION = PresentationOption.Alert | PresentationOption.Sound;
	public const AuthorizationOption G_NOTI_M_OPTS_AUTHORIZATION = AuthorizationOption.Alert | AuthorizationOption.Badge | AuthorizationOption.Sound;
#elif UNITY_ANDROID
	// 기타
	public const string G_NOTI_M_NAME_GROUP_NOTI = "NotiMGroupNoti";
	public const string G_NOTI_M_DESC_GROUP_NOTI = KCDefine.G_NOTI_M_NAME_GROUP_NOTI;
#endif // #if UNITY_IOS
	#endregion // 컴파일 상수
}
#endif // #if NOTI_MODULE_ENABLE
