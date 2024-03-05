using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 함수 - 게임 객체 */
public static partial class CFunc {
	#region 제네릭 클래스 함수
	/** 객체를 설정한다 */
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

	/** 객체를 설정한다 */
	public static void SetupGameObjs<K>(List<(K, string, GameObject, GameObject)> a_oKeyInfoList, 
		Dictionary<K, GameObject> a_oOutObjDict, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjDict != null));

		// 객체 설정이 불가능 할 경우
		if(!a_oKeyInfoList.ExIsValid() || a_oOutObjDict == null) {
			return;
		}

		for(int i = 0; i < a_oKeyInfoList.Count; ++i) {
			var oObj = a_oKeyInfoList[i].Item3?.ExFindChild(a_oKeyInfoList[i].Item2);
			
			// 객체가 없을 경우
			if(oObj == null) {
				oObj = (a_oKeyInfoList[i].Item4 == null) ? 
					CFactory.CreateGameObj(a_oKeyInfoList[i].Item2, a_oKeyInfoList[i].Item3) : CFactory.CreateCloneGameObj(a_oKeyInfoList[i].Item2, a_oKeyInfoList[i].Item4, a_oKeyInfoList[i].Item3);
			}

			a_oOutObjDict.ExReplaceVal(a_oKeyInfoList[i].Item1, oObj);
		}
	}
	#endregion // 제네릭 클래스 함수
}
