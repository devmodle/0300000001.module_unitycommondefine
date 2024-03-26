using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 접근자 확장 클래스 - 효과 (라인) */
public static partial class CExtensionAccess
{
	#region 클래스 접근 함수
	/** 너비를 변경한다 */
	public static void ExSetWidth(this LineRenderer a_oSender, 
		float a_fSrcWidth, float a_fDestWidth, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 너비 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.startWidth = a_fSrcWidth;
		a_oSender.endWidth = a_fDestWidth;
	}

	/** 색상을 변경한다 */
	public static void ExSetColor(this LineRenderer a_oSender, 
		Color a_stSrcColor, Color a_stEndColor, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 색상 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.startColor = a_stSrcColor;
		a_oSender.endColor = a_stEndColor;
	}

	/** 위치를 설정한다 */
	public static void ExSetPositions(this LineRenderer a_oSender, List<Vector3> a_oPosList, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oPosList != null));

		// 위치 설정이 불가능 할 경우
		if(a_oSender == null || a_oPosList == null)
		{
			return;
		}

		a_oSender.positionCount = a_oPosList.Count;
		a_oSender.SetPositions(a_oPosList.ToArray());
	}
	#endregion // 클래스 접근 함수
}

/** 접근자 확장 클래스 - 효과 (파티클) */
public static partial class CExtensionAccess
{
	#region 클래스 접근 함수
	/** 색상을 변경한다 */
	public static void ExSetStartColor(this ParticleSystem a_oSender,
		Color a_stMinColor, Color a_stMaxColor, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 색상 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		var oMainModule = a_oSender.main;
		oMainModule.startColor = new ParticleSystem.MinMaxGradient(a_stMinColor, a_stMaxColor);
	}

	/** 정렬 순서를 변경한다 */
	public static void ExSetSortingOrder(this ParticleSystem a_oSender, 
		STSortingOrderInfo a_stOrderInfo, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_stOrderInfo.m_oLayer.ExIsValid()));

		// 순서 변경이 불가능 할 경우
		if(a_oSender == null || !a_stOrderInfo.m_oLayer.ExIsValid())
		{
			return;
		}

		var oRenderer = a_oSender.GetComponent<ParticleSystemRenderer>();
		oRenderer?.ExSetSortingOrder(a_stOrderInfo, a_bIsAssert);
	}
	#endregion // 클래스 접근 함수
}
