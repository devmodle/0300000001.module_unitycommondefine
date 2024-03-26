using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if PURCHASE_MODULE_ENABLE
/** 상수 - 결제 */
public static partial class KCDefine
{
	#region 클래스 프로퍼티
	public static string G_PURCHASE_M_DATA_P_IDS_PRODUCT_PURCHASE => $"{KCDefine.B_DIR_P_WRITABLE}IDsProductPurchase.bytes";
	#endregion // 클래스 프로퍼티

	#region 컴파일 상수
	// 기타 {
	public const string G_PURCHASE_M_ENVIRONMENT_N_DEV = "development";
	public const string G_PURCHASE_M_ENVIRONMENT_N_PRODUCTION = "production";

	public const string G_PURCHASE_M_PAYLOAD_PRODUCT_PURCHASE = "PurchaseMPayloadProductPurchase";
	// 기타 }

	// 식별자 {
	public const string G_PURCHASE_M_KEY_CALLBACK_INIT = "PurchaseMCallbackInit";
	public const string G_PURCHASE_M_KEY_CALLBACK_FAIL_INIT = "PurchaseMCallbackFailInit";
	public const string G_PURCHASE_M_KEY_CALLBACK_FAIL_PURCHASE = "PurchaseMCallbackFailPurchase";

	public const string G_PURCHASE_M_KEY_CALLBACK_PRODUCTS_RESTORE = "PurchaseMCallbackProductsRestore";
	public const string G_PURCHASE_M_KEY_CALLBACK_PURCHASE_CONFIRM = "PurchaseMCallbackPurchaseConfirm";
	public const string G_PURCHASE_M_KEY_CALLBACK_RESULT_PURCHASE_HANDLE = "PurchaseMCallbackResultPurchaseHandle";
	// 식별자 }
	#endregion // 컴파일 상수
}
#endif // #if PURCHASE_MODULE_ENABLE
