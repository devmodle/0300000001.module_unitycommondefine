using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if FACEBOOK_MODULE_ENABLE
/** 상수 - 페이스 북 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 식별자 {
	public const string B_KEY_FACEBOOK_M_INIT_CALLBACK = "FacebookMInitCallback";

	public const string B_KEY_FACEBOOK_M_LOGIN_CALLBACK = "FacebookMLoginCallback";
	public const string B_KEY_FACEBOOK_M_LOGOUT_CALLBACK = "FacebookMLogoutCallback";

	public const string B_KEY_FACEBOOK_M_VIEW_STATE_SHOW_CALLBACK = "FacebookMViewStateShowCallback";
	public const string B_KEY_FACEBOOK_M_VIEW_STATE_CLOSE_CALLBACK = "FacebookMViewStateCloseCallback";
	// 식별자 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 식별자
	public static readonly List<string> B_KEY_FACEBOOK_PERMISSION_LIST = new List<string>() {
		"public_profile"
	};
	#endregion // 런타임 상수
}
#endif // #if FACEBOOK_MODULE_ENABLE
