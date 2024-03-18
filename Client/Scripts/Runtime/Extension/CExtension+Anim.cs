using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using DG.Tweening;

/** 확장 클래스 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 효과를 실행한다 */
	public static void ExPlay(this Animation a_oSender, PlayMode a_ePlayMode = PlayMode.StopAll, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 애니메이션이 존재 할 경우
		if(a_oSender != null)
		{
			a_oSender.Stop();
			a_oSender.Play(a_ePlayMode);
		}
	}
	#endregion // 클래스 함수
}
