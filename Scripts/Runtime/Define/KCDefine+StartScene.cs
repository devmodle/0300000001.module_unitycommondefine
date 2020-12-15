using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 시작 씬 상수
public static partial class KCDefine {
	#region 기본
	// 개수
	public const int SS_MAX_NUM_DOTS = 3;

	// 시간
	public const float SS_DELTA_TIME_UPDATE_STATE = 0.5f;

	// 텍스트
	public const string SS_TEXT_LOADING = "Loading...";

	// 이름 {
	public const string SS_OBJ_NAME_LOADING_TEXT = "LoadingText";
	public const string SS_OBJ_NAME_LOADING_IMG_OBJ = "LoadingImgObj";

	public const string SS_OBJ_NAME_GAUGE_IMG = "GaugeImg";
	public const string SS_FUNC_NAME_START_SCENE_EVENT = "OnReceiveStartSceneEvent";
	// 이름 }
	#endregion			// 기본

	#region 런타임 상수
	// 위치
	public static readonly Vector3 SS_POS_LOADING_TEXT = new Vector3(0.0f, 40.0f, 0.0f);
	public static readonly Vector3 SS_POS_LOADING_IMG_OBJ = new Vector3(0.0f, -40.0f, 0.0f);
	
	// 경로
	public static readonly string SS_OBJ_PATH_LOADING_TEXT = string.Format("{0}{1}SS_LoadingText", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_START_SCENE);
	public static readonly string SS_OBJ_PATH_LOADING_IMG_OBJ = string.Format("{0}{1}SS_LoadingImgObj", KCDefine.B_DIR_PATH_PREFABS, KCDefine.B_DIR_PATH_START_SCENE);
	#endregion			// 런타임 상수
}
