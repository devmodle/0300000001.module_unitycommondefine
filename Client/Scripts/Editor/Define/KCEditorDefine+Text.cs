using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using UnityEditor;

/** 에디터 상수 - 텍스트 */
public static partial class KCEditorDefine {
	#region 상수
	// 기타 {
	public const string B_TEXT_OK = "확인";
	public const string B_TEXT_APPLY = "적용";
	public const string B_TEXT_ALERT = "알림";

	public const string B_TEXT_CANCEL = "취소";
	public const string B_TEXT_SEARCH = "검색";
	public const string B_TEXT_REPLACE = "변경";

	public const string B_TEXT_FONT_REPLACE = "=====> 폰트 변경 <=====";
	public const string B_TEXT_OBJ_NAME_REPLACE = "=====> 객체 이름 변경 <=====";
	// 기타 }

	// 알림 팝업 {
	public const string B_MSG_ALERT_P_RESET = "해당 속성을 리셋하시겠습니까?";
	public const string B_MSG_ALERT_P_EXPORT_IMG_SUCCESS = "이미지를 추출했습니다.";
	public const string B_MSG_ALERT_P_PLATFORM_BUILD_FAIL = "해당 플랫폼으로 전환 후 빌드해주세요.";

	public const string B_MSG_ALERT_P_EXPORT_TEX_FAIL = "텍스처를 선택해주세요.";
	public const string B_MSG_ALERT_P_EXPORT_SPRITE_FAIL = "스프라이트를 선택해주세요.";

	public const string B_MSG_FMT_ALERT_P_MISSING_PREFAB = "프리팹이 소실 된 {0} 객체를 제거하시겠습니까?";
	// 알림 팝업 }
	#endregion // 상수
}
#endif // #if UNITY_EDITOR
