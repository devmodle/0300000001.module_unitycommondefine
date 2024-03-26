using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 버전 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 버전
	public const string G_VER_STR_DEF = "1.0.0";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 버전 {
	public static readonly System.Version G_VER_INVALID = new System.Version(0, 0, 0);

	public static readonly System.Version G_VER_INFO_APP_COMMON = new System.Version(1, 0, 0);
	public static readonly System.Version G_VER_INFO_GAME_COMMON = new System.Version(1, 0, 0);
	public static readonly System.Version G_VER_INFO_USER_COMMON = new System.Version(1, 0, 0);
	// 버전 }
	#endregion // 런타임 상수
}
