using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 함수 - 메세지 */
public static partial class CFunc
{
	#region 클래스 함수
	/** 메세지를 전송한다 */
	public static void SendMsg(string a_oName,
		string a_oFuncName, object a_oParams = null, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oName.ExIsValid() && a_oFuncName.ExIsValid()));

		// 메세지 전송이 불가능 할 경우
		if(!a_oName.ExIsValid() || !a_oFuncName.ExIsValid())
		{
			return;
		}

		CFunc.FindObj(a_oName)?.ExSendMsg(string.Empty, a_oFuncName, a_oParams, a_bIsAssert);
	}

	/** 메세지를 전송한다 */
	public static void BroadcastMsg(string a_oFuncName, object a_oParams = null, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oFuncName.ExIsValid());

		// 메세지 전송이 불가능 할 경우
		if(!a_oFuncName.ExIsValid())
		{
			return;
		}

		CAccess.EnumerateScenes((a_stScene) =>
		{
			a_stScene.ExBroadcastMsg(a_oFuncName, a_oParams, a_bIsAssert);
			return true;
		});
	}
	#endregion // 클래스 함수
}
