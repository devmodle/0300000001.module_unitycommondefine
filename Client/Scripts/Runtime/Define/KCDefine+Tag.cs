using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - 태그 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 태그 {
	public const string U_TAG_PLAYER = "Player";
	public const string U_TAG_FINISH = "Finish";
	public const string U_TAG_RESPAWN = "Respawn";
	public const string U_TAG_UNTAGGED = "Untagged";
	public const string U_TAG_EDITOR_ONLY = "EditorOnly";
	public const string U_TAG_MAIN_CAMERA = "MainCamera";
	public const string U_TAG_GAME_CONTROLLER = "GameController";

	public const string U_TAG_ITEM = "Item";
	public const string U_TAG_SKILL = "Skill";
	public const string U_TAG_OBJ = "Object";
	public const string U_TAG_FX = "FX";
	public const string U_TAG_CELL = "Cell";
	public const string U_TAG_NON_PLAYER = "NonPlayer";
	public const string U_TAG_OBSTACLE = "Obstacle";
	public const string U_TAG_MAIN_LIGHT = "MainLight";
	public const string U_TAG_ADDITIONAL_LIGHT = "AdditionalLight";
	public const string U_TAG_ADDITIONAL_CAMERA = "AdditionalCamera";
	public const string U_TAG_SCENE_MANAGER = "SceneManager";
	// 태그 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 태그
	public static readonly List<string> U_TAG_LIST = new List<string>() {
		KCDefine.U_TAG_MAIN_LIGHT, 
		KCDefine.U_TAG_ADDITIONAL_LIGHT, 
		KCDefine.U_TAG_ADDITIONAL_CAMERA, 
		KCDefine.U_TAG_SCENE_MANAGER, 
		KCDefine.U_TAG_OBSTACLE, 
		KCDefine.U_TAG_ITEM, 
		KCDefine.U_TAG_SKILL, 
		KCDefine.U_TAG_OBJ, 
		KCDefine.U_TAG_FX, 
		KCDefine.U_TAG_CELL, 
		KCDefine.U_TAG_NON_PLAYER
	};
	#endregion // 런타임 상수
}
