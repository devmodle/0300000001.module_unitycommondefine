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
	public const float B_DELTA_T_NOTI_M_REQUEST_CHECK = 0.15f;
	public const float B_MAX_DELTA_T_NOTI_M_REQUEST_CHECK = 0.5f;

	// 식별자
	public const string B_KEY_NOTI_M_INIT_CALLBACK = "NotiMInitCallback";

#if UNITY_IOS
	// 기타
	public const PresentationOption B_OPTS_PRESENTATION = PresentationOption.Alert | PresentationOption.Sound;
	public const AuthorizationOption B_OPTS_AUTHORIZATION = AuthorizationOption.Alert | AuthorizationOption.Badge | AuthorizationOption.Sound;
#elif UNITY_ANDROID
	// 기타
	public const string B_GROUP_N_NOTI = "NotiMNotiGroup";
	public const string B_GROUP_DESC_NOTI = KCDefine.B_GROUP_N_NOTI;
#endif // #if UNITY_IOS
	#endregion // 컴파일 상수
}
#endif // #if NOTI_MODULE_ENABLE
