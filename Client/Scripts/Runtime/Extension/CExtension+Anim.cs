using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 애니메이션 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 애니메이션을 재생한다 */
	public static void ExPlay(this Animation a_oSender, PlayMode a_ePlayMode = PlayMode.StopAll, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 애니메이션 재생이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.Stop();
		a_oSender.Play(a_ePlayMode);
	}
	#endregion // 클래스 함수
}
