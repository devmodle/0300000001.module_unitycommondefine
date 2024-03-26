using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build;

/** 에디터 상수 - 에셋 임포터 */
public static partial class KCDefineEditor
{
	#region 런타임 상수
	// 이름
	public static List<string> G_IMPORTER_LIST_NAME_PLATFORM = new List<string>()
	{
		NamedBuildTarget.iOS.TargetName, 
		NamedBuildTarget.Android.TargetName, 
		NamedBuildTarget.Standalone.TargetName
	};
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
