using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#region 인터페이스
/** 풀링 인터페이스 */
public partial interface IPoolable
{
	/** 풀링 여부를 변경한다 */
	public void SetIsPooling(bool a_bIsPooling);
}

/** 갱신 인터페이스 */
public partial interface IUpdatable
{
	/** 상태를 갱신한다 */
	public void OnUpdate(float a_fDeltaTime);

	/** 상태를 갱신한다 */
	public void OnUpdateLate(float a_fDeltaTime);

	/** 상태를 갱신한다 */
	public void OnUpdateFixed(float a_fDeltaTime);

	/** 상태를 갱신한다 */
	public void OnUpdateCustom(float a_fDeltaTime);
}
#endregion // 인터페이스
