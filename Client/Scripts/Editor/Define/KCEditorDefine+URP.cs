using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && URP_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 알림 */
public static partial class KCEditorDefine
{
	#region 컴파일 상수
	// 이름 {
	public const string G_FIELD_N_URP_MSAA_QUALITY = "m_MSAA";
	public const string G_FIELD_N_URP_BORDER_CASCADE = "m_CascadeBorder";
	public const string G_FIELD_N_URP_SAMPLING_DOWN_OPAQUE = "m_OpaqueDownsampling";

	public const string G_FIELD_N_URP_CASCADE_SPLIT_2 = "m_Cascade2Split";
	public const string G_FIELD_N_URP_CASCADE_SPLIT_3 = "m_Cascade3Split";
	public const string G_FIELD_N_URP_CASCADE_SPLIT_4 = "m_Cascade4Split";

	public const string G_FIELD_N_URP_QUALITY_SHADOW_SOFT = "m_SoftShadowQuality";
	public const string G_FIELD_N_URP_SUPPORTS_SHADOW_SOFT = "m_SoftShadowsSupported";
	public const string G_FIELD_N_URP_SUPPORTS_HOLES_TERRAIN = "m_SupportsTerrainHoles";
	public const string G_FIELD_N_URP_MODE_UPDATE_FRAMEWORK_VOLUME = "m_VolumeFrameworkUpdateMode";

	public const string G_FIELD_N_URP_FADE_CROSS_LOD_ENABLE = "m_EnableLODCrossFade";
	public const string G_FIELD_N_URP_TYPE_DITHERING_FADE_CROSS_LOD = "m_LODCrossFadeDitheringType";

	public const string G_FIELD_N_URP_BLENDING_PROBE_REFLECTION = "m_ReflectionProbeBlending";
	public const string G_FIELD_N_URP_CONVERSION_LINEAR_SRGB_FAST_USE = "m_UseFastSRGBLinearConversion";
	public const string G_FIELD_N_URP_PROJECTION_BOX_PROBE_REFLECTION = "m_ReflectionProbeBoxProjection";

	public const string G_FIELD_N_URP_MODE_RENDERING_LIGHT_MAIN = "m_MainLightRenderingMode";
	public const string G_FIELD_N_URP_SUPPORTS_SHADOWS_LIGHT_MAIN = "m_MainLightShadowsSupported";
	public const string G_FIELD_N_URP_RESOLUTION_MAP_SHADOW_LIGHT_MAIN = "m_MainLightShadowmapResolution";

	public const string G_FIELD_N_URP_FMT_COOKIE_LIGHTS_ADDITIONAL = "m_AdditionalLightsCookieFormat";
	public const string G_FIELD_N_URP_LIMIT_OBJ_PER_LIGHTS_ADDITIONAL = "m_AdditionalLightsPerObjectLimit";
	public const string G_FIELD_N_URP_MODE_RENDERING_LIGHTS_ADDITIONAL = "m_AdditionalLightsRenderingMode";
	public const string G_FIELD_N_URP_SUPPORTS_SHADOW_LIGHTS_ADDITIONAL = "m_AdditionalLightShadowsSupported";
	public const string G_FIELD_N_URP_RESOLUTION_COOKIE_LIGHTS_ADDITIONAL = "m_AdditionalLightsCookieResolution";
	public const string G_FIELD_N_URP_RESOLUTION_MAP_SHADOW_LIGHTS_ADDITIONAL = "m_AdditionalLightsShadowmapResolution";

	public const string G_PROPERTY_N_URP_VARIANTS_DEBUG_STRIP = "m_StripDebugVariants";
	public const string G_PROPERTY_N_URP_VARIANTS_UNUSED_STRIP = "m_StripUnusedVariants";
	public const string G_PROPERTY_N_URP_VARIANTS_PROCESSING_POST_UNUSED_STRIP = "m_StripUnusedPostProcessingVariants";

	public const string G_PROPERTY_N_URP_LEVEL_LOG_VARIANT_SHADER = "m_ShaderVariantLogLevel";
	// 이름 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로
	public static readonly string G_ASSET_P_URP_SETTINGS_GLOBAL = $"{KCEditorDefine.B_DIR_P_ASSETS}UniversalRenderPipelineGlobalSettings.asset";
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && URP_MODULE_ENABLE
