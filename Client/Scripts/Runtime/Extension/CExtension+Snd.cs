using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 사운드 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 사운드를 실행한다 */
	public static void ExPlay(this AudioSource a_oSender, AudioClip a_oClip, bool a_bIsLoop, bool a_bIs3DSnd, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oClip != null));

		// 사운드 실행이 불가능 할 경우
		if(a_oSender == null || a_oClip == null)
		{
			return;
		}

		a_oSender.clip = a_oClip;
		a_oSender.loop = a_bIsLoop;

		a_oSender.spread = a_bIs3DSnd ? KCDefine.B_ANGLE_360_DEG : KCDefine.B_ANGLE_0_DEG;
		a_oSender.dopplerLevel = a_bIs3DSnd ? KCDefine.B_VAL_1_REAL : KCDefine.B_VAL_0_REAL;
		a_oSender.spatialBlend = a_bIs3DSnd ? KCDefine.B_VAL_1_REAL : KCDefine.B_VAL_0_REAL;
		a_oSender.reverbZoneMix = a_bIs3DSnd ? KCDefine.B_VAL_1_REAL : KCDefine.B_VAL_0_REAL;

		a_oSender.Play();
	}
	#endregion // 클래스 함수
}
