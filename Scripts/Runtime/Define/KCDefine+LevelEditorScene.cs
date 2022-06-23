using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR || UNITY_STANDALONE
/** 레벨 에디터 씬 상수 */
public static partial class KCDefine {
	#region 기본
	// 형식
	public const string LES_TEXT_FMT_LEVEL = "레벨 {0:0000}";
	public const string LES_TEXT_FMT_STAGE = "스테이지 {0:000}";
	public const string LES_TEXT_FMT_CHAPTER = "챕터 {0:00}";

	// 중앙 에디터 UI
	public const string LES_OBJ_N_ME_UIS_SAVE_BTN = "SAVE_BTN";
	public const string LES_OBJ_N_ME_UIS_RESET_BTN = "RESET_BTN";
	public const string LES_OBJ_N_ME_UIS_TEST_BTN = "TEST_BTN";
	public const string LES_OBJ_N_ME_UIS_COPY_LEVEL_BTN = "COPY_LEVEL_BTN";

	// 왼쪽 에디터 UI {
	public const string LES_OBJ_N_LE_UIS_ADD_LEVEL_BTN = "ADD_LEVEL_BTN";
	public const string LES_OBJ_N_LE_UIS_ADD_STAGE_BTN = "ADD_STAGE_BTN";
	public const string LES_OBJ_N_LE_UIS_ADD_CHAPTER_BTN = "ADD_CHAPTER_BTN";

	public const string LES_OBJ_N_LE_UIS_STAGE_SCROLL_VIEW_01 = "STAGE_SCROLL_VIEW_01";
	public const string LES_OBJ_N_LE_UIS_STAGE_SCROLL_VIEW_02 = "STAGE_SCROLL_VIEW_02";
	// 왼쪽 에디터 UI }

	// 오른쪽 에디터 UI
	public const string LES_OBJ_N_RE_UIS_APPLY_BTN = "APPLY_BTN";
	public const string LES_OBJ_N_RE_UIS_LOAD_LEVEL_BTN = "LOAD_LEVEL_BTN";
	public const string LES_OBJ_N_RE_UIS_LOAD_LOCAL_TABLE_BTN = "LOAD_LOCAL_TABLE_BTN";
	#endregion			// 기본
}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
