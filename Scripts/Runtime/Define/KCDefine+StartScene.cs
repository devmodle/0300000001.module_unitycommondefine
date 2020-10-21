using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 시작 씬 상수
public static partial class KCDefine {
	#region 기본
	// 이름
	public const string SS_FUNC_NAME_START_SCENE_EVENT = "OnReceiveStartSceneEvent";
	#endregion			// 기본

	#region 런타임 상수
	// 경로
	public static readonly string SS_OBJ_PATH_LOADING_TEXT = string.Format("{0}{1}SS_LoadingText", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_START_SCENE);
	public static readonly string SS_OBJ_PATH_LOADING_IMG_OBJ = string.Format("{0}{1}SS_LoadingImgObj", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_START_SCENE);
	#endregion			// 런타임 상수
}
