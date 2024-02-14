using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_IOS
using UnityEngine.iOS;

/** 상수 - iOS */
public static partial class KCDefine {
	#region 컴파일 상수
	// 이름
	public const string B_MODEL_N_IPAD = "iPad";
	public const string B_MODEL_N_IPHONE = "iPhone";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 버전
	public static readonly System.Version B_MIN_VER_HAPTIC_FEEDBACK = new System.Version(10, 0, 0);
	public static readonly System.Version B_MIN_VER_TRACKING_CONSENT_VIEW = new System.Version(14, 0, 0);
	#endregion // 런타임 상수
}
#endif // #if UNITY_IOS
