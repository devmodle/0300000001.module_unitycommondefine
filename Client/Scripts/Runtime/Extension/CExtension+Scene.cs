using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using UnityEngine.SceneManagement;

/** 확장 클래스 - 씬 */
public static partial class CExtension {
	#region 클래스 함수
	/** 자식 객체를 탐색한다 */
	public static GameObject ExFindChild(this Scene a_stSender, string a_oName, bool a_bIsEnableSubName = false) {
		CFunc.Assert(a_oName.ExIsValid());
		var oObjs = a_stSender.GetRootGameObjects();

		for(int i = 0; i < oObjs.Length; ++i) {
			var oObj = oObjs[i].ExFindChild(a_oName, true, a_bIsEnableSubName);

			// 자식 객체가 존재 할 경우
			if(oObj != null) {
				return oObj;
			}
		}

		return null;
	}

	/** 자식 객체를 탐색한다 */
	public static List<GameObject> ExFindChildren(this Scene a_stSender, string a_oName, List<GameObject> a_oOutObjList = null, bool a_bIsEnableSubName = false) {
		var oObjs = a_stSender.GetRootGameObjects();
		var oObjList = a_oOutObjList ?? new List<GameObject>();

		// 객체 탐색이 불가능 할 경우
		if(!oObjs.ExIsValid()) {
			return oObjList;
		}

		for(int i = 0; i < oObjs.Length; ++i) {
			oObjList.AddRange(oObjs[i].ExFindChildren(a_oName, true, a_bIsEnableSubName));
		}

		return oObjList;
	}
	#endregion // 클래스 함수
}
