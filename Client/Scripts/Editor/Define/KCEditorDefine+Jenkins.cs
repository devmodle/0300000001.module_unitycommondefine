using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
/** 에디터 젠킨스 상수 */
public static partial class KCEditorDefine {
	#region 상수
	// 기타 {
	public const string B_BRANCH_FMT_JENKINS = "origin/{0}";
	public const string B_ANALYTICS_FMT_JENKINS = "{0}/00.Analytics";

	public const string B_BUILD_CMD_FMT_JENKINS = "curl -X POST {0} --user {1}:{2} --data token={3}";
	public const string B_BUILD_DATA_FMT_JENKINS = "--data {0}={1}";

	public const string B_DEBUG_BUILD_FUNC_JENKINS = "Debug";
	public const string B_RELEASE_BUILD_FUNC_JENKINS = "Release";
	public const string B_STORE_A_BUILD_FUNC_JENKINS = "StoreA";
	public const string B_STORE_B_BUILD_FUNC_JENKINS = "StoreB";
	public const string B_STORE_DIST_BUILD_FUNC_JENKINS = "StoreDist";
	// 기타 }

	// iOS {
	public const string B_PROJ_PLATFORM_N_IOS = "iOS";
	public const string B_PROJ_PLATFORM_N_IPHONE = "iPhone";

	public const string B_IOS_DEBUG_PIPELINE_N_JENKINS = "01.iOSDebug";
	public const string B_IOS_RELEASE_PIPELINE_N_JENKINS = "02.iOSRelease";
	public const string B_IOS_STORE_PIPELINE_N_JENKINS = "03.iOSStore";

	public const string B_IOS_APPLE_BUILD_PROJ_N_JENKINS = "01.iOSApple";
	// iOS }

	// 안드로이드 {
	public const string B_PROJ_PLATFORM_N_ANDROID = "Android";

	public const string B_ANDROID_DEBUG_PIPELINE_N_JENKINS = "11.AndroidDebug";
	public const string B_ANDROID_RELEASE_PIPELINE_N_JENKINS = "12.AndroidRelease";
	public const string B_ANDROID_STORE_PIPELINE_N_JENKINS = "13.AndroidStore";

	public const string B_ANDROID_GOOGLE_BUILD_PROJ_N_JENKINS = "11.AndroidGoogle";
	public const string B_ANDROID_AMAZON_BUILD_PROJ_N_JENKINS = "12.AndroidAmazon";
	// 안드로이드 }

	// 독립 플랫폼 {
	public const string B_PROJ_PLATFORM_N_SERVER = "Server";
	public const string B_PROJ_PLATFORM_N_STANDALONE = "Standalone";
	public const string B_PROJ_PLATFORM_N_STANDALONE_MAC = "OSXUniversal";
	public const string B_PROJ_PLATFORM_N_STANDALONE_WNDS = "Win64";

	public const string B_STANDALONE_DEBUG_PIPELINE_N_JENKINS = "41.StandaloneDebug";
	public const string B_STANDALONE_RELEASE_PIPELINE_N_JENKINS = "42.StandaloneRelease";
	public const string B_STANDALONE_STORE_PIPELINE_N_JENKINS = "43.StandaloneStore";

	public const string B_STANDALONE_MAC_STEAM_BUILD_PROJ_N_JENKINS = "41.StandaloneMacSteam";
	public const string B_STANDALONE_WNDS_STEAM_BUILD_PROJ_N_JENKINS = "51.StandaloneWndsSteam";
	// 독립 플랫폼 }

	// 이름 {
	public const string B_TEX_IMPORTER_PLATFORM_N_DEF = "DefaultTexturePlatform";

#if NINETAP_BUILD_PIPELINE_ENABLE
	public const string B_PIPELINE_GROUP_NAME_FMT_JENKINS = "job/000000.Common/job/{0}/job/01.Pipelines/job";
#else
	public const string B_PIPELINE_GROUP_NAME_FMT_JENKINS = "job/0000000000.Common/job/{0}/job/01.Pipelines/job";
#endif // #if NINETAP_BUILD_PIPELINE_ENABLE
	// 이름 }

	// 식별자 {
	public const string B_KEY_JENKINS_PROJ_ROOT = "ProjRoot";
	public const string B_KEY_JENKINS_MODULE_VER = "ModuleVer";
	public const string B_KEY_JENKINS_BRANCH = "Branch";
	public const string B_KEY_JENKINS_SRC = "Src";
	public const string B_KEY_JENKINS_ANALYTICS_SRC = "AnalyticsSrc";

	public const string B_KEY_JENKINS_PROJ_NAME = "ProjName";
	public const string B_KEY_JENKINS_PROJ_PATH = "ProjPath";
	public const string B_KEY_JENKINS_BUILD_OUTPUT_PATH = "BuildOutputPath";
	public const string B_KEY_JENKINS_BUNDLE_ID = "BundleID";
	public const string B_KEY_JENKINS_PROFILE_ID = "ProfileID";
	public const string B_KEY_JENKINS_PLATFORM = "Platform";
	public const string B_KEY_JENKINS_PROJ_PLATFORM = "ProjPlatform";

	public const string B_KEY_JENKINS_BUILD_VER = "BuildVer";
	public const string B_KEY_JENKINS_BUILD_FUNC = "BuildFunc";
	public const string B_KEY_JENKINS_PIPELINE_NAME = "PipelineName";
	public const string B_KEY_JENKINS_IPA_EXPORT_METHOD = "IPAExportMethod";
	public const string B_KEY_JENKINS_BUILD_FILE_EXTENSION = "BuildFileExtension";
	// 식별자 }
	#endregion // 상수
}
#endif // #if UNITY_EDITOR
