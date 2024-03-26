using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.Globalization;

/** 확장 클래스 - 시간 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 문자열 => 시간으로 변환한다 */
	public static System.DateTime ExStrTimeToTime(this string a_oSender, string a_oFmt)
	{
		CFunc.Assert(a_oSender.ExIsValid() && a_oFmt.ExIsValid());
		return System.DateTime.ParseExact(a_oSender, a_oFmt, CultureInfo.InvariantCulture);
	}

	/** 시간 => 문자열로 변환한다 */
	public static string ExToStr(this System.DateTime a_stSender, string a_oFmt)
	{
		CFunc.Assert(a_stSender.ExIsValid());
		return a_stSender.ToString(a_oFmt, CultureInfo.InvariantCulture);
	}

	/** 시간 => 긴 문자열로 변환한다 */
	public static string ExToStrLong(this System.DateTime a_stSender, bool a_bIsEnableSlash = true)
	{
		CFunc.Assert(a_stSender.ExIsValid());

		return a_stSender.ExToStr(a_bIsEnableSlash ? 
			KCDefine.B_DATE_T_FMT_SLASH_YYYY_MM_DD_HH_MM_SS : KCDefine.B_DATE_T_FMT_YYYY_MM_DD_HH_MM_SS);
	}

	/** 시간 => 짧은 문자열로 변환한다 */
	public static string ExToStrShort(this System.DateTime a_stSender, bool a_bIsEnableSlash = true)
	{
		CFunc.Assert(a_stSender.ExIsValid());

		return a_stSender.ExToStr(a_bIsEnableSlash ? 
			KCDefine.B_DATE_T_FMT_SLASH_YYYY_MM_DD : KCDefine.B_DATE_T_FMT_YYYY_MM_DD);
	}

	/** 지역 시간 => PST 시간으로 변환한다 */
	public static System.DateTime ExToTimePST(this System.DateTime a_stSender)
	{
		CFunc.Assert(a_stSender.ExIsValid());
		return a_stSender.ToUniversalTime().AddHours(KCDefine.B_DELTA_T_UTC_TO_PST);
	}

	/** 지역 시간 => 특정 지역 시간으로 변환한다 */
	public static System.DateTime ExToTimeZone(this System.DateTime a_stSender, string a_oIDZoneTime)
	{
		CFunc.Assert(a_stSender.ExIsValid() && a_oIDZoneTime.ExIsValid());
		var stInfoZoneTime = System.TimeZoneInfo.FindSystemTimeZoneById(a_oIDZoneTime);

		return System.TimeZoneInfo.ConvertTime(a_stSender, System.TimeZoneInfo.Local, stInfoZoneTime);
	}

	/** PST 시간 => 지역 시간으로 변환한다 */
	public static System.DateTime ExPSTToTimeLocal(this System.DateTime a_stSender)
	{
		CFunc.Assert(a_stSender.ExIsValid());
		return a_stSender.AddHours(-KCDefine.B_DELTA_T_UTC_TO_PST).ToLocalTime();
	}

	/** 특정 지역 시간 => 지역 시간으로 변환한다 */
	public static System.DateTime ExZoneToTimeLocal(this System.DateTime a_stSender, string a_oIDZoneTime)
	{
		CFunc.Assert(a_stSender.ExIsValid() && a_oIDZoneTime.ExIsValid());
		var stInfoZoneTime = System.TimeZoneInfo.FindSystemTimeZoneById(a_oIDZoneTime);

		return System.TimeZoneInfo.ConvertTime(a_stSender, stInfoZoneTime, System.TimeZoneInfo.Local);
	}
	#endregion // 클래스 함수
}
