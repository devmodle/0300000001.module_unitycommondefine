using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#region 제네릭 레코드
/** 매개 변수 */
public partial record RCParams<TOwner, TSender, TParams>
{
	public TOwner m_oOwner;
	public System.Action<TSender, TParams> m_oCallback;
}
#endregion // 제네릭 레코드
