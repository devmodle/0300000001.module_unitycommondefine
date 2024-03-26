using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 메뉴 */
public static partial class KCDefineEditor
{
	#region 컴파일 상수
	// 기타 {
	public const string B_MENU_TOOLS_BASE = "Tools/Utility/";
	public const string B_MENU_GAME_OBJECTS_BASE = "GameObject/";

	public const string B_MENU_TOOLS_BUILD_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Build/";
	public const string B_MENU_TOOLS_SETUP_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Setup/";
	public const string B_MENU_TOOLS_RESET_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Reset/";

	public const string B_MENU_TOOLS_IMPORT_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Import/";
	public const string B_MENU_TOOLS_EXPORT_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Export/";
	public const string B_MENU_TOOLS_CREATE_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "Create/";
	public const string B_MENU_TOOLS_SUB_CREATE_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "SubCreate/";

	public const string B_MENU_TOOLS_EDITOR_WND_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "EditorWindow/";
	public const string B_MENU_TOOLS_CHANGE_PLATFORM_BASE = KCDefineEditor.B_MENU_TOOLS_BASE + "ChangePlatform/";

	public const string B_MENU_GAME_OBJECT_UI_BASE = KCDefineEditor.B_MENU_GAME_OBJECTS_BASE + "UI/Utility/";
	public const string B_MENU_GAME_OBJECT_2D_BASE = KCDefineEditor.B_MENU_GAME_OBJECTS_BASE + "2D Object/Utility/";
	public const string B_MENU_GAME_OBJECT_3D_BASE = KCDefineEditor.B_MENU_GAME_OBJECTS_BASE + "3D Object/Utility/";
	public const string B_MENU_GAME_OBJECT_FX_BASE = KCDefineEditor.B_MENU_GAME_OBJECTS_BASE + "Effects/Utility/";
	// 기타 }
	#endregion // 컴파일 상수
}
#endif // #if UNITY_EDITOR
