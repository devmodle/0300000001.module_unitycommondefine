using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 에디터 옵션 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 기타 {
	public const string B_EDITOR_OPTS_REMOTE_COMPRESSION = "JPEG";
	public const string B_EDITOR_OPTS_REMOTE_RESOLUTION = "Downsize";
	public const string B_EDITOR_OPTS_VER_CONTROL = "Visible Meta Files";
	public const string B_EDITOR_OPTS_JOYSTIC_SRC = "Remote";

#if UNITY_IOS
	public const string B_EDITOR_OPTS_REMOTE_DEVICE = "Any iOS Device";
#elif UNITY_ANDROID
	public const string B_EDITOR_OPTS_REMOTE_DEVICE = "Any Android Device";
#else
	public const string B_EDITOR_OPTS_REMOTE_DEVICE = "None";
#endif // #if UNITY_IOS
	// 기타 }

	// 단위
	public const float B_EDITOR_OPTS_CASCADE_BORDER_PERCENT = 0.15f;
	public const float B_EDITOR_OPTS_CASCADE_2_SPLIT_PERCENT = 0.15f;
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 기타
	public static readonly List<string> B_EDITOR_OPTS_EXTENSION_LIST = new List<string>() {
		"txt", "xml", "fnt", "cd", "asmdef", "rsp", "asmref"
	};

	// 단위
	public static readonly Vector2 B_EDITOR_OPTS_CASCADE_3_SPLIT_PERCENT = new Vector2(0.15f, 0.15f + (0.1f * 2.0f));
	public static readonly Vector3 B_EDITOR_OPTS_CASCADE_4_SPLIT_PERCENT = new Vector3(0.15f, 0.15f + (0.1f * 2.0f), 0.15f + (0.1f * 2.0f) + (0.1f * 3));
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
