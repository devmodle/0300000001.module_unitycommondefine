using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using DG.Tweening;
using DG.Tweening.Core;

/** 애니메이션 팩토리 */
public static partial class CFactory
{
	#region 클래스 함수
	/** 애니메이션을 생성한다 */
	public static DG.Tweening.Tween MakeAnim(DOGetter<float> a_oGetter,
		DOSetter<float> a_oSetter, System.Action a_oInitCallback, System.Action<float> a_oSetterCallback, float a_fVal, float a_fDuration, Ease a_eEase = KCDefine.U_EASE_DEF, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oGetter != null && a_oSetter != null);
		a_oInitCallback?.Invoke();

		return DOTween.To(a_oGetter, (a_fAniVal) =>
		{
			a_oSetter(a_fAniVal);
			a_oSetterCallback?.Invoke(a_fAniVal);
		}, a_fVal, a_fDuration).SetAutoKill().SetEase(a_eEase).SetUpdate(a_bIsRealtime);
	}

	/** 시퀀스를 생성한다 */
	public static Sequence MakeSequence(DG.Tweening.Tween a_oAnim,
		System.Action<Sequence> a_oCallback, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsJoin = false, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oAnim != null);

		return CFactory.MakeSequence(new List<DG.Tweening.Tween>()
		{
			a_oAnim
		}, a_oCallback, a_fDelay, a_bIsJoin, a_bIsRealtime);
	}

	/** 시퀀스를 생성한다 */
	public static Sequence MakeSequence(List<DG.Tweening.Tween> a_oAnimList,
		System.Action<Sequence> a_oCallback, float a_fDelay = KCDefine.B_VAL_0_REAL, bool a_bIsJoin = false, bool a_bIsRealtime = false)
	{
		CFunc.Assert(a_oAnimList != null);
		var oAnim = DOTween.Sequence().SetAutoKill().SetUpdate(a_bIsRealtime);

		for(int i = 0; i < a_oAnimList.Count; ++i)
		{
			// 조인 모드 일 경우
			if(a_bIsJoin)
			{
				oAnim.Join(a_oAnimList[i]);
			}
			else
			{
				oAnim.Append(a_oAnimList[i]);
			}
		}

		var oSequence = DOTween.Sequence().SetAutoKill().SetDelay(a_fDelay).SetUpdate(a_bIsRealtime).Append(oAnim);
		return oSequence.AppendCallback(() => a_oCallback?.Invoke(oSequence));
	}
	#endregion // 클래스 함수
}
