using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build;

/** 에디터 상수 - 입력 시스템 */
public static partial class KCEditorDefine {
	#region 런타임 상수
	// 기타 {
	public static List<string> B_AUDIO_IMPORTER_PLATFORM_NAME_LIST = new List<string>() {
		NamedBuildTarget.iOS.TargetName, NamedBuildTarget.Android.TargetName, NamedBuildTarget.Standalone.TargetName
	};

	public static List<string> B_TEX_IMPORTER_PLATFORM_NAME_LIST = new List<string>() {
		NamedBuildTarget.iOS.TargetName, NamedBuildTarget.Android.TargetName, NamedBuildTarget.Standalone.TargetName
	};
	// 기타 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
