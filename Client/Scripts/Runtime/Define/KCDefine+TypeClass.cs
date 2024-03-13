using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#region 클래스
/** 경로 정보 */
public partial class CPathInfo
{
	public int m_nCost = 0;
	public Vector3Int m_stIdx = Vector3Int.zero;
	public CPathInfo m_oPrevPathInfo = null;
}

#if UNITY_EDITOR || UNITY_STANDALONE
/** 에디터 생성 정보 */
public partial class CEditorCreateInfo
{
	public int m_nNumLevels = 0;
	public Vector3Int m_stMinNumCells = Vector3Int.zero;
	public Vector3Int m_stMaxNumCells = Vector3Int.zero;
}
#endif // #if UNITY_EDITOR || UNITY_STANDALONE
#endregion // 클래스

#region 제네릭 클래스
/** 리스트 래퍼 */
public partial class CListWrapper<T>
{
	public List<T> m_oListA = new List<T>();
	public List<T> m_oListB = new List<T>();
	public List<T> m_oListC = new List<T>();

	#region 함수
	/** 클리어한다 */
	public void Clear()
	{
		m_oListA?.Clear();
		m_oListB?.Clear();
		m_oListC?.Clear();
	}
	#endregion // 함수
}

/** 딕셔너리 래퍼 */
public partial class CDictWrapper<K, V>
{
	public Dictionary<K, V> m_oDictA = new Dictionary<K, V>();
	public Dictionary<K, V> m_oDictB = new Dictionary<K, V>();
	public Dictionary<K, V> m_oDictC = new Dictionary<K, V>();

	#region 함수
	/** 클리어한다 */
	public void Clear()
	{
		m_oDictA?.Clear();
		m_oDictB?.Clear();
		m_oDictC?.Clear();
	}
	#endregion // 함수
}

/** 풀 리스트 래퍼 */
public partial class CPoolListWrapper<T>
{
	public List<T> m_oList = new List<T>();
	public Queue<T> m_oQueue = new Queue<T>();

	#region 함수
	/** 클리어한다 */
	public void Clear()
	{
		m_oList?.Clear();
		m_oQueue?.Clear();
	}
	#endregion // 함수
}
#endregion // 제네릭 클래스
