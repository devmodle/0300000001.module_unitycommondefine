using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 계층 */
public static partial class KCEditorDefine
{
	#region 컴파일 상수
	// 단위
	public const float G_HIERARCHY_OFFSET_TEXT = 15.0f;
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 색상
	public static readonly Color G_HIERARCHY_COLOR_TEXT = new Color(1.0f, 0.27f, 0.0f, 1.0f);
	public static readonly Color G_HIERARCHY_COLOR_OUTLINE = Color.black;
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
