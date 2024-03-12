using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 배열 */
public static partial class CExtension
{
	#region 제네릭 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset<T>(this T[] a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		for(int i = 0; i < a_oSender.Length; ++i)
		{
			a_oSender[i] = default;
		}
	}

	/** 상태를 리셋한다 */
	public static void ExReset<T>(this T[,] a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		for(int i = 0; i < a_oSender.GetLength(KCDefine.B_VAL_0_INT); ++i)
		{
			for(int j = 0; j < a_oSender.GetLength(KCDefine.B_VAL_1_INT); ++j)
			{
				a_oSender[i, j] = default;
			}
		}
	}

	/** 상태를 리셋한다 */
	public static void ExReset<T>(this T[,,] a_oSender, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null)
		{
			return;
		}

		for(int i = 0; i < a_oSender.GetLength(KCDefine.B_VAL_0_INT); ++i)
		{
			for(int j = 0; j < a_oSender.GetLength(KCDefine.B_VAL_1_INT); ++j)
			{
				for(int k = 0; k < a_oSender.GetLength(KCDefine.B_VAL_2_INT); ++k)
				{
					a_oSender[i, j, k] = default;
				}
			}
		}
	}

	/** 값을 안정 정렬한다 */
	public static void ExStableSort<T>(this T[] a_oSender,
		System.Comparison<T> a_oCompare, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_oCompare != null));

		// 안정 정렬이 불가능 할 경우
		if(a_oSender == null || a_oCompare == null)
		{
			return;
		}

		for(int i = 1; i < a_oSender.Length; ++i)
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

	/** 타입 => 지정 타입으로 변환한다 */
	public static TDest[] ExToTypes<TSrc, TDest>(this TSrc[] a_oSender) where TSrc : class where TDest : class
	{
		CFunc.Assert(a_oSender != null);
		var oTypes = new TDest[a_oSender.Length];

		for(int i = 0; i < a_oSender.Length; ++i)
		{
			oTypes.ExSetVal(i, a_oSender[i] as TDest);
		}

		return oTypes;
	}

	/** 타입 => 지정 타입으로 변환한다 */
	public static TDest[,] ExToTypes<TSrc, TDest>(this TSrc[,] a_oSender) where TSrc : class where TDest : class
	{
		CFunc.Assert(a_oSender != null);
		var oTypes = new TDest[a_oSender.GetLength(KCDefine.B_VAL_0_INT), a_oSender.GetLength(KCDefine.B_VAL_1_INT)];

		for(int i = 0; i < a_oSender.GetLength(KCDefine.B_VAL_0_INT); ++i)
		{
			for(int j = 0; j < a_oSender.GetLength(KCDefine.B_VAL_1_INT); ++j)
			{
				oTypes.ExSetVal(new Vector3Int(j, i, KCDefine.B_VAL_0_INT), a_oSender[i, j] as TDest);
			}
		}

		return oTypes;
	}

	/** 타입 => 지정 타입으로 변환한다 */
	public static TDest[,,] ExToTypes<TSrc, TDest>(this TSrc[,,] a_oSender) where TSrc : class where TDest : class
	{
		CFunc.Assert(a_oSender != null);
		var oTypes = new TDest[a_oSender.GetLength(KCDefine.B_VAL_0_INT), a_oSender.GetLength(KCDefine.B_VAL_1_INT), a_oSender.GetLength(KCDefine.B_VAL_2_INT)];

		for(int i = 0; i < a_oSender.GetLength(KCDefine.B_VAL_0_INT); ++i)
		{
			for(int j = 0; j < a_oSender.GetLength(KCDefine.B_VAL_1_INT); ++j)
			{
				for(int k = 0; k < a_oSender.GetLength(KCDefine.B_VAL_2_INT); ++k)
				{
					oTypes.ExSetVal(new Vector3Int(k, j, i), a_oSender[i, j, k] as TDest);
				}
			}
		}

		return oTypes;
	}
	#endregion // 제네릭 클래스 함수
}
