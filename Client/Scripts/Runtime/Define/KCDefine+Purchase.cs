using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if PURCHASE_MODULE_ENABLE
/** 상수 - 결제 */
public static partial class KCDefine {
	#region 클래스 프로퍼티
	public static string B_DATA_P_PURCHASE_PRODUCT_IDS => $"{KCDefine.B_DIR_P_WRITABLE}PurchaseProductIDs.bytes";
	#endregion // 클래스 프로퍼티

	#region 컴파일 상수
	// 기타 {
	public const string B_ENVIRONMENT_N_DEV = "development";
	public const string B_ENVIRONMENT_N_PRODUCTION = "production";
	
	public const string B_PAYLOAD_PURCHASE_M_PURCHASE_PRODUCT = "PurchaseMPurchaseProduct";
	// 기타 }

	// 식별자 {
	public const string B_KEY_PURCHASE_M_INIT_CALLBACK = "PurchaseMInitCallback";
	public const string B_KEY_PURCHASE_M_INIT_FAIL_CALLBACK = "PurchaseMInitFailCallback";
	public const string B_KEY_PURCHASE_M_PURCHASE_FAIL_CALLBACK = "PurchaseMPurchaseFailCallback";

	public const string B_KEY_PURCHASE_M_RESTORE_PRODUCTS_CALLBACK = "PurchaseMRestoreProductsCallback";
	public const string B_KEY_PURCHASE_M_CONFIRM_PURCHASE_CALLBACK = "PurchaseMConfirmPurchaseCallback";
	public const string B_KEY_PURCHASE_M_HANDLE_PURCHASE_RESULT_CALLBACK = "PurchaseMHandlePurchaseResultCallback";
	// 식별자 }
	#endregion // 컴파일 상수
}
#endif // #if PURCHASE_MODULE_ENABLE
