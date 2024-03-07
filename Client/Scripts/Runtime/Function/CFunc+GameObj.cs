using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;
#endif // #if UNITY_EDITOR

/** 함수 - 게임 객체 */
public static partial class CFunc {
	#region 클래스 함수
#if UNITY_EDITOR
	/** 객체를 선택한다 */
	public static void SelObj(GameObject a_oObj, bool a_bIsPing = false) {
		Selection.activeGameObject = a_oObj;

		// 핑 모드 일 경우
		if(a_bIsPing && a_oObj != null) {
			EditorGUIUtility.PingObject(a_oObj);
		}
	}

	/** 객체를 선택한다 */
	public static void SelObjs(List<GameObject> a_oObjList, bool a_bIsPing = false) {
		Selection.objects = (a_oObjList != null) ? a_oObjList.ToArray() : null;

		// 핑 모드 일 경우
		if(a_bIsPing && a_oObjList.ExIsValid()) {
			EditorGUIUtility.PingObject(a_oObjList[KCDefine.B_VAL_0_INT]);
		}
	}
#endif // #if UNITY_EDITOR
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 게임 객체를 설정한다 */
	public static void SetupGameObjs<K>(List<(K, string, GameObject)> a_oKeyInfoList, 
		Dictionary<K, GameObject> a_oOutObjDict, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjDict != null));

		// 객체 설정이 불가능 할 경우
		if(!a_oKeyInfoList.ExIsValid() || a_oOutObjDict == null) {
			return;
		}

		for(int i = 0; i < a_oKeyInfoList.Count; ++i) {
			a_oOutObjDict.ExReplaceVal(a_oKeyInfoList[i].Item1, 
				a_oKeyInfoList[i].Item3?.ExFindChild(a_oKeyInfoList[i].Item2));
		}
	}

	/** 게임 객체를 설정한다 */
	public static void SetupGameObjs<K>(List<(K, string, GameObject, GameObject)> a_oKeyInfoList, 
		Dictionary<K, GameObject> a_oOutObjDict, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjDict != null));

		// 객체 설정이 불가능 할 경우
		if(!a_oKeyInfoList.ExIsValid() || a_oOutObjDict == null) {
			return;
		}

		for(int i = 0; i < a_oKeyInfoList.Count; ++i) {
			var oObj = a_oKeyInfoList[i].Item3?.ExFindChild(a_oKeyInfoList[i].Item2) ?? 
				CFunc.CreateGameObj(a_oKeyInfoList[i].Item2, a_oKeyInfoList[i].Item4, a_oKeyInfoList[i].Item3);

			a_oOutObjDict.ExReplaceVal(a_oKeyInfoList[i].Item1, oObj);
		}
	}

	/** 게임 객체를 생성한다 */
	private static GameObject CreateGameObj(string a_oName, GameObject a_oOrigin, GameObject a_oParent) {
		// 원본 게임 객체가 존재 할 경우
		if(a_oOrigin != null) {
			CFactory.CreateCloneGameObj(a_oName, a_oOrigin, a_oParent);
		}

		return CFactory.CreateGameObj(a_oName, a_oParent);
	}
	#endregion // 제네릭 클래스 함수
}
