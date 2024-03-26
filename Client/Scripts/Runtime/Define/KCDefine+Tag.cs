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
	public const string G_TAG_FINISH = "Finish";
	public const string G_TAG_RESPAWN = "Respawn";
	public const string G_TAG_UNTAGGED = "Untagged";
	public const string G_TAG_ONLY_EDITOR = "EditorOnly";
	public const string G_TAG_CONTROLLER_GAME = "GameController";

	public const string G_TAG_LIGHT_MAIN = "MainLight";
	public const string G_TAG_LIGHT_ADDITIONAL = "AdditionalLight";

	public const string G_TAG_CAMERA_MAIN = "MainCamera";
	public const string G_TAG_CAMERA_ADDITIONAL = "AdditionalCamera";

	public const string G_TAG_PLAYER = "Player";
	public const string G_TAG_PLAYER_NON = "NonPlayer";

	public const string G_TAG_ITEM = "Item";
	public const string G_TAG_SKILL = "Skill";
	public const string G_TAG_OBJ = "Object";
	public const string G_TAG_FX = "FX";
	public const string G_TAG_CELL = "Cell";
	public const string G_TAG_OBSTACLE = "Obstacle";
	public const string G_TAG_MANAGER_SCENE = "SceneManager";
	// 태그 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 태그
	public static readonly List<string> G_TAG_LIST = new List<string>() {
		KCDefine.G_TAG_LIGHT_MAIN,
		KCDefine.G_TAG_LIGHT_ADDITIONAL,
		KCDefine.G_TAG_CAMERA_ADDITIONAL,
		KCDefine.G_TAG_MANAGER_SCENE,

		KCDefine.G_TAG_OBSTACLE,
		KCDefine.G_TAG_ITEM,
		KCDefine.G_TAG_SKILL,
		KCDefine.G_TAG_OBJ,
		KCDefine.G_TAG_FX,
		KCDefine.G_TAG_CELL,
		KCDefine.G_TAG_PLAYER_NON
	};
	#endregion // 런타임 상수
}
