using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 단위 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 기타 {
	public const int B_IDX_INVALID = -1;

	public const int B_COMPARE_LESS = -1;
	public const int B_COMPARE_GREAT = 1;
	public const int B_COMPARE_EQUALS = 0;
	// 기타 }

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

	// 변환 {
	public const int B_UNIT_BITS_PER_BYTE = 8;
	public const int B_UNIT_BYTES_PER_KILO_BYTE = 1024;
	public const int B_UNIT_BYTES_PER_MEGA_BYTE = 1024 * 1024;

	public const int B_UNIT_SECS_PER_HOUR = 360;
	public const int B_UNIT_SECS_PER_MINUTE = 60;
	public const int B_UNIT_MILLI_SECS_PER_SEC = 1000;
	public const int B_UNIT_MICRO_SECS_PER_SEC = 1000000;

	public const int B_UNIT_CENTI_METER = 100;
	public const int B_UNIT_NORM_VAL_TO_PERCENT = 100;

	public const int B_UNIT_DIGITS_TEN = 10;
	public const int B_UNIT_DIGITS_HUNDRED = 100;
	public const int B_UNIT_DIGITS_THOUSAND = 1000;
	public const int B_UNIT_DIGITS_TEN_THOUSAND = 10000;
	public const int B_UNIT_DIGITS_HUNDRED_THOUSAND = 100000;
	// 변환 }

	// 해상도 {
	public const float B_UNIT_SCALE = 1.0f / (float)KCDefine.B_UNIT_CENTI_METER;
	public const float B_UNIT_LIGHTMAP_RESOLUTION = 1.0f;

	public const float B_UNIT_PIXELS_PER_UNIT = 1.0f;
	public const float B_UNIT_REF_PIXELS_PER_UNIT = KCDefine.B_UNIT_PIXELS_PER_UNIT;
	// 해상도 }

	// 식별자 {
	public const int B_UNIT_IDS_PER_IDS_01 = 1;
	public const int B_UNIT_IDS_PER_IDS_02 = 10000;
	public const int B_UNIT_IDS_PER_IDS_03 = 10000000;

	public const int B_UNIT_KINDS_PER_TYPE = 100000000;
	public const int B_UNIT_KINDS_PER_SUB_TYPE = 10000000;
	public const int B_UNIT_KINDS_PER_KINDS_TYPE = 100000;
	public const int B_UNIT_KINDS_PER_SUB_KINDS_TYPE = 100;
	// 식별자 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 기타 {
	public static readonly string B_IDX_INVALID_STR = $"{KCDefine.B_IDX_INVALID}";
	
	public static readonly Vector3 B_SIZE_BANNER_ADS = new Vector3(320.0f, 50.0f, 0.0f);
	public static readonly Vector3 B_MIN_SIZE_ALERT_POPUP = new Vector3(400.0f, 300.0f, 0.0f);

	public static readonly Rect B_RECT_DEF = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
	public static readonly Rect B_RECT_CAMERA_VIEWPORT = KCDefine.B_RECT_DEF;
	// 기타 }
	#endregion // 런타임 상수
}
