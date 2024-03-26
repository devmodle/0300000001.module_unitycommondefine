using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 상수 - 스크립트 순서 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 스크립트 순서 {
	public const int G_SCRIPT_O_LATE = byte.MaxValue * 20;
	public const int G_SCRIPT_O_LATEST = byte.MaxValue * 30;
	public const int G_SCRIPT_O_INVALID = int.MaxValue;

	public const int G_SCRIPT_O_MANAGER_SCENE_INIT = byte.MaxValue * 10;
	public const int G_SCRIPT_O_MANAGER_SCENE_SETUP = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 1;
	public const int G_SCRIPT_O_MANAGER_SCENE_SETUP_LATE = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 2;

	public const int G_SCRIPT_O_MANAGER_SCENE = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 10;
	public const int G_SCRIPT_O_MANAGER_SCENE_LOADING = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 20;

	public const int G_SCRIPT_O_MANAGER_SCENE_RESULT = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 100;
	public const int G_SCRIPT_O_MANAGER_SCENE_OVERLAY = KCDefine.G_SCRIPT_O_MANAGER_SCENE_INIT + 110;
	// 스크립트 순서 }
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR
