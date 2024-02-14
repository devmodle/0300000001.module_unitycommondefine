using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if FLURRY_MODULE_ENABLE
/** 상수 - 플러리 */
public static partial class KCDefine {
	#region 컴파일 상수
	// 단위
	public const long B_TIMEOUT_FLURRY_M_NETWORK_CONNECTION = 60 * KCDefine.B_UNIT_MILLI_SECS_PER_SEC;

	// 식별자
	public const string B_KEY_FLURRY_M_INIT_CALLBACK = "FlurryMInitCallback";
	#endregion // 컴파일 상수
}
#endif // #if FLURRY_MODULE_ENABLE
