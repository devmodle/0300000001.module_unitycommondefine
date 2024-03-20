using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
using Unity.Linq;

/** 에디터 접근자 확장 클래스 - 게임 객체 */
public static partial class CEditorAccessExtension
{
	#region 클래스 접근 함수
	/** 정적 플래그를 변경한다 */
	public static void ExSetStaticEditorFlags(this GameObject a_oSender,
		StaticEditorFlags a_eFlags, bool a_bIsCascade = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 플래그 변경이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		GameObjectUtility.SetStaticEditorFlags(a_oSender, a_eFlags);

		// 계층 적용 모드가 아닐 경우
		if(!a_bIsCascade)
		{
			return;
		}

		foreach(var oObj in a_oSender.Descendants())
		{
			GameObjectUtility.SetStaticEditorFlags(oObj, a_eFlags);
		}
	}
	#endregion // 클래스 접근 함수
}
#endif // #if UNITY_EDITOR
