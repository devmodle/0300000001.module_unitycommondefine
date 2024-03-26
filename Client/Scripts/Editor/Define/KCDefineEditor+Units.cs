using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 단위 */
public static partial class KCDefineEditor
{
	#region 런타임 상수
	// 에디터 윈도우
	public static readonly Vector3 G_SIZE_WND_EDITOR_MIN = new Vector3(350.0f, 350.0f, 0.0f);
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
