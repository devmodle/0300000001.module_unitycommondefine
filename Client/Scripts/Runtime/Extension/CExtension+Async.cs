using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 비동기 */
public static partial class CExtension
{
	#region 클래스 함수
	/** 함수를 지연 호출한다 */
	public static void ExLateCallFunc(this MonoBehaviour a_oSender,
		System.Action<MonoBehaviour> a_oCallback, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 지연 호출이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.StartCoroutine(a_oSender.ExCoLateCallFunc(a_oCallback));
	}

	/** 함수를 지연 호출한다 */
	public static void ExLateCallFunc(this MonoBehaviour a_oSender,
		System.Action<MonoBehaviour> a_oCallback, float a_fDelay, bool a_bIsRealtime = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 지연 호출이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.StartCoroutine(a_oSender.ExCoLateCallFunc(a_oCallback, a_fDelay, a_bIsRealtime));
	}

	/** 함수를 반복 호출한다 */
	public static void ExRepeatCallFunc(this MonoBehaviour a_oSender,
		System.Func<MonoBehaviour, bool, bool> a_oCallback, float a_fTimeDelta, float a_fMaxDeltaTime, bool a_bIsRealtime = false, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 지연 호출이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		var oEnumerator = a_oSender.ExCoRepeatCallFunc(a_oCallback,
			a_fTimeDelta, a_fMaxDeltaTime, a_bIsRealtime);

		a_oSender.StartCoroutine(oEnumerator);
	}
	#endregion // 클래스 함수
}

/** 확장 클래스 - 비동기 (코루틴) */
public static partial class CExtension
{
	#region 클래스 함수
	/** 함수를 지연 호출한다 */
	private static IEnumerator ExCoLateCallFunc(this MonoBehaviour a_oSender,
		System.Action<MonoBehaviour> a_oCallback)
	{
		CFunc.Assert(a_oSender != null);

		try
		{
			yield return CAccess.CoGetWaitForEndOfFrame();
		}
		finally
		{
			a_oCallback?.Invoke(a_oSender);
		}
	}

	/** 함수를 지연 호출한다 */
	private static IEnumerator ExCoLateCallFunc(this MonoBehaviour a_oSender,
		System.Action<MonoBehaviour> a_oCallback, float a_fDelay, bool a_bIsRealtime)
	{
		CFunc.Assert(a_oSender != null && a_fDelay.ExIsGreatEquals(KCDefine.B_VAL_0_REAL));

		try
		{
			yield return CAccess.CoGetWaitForSecs(a_fDelay, a_bIsRealtime);
		}
		finally
		{
			a_oCallback?.Invoke(a_oSender);
		}
	}

	/** 함수를 반복 호출한다 */
	private static IEnumerator ExCoRepeatCallFunc(this MonoBehaviour a_oSender,
		System.Func<MonoBehaviour, bool, bool> a_oCallback, float a_fTimeDelta, double a_dblMaxDeltaTime, bool a_bIsRealtime)
	{
		CFunc.Assert(a_oSender != null &&
			a_oCallback != null && a_fTimeDelta.ExIsGreatEquals(KCDefine.B_VAL_0_REAL));

		var stStartTime = System.DateTime.Now;

		do
		{
			yield return CAccess.CoGetWaitForSecs(a_fTimeDelta, a_bIsRealtime);

			// 반복 호출이 필요 없을 경우
			if(a_oCallback(a_oSender, false))
			{
				break;
			}
		} while(System.DateTime.Now.ExGetDeltaTime(stStartTime).ExIsLess(a_dblMaxDeltaTime));

		a_oCallback(a_oSender, true);
	}
	#endregion // 클래스 함수
}
