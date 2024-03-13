using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 플랫폼 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 유니티 메세지 전송자 {
	public const string B_KEY_UNITY_MS_APP_ID = "AppID";
	public const string B_KEY_UNITY_MS_VER = "Ver";
	public const string B_KEY_UNITY_MS_TIMEOUT = "Timeout";

	public const string B_KEY_UNITY_MS_ALERT_TITLE = "Title";
	public const string B_KEY_UNITY_MS_ALERT_MSG = "Msg";
	public const string B_KEY_UNITY_MS_ALERT_OK_BTN_TEXT = "OKBtnText";
	public const string B_KEY_UNITY_MS_ALERT_CANCEL_BTN_TEXT = "CancelBtnText";

	public const string B_KEY_UNITY_MS_MAIL_TITLE = "Title";
	public const string B_KEY_UNITY_MS_MAIL_MSG = "Msg";
	public const string B_KEY_UNITY_MS_MAIL_RECIPIENT = "Recipient";

	public const string B_KEY_UNITY_MS_VIBRATE_TYPE = "Type";
	public const string B_KEY_UNITY_MS_VIBRATE_STYLE = "Style";
	public const string B_KEY_UNITY_MS_VIBRATE_DURATION = "Duration";
	public const string B_KEY_UNITY_MS_VIBRATE_INTENSITY = "Intensity";

	public const string B_KEY_UNITY_MS_SEND_SHARE_MSG_CALLBACK = "UnityMSSendShareMsgCallback";
	public const string B_CLS_N_UNITY_MS_UNITY_MSG_RECEIVER = "lkstudio.dante.android.CAndroidPlugin";
	public const string B_FUNC_N_UNITY_MS_UNITY_MSG_HANDLER = "onReceiveUnityMsg";
	// 유니티 메세지 전송자 }

	// 디바이스 메세지 수신자 {
	public const string B_KEY_DEVICE_MR_VER = KCDefine.B_KEY_UNITY_MS_VER;
	public const string B_KEY_DEVICE_MR_RESULT = "Result";
	public const string B_KEY_FMT_DEVICE_MR_HANDLE_MSG_CALLBACK = "DeviceMRHandleMsgCallback_{0}";

	public const string B_FUNC_N_DEVICE_MR_MSG_HANDLER = "OnReceiveDeviceMsg";
	// 디바이스 메세지 수신자 }
	#endregion // 컴파일 상수
}
