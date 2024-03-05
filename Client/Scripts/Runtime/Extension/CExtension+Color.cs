using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 색상 */
public static partial class CExtension {
	#region 클래스 함수
	/** 색상 => 값으로 변환한다 */
	public static long ExToColorVal(this Color a_stColor, bool a_bIsEnableAlpha = true) {
		long nRVal = (long)(a_stColor.r * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_2_INT);
		long nGVal = (long)(a_stColor.g * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_1_INT);
		long nBVal = (long)(a_stColor.b * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_0_INT);
		long nAVal = KCDefine.B_VAL_0_INT;

		// 알파 채널 모드 일 경우
		if(a_bIsEnableAlpha) {
			nRVal = (long)(a_stColor.r * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_3_INT);
			nGVal = (long)(a_stColor.g * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_2_INT);
			nBVal = (long)(a_stColor.b * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_1_INT);
			nAVal = (long)(a_stColor.a * byte.MaxValue) << (KCDefine.B_VAL_8_INT * KCDefine.B_VAL_0_INT);
		}

		return nRVal | nGVal | nBVal | nAVal;
	}

	/** 색상 => 누적 값으로 변환한다 */
	public static float ExToColorSumVal(this Color a_stColor, bool a_bIsEnableAlpha = true) {
		float fSumVal = a_stColor.r + a_stColor.g + a_stColor.b;
		return a_bIsEnableAlpha ? fSumVal + a_stColor.a : fSumVal;
	}

	/** 색상 => 문자열로 변환한다 */
	public static string ExToColorStr(this Color a_stSender, bool a_bIsEnableAlpha = true) {
		return a_bIsEnableAlpha ? ColorUtility.ToHtmlStringRGBA(a_stSender) : ColorUtility.ToHtmlStringRGB(a_stSender);
	}
	#endregion // 클래스 함수
}
