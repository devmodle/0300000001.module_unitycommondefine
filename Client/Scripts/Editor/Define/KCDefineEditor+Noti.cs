using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && NOTI_MODULE_ENABLE
using UnityEditor;
using Unity.Notifications.iOS;

/** 에디터 상수 - 알림 */
public static partial class KCDefineEditor
{
	#region 컴파일 상수
	// 기타
	public const PresentationOption B_PRESENT_OPTS_REMOTE_NOTI = PresentationOption.Alert | PresentationOption.Badge | PresentationOption.Sound;
	public const AuthorizationOption B_PRESENT_OPTS_AUTHORIZATION_NOTI = AuthorizationOption.Alert | AuthorizationOption.Badge | AuthorizationOption.Sound;
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로 {
	public static readonly string B_DATA_P_NOTI_PROJ_PROPERTIES = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}/CustomAndroidLibrary.androidlib/project.properties";
	public static readonly string B_DATA_P_NOTI_ANDROID_MANIFEST = $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}/CustomAndroidLibrary.androidlib/AndroidManifest.xml";

	public static readonly List<(string, string)> B_NOTI_ICON_P_INFO_LIST = new List<(string, string)>() {
		($"{KCDefineEditor.B_ABS_DIR_P_UNITY_PROJ_RESOURCES}{KCDefineEditor.B_ICON_P_ANDROID_NOTI_96x96}.png", $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}/CustomAndroidLibrary.androidlib/res/drawable/{KCDefine.U_ICON_N_ANDROID_NOTI_SMALL}.png"),
		($"{KCDefineEditor.B_ABS_DIR_P_UNITY_PROJ_RESOURCES}{KCDefineEditor.B_ICON_P_ANDROID_APP_192x192}.png", $"{KCDefineEditor.B_ABS_DIR_P_ANDROID_PLUGINS}/CustomAndroidLibrary.androidlib/res/drawable/{KCDefine.U_ICON_N_ANDROID_NOTI_LARGE}.png")
	};
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && NOTI_MODULE_ENABLE
