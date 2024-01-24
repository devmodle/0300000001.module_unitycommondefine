using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR && URP_MODULE_ENABLE
using UnityEditor;

/** 에디터 상수 - 알림 */
public static partial class KCEditorDefine {
	#region 컴파일 상수
	// 이름 {
	public const string B_FIELD_N_URP_MSAA_QUALITY = "m_MSAA";
	public const string B_FIELD_N_URP_CASCADE_BORDER = "m_CascadeBorder";
	public const string B_FIELD_N_URP_OPAQUE_DOWN_SAMPLING = "m_OpaqueDownsampling";

	public const string B_FIELD_N_URP_CASCADE_2_SPLIT = "m_Cascade2Split";
	public const string B_FIELD_N_URP_CASCADE_3_SPLIT = "m_Cascade3Split";
	public const string B_FIELD_N_URP_CASCADE_4_SPLIT = "m_Cascade4Split";

	public const string B_FIELD_N_URP_RENDERER_DATAS = "m_RendererDataList";
	public const string B_FIELD_N_URP_SOFT_SHADOW_QUALITY = "m_SoftShadowQuality";
	public const string B_FIELD_N_URP_SUPPORTS_SOFT_SHADOW = "m_SoftShadowsSupported";
	public const string B_FIELD_N_URP_SUPPORTS_TERRAIN_HOLES = "m_SupportsTerrainHoles";
	public const string B_FIELD_N_URP_VOLUME_FRAMEWORK_UPDATE_MODE = "m_VolumeFrameworkUpdateMode";

	public const string B_FIELD_N_URP_ENABLE_LOD_CROSS_FADE = "m_EnableLODCrossFade";
	public const string B_FIELD_N_URP_LOD_CROSS_FADE_DITHERING_TYPE = "m_LODCrossFadeDitheringType";

	public const string B_FIELD_N_URP_REFLECTION_PROBE_BLENDING = "m_ReflectionProbeBlending";
	public const string B_FIELD_N_URP_USE_FAST_SRGB_LINEAR_CONVERSION = "m_UseFastSRGBLinearConversion";
	public const string B_FIELD_N_URP_REFLECTION_PROBE_BOX_PROJECTION = "m_ReflectionProbeBoxProjection";

	public const string B_FIELD_N_URP_MAIN_LIGHT_RENDERING_MODE = "m_MainLightRenderingMode";
	public const string B_FIELD_N_URP_MAIN_LIGHT_SUPPORTS_SHADOW = "m_MainLightShadowsSupported";
	public const string B_FIELD_N_URP_MAIN_LIGHT_SHADOW_MAP_RESOLUTION = "m_MainLightShadowmapResolution";

	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_COOKIE_FMT = "m_AdditionalLightsCookieFormat";
	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_PER_OBJ_LIMIT = "m_AdditionalLightsPerObjectLimit";
	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_RENDERING_MODE = "m_AdditionalLightsRenderingMode";
	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_SUPPORTS_SHADOW = "m_AdditionalLightShadowsSupported";
	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_COOKIE_RESOLUTION = "m_AdditionalLightsCookieResolution";
	public const string B_FIELD_N_URP_ADDITIONAL_LIGHTS_SHADOW_MAP_RESOLUTION = "m_AdditionalLightsShadowmapResolution";

	public const string B_PROPERTY_N_URP_STRIP_DEBUG_VARIANTS = "m_StripDebugVariants";
	public const string B_PROPERTY_N_URP_STRIP_UNUSED_VARIANTS = "m_StripUnusedVariants";
	public const string B_PROPERTY_N_URP_SHADER_VARIANT_LOG_LEVEL = "m_ShaderVariantLogLevel";
	public const string B_PROPERTY_N_URP_STRIP_UNUSED_POST_PROCESSING_VARIANTS = "m_StripUnusedPostProcessingVariants";
	// 이름 }
	#endregion // 컴파일 상수

	#region 런타임 상수
	// 경로
	public static readonly string B_ASSET_P_URP_GLOBAL_SETTINGS = $"{KCEditorDefine.B_DIR_P_ASSETS}UniversalRenderPipelineGlobalSettings.asset";
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR && URP_MODULE_ENABLE
