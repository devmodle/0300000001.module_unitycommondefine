using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! 약관 동의 씬 상수
public static partial class KCDefine {
	#region 기본
	// 이름
	public const string AS_OBJ_N_AGREE_POPUP = "AgreePopup";

	public const string AS_OBJ_N_SERVICES_TEXT = "ContentsText";
	public const string AS_OBJ_N_PRIVACY_TEXT = "ContentsText";

	public const string AS_OBJ_N_SERVICES_URL_TEXT = "ServicesURLText";
	public const string AS_OBJ_N_PRIVACY_URL_TEXT = "PrivacyURLText";

	public const string AS_OBJ_N_SERVICES_IMG = "CheckImg";
	public const string AS_OBJ_N_PRIVACY_IMG = "CheckImg";

	public const string AS_OBJ_N_SERVICES_BTN = "AgreeBtn";
	public const string AS_OBJ_N_PRIVACY_BTN = "AgreeBtn";

	public const string AS_OBJ_N_OK_BTN = "OKBtn";
	#endregion			// 기본

	#region 런타임 상수
	// 경로 {
	public static readonly string AS_DATA_P_SERVICES = string.Format("{0}{1}AS_Services_{2}", KCDefine.B_DIR_P_DATAS, KCDefine.B_DIR_P_AGREE_SCENE, SystemLanguage.Korean);
	public static readonly string AS_DATA_P_PRIVACY = string.Format("{0}{1}AS_Privacy_{2}", KCDefine.B_DIR_P_DATAS, KCDefine.B_DIR_P_AGREE_SCENE, SystemLanguage.Korean);

	public static readonly string AS_OBJ_P_LANDSCAPE_AGREE_POPUP = string.Format("{0}{1}AS_LandscapeAgreePopup", KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_AGREE_SCENE);
	public static readonly string AS_OBJ_P_PORTRAIT_AGREE_POPUP = string.Format("{0}{1}AS_PortraitAgreePopup", KCDefine.B_DIR_P_PREFABS, KCDefine.B_DIR_P_AGREE_SCENE);
	// 경로 }
	#endregion			// 런타임 상수
}
