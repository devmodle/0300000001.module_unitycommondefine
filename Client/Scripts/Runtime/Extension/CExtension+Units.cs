using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 단위 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 값 => 왼쪽 쉬프트 비트로 변환한다 */
	public static int ExToLShiftBits(this int a_nSender, int a_nOffset)
	{
		CFunc.Assert(a_nOffset >= KCDefine.B_VAL_0_INT);
		return a_nSender << a_nOffset;
	}

	/** 값 => 오른쪽 쉬프트 비트로 변환한다 */
	public static int ExToRShiftBits(this int a_nSender, int a_nOffset)
	{
		CFunc.Assert(a_nOffset >= KCDefine.B_VAL_0_INT);
		return a_nSender >> a_nOffset;
	}

	/** 픽셀 => DPI 픽셀로 변환한다 */
	public static float ExPixelsToDPIPixels(this int a_nSender)
	{
		return a_nSender * (KCDefine.B_DEF_SCREEN_DPI / CAccess.ScreenDPI);
	}

	/** 픽셀 => DPI 픽셀로 변환한다 */
	public static float ExPixelsToDPIPixels(this float a_fSender)
	{
		return a_fSender * (KCDefine.B_DEF_SCREEN_DPI / CAccess.ScreenDPI);
	}

	/** 문자열 => 색상으로 변환한다 */
	public static Color ExColorStrToColor(this string a_oSender)
	{
		CFunc.Assert(a_oSender.ExIsValid());

		string oColorStr = a_oSender.Replace(KCDefine.B_TOKEN_SHARP, string.Empty);
		oColorStr = oColorStr.PadLeft(KCDefine.B_VAL_6_INT, char.Parse(KCDefine.B_STR_0_INT));
		oColorStr = string.Format(KCDefine.B_TEXT_FMT_2_COMBINE, KCDefine.B_TOKEN_SHARP, oColorStr);

		return ColorUtility.TryParseHtmlString(oColorStr, out Color stColor) ? stColor : Color.white;
	}

	/** 문자열 => 시간으로 변환한다 */
	public static System.DateTime ExTimeStrToTime(this string a_oSender, string a_oFmt)
	{
		CFunc.Assert(a_oSender.ExIsValid() && a_oFmt.ExIsValid());
		return System.DateTime.ParseExact(a_oSender, a_oFmt, CultureInfo.InvariantCulture);
	}
	#endregion // 클래스 함수
}
