using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if ADS_MODULE_ENABLE
#if ADMOB_ADS_ENABLE
using GoogleMobileAds.Api;
#endif // #if ADMOB_ADS_ENABLE

/** 상수 - 광고 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 단위
	public const float U_DELTA_T_ADS_M_ADS_LOAD = 5.0f;

	// 식별자 {
	public const string U_KEY_ADS_M_BANNER_ADS_ID = "AdsMBannerAdsID";
	public const string U_KEY_ADS_M_FULLSCREEN_ADS_ID = "AdsMFullscreenAdsID";
	public const string U_KEY_ADS_M_REWARD_ADS_ID = "AdsMRewardAdsID";

	public const string U_KEY_FMT_ADS_M_LOAD_FAIL_BANNER_ADS_INFO = "AdsMLoadFailBannerAdsInfo_{0}";
	public const string U_KEY_FMT_ADS_M_LOAD_FAIL_FULLSCREEN_ADS_INFO = "AdsMLoadFailFullscreenAdsInfo_{0}";
	public const string U_KEY_FMT_ADS_M_LOAD_FAIL_REWARD_ADS_INFO = "AdsMLoadFailRewardAdsInfo_{0}";
	// 식별자 }

#if ADMOB_ADS_ENABLE
	// 식별자 {
	public const string U_ADS_ID_ADMOB_TEST_BANNER_ADS = "ca-app-pub-3940256099942544/6300978111";
	public const string U_ADS_ID_ADMOB_TEST_FULLSCREEN_ADS = "ca-app-pub-3940256099942544/1033173712";
	public const string U_ADS_ID_ADMOB_TEST_REWARD_ADS = "ca-app-pub-3940256099942544/5224354917";

	public const string U_KEY_ADS_M_ADMOB_INIT_CALLBACK = "AdsMAdmobInitCallback";

	public const string U_KEY_ADS_M_ADMOB_BANNER_ADS_LOAD_CALLBACK = "AdsMAdmobBannerAdsLoadCallback";
	public const string U_KEY_ADS_M_ADMOB_BANNER_ADS_LOAD_FAIL_CALLBACK = "AdsMAdmobBannerAdsLoadFailCallback";
	public const string U_KEY_ADS_M_ADMOB_BANNER_ADS_CLOSE_CALLBACK = "AdsMAdmobBannerAdsCloseCallback";

	public const string U_KEY_ADS_M_ADMOB_FULLSCREEN_ADS_LOAD_CALLBACK = "AdsMAdmobFullscreenAdsLoadCallback";
	public const string U_KEY_ADS_M_ADMOB_FULLSCREEN_ADS_LOAD_FAIL_CALLBACK = "AdsMAdmobFullscreenAdsLoadFailCallback";
	public const string U_KEY_ADS_M_ADMOB_FULLSCREEN_ADS_CLOSE_CALLBACK = "AdsMAdmobFullscreenAdsCloseCallback";

	public const string U_KEY_ADS_M_ADMOB_REWARD_ADS_LOAD_CALLBACK = "AdsMAdmobRewardAdsLoadCallback";
	public const string U_KEY_ADS_M_ADMOB_REWARD_ADS_LOAD_FAIL_CALLBACK = "AdsMAdmobRewardAdsLoadFailCallback";
	public const string U_KEY_ADS_M_ADMOB_REWARD_ADS_CLOSE_CALLBACK = "AdsMAdmobRewardAdsCloseCallback";
	public const string U_KEY_ADS_M_ADMOB_REWARD_ADS_RECEIVE_ADS_REWARD_CALLBACK = "AdsMAdmobRewardAdsReceiveAdsRewardCallback";
	// 식별자 }
#endif // #if ADMOB_ADS_ENABLE

#if IRON_SRC_ADS_ENABLE
	// 식별자 {
	public const string U_KEY_ADS_M_IRON_SRC_INIT_CALLBACK = "AdsMIronSrcInitCallback";

	public const string U_KEY_ADS_M_IRON_SRC_BANNER_ADS_LOAD_CALLBACK = "AdsMIronSrcBannerAdsLoadCallback";
	public const string U_KEY_ADS_M_IRON_SRC_BANNER_ADS_LOAD_FAIL_CALLBACK = "AdsMIronSrcBannerAdsLoadFailCallback";

	public const string U_KEY_ADS_M_IRON_SRC_FULLSCREEN_ADS_LOAD_CALLBACK = "AdsMIronSrcFullscreenAdsLoadCallback";
	public const string U_KEY_ADS_M_IRON_SRC_FULLSCREEN_ADS_LOAD_FAIL_CALLBACK = "AdsMIronSrcFullscreenAdsLoadFailCallback";
	public const string U_KEY_ADS_M_IRON_SRC_FULLSCREEN_ADS_CLOSE_CALLBACK = "AdsMIronSrcFullscreenAdsCloseCallback";

	public const string U_KEY_ADS_M_IRON_SRC_REWARD_ADS_LOAD_CALLBACK = "AdsMIronSrcRewardAdsLoadCallback";
	public const string U_KEY_ADS_M_IRON_SRC_REWARD_ADS_LOAD_FAIL_CALLBACK = "AdsMIronSrcRewardAdsLoadFailCallback";
	public const string U_KEY_ADS_M_IRON_SRC_REWARD_ADS_CLOSE_CALLBACK = "AdsMIronSrcRewardAdsCloseCallback";
	public const string U_KEY_ADS_M_IRON_SRC_REWARD_ADS_RECEIVE_ADS_REWARD_CALLBACK = "AdsMIronSrcRewardAdsReceiveAdsRewardCallback";
	// 식별자 }
#endif // #if IRON_SRC_ADS_ENABLE

#if APP_LOVIN_ADS_ENABLE
	// 식별자 {
	public const string U_KEY_ADS_M_APP_LOVIN_IS_ADAPTIVE_BANNER = "adaptive_banner";
	public const string U_KEY_ADS_M_APP_LOVIN_INIT_CALLBACK = "AdsMAppLovinInitCallback";

	public const string U_KEY_ADS_M_APP_LOVIN_BANNER_ADS_LOAD_CALLBACK = "AdsMAppLovinBannerAdsLoadCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_BANNER_ADS_LOAD_FAIL_CALLBACK = "AdsMAppLovinBannerAdsLoadFailCallback";

	public const string U_KEY_ADS_M_APP_LOVIN_FULLSCREEN_ADS_LOAD_CALLBACK = "AdsMAppLovinFullscreenAdsLoadCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_FULLSCREEN_ADS_LOAD_FAIL_CALLBACK = "AdsMAppLovinFullscreenAdsLoadFailCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_FULLSCREEN_ADS_CLOSE_CALLBACK = "AdsMAppLovinFullscreenAdsCloseCallback";

	public const string U_KEY_ADS_M_APP_LOVIN_REWARD_ADS_LOAD_CALLBACK = "AdsMAppLovinRewardAdsLoadCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_REWARD_ADS_LOAD_FAIL_CALLBACK = "AdsMAppLovinRewardAdsLoadFailCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_REWARD_ADS_CLOSE_CALLBACK = "AdsMAppLovinRewardAdsCloseCallback";
	public const string U_KEY_ADS_M_APP_LOVIN_REWARD_ADS_RECEIVE_ADS_REWARD_CALLBACK = "AdsMAppLovinRewardAdsReceiveAdsRewardCallback";
	// 식별자 }
#endif // #if APP_LOVIN_ADS_ENABLE
	#endregion // 컴파일 상수

	#region 런타임 상수
#if ADMOB_ADS_ENABLE
	// 단위
	public static readonly AdSize U_SIZE_ADMOB_BANNER_ADS = new AdSize((int)KCDefine.U_SIZE_BANNER_ADS.x, (int)KCDefine.U_SIZE_BANNER_ADS.y);
#endif // #if ADMOB_ADS_ENABLE

#if IRON_SRC_ADS_ENABLE
	// 단위
	public static readonly IronSourceBannerSize U_SIZE_IRON_SRC_BANNER_ADS = new IronSourceBannerSize((int)KCDefine.U_SIZE_BANNER_ADS.x, (int)KCDefine.U_SIZE_BANNER_ADS.y);
#endif // #if IRON_SRC_ADS_ENABLE
	#endregion // 런타임 상수
}
#endif // #if ADS_MODULE_ENABLE
