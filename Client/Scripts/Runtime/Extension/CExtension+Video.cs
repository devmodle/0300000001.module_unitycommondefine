using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using UnityEngine.Video;

/** 확장 클래스 - 비디오 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 비디오를 실행한다 */
	public static void ExPlay(this VideoPlayer a_oSender, VideoClip a_oClip, bool a_bIsLoop, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oClip != null));

		// 비디오 실행이 불가능 할 경우
		if(a_oSender == null || a_oClip == null)
		{
			return;
		}

		a_oSender.clip = a_oClip;
		a_oSender.loop = a_bIsLoop;

		a_oSender.Play();
	}
	#endregion // 클래스 함수
}
