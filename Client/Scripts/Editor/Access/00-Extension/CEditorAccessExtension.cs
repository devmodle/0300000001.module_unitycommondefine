using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using Unity.Linq;

/** 에디터 접근자 확장 클래스 */
public static partial class CEditorAccessExtension
{
	#region 클래스 함수
	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this EBuildMode a_eSender)
	{
		return a_eSender > EBuildMode.NONE && a_eSender < EBuildMode.MAX_VAL;
	}

	/** 유효 여부를 검사한다 */
	public static bool ExIsValid(this BuildTarget a_eSender)
	{
		bool bIsMobile = a_eSender == BuildTarget.iOS || a_eSender == BuildTarget.Android;
		bool bIsDesktop = a_eSender == BuildTarget.StandaloneOSX || a_eSender == BuildTarget.StandaloneWindows || a_eSender == BuildTarget.StandaloneWindows64;

		return bIsMobile || bIsDesktop;
	}

	/** 성공 완료 여부를 검사한다 */
	public static bool ExIsCompleteSuccess(this Request a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		return a_oSender.IsCompleted && a_oSender.Status == StatusCode.Success;
	}
	#endregion // 클래스 함수
}
#endif // #if UNITY_EDITOR
