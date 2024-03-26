using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 에디터 옵션 */
public static partial class KCDefineEditor
{
	#region 컴파일 상수
	// 기타 {
	public const string G_OPTS_EDITOR_COMPRESSION_REMOTE = "JPEG";
	public const string G_OPTS_EDITOR_RESOLUTION_REMOTE = "Downsize";
	public const string G_OPTS_EDITOR_CONTROL_VER = "Visible Meta Files";
	public const string G_OPTS_EDITOR_SRC_JOYSTIC = "Remote";

#if UNITY_IOS
	public const string G_OPTS_EDITOR_DEVICE_REMOTE = "Any iOS Device";
#elif UNITY_ANDROID
	public const string G_OPTS_EDITOR_DEVICE_REMOTE = "Any Android Device";
#else
	public const string G_OPTS_EDITOR_DEVICE_REMOTE = "None";
#endif // #if UNITY_IOS
	// 기타 }

	// 단위
	public const float G_OPTS_EDITOR_PERCENT_BORDER_CASCADE = 0.35f;
	public const float G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_2 = 0.15f;
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 기타
	public static readonly List<string> G_OPTS_EDITOR_LIST_EXTENSION = new List<string>()
	{
		"txt", "xml", "fnt", "cd", "asmdef", "rsp", "asmref"
	};

	// 단위
	public static readonly Vector2 G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_3 = new Vector2(KCDefineEditor.G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_2, KCDefineEditor.G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_2 + (0.1f * 2.0f));
	public static readonly Vector3 G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_4 = new Vector3(KCDefineEditor.G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_2, KCDefineEditor.G_OPTS_EDITOR_PERCENT_CASCADE_SPLIT_2 + (0.1f * 2.0f), 0.15f + (0.1f * 2.0f) + (0.1f * 3.0f));
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
