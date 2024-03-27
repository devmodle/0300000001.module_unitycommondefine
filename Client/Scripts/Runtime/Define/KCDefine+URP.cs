using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/** 상수 - URP */
public static partial class KCDefine
{
	#region 컴파일 상수
	// 이름
	public const string G_FIELD_N_CLEAR_DEPTH = "m_ClearDepth";
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로 {
	public static readonly string G_MAT_P_URP_LIT = $"{KCDefine.B_DIR_P_MATERIALS}{KCDefine.B_DIR_P_GLOBAL}G_URPLit";
	public static readonly string G_MAT_P_URP_UNLIT = $"{KCDefine.B_DIR_P_MATERIALS}{KCDefine.B_DIR_P_GLOBAL}G_URPUnlit";

	public static readonly string G_ASSET_P_URP_QUALITY_NORM = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_Asset_QualityNorm";
	public static readonly string G_ASSET_P_URP_QUALITY_HIGH = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_Asset_QualityHigh";
	public static readonly string G_ASSET_P_URP_QUALITY_ULTRA = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_Asset_QualityUltra";

	public static readonly string G_ASSET_P_URP_RENDERER_DATA = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_DataRenderer";
	public static readonly string G_ASSET_P_URP_RENDERER_DATA_SSAO = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_DataRenderer_SSAO";

	public static readonly string G_ASSET_P_URP_RENDERER_DATA_2D = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_DataRender2D";
	public static readonly string G_ASSET_P_URP_RENDERER_DATA_2D_SSAO = $"{KCDefine.B_DIR_P_PIPELINES}{KCDefine.B_DIR_P_GLOBAL}G_URP_DataRender2D_SSAO";
	// 경로 }
	#endregion // 런타임 상수
}
