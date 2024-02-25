using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 확장 클래스 - 카메라 */
public static partial class CExtension {
	#region 클래스 함수
	/** 상태를 리셋한다 */
	public static void ExReset(this Camera a_oSender, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oSender != null);

		// 상태 리셋이 불가능 할 경우
		if(a_oSender == null) {
			return;
		}

		a_oSender.allowHDR = true;
		a_oSender.allowMSAA = CAccess.IsSupportsMSAA;
		a_oSender.allowDynamicResolution = false;

		a_oSender.useOcclusionCulling = true;
		a_oSender.usePhysicalProperties = false;

		a_oSender.targetDisplay = KCDefine.B_VAL_0_INT;
		a_oSender.stereoTargetEye = StereoTargetEyeMask.Both;

		a_oSender.rect = KCDefine.B_RECT_CAMERA_VIEWPORT;
		a_oSender.farClipPlane = KCDefine.U_DISTANCE_CAMERA_FAR_PLANE;
		a_oSender.nearClipPlane = KCDefine.U_DISTANCE_CAMERA_NEAR_PLANE;
	}

	/** 2 차원 카메라를 설정한다 */
	public static void ExSetup2D(this Camera a_oSender, float a_fPlaneHeight, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oSender != null && a_fPlaneHeight.ExIsGreat(KCDefine.B_VAL_0_REAL)));

		// 카메라 설정이 불가능 할 경우
		if(a_oSender == null || a_fPlaneHeight.ExIsLessEquals(KCDefine.B_VAL_0_REAL)) {
			return;
		}

		a_oSender.orthographic = true;
		a_oSender.orthographicSize = a_fPlaneHeight / KCDefine.B_VAL_2_REAL;
	}

	/** 3 차원 카메라를 설정한다 */
	public static void ExSetup3D(this Camera a_oSender, 
		float a_fPlaneHeight, float a_fPlaneDistance, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || 
			(a_oSender != null && a_fPlaneHeight.ExIsGreat(KCDefine.B_VAL_0_REAL) && a_fPlaneDistance.ExIsGreat(KCDefine.B_VAL_0_REAL)));

		bool bIsValidA = a_oSender != null;

		bool bIsValidB = a_fPlaneHeight.ExIsGreat(KCDefine.B_VAL_0_REAL) && 
			a_fPlaneDistance.ExIsGreat(KCDefine.B_VAL_0_REAL);

		// 카메라 설정이 불가능 할 경우
		if(!bIsValidA || !bIsValidB) {
			return;
		}

		float fHeight = a_fPlaneHeight / KCDefine.B_VAL_2_REAL;
		float fFieldOfView = Mathf.Atan(fHeight / a_fPlaneDistance);

		a_oSender.orthographic = false;
		a_oSender.fieldOfView = (fFieldOfView * KCDefine.B_VAL_2_REAL) * Mathf.Rad2Deg;
	}
	#endregion // 클래스 함수
}
