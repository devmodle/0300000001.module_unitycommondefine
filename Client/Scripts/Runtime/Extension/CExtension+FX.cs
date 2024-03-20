using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 효과 (라인) */
public static partial class CExtension
{
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this LineRenderer a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.useWorldSpace = false;
		a_oSender.alignment = LineAlignment.TransformZ;
		a_oSender.textureMode = LineTextureMode.Tile;
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - 효과 (파티클) */
public static partial class CExtension
{
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this ParticleSystem a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		var oParent = a_oSender.transform.parent;
		var oLayoutGroupInParent = oParent.GetComponentInParent<ParticleSystem>();

		var oMainModule = a_oSender.main;
		oMainModule.prewarm = true;
		oMainModule.playOnAwake = false;

		oMainModule.cullingMode = ParticleSystemCullingMode.Automatic;
		oMainModule.scalingMode = ParticleSystemScalingMode.Hierarchy;

		oMainModule.stopAction = (oLayoutGroupInParent != null) ? 
			ParticleSystemStopAction.None : ParticleSystemStopAction.Callback;
	}

	/** 파티클을 실행한다 */
	public static void ExPlay(this ParticleSystem a_oSender, 
		ParticleSystemStopBehavior a_eStopBehavior = ParticleSystemStopBehavior.StopEmittingAndClear, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 파티클 실행이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.Stop(true, a_eStopBehavior);
		a_oSender.Play(true);
	}
	#endregion // 클래스 함수
}
