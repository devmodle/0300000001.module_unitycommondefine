using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using DG.Tweening;

/** 확장 클래스 - 애니메이션 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 애니메이션을 실행한다 */
	public static void ExPlay(this Animation a_oSender, PlayMode a_ePlayMode = PlayMode.StopAll, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 애니메이션 실행이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.Stop();
		a_oSender.Play(a_ePlayMode);
	}

	/** 애니메이션을 시작한다 */
	public static void ExStartAnim(this DOTweenAnimation a_oSender, 
		UnityAction a_oCallback, UnityAction a_oStepCallback = null, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 애니메이션 시작이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.hasOnComplete = true;
		a_oSender.hasOnStepComplete = true;

		a_oSender.onComplete.RemoveAllListeners();
		a_oSender.onComplete.AddListener(a_oCallback);

		a_oSender.onStepComplete.RemoveAllListeners();
		a_oSender.onStepComplete.AddListener(a_oStepCallback);

		a_oSender.CreateTween(true);
	}
	#endregion // 클래스 함수
}
