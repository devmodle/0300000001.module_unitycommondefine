using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using System.Diagnostics;
using UnityEditor;

/** 에디터 함수 - 커맨드 라인 */
public static partial class CFuncEditor
{
	#region 클래스 함수
	/** 커맨드 라인을 실행한다 */
	public static void ExecuteCmdLine(string a_oParams, bool a_bIsAsync = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oParams.ExIsValid());

		// 매개 변수가 유효 할 경우
		if(a_oParams.ExIsValid())
		{
#if UNITY_EDITOR_WIN
			string oParams = string.Format(KCDefineEditor.B_CMD_LINE_PARAMS_FMT_CMD_PROMPT, a_oParams);
			CFuncEditor.ExecuteCmdLine(KCDefineEditor.B_TOOL_P_CMD_PROMPT, oParams, a_bIsAsync, a_bIsAssert);
#else
			string oPath = CAccessEditor.IsAppleMSeries ? 
				KCDefineEditor.B_BUILD_CMD_SILICON_EXPORT_PATH : KCDefineEditor.B_BUILD_CMD_INTEL_EXPORT_PATH;

			string oParams = string.Format(KCDefine.B_TEXT_FMT_2_SEMI_COLON_COMBINE, oPath, a_oParams);
			oParams = string.Format(KCDefineEditor.B_CMD_LINE_PARAMS_FMT_SHELL, oParams);

			CFuncEditor.ExecuteCmdLine(KCDefineEditor.B_TOOL_P_SHELL, oParams, a_bIsAsync, a_bIsAssert);
#endif // #if UNITY_EDITOR_WIN
		}
	}
	#endregion // 클래스 함수
}

/** 에디터 함수 - 커맨드 라인 (Private) */
public static partial class CFuncEditor
{
	#region 클래스 함수
	/** 커맨드 라인을 실행한다 */
	private static void ExecuteCmdLine(string a_oPathFile, string a_oParams, bool a_bIsAsync = true, bool a_bIsAssert = true)
	{
		CFunc.ShowLog($"CFuncEditor.ExecuteCmdLine: {a_oPathFile}, {a_oParams}");
		CFunc.Assert(!a_bIsAssert || (a_oPathFile.ExIsValid() && a_oParams.ExIsValid()));

		// 실행이 불가능 할 경우
		if(!a_oPathFile.ExIsValid() || !a_oParams.ExIsValid())
		{
			return;
		}

		var oProcess = Process.Start(CFactoryEditor.MakeProcessStartInfo(a_oPathFile, a_oParams));

		// 동기 모드 일 경우
		if(!a_bIsAsync)
		{
			oProcess?.WaitForExit();
		}
	}
	#endregion // 클래스 함수
}
#endif // #if UNITY_EDITOR
