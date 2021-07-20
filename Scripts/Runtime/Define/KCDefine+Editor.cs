using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR || UNITY_STANDALONE
//! 에디터 기본 상수
public static partial class KCDefine {
	#region 기본
	// 이름 {
	public const string E_OBJ_N_PORTRAIT_UIS = "PortraitUIs";
	public const string E_OBJ_N_LANDSCAPE_UIS = "LandscapeUIs";

	public const string E_OBJ_N_LEFT_EDITOR_UIS = "LeftEditorUIs";
	public const string E_OBJ_N_MID_EDITOR_UIS = "MidEditorUIs";
	public const string E_OBJ_N_RIGHT_EDITOR_UIS = "RightEditorUIs";
	
	// 에디터 스크롤러 셀 뷰 {
	public const string E_OBJ_N_EDITOR_SCROLLER_CELL_VIEW = "EditorScrollerCellView";
	public const string E_OBJ_N_ESCV_NAME_TEXT = "NameText";

	public const string E_OBJ_N_ESCV_COPY_BTN = "CopyBtn";
	public const string E_OBJ_N_ESCV_MOVE_BTN = "MoveBtn";
	public const string E_OBJ_N_ESCV_REMOVE_BTN = "RemoveBtn";
	// 에디터 스크롤러 셀 뷰 }
	// 이름 }
	#endregion			// 기본

	#region 런타임 상수
	// 경로
	public static readonly string E_OBJ_P_EDITOR_SCROLLER_CELL_VIEW = $"{KCDefine.B_DIR_P_PREFABS}{KCDefine.B_DIR_P_GLOBAL}G_EditorScrollerCellView";
	#endregion			// 런타임 상수
}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
