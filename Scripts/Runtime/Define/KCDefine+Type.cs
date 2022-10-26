using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DG.Tweening;
using MessagePack;

#if GOOGLE_SHEET_ENABLE && (UNITY_EDITOR || UNITY_STANDALONE) && (DEBUG || DEVELOPMENT_BUILD)
using GoogleSheetsToUnity;
#endif            // #if GOOGLE_SHEET_ENABLE && (UNITY_EDITOR || UNITY_STANDALONE) && (DEBUG || DEVELOPMENT_BUILD)                                                                                                          

#region 기본
/** 상태 갱신 인터페이스 */
public partial interface IUpdater {
	/** 상태를 갱신한다 */
	public void OnUpdate(float a_fDeltaTime);

	/** 상태를 갱신한다 */
	public void OnLateUpdate(float a_fDeltaTime);
}

/** 작업 정보 */
public struct STTaskInfo {
	public Task m_oTask;
	public System.Action<Task> m_oCallback;
}

/** 콜백 정보 */
public struct STCallbackInfo {
	public string m_oKey;
	public System.Action m_oCallback;
}

/** 컴포넌트 정보 */
public struct STComponentInfo {
	public int m_nID;
	public Component m_oComponent;
}

/** 정렬 순서 정보 */
public struct STSortingOrderInfo {
	public int m_nOrder;
	public string m_oLayer;

	#region 상수
	public static readonly STSortingOrderInfo INVALID = new STSortingOrderInfo() {
		m_nOrder = int.MinValue
	};
	#endregion            // 상수               
}

/** 비활성화 객체 정보 */
public struct STDespawnObjInfo {
	public bool m_bIsDestroy;
	public string m_oObjsPoolKey;
	public System.DateTime m_stDespawnTime;

	public GameObject m_oObj;
}

/** 터치 응답자 정보 */
public struct STTouchResponderInfo {
	public Sequence m_oAni;
	public GameObject m_oTouchResponder;
	public System.Action<GameObject> m_oCallback;
}

/** 식별자 정보 */
[MessagePackObject]
[System.Serializable]
public struct STIDInfo {
	[Key(0)] public int m_nID01;
	[Key(1)] public int m_nID02;
	[Key(2)] public int m_nID03;

	#region 상수
	public static readonly STIDInfo INVALID = new STIDInfo() {
		m_nID01 = KCDefine.B_IDX_INVALID, m_nID02 = KCDefine.B_IDX_INVALID, m_nID03 = KCDefine.B_IDX_INVALID
	};
	#endregion            // 상수               

	#region 프로퍼티
	[IgnoreMember] public ulong UniqueID01 => this.UniqueID02 + ((ulong)m_nID01 * KCDefine.B_UNIT_IDS_PER_IDS_01);
	[IgnoreMember] public ulong UniqueID02 => this.UniqueID03 + ((ulong)m_nID02 * KCDefine.B_UNIT_IDS_PER_IDS_02);
	[IgnoreMember] public ulong UniqueID03 => (ulong)m_nID03 * KCDefine.B_UNIT_IDS_PER_IDS_03;
	#endregion            // 프로퍼티                 

	#region 함수
	/** 생성자 */
	public STIDInfo(SimpleJSON.JSONNode a_oIDInfo) {
		string oID01Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_1_INT);
		string oID02Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_2_INT);
		string oID03Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_3_INT);

		m_nID01 = a_oIDInfo[oID01Key].ExIsValid() ? a_oIDInfo[oID01Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID02 = a_oIDInfo[oID02Key].ExIsValid() ? a_oIDInfo[oID02Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID03 = a_oIDInfo[oID03Key].ExIsValid() ? a_oIDInfo[oID03Key].AsInt : KCDefine.B_VAL_0_INT;
	}

	/** 생성자 */
	public STIDInfo(int a_nID01, int a_nID02 = KCDefine.B_VAL_0_INT, int a_nID03 = KCDefine.B_VAL_0_INT) : this() {
		m_nID01 = a_nID01;
		m_nID02 = a_nID02;
		m_nID03 = a_nID03;
	}
	#endregion         // 함수               

	#region 조건부 함수
#if UNITY_EDITOR || UNITY_STANDALONE
	/** 식별자 정보를 생성한다 */
	public void MakeIDInfo(SimpleJSON.JSONClass a_oOutIDInfo) {
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_1_INT), $"{Mathf.Clamp(m_nID01, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_LEVEL_INFOS)}");
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_2_INT), $"{Mathf.Clamp(m_nID02, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_STAGE_INFOS)}");
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_3_INT), $"{Mathf.Clamp(m_nID03, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_CHAPTER_INFOS)}");
	}
