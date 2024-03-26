using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEngine.Rendering;
using UnityEditor;

/** 에디터 상수 - iOS */
public static partial class KCDefineEditor
{
	#region 상수
	// 기타 {
	public const string B_IPA_EXPORT_METHOD_IOS_DEV = "development";
	public const string B_IPA_EXPORT_METHOD_IOS_STORE = "app-store";

	public const string B_BUILD_CMD_FMT_IOS_COCOA_PODS = "pod update --clean-install --project-directory={0}";
	// 기타 }

	// 텍스트 {
	public const string B_TEXT_IOS_TRUE = "YES";
	public const string B_TEXT_IOS_FALSE = "NO";

	public const string B_TEXT_IOS_METAL = "metal";
	public const string B_TEXT_IOS_ARM_64 = "arm64";
	// 텍스트 }

	// 이름 {
	public const string B_BUILD_FILE_EXTENSION_IOS_IPA = "ipa";

	public const string B_PROPERTY_N_IOS_ENABLE_BITCODE = "ENABLE_BITCODE";
	public const string B_PROPERTY_N_IOS_USER_HEADER_SEARCH_PATHS = "USER_HEADER_SEARCH_PATHS";
	public const string B_PROPERTY_N_IOS_PREPROCESSOR_DEFINITIONS = "GCC_PREPROCESSOR_DEFINITIONS";
	public const string B_PROPERTY_N_IOS_ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES = "ALWAYS_EMBED_SWIFT_STANDARD_LIBRARIES";
	// 이름 }

	// 경로 {
	public const string B_BUILD_P_FMT_IOS = "Builds/iOS/{0}";
	public const string B_SEARCH_P_IOS_PODS = "$(SRCROOT)/**";
	public const string B_BUILD_OUTPUT_P_FMT_IOS = "Builds/iOS/{0}/BuildOutput/Export/{0}BuildOutput.{1}";

	public const string B_DATA_P_FMT_INFO_IOS = "{0}/Info.plist";
	public const string B_DATA_P_FMT_COCOA_PODS = "{0}/Podfile";
	public const string B_PROJ_P_FMT_COCOA_PODS = "{0}/Pods/Pods.xcodeproj/project.pbxproj";
	// 경로 }

	// 식별자 {
	public const string B_KEY_IOS_ADS_NETWORK_ID = "SKAdNetworkIdentifier";
	public const string B_KEY_IOS_ADS_NETWORK_ITEMS = "SKAdNetworkItems";

	public const string B_KEY_IOS_ALLOWS_ARBITRARY_LOADS = "NSAllowsArbitraryLoads";
	public const string B_KEY_IOS_APP_TRANSPORT_SECURITY = "NSAppTransportSecurity";

	public const string B_KEY_IOS_REQUIRED_DEVICE_CAPABILITIES = "UIRequiredDeviceCapabilities";
	public const string B_KEY_IOS_APP_USES_NON_EXEMPT_ENCRYPTION_ENABLE = "ITSAppUsesNonExemptEncryption";

	public const string B_KEY_IOS_USER_TRACKING_USAGE_DESC = "NSUserTrackingUsageDescription";
	public const string B_KEY_IOS_FIREBASE_APP_STORE_RECEIPT_URL_CHECK_ENABLE = "FirebaseAppStoreReceiptURLCheckEnabled";
	// 식별자 }
	#endregion // 상수

	#region 런타임 상수
	// 기타
	public static readonly List<GraphicsDeviceType> B_GRAPHICS_DEVICE_TYPE_LIST_IOS = new List<GraphicsDeviceType>() {
		GraphicsDeviceType.Metal
	};

	// 경로 {
	public static readonly string B_ABS_BUILD_P_IOS = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../Builds/iOS";
	public static readonly string B_PLUGIN_PROJ_P_IOS = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/iOS";
	public static readonly string B_ENTITLEMENTS_P_CAPABILITY_IOS = $"{Application.identifier}.entitlements";

	public static readonly string B_SRC_PLUGIN_P_IOS = $"{KCDefineEditor.B_ABS_DIR_P_ASSETS}../NativePlugins/Client/iOS/Classes/Plugin/";
	public static readonly string B_DEST_PLUGIN_P_IOS = $"{KCDefineEditor.B_ABS_DIR_P_IOS_PLUGINS}CustomiOSNativePlugin/";
	// 경로 }
	#endregion // 런타임 상수
}
#endif // #if UNITY_EDITOR
