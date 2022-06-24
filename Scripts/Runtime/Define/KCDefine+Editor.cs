using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR || UNITY_STANDALONE
/** 에디터 기본 상수 */
public static partial class KCDefine {
	#region 기본
	// 이름
	public const string E_OBJ_N_EDITOR_INPUT_POPUP = "EDITOR_INPUT_POPUP";
	public const string E_OBJ_N_EDITOR_LEVEL_CREATE_POPUP = "EDITOR_LEVEL_CREATE_POPUP";
	#endregion			// 기본

	#region 런타임 상수
	// 경로 {
	public static readonly string E_OBJ_P_EDITOR_INPUT_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_EditorInputPopup";
	public static readonly string E_OBJ_P_EDITOR_LEVEL_CREATE_POPUP = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_POPUP}G_EditorLevelCreatePopup";

	public static readonly string E_OBJ_P_LEVEL_EDITOR_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_SCROLL_VIEW_ROOT}G_LevelEditorScrollerCellView";
	public static readonly string E_OBJ_P_STAGE_EDITOR_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_SCROLL_VIEW_ROOT}G_StageEditorScrollerCellView";
	public static readonly string E_OBJ_P_CHAPTER_EDITOR_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}{KCDefine.B_DIR_P_SCROLL_VIEW_ROOT}G_ChapterEditorScrollerCellView";
	// 경로 }
	#endregion			// 런타임 상수
}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