#endif         // #if UNITY_EDITOR || UNITY_STANDALONE                                                 
	#endregion         // 조건부 함수                   
}

/** 인덱스 정보 */
[MessagePackObject]
[System.Serializable]
public struct STIdxInfo : System.IEquatable<STIdxInfo> {
	[Key(0)] public int m_nIdx01;
	[Key(1)] public int m_nIdx02;
	[Key(2)] public int m_nIdx03;

	#region 상수
	public static readonly STIdxInfo INVALID = new STIdxInfo() {
		m_nIdx01 = KCDefine.B_IDX_INVALID, m_nIdx02 = KCDefine.B_IDX_INVALID, m_nIdx03 = KCDefine.B_IDX_INVALID
	};
	#endregion            // 상수               

	#region IEquatable
	/** 동일 여부를 검사한다 */
	public bool Equals(STIdxInfo a_stIdxInfo) {
		return m_nIdx01 == a_stIdxInfo.m_nIdx01 && m_nIdx02 == a_stIdxInfo.m_nIdx02 && m_nIdx03 == a_stIdxInfo.m_nIdx03;
	}
	#endregion         // IEquatable                       

	#region 함수
	/** 생성자 */
	public STIdxInfo(int a_nIdx01, int a_nIdx02, int a_nIdx03 = KCDefine.B_IDX_INVALID) : this() {
		m_nIdx01 = a_nIdx01;
		m_nIdx02 = a_nIdx02;
		m_nIdx03 = a_nIdx03;
	}
	#endregion         // 함수               
}

/** 기록 정보 */
[MessagePackObject]
[System.Serializable]
public struct STRecordInfo {
	[Key(0)] public bool m_bIsSuccess;
	[Key(1)] public long m_nIntRecord;
	[Key(2)] public double m_dblRealRecord;
}

/** 빌드 버전 정보 */
[System.Serializable]
public struct STBuildVerInfo {
	public int m_nNum;
	public string m_oVer;
}

/** 결제 정보 */
[System.Serializable]
public struct STPurchaseInfo {
	public string m_oID;
	public string m_oReceipt;
}

/** 지역화 정보 */
[System.Serializable]
public struct STLocalizeInfo {
	public string m_oCountryCode;
	public SystemLanguage m_eSystemLanguage;
	public List<STFontSetInfo> m_oFontSetInfoList;

	#region 상수
	public static readonly STLocalizeInfo INVALID = new STLocalizeInfo() {
		m_eSystemLanguage = SystemLanguage.Unknown
	};
	#endregion            // 상수               
}

/** 폰트 세트 정보 */
[System.Serializable]
public struct STFontSetInfo {
	public string m_oPath;
	public EFontSet m_eSet;

	#region 상수
	public static readonly STFontSetInfo INVALID = new STFontSetInfo() {
		m_eSet = EFontSet.NONE
	};
	#endregion            // 상수               
}

/** 디바이스 정보 */
[System.Serializable]
public struct STDeviceInfo {
	public List<string> m_oiOSAdmobTestDeviceIDList;
	public List<string> m_oAndroidAdmobTestDeviceIDList;
}

/** 값 정보 */
[MessagePackObject]
[System.Serializable]
public struct STValInfo : System.IEquatable<STValInfo> {
	[Key(1)] public decimal m_dmVal;
	[Key(11)] public EValType m_eValType;

	#region 상수
	public static readonly STValInfo INVALID = new STValInfo() {
		m_eValType = EValType.NONE
	};
	#endregion            // 상수               

	#region IEquatable
	/** 동일 여부를 검사한다 */
	public bool Equals(STValInfo a_stValInfo) {
		return m_dmVal == a_stValInfo.m_dmVal && m_eValType == a_stValInfo.m_eValType;
	}
	#endregion         // IEquatable                       

