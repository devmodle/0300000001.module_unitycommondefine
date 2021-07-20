using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR || UNITY_STANDALONE
//! 레벨 에디터 씬 상수
public static partial class KCDefine {
	#region 기본
	// 이름 {
	public const string LES_OBJ_N_ADD_LEVEL_BTN = "AddLevelBtn";
	public const string LES_OBJ_N_ADD_STAGE_BTN = "AddStageBtn";
	public const string LES_OBJ_N_ADD_CHAPTER_BTN = "AddChapterBtn";
	public const string LES_OBJ_N_APPLY_NUM_CELLS_BTN = "ApplyNumCellsBtn";

	public const string LES_OBJ_N_NUM_CELLS_X_INPUT = "NumCellsXInput";
	public const string LES_OBJ_N_NUM_CELLS_Y_INPUT = "NumCellsYInput";

	public const string LES_OBJ_N_LEVEL_SCROLL_VIEW = "LevelScrollView";
	public const string LES_OBJ_N_STAGE_SCROLL_VIEW = "StageScrollView";
	public const string LES_OBJ_N_CHAPTER_SCROLL_VIEW = "ChapterScrollView";
	// 이름 }
	#endregion			// 기본
}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
