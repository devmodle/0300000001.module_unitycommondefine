using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 함수 - 호출 (액션) */
public static partial class CFunc {
	#region 클래스 함수
	/** 함수를 호출한다 */
	public static void Invoke(ref System.Action a_oAction) {
		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke();
	}
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 함수를 호출한다 */
	public static void Invoke<TA>(ref System.Action<TA> a_oAction, TA a_tParamsA) {
		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB>(ref System.Action<TA, TB> a_oAction, TA a_tParamsA, TB a_tParamsB) {
		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC>(ref System.Action<TA, TB, TC> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD>(ref System.Action<TA, TB, TC, TD> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD, TE>(ref System.Action<TA, TB, TC, TD, TE> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD, TE, TF>(ref System.Action<TA, TB, TC, TD, TE, TF> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD, TE, TF, TG>(ref System.Action<TA, TB, TC, TD, TE, TF, TG> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD, TE, TF, TG, TH>(ref System.Action<TA, TB, TC, TD, TE, TF, TG, TH> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG, TH a_tParamsH) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG, a_tParamsH);
	}

	/** 함수를 호출한다 */
	public static void Invoke<TA, TB, TC, TD, TE, TF, TG, TH, TI>(ref System.Action<TA, TB, TC, TD, TE, TF, TG, TH, TI> a_oAction, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG, TH a_tParamsH, TI a_tParamsI) {

		var oAction = a_oAction;
		a_oAction = null;

		oAction?.Invoke(a_tParamsA, 
			a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG, a_tParamsH, a_tParamsI);
	}
	#endregion // 제네릭 클래스 함수
}

/** 함수 - 호출 (함수) */
public static partial class CFunc {
	#region 제네릭 클래스 함수
	/** 함수를 호출한다 */
	public static TResult Invoke<TResult>(ref System.Func<TResult> a_oFunc) {
		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke();
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TResult>(ref System.Func<TA, TResult> a_oFunc, TA a_tParamsA) {
		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TResult>(ref System.Func<TA, TB, TResult> a_oFunc, TA a_tParamsA, TB a_tParamsB) {
		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TResult>(ref System.Func<TA, TB, TC, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TResult>(ref System.Func<TA, TB, TC, TD, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TE, TResult>(ref System.Func<TA, TB, TC, TD, TE, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TE, TF, TResult>(ref System.Func<TA, TB, TC, TD, TE, TF, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TE, TF, TG, TResult>(ref System.Func<TA, TB, TC, TD, TE, TF, TG, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TE, TF, TG, TH, TResult>(ref System.Func<TA, TB, TC, TD, TE, TF, TG, TH, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG, TH a_tParamsH) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;
		return oFunc.Invoke(a_tParamsA, a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG, a_tParamsH);
	}

	/** 함수를 호출한다 */
	public static TResult Invoke<TA, TB, TC, TD, TE, TF, TG, TH, TI, TResult>(ref System.Func<TA, TB, TC, TD, TE, TF, TG, TH, TI, TResult> a_oFunc, 
		TA a_tParamsA, TB a_tParamsB, TC a_tParamsC, TD a_tParamsD, TE a_tParamsE, TF a_tParamsF, TG a_tParamsG, TH a_tParamsH, TI a_tParamsI) {

		CFunc.Assert(a_oFunc != null);
		var oFunc = a_oFunc;

		a_oFunc = null;

		return oFunc.Invoke(a_tParamsA, 
			a_tParamsB, a_tParamsC, a_tParamsD, a_tParamsE, a_tParamsF, a_tParamsG, a_tParamsH, a_tParamsI);
	}
	#endregion // 제네릭 클래스 함수
}