	#region 함수
	/** 생성자 */
	public STValInfo(SimpleJSON.JSONNode a_oValInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT) {
		m_dmVal = decimal.TryParse(a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT], NumberStyles.Any, null, out decimal dmVal) ? dmVal : KCDefine.B_VAL_0_INT;
		m_eValType = a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].ExIsValid() ? (EValType)a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].AsInt : EValType.NONE;
	}

	/** 생성자 */
	public STValInfo(decimal a_dmVal, EValType a_eValType) : this() {
		m_dmVal = a_dmVal;
		m_eValType = a_eValType;
	}
	#endregion         // 함수               

	#region 조건부 함수
#if UNITY_EDITOR || UNITY_STANDALONE
	/** 값 정보를 생성한다 */
	public void MakeValInfo(string a_oKey, SimpleJSON.JSONClass a_oOutValInfo) {
		var oJSONArray = new SimpleJSON.JSONArray();
		oJSONArray.Add($"{(int)m_eValType}");
		oJSONArray.Add($"{m_dmVal}");

		a_oOutValInfo.Add(a_oKey, oJSONArray);
	}
#endif         // #if UNITY_EDITOR || UNITY_STANDALONE                                                 
	#endregion         // 조건부 함수                   
}

/** 공용 정보 */
[System.Serializable]
public struct STCommonInfo {
	public bool m_bIsTrue01;
	public bool m_bIsTrue02;
	public bool m_bIsTrue03;

	public string m_oName;
	public string m_oDesc;

	#region 함수
	/** 생성자 */
	public STCommonInfo(SimpleJSON.JSONNode a_oCommonInfo) {
		string oIsTrue01Key = string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_1_INT);
		string oIsTrue02Key = string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_2_INT);
		string oIsTrue03Key = string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_3_INT);

		m_bIsTrue01 = a_oCommonInfo[oIsTrue01Key].ExIsValid() ? a_oCommonInfo[oIsTrue01Key].AsInt != KCDefine.B_VAL_0_INT : false;
		m_bIsTrue02 = a_oCommonInfo[oIsTrue02Key].ExIsValid() ? a_oCommonInfo[oIsTrue02Key].AsInt != KCDefine.B_VAL_0_INT : false;
		m_bIsTrue03 = a_oCommonInfo[oIsTrue03Key].ExIsValid() ? a_oCommonInfo[oIsTrue03Key].AsInt != KCDefine.B_VAL_0_INT : false;

		m_oName = a_oCommonInfo[KCDefine.U_KEY_NAME].ExIsValid() ? a_oCommonInfo[KCDefine.U_KEY_NAME] : string.Empty;
		m_oDesc = a_oCommonInfo[KCDefine.U_KEY_DESC].ExIsValid() ? a_oCommonInfo[KCDefine.U_KEY_DESC] : string.Empty;
	}
	#endregion         // 함수               

	#region 조건부 함수
#if UNITY_EDITOR || UNITY_STANDALONE
	/** 공용 정보를 생성한다 */
	public void MakeCommonInfo(SimpleJSON.JSONClass a_oOutCommonInfo) {
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_1_INT), m_bIsTrue01 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_2_INT), m_bIsTrue02 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_TRUE, KCDefine.B_VAL_3_INT), m_bIsTrue03 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);

		a_oOutCommonInfo.Add(KCDefine.U_KEY_NAME, m_oName ?? string.Empty);
		a_oOutCommonInfo.Add(KCDefine.U_KEY_DESC, m_oDesc ?? string.Empty);
	}
#endif         // #if UNITY_EDITOR || UNITY_STANDALONE                                                 
	#endregion         // 조건부 함수                   
}

/** 시간 정보 */
[System.Serializable]
public struct STTimeInfo {
	public float m_fDelay;
	public float m_fDuration;
	public float m_fDeltaTime;

	#region 함수
	/** 생성자 */
	public STTimeInfo(SimpleJSON.JSONNode a_oDurationInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT) {
		m_fDelay = a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].ExIsValid() ? a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDuration = a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT].ExIsValid() ? a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDeltaTime = a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_2_INT].ExIsValid() ? a_oDurationInfo[a_nSrcIdx + KCDefine.B_VAL_2_INT].AsFloat : KCDefine.B_VAL_0_REAL;
	}
	#endregion         // 함수               
}

