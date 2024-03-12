using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEngine.Rendering;
using UnityEditor;

/** 에디터 독립 플랫폼 상수 */
public static partial class KCEditorDefine
{
	#region 상수
	// 이름
	public const string B_BUILD_FILE_EXTENSION_STANDALONE_APP = "app";
	public const string B_BUILD_FILE_EXTENSION_STANDALONE_EXE = "exe";
	public const string B_BUILD_FILE_EXTENSION_STANDALONE_ZIP = "zip";

	// 경로
	public const string B_BUILD_P_FMT_STANDALONE = "Builds/Standalone/{0}/{1}";
	public const string B_BUILD_FILE_N_FMT_STANDALONE = "{0}BuildOutput.{1}";
	public const string B_BUILD_OUTPUT_P_FMT_STANDALONE = "Builds/Standalone/{0}/{0}BuildOutput.{1}";
	#endregion // 상수

	#region 런타임 상수
	// 기타 {
	public static readonly List<GraphicsDeviceType> B_GRAPHICS_DEVICE_TYPE_LIST_MAC = new List<GraphicsDeviceType>() {
		GraphicsDeviceType.Metal, GraphicsDeviceType.OpenGLCore
	};

	public static readonly List<GraphicsDeviceType> B_GRAPHICS_DEVICE_TYPE_LIST_WNDS = new List<GraphicsDeviceType>() {
		GraphicsDeviceType.Direct3D12, GraphicsDeviceType.Direct3D11, GraphicsDeviceType.OpenGLCore
	};
	// 기타 }

	// 경로
	public static readonly string B_ABS_BUILD_P_FMT_STANDALONE = $"{KCEditorDefine.B_ABS_DIR_P_ASSETS}../Builds/Standalone/{"{0}"}";
	public static readonly string B_DIR_P_FMT_EXTERNAL_DATAS_STANDALONE = $"{"{0}"}/{KCDefine.B_DIR_N_EXTERNAL_DATAS}/";
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
