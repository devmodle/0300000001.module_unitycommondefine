using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && LOCALIZE_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 지역화 */
public static partial class KCDefineEditor
{
	#region 컴파일 상수
	// 이름
	public const string B_PROPERTY_N_LOCALIZE_INITIALIZE_SYNCHRONOUSLY = "m_InitializeSynchronously";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로
	public static readonly string B_ASSET_P_LOCALIZE_SETTINGS = $"{KCDefineEditor.B_DIR_P_ASSETS}LocalizationSettings.asset";
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && LOCALIZE_MODULE_ENABLE