/** 공용 타입 래퍼 */
[MessagePackObject]
public struct STCommonTypeWrapper {
	[Key(0)] public List<int> m_oIntList;
	[Key(1)] public List<float> m_oRealList;
	[Key(2)] public List<string> m_oStrList;
}

/** 경로 정보 */
public partial class CPathInfo {
	public int m_nCost = 0;
	public Vector3Int m_stIdx = Vector3Int.zero;
	public CPathInfo m_oPrevPathInfo = null;
}

/** 상수 확장 클래스 */
public static partial class CDefineExtension {
	#region 클래스 함수
	/** 유효 여부를 검사한다 */
	internal static bool ExIsValid(this string a_oSender) {
		return a_oSender != null && a_oSender.Length > KCDefine.B_VAL_0_INT;
	}

	/** 유효 여부를 검사한다 */
	internal static bool ExIsValid(this SimpleJSON.JSONNode a_oSender) {
		return a_oSender != null && a_oSender.Value.ExIsValid() && !a_oSender.Value.Equals(KCDefine.B_TEXT_NULL);
	}
	#endregion         // 클래스 함수                   
}
#endregion         // 기본               

#region 제네릭 타입
/** 리스트 래퍼 */
public partial class CListWrapper<T> {
	public List<T> m_oList01 = new List<T>();
	public List<T> m_oList02 = new List<T>();
	public List<T> m_oList03 = new List<T>();
}

/** 딕셔너리 래퍼 */
public partial class CDictWrapper<K, V> {
	public Dictionary<K, V> m_oDict01 = new Dictionary<K, V>();
	public Dictionary<K, V> m_oDict02 = new Dictionary<K, V>();
	public Dictionary<K, V> m_oDict03 = new Dictionary<K, V>();
}
#endregion         // 제네릭 타입                   

#region 조건부 타입
#if ADS_MODULE_ENABLE
/** 광고 보상 정보 */
public struct STAdsRewardInfo {
	public string m_oID;
	public string m_oVal;

#region 상수
	public static readonly STAdsRewardInfo INVALID = new STAdsRewardInfo() {
		m_oID = string.Empty, m_oVal = string.Empty
	};
#endregion         // 상수               
}
#endif         // #if ADS_MODULE_ENABLE                                  

#if NOTI_MODULE_ENABLE
/** 알림 정보 */
public struct STNotiInfo {
	public bool m_bIsRepeat;

	public string m_oTitle;
	public string m_oSubTitle;
	public string m_oMsg;

	public System.DateTime m_stNotiTime;
}
#endif         // #if NOTI_MODULE_ENABLE                                   

#if UNITY_EDITOR || UNITY_STANDALONE
/** 에디터 레벨 생성 정보 */
public partial class CEditorLevelCreateInfo {
	public int m_nNumLevels = 0;
	public Vector3Int m_stMinNumCells = Vector3Int.zero;
	public Vector3Int m_stMaxNumCells = Vector3Int.zero;
}
#endif         // #if UNITY_EDITOR || UNITY_STANDALONE                                                 

#if GOOGLE_SHEET_ENABLE && (UNITY_EDITOR || UNITY_STANDALONE) && (DEBUG || DEVELOPMENT_BUILD)
/** 구글 시트 로드 정보 */
public struct STGoogleSheetLoadInfo {
	public int m_nSrcIdx;
	public int m_nNumCells;
	public string m_oID;
	public string m_oName;
	public GstuSpreadSheet m_oGoogleSheet;

#region 상수
	public static readonly STGoogleSheetLoadInfo INVALID = new STGoogleSheetLoadInfo() {
		m_nSrcIdx = KCDefine.B_IDX_INVALID
	};
#endregion            // 상수               
}
#endif         // #if GOOGLE_SHEET_ENABLE && (UNITY_EDITOR || UNITY_STANDALONE) && (DEBUG || DEVELOPMENT_BUILD)                                                                                                          
#endregion         // 조건부 타입                   
