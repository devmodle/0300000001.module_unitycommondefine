using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 단위 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 기타
	public const int B_COMPARE_LESS = -1;
	public const int B_COMPARE_GREAT = 1;
	public const int B_COMPARE_EQUALS = 0;

	// 횟수 {
	public const int B_TIMES_INT_ONCE = 1;
	public const int B_TIMES_INT_INFINITE = -1;

	public const uint B_TIMES_UINT_ONCE = 1;
	public const uint B_TIMES_UINT_INFINITE = uint.MaxValue;
	// 횟수 }

	// 시간 {
	public const float B_DELTA_T_INFINITE = float.MaxValue;
	public const float B_DELTA_T_INTERMEDIATE = float.Epsilon;

	public const float B_DELTA_T_ASYNC_TASK = 0.15f;
	public const float B_DELTA_T_ASYNC_OPERATION = 0.15f;
	public const float B_MAX_DELTA_T_TRACKING_CONSENT_VIEW = 2.5f;

	public const double B_DELTA_T_UTC_TO_PST = -8.0;
	// 시간 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 기타 {
	public static readonly Vector3 U_SIZE_BANNER_ADS = new Vector3(320.0f, 50.0f, 0.0f);
	public static readonly Vector3 U_MIN_SIZE_ALERT_POPUP = new Vector3(400.0f, 300.0f, 0.0f);
	
	public static readonly Rect U_RECT_CAMERA_VIEWPORT = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
	// 기타 }
	#endregion // 런타임 상수
}
