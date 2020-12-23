using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 초기화 씬 상수
public static partial class KCDefine {
	#region 기본
	// 이름
	public const string IS_OBJ_N_BLIND_UI = "BlindUI";
	#endregion			// 기본
	
	#region 런타임 상수
	// 경로
	public static readonly string IS_OBJ_P_SCREEN_BLIND_UI = string.Format("{0}{1}IS_ScreenBlindUI", KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_INIT_SCENE);
	public static readonly string IS_OBJ_P_SCREEN_BLIND_IMG = string.Format("{0}{1}IS_ScreenBlindImg", KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_INIT_SCENE);
	#endregion			// 런타임 상수
}
