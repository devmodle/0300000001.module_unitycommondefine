using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** 타이틀 씬 상수 */
public static partial class KCDefine {
	#region 기본
	// 이름
	public const string TS_OBJ_N_VER_TEXT = "VerText";
	#endregion			// 기본

	#region 런타임 상수
	// 위치
	public static readonly Vector3 TS_POS_VER_TEXT = new Vector3(10.0f, -10.0f, 0.0f);

	// 경로 {
	public static readonly string TS_OBJ_P_VER_TEXT = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_TITLE_SCENE}TS_VerText";

	public static readonly string TS_OBJ_P_LEVEL_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_TITLE_SCENE}TS_LevelScrollerCellView";
	public static readonly string TS_OBJ_P_STAGE_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_TITLE_SCENE}TS_StageScrollerCellView";
	public static readonly string TS_OBJ_P_CHAPTER_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_TITLE_SCENE}TS_ChapterScrollerCellView";
	// 경로 }
	#endregion			// 런타임 상수
}
