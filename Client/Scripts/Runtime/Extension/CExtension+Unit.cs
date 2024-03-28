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
	public static int ExToBitsLShift(this int a_nSender, int a_nOffset)
	{
		CFunc.Assert(a_nOffset >= KCDefine.B_VAL_0_INT);
		return a_nSender << a_nOffset;
	}

	/** 값 => 오른쪽 쉬프트 비트로 변환한다 */
	public static int ExToBitsRShift(this int a_nSender, int a_nOffset)
	{
		CFunc.Assert(a_nOffset >= KCDefine.B_VAL_0_INT);
		return a_nSender >> a_nOffset;
	}

	/** 픽셀 => DPI 픽셀로 변환한다 */
	public static float ExPixelsToPixelsDPI(this int a_nSender)
	{
		return a_nSender * (KCDefine.B_DEF_SCREEN_DPI / CAccess.ScreenDPI);
	}

	/** 픽셀 => DPI 픽셀로 변환한다 */
	public static float ExPixelsToPixelsDPI(this float a_fSender)
	{
		return a_fSender * (KCDefine.B_DEF_SCREEN_DPI / CAccess.ScreenDPI);
	}
	#endregion // 클래스 함수
}
