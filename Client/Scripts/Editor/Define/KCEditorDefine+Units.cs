using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 단위 */
public static partial class KCEditorDefine
{
	#region 컴파일 상수
	// 태그
	public const int B_UNIT_CUSTOM_TAG_START_ID = 10;
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 에디터 윈도우
	public static readonly Vector3 B_MIN_SIZE_EDITOR_WND = new Vector3(350.0f, 350.0f, 0.0f);
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
