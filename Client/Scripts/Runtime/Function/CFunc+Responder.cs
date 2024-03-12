using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 함수 - 응답자 */
public static partial class CFunc {
	#region 제네릭 클래스 함수
	/** 터치 응답자를 설정한다 */
	public static void SetupTouchResponders<K>(List<(K, string, GameObject, GameObject)> a_oKeyInfoList, 
		Vector3 a_stSize, Dictionary<K, GameObject> a_oOutObjsDict, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjsDict != null));
		CFunc.SetupResponders(a_oKeyInfoList, a_stSize, a_oOutObjsDict, CFactory.CreateTouchResponder, a_bIsAssert);
	}

	/** 드래그 응답자를 설정한다 */
	public static void SetupDragResponders<K>(List<(K, string, GameObject, GameObject)> a_oKeyInfoList, 
		Vector3 a_stSize, Dictionary<K, GameObject> a_oOutObjsDict, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjsDict != null));
		CFunc.SetupResponders(a_oKeyInfoList, a_stSize, a_oOutObjsDict, CFactory.CreateDragResponder, a_bIsAssert);
	}

	/** 응답자를 설정한다 */
	public static void SetupResponders<K>(List<(K, string, GameObject, GameObject)> a_oKeyInfoList, 
		Vector3 a_stSize, Dictionary<K, GameObject> a_oOutObjsDict, System.Func<string, GameObject, GameObject, Vector3, Vector3, Color, GameObject> a_oCreator, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oKeyInfoList.ExIsValid() && a_oOutObjsDict != null));

		// 응답자 설정이 불가능 할 경우
		if(!a_oKeyInfoList.ExIsValid() || a_oOutObjsDict == null) {
			return;
		}

		for(int i = 0; i < a_oKeyInfoList.Count; ++i) {
			var oTouchResponder = a_oKeyInfoList[i].Item3?.ExFindChild(a_oKeyInfoList[i].Item2) ?? 
				a_oCreator(a_oKeyInfoList[i].Item2, a_oKeyInfoList[i].Item4, a_oKeyInfoList[i].Item3, a_stSize, Vector3.zero, KCDefine.B_COLOR_TRANSPARENT);

			a_oOutObjsDict.ExReplaceVal(a_oKeyInfoList[i].Item1, oTouchResponder);
			a_oOutObjsDict.ExGetVal(a_oKeyInfoList[i].Item1)?.ExSetRaycastTarget<Image>(true, a_bIsAssert);
		}
	}
	#endregion // 제네릭 클래스 함수
}
