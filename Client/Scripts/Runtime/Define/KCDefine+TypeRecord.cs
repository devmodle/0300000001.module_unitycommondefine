using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#region 제네릭 레코드
/** 매개 변수 */
public partial record REParams<TSender>
{
	public System.Action<TSender> m_oCallback;
}

/** 매개 변수 */
public partial record REParams<TSender, TParams> : REParams<TSender>
{
	public System.Action<TSender, TParams> m_oParamsCallback;
}

/** 매개 변수 */
public partial record REParams<TSender, TParams, TOwner> : REParams<TSender, TParams>
{
	public TOwner m_tOwner;
}
#endregion // 제네릭 레코드
