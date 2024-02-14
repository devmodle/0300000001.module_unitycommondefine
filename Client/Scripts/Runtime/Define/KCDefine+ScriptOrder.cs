using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 상수 - 스크립트 순서 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 스크립트 순서 {
	public const int B_SCRIPT_O_LATE = byte.MaxValue * 20;
	public const int B_SCRIPT_O_LATEST = byte.MaxValue * 30;
	public const int B_SCRIPT_O_INVALID = int.MaxValue;

	public const int B_SCRIPT_O_INIT_SCENE_MANAGER = byte.MaxValue * 10;
	public const int B_SCRIPT_O_SETUP_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 1;
	public const int B_SCRIPT_O_LATE_SETUP_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 2;

	public const int B_SCRIPT_O_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 10;
	public const int B_SCRIPT_O_LOADING_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 20;

	public const int B_SCRIPT_O_RESULT_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 100;
	public const int B_SCRIPT_O_OVERLAY_SCENE_MANAGER = KCDefine.B_SCRIPT_O_INIT_SCENE_MANAGER + 110;
	// 스크립트 순서 }
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR
