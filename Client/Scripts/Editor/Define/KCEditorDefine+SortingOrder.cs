using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 정렬 순서 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 순서 {
	public const int B_SORTING_O_UIS_MENU = 0;
	public const int B_SORTING_O_OBJS_MENU = 0;
	public const int B_SORTING_O_BUILD_MENU = 10000;

	public const int B_SORTING_O_SETUP_MENU = 20000;
	public const int B_SORTING_O_RESET_MENU = KCEditorDefine.B_SORTING_O_SETUP_MENU + 1;

	public const int B_SORTING_O_IMPORT_MENU = 30000;
	public const int B_SORTING_O_EXPORT_MENU = KCEditorDefine.B_SORTING_O_IMPORT_MENU + 1;

	public const int B_SORTING_O_CREATE_MENU = 40000;
	public const int B_SORTING_O_SUB_CREATE_MENU = KCEditorDefine.B_SORTING_O_CREATE_MENU + 1;

	public const int B_SORTING_O_EDITOR_WND_MENU = 50000;
	public const int B_SORTING_O_CHANGE_PLATFORM_MENU = KCEditorDefine.B_SORTING_O_EDITOR_WND_MENU + 1;
	// 순서 }
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR
