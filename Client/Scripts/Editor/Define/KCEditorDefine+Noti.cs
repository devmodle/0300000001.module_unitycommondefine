using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && NOTI_MODULE_ENABLE
using Unity.Notifications.iOS;

/** 에디터 상수 - 알림 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 기타
	public const PresentationOption B_PRESENT_OPTS_REMOTE_NOTI = PresentationOption.Alert | PresentationOption.Badge | PresentationOption.Sound;
	public const AuthorizationOption B_PRESENT_OPTS_AUTHORIZATION_NOTI = AuthorizationOption.Alert | AuthorizationOption.Badge | AuthorizationOption.Sound;
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR && NOTI_MODULE_ENABLE
