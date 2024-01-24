using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 커맨드 라인 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 기타 {
	public const string B_CMD_LINE_PARAMS_FMT_SHELL = "-c \"{0}\"";
	public const string B_CMD_LINE_PARAMS_FMT_CMD_PROMPT = "/c \"{0}\"";

	public const string B_BUILD_CMD_INTEL_EXPORT_PATH = "export PATH=\"${PATH}:/usr/local/bin\"";
	public const string B_BUILD_CMD_SILICON_EXPORT_PATH = "export PATH=\"${PATH}:/opt/homebrew/bin\"";
	// 기타 }
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR
