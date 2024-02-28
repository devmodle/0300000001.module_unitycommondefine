using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - URP */
public static partial class KCDefine {
	#region 컴파일 상수
	// 이름
	public const string U_FIELD_N_CLEAR_DEPTH = "m_ClearDepth";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로 {
	public static readonly string U_MAT_P_G_URP_LIT = $"{KCDefine.B_DIR_P_MATERIALS}{KCDefine.B_DIR_P_GLOBAL}G_URPLit";
	public static readonly string U_MAT_P_G_URP_UNLIT = $"{KCDefine.B_DIR_P_MATERIALS}{KCDefine.B_DIR_P_GLOBAL}G_URPUnlit";

	public static readonly string U_ASSET_P_G_NORM_QUALITY_URP = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_NormQualityURPAsset";
	public static readonly string U_ASSET_P_G_HIGH_QUALITY_URP = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_HighQualityURPAsset";
	public static readonly string U_ASSET_P_G_ULTRA_QUALITY_URP = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_UltraQualityURPAsset";

	public static readonly string U_ASSET_P_G_URP_RENDERER_DATA = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URPRendererData";
	public static readonly string U_ASSET_P_G_URP_RENDERER_DATA_SSAO = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URPRendererDataSSAO";

	public static readonly string U_ASSET_P_G_URP_RENDERER_DATA_2D = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URPRenderData2D";
	public static readonly string U_ASSET_P_G_URP_RENDERER_DATA_2D_SSAO = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URPRenderData2DSSAO";
	// 경로 }
	#endregion // 런타임 상수
}
