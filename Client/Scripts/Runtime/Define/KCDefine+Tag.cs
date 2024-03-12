using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 태그 */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 태그 {
	public const string B_TAG_PLAYER = "Player";
	public const string B_TAG_FINISH = "Finish";
	public const string B_TAG_RESPAWN = "Respawn";
	public const string B_TAG_UNTAGGED = "Untagged";
	public const string B_TAG_EDITOR_ONLY = "EditorOnly";
	public const string B_TAG_MAIN_CAMERA = "MainCamera";
	public const string B_TAG_GAME_CONTROLLER = "GameController";

	public const string B_TAG_ITEM = "Item";
	public const string B_TAG_SKILL = "Skill";
	public const string B_TAG_OBJ = "Object";
	public const string B_TAG_FX = "FX";
	public const string B_TAG_CELL = "Cell";
	public const string B_TAG_NON_PLAYER = "NonPlayer";
	public const string B_TAG_OBSTACLE = "Obstacle";
	public const string B_TAG_MAIN_LIGHT = "MainLight";
	public const string B_TAG_ADDITIONAL_LIGHT = "AdditionalLight";
	public const string B_TAG_ADDITIONAL_CAMERA = "AdditionalCamera";
	public const string B_TAG_SCENE_MANAGER = "SceneManager";
	// 태그 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 태그
	public static readonly List<string> B_TAG_LIST = new List<string>() {
		KCDefine.B_TAG_MAIN_LIGHT,
		KCDefine.B_TAG_ADDITIONAL_LIGHT,
		KCDefine.B_TAG_ADDITIONAL_CAMERA,
		KCDefine.B_TAG_SCENE_MANAGER,
		KCDefine.B_TAG_OBSTACLE,
		KCDefine.B_TAG_ITEM,
		KCDefine.B_TAG_SKILL,
		KCDefine.B_TAG_OBJ,
		KCDefine.B_TAG_FX,
		KCDefine.B_TAG_CELL,
		KCDefine.B_TAG_NON_PLAYER
	};
	#endregion // 런타임 상수
}
