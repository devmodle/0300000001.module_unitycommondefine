using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 함수 - 색상 */
public static partial class CFunc
{
	#region 클래스 함수
	/** 동일 여부를 검사한다 */
	public static bool ExIsEquals(this Color a_stSender, Color a_stRhs)
	{
		return a_stSender.r.ExIsEquals(a_stRhs.r) && a_stSender.g.ExIsEquals(a_stRhs.g) && a_stSender.b.ExIsEquals(a_stRhs.b) && a_stSender.a.ExIsEquals(a_stRhs.a);
	}
	#endregion // 클래스 함수
}
