using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 딕셔너리 */
public static partial class CExtension {
	#region 제네릭 클래스 함수
	/** 딕셔너리를 복사한다 */
	public static void ExCopyTo<KSrc, VSrc, VDest>(this Dictionary<KSrc, VSrc> a_oSender,
		Dictionary<KSrc, VDest> a_oDestDict, System.Func<KSrc, VSrc, VDest> a_oCallback, bool a_bIsClear = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oDestDict != null && a_oCallback != null));

		// 딕셔너리 복사가 불가능 할 경우
		if(a_oSender == null || a_oDestDict == null || a_oCallback == null) {
			return;
		}

		// 클리어 모드 일 경우
		if(a_bIsClear) {
			a_oDestDict.Clear();
		}

		foreach(var stKeyVal in a_oSender) {
			var tVal = a_oCallback(stKeyVal.Key, stKeyVal.Value);
			a_oDestDict.TryAdd(stKeyVal.Key, tVal);
		}
	}

	/** 타입 => 지정 타입으로 변환한다 */
	public static Dictionary<KDest, VDest> ExToTypes<KSrc, VSrc, KDest, VDest>(this Dictionary<KSrc, VSrc> a_oSender) {
		CFunc.Assert(a_oSender != null);
		var oTypeDict = new Dictionary<KDest, VDest>();

		foreach(var stKeyVal in a_oSender) {
			// 타입 변환이 불가능 할 경우
			if(!(stKeyVal.Key is KDest) && !(stKeyVal.Value is VDest)) {
				continue;
			}

			oTypeDict.Add((KDest)stKeyVal.Key, (VDest)stKeyVal.Value);
		}

		return oTypeDict;
	}
	#endregion // 제네릭 클래스 함수
}
