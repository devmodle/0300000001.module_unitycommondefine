using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 리스트 */
public static partial class CExtension
{
	#region 제네릭 클래스 함수
	/** 값을 추가한다 */
	public static void ExAddVal<T>(this List<T> a_oSender, T a_tVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oSender.Contains(a_tVal))
		{
			return;
		}

		a_oSender.Add(a_tVal);
	}

	/** 값을 추가한다 */
	public static void ExAddVal<T>(this List<T> a_oSender,
		T a_tVal, System.Predicate<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null || a_oSender.ExFindVal(a_oCompare).ExIsValidIdx())
		{
			return;
		}

		a_oSender.Add(a_tVal);
	}

	/** 값을 추가한다 */
	public static void ExAddVals<T>(this List<T> a_oSender, List<T> a_oValList, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oValList != null));

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oValList == null)
		{
			return;
		}

		for(int i = 0; i < a_oValList.Count; ++i)
		{
			a_oSender.ExAddVal(a_oValList[i], a_bIsAssert);
		}
	}

	/** 값을 추가한다 */
	public static void ExAddVals<T>(this List<T> a_oSender,
		List<T> a_oValList, System.Predicate<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oValList != null && a_oCompare != null));

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oValList == null || a_oCompare == null)
		{
			return;
		}

		for(int i = 0; i < a_oValList.Count; ++i)
		{
			a_oSender.ExAddVal(a_oValList[i], a_oCompare, a_bIsAssert);
		}
	}

	/** 값을 추가한다 */
	public static void ExInsertVal<T>(this List<T> a_oSender,
		int a_nIdx, T a_tVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_nIdx <= KCDefine.B_IDX_INVALID || a_nIdx > a_oSender.Count)
		{
			return;
		}

		a_oSender.Insert(a_nIdx, a_tVal);
	}

	/** 값을 추가한다 */
	public static void ExInsertVal<T>(this List<T> a_oSender,
		System.Predicate<T> a_oCompare, T a_tVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		a_oSender.ExInsertVal(a_oSender.ExFindVal(a_oCompare), a_tVal);
	}

	/** 값을 추가한다 */
	public static void ExInsertVals<T>(this List<T> a_oSender,
		System.Predicate<T> a_oCompare, List<T> a_oValList, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null && a_oValList != null));

		// 값 추가가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null || a_oValList == null)
		{
			return;
		}

		for(int i = 0; i < a_oValList.Count; ++i)
		{
			a_oSender.ExInsertVal(a_oCompare, a_oValList[i]);
		}
	}

	/** 값을 대체한다 */
	public static void ExReplaceVal<T>(this List<T> a_oSender,
		T a_tVal, T a_tReplaceVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 값 대체가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.ExReplaceVal(a_tReplaceVal, (a_tCompareVal) => a_tCompareVal.Equals(a_tVal), a_bIsAssert);
	}

	/** 값을 대체한다 */
	public static void ExReplaceVal<T>(this List<T> a_oSender,
		T a_tReplaceVal, System.Predicate<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 값 대체가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		int nIdx = a_oSender.ExFindVal(a_oCompare);

		// 값이 존재 할 경우
		if(a_oSender.ExIsValidIdx(nIdx))
		{
			a_oSender[nIdx] = a_tReplaceVal;
		}
		else
		{
			a_oSender.Add(a_tReplaceVal);
		}
	}

	/** 값을 대체한다 */
	public static void ExReplaceVals<T>(this List<T> a_oSender,
		List<(T, T)> a_oValInfoList, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oValInfoList != null));

		// 값 대체가 불가능 할 경우
		if(a_oSender == null || a_oValInfoList == null)
		{
			return;
		}

		for(int i = 0; i < a_oValInfoList.Count; ++i)
		{
			a_oSender.ExReplaceVal(a_oValInfoList[i].Item1, a_oValInfoList[i].Item2, a_bIsAssert);
		}
	}

	/** 값을 제거한다 */
	public static void ExRemoveVal<T>(this List<T> a_oSender, T a_tVal, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 값 제거가 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		a_oSender.ExRemoveVal((a_tCompareVal) => a_tCompareVal.Equals(a_tVal), a_bIsAssert);
	}

	/** 값을 제거한다 */
	public static void ExRemoveVal<T>(this List<T> a_oSender,
		System.Predicate<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 값 제거가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		a_oSender.ExRemoveValAt(a_oSender.ExFindVal(a_oCompare), a_bIsAssert);
	}

	/** 값을 제거한다 */
	public static void ExRemoveVals<T>(this List<T> a_oSender, List<T> a_oValList, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oValList != null));

		// 값 제거가 불가능 할 경우
		if(a_oSender == null || a_oValList == null)
		{
			return;
		}

		for(int i = 0; i < a_oValList.Count; ++i)
		{
			a_oSender.ExRemoveVal(a_oValList[i], a_bIsAssert);
		}
	}

	/** 값을 제거한다 */
	public static void ExRemoveVals<T>(this List<T> a_oSender,
		System.Predicate<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 값 제거가 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		int nIdx = a_oSender.ExFindVal(a_oCompare);

		do
		{
			a_oSender.ExRemoveValAt(nIdx, a_bIsAssert);
		} while((nIdx = a_oSender.ExFindVal(a_oCompare)).ExIsValidIdx());
	}

	/** 값을 제거한다 */
	public static void ExRemoveValAt<T>(this List<T> a_oSender, int a_nIdx, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 값 제거가 불가능 할 경우
		if(a_oSender == null || !a_oSender.ExIsValidIdx(a_nIdx))
		{
			return;
		}

		a_oSender.RemoveAt(a_nIdx);
	}

	/** 값을 탐색한다 */
	public static int ExFindVal<T>(this List<T> a_oSender, System.Predicate<T> a_oCompare)
	{
		CFunc.Assert(a_oSender != null && a_oCompare != null);
		return a_oSender.FindIndex(a_oCompare);
	}

	/** 값을 안정 정렬한다 */
	public static void ExStableSort<T>(this List<T> a_oSender, System.Comparison<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 안정 정렬이 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		for(int i = 1; i < a_oSender.Count; ++i)
		{
			int j = 0;
			var tVal = a_oSender[i];

			for(j = i - 1; j >= KCDefine.B_VAL_0_INT; --j)
			{
				// 정렬 진행이 필요 없을 경우
				if(a_oCompare(a_oSender[j], tVal) <= KCDefine.B_COMPARE_EQUALS)
				{
					break;
				}

				a_oSender[j + KCDefine.B_VAL_1_INT] = a_oSender[j];
			}

			a_oSender[j + KCDefine.B_VAL_1_INT] = tVal;
		}
	}

	/** 리스트를 이동한다 */
	public static void ExCopyTo<TSrc, TDest>(this List<TSrc> a_oSender,
		List<TDest> a_oDestList, System.Func<TSrc, TDest> a_oCallback, bool a_bIsClear = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oDestList != null && a_oCallback != null));

		// 리스트 복사가 불가능 할 경우
		if(a_oSender == null || a_oDestList == null || a_oCallback == null)
		{
			return;
		}

		// 클리어 모드 일 경우
		if(a_bIsClear)
		{
			a_oDestList.Clear();
		}

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			a_oDestList.Add(a_oCallback(a_oSender[i]));
		}
	}

	/** 리스트 => 비트 마스크로 변환한다 */
	public static int ExToBitmask(this List<int> a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		int nVal = KCDefine.B_VAL_0_INT;

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			nVal |= KCDefine.B_VAL_1_INT.ExToLShiftBits(a_oSender[i]);
		}

		return nVal;
	}

	/** 리스트 => 문자열로 변환한다 */
	public static string ExToStr<T>(this List<T> a_oSender, string a_oToken = KCDefine.B_TEXT_EMPTY)
	{
		CFunc.Assert(a_oSender != null && a_oToken != null);
		var oStrBuilder = new System.Text.StringBuilder();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			oStrBuilder.Append(a_oSender[i]);
			oStrBuilder.Append((i < a_oSender.Count - KCDefine.B_VAL_1_INT) ? a_oToken : string.Empty);
		}

		return oStrBuilder.ToString();
	}

	/** 인덱스 정보 => 인덱스로 변환한다 */
	public static List<Vector3Int> ExToIndices(this List<STIdxInfo> a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		var oIdxList = new List<Vector3Int>();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			oIdxList.Add((Vector3Int)a_oSender[i]);
		}

		return oIdxList;
	}

	/** 인덱스 => 위치로 변환한다 */
	public static List<Vector3> ExToPositions(this List<Vector2Int> a_oSender,
		Vector3 a_stOffset, Vector3 a_stSize)
	{
		CFunc.Assert(a_oSender != null);
		var oPosList = new List<Vector3>();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			oPosList.Add(a_oSender[i].ExToPos(a_stOffset, a_stSize));
		}

		return oPosList;
	}

	/** 인덱스 => 위치로 변환한다 */
	public static List<Vector3> ExToPositions(this List<Vector3Int> a_oSender,
		Vector3 a_stOffset, Vector3 a_stSize)
	{
		CFunc.Assert(a_oSender != null);
		var oPosList = new List<Vector3>();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			oPosList.Add(a_oSender[i].ExToPos(a_stOffset, a_stSize));
		}

		return oPosList;
	}

	/** 인덱스 => 인덱스 정보로 변환한다 */
	public static List<STIdxInfo> ExToIdxInfos(this List<Vector3Int> a_oSender)
	{
		CFunc.Assert(a_oSender != null);
		var oIdxInfoList = new List<STIdxInfo>();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			oIdxInfoList.Add((STIdxInfo)a_oSender[i]);
		}

		return oIdxInfoList;
	}

	/** 타입 => 지정 타입으로 변환한다 */
	public static List<TDest> ExToTypes<TSrc, TDest>(this List<TSrc> a_oSender) where TSrc : class where TDest : class
	{
		CFunc.Assert(a_oSender != null);
		var oTypeList = new List<TDest>();

		for(int i = 0; i < a_oSender.Count; ++i)
		{
			var tDest = a_oSender[i] as TDest;

			// 타입 변환이 불가능 할 경우
			if(tDest == null)
			{
				continue;
			}

			oTypeList.Add(tDest);
		}

		return oTypeList;
	}
	#endregion // 제네릭 클래스 함수
}
