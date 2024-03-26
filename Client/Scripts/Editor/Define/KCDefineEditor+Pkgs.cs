using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 패키지 */
public static partial class KCDefineEditor
{
	#region 컴파일 상수
	// 식별자
	public const string B_UNITY_PKGS_ID_FMT = "{0}@{1}";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 이름 {
	public const string B_NAME_DOTWEEN_PRO_PKGS = "DOTweenPro-v1.0.335";
	public const string B_NAME_APPLE_SIGN_IN_PKGS = "AppleSignInUnity-v1.4.2";

	public const string B_NAME_NGUI_PKGS = "NGUI-v2023.05.29";
	public const string B_NAME_2D_TOOLKIT_PKGS = "2DToolkit-v2.5.8.16";
	public const string B_NAME_SPRITE_TRAIL_PKGS = "SpriteTrail-v1.4.0";
	public const string B_NAME_SND_MANAGER_PRO_PKGS = "SoundManagerPro-v3.7.0";
	public const string B_NAME_ULTIMATE_STATUS_BAR_PKGS = "UltimateStatusBar-v2.6.0";

	public const string B_NAME_BUILD_REPORT_TOOL_PKGS = "BuildReportTool-v3.10.1";
	public const string B_NAME_ODIN_INSPECTOR_AND_SERIALIZER_PKGS = "OdinInspectorAndSerializer-v4.0.02";
	// 이름 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
