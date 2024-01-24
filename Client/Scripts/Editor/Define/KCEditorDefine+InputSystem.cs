using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && INPUT_SYSTEM_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 입력 시스템 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 이름
	public const string B_MODULE_N_INPUT_SYSTEM_SETTINGS = "com.unity.input.settings";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로
	public static readonly string B_ASSET_P_INPUT_SETTINGS = $"{KCEditorDefine.B_DIR_P_ASSETS}InputSystem.inputsettings.asset";
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && INPUT_SYSTEM_MODULE_ENABLE
