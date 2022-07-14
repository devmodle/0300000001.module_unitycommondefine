using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DG.Tweening;
using MessagePack;

#region 기본
/** 작업 정보 */
public partial struct STTaskInfo {
	public Task m_oTask;
	public System.Action<Task> m_oCallback;
}

/** 기록 정보 */
public partial struct STRecordInfo {
	public bool m_bIsSuccess;
	public long m_nIntRecord;
	public double m_dblRealRecord;
}

/** 콜백 정보 */
public partial struct STCallbackInfo {
	public string m_oKey;
	public System.Action m_oCallback;
}

/** 컴포넌트 정보 */
public partial struct STComponentInfo {
	public int m_nID;
	public Component m_oComponent;
}

/** 정렬 순서 정보 */
public partial struct STSortingOrderInfo {
	public int m_nOrder;
	public string m_oLayer;
}

/** 비활성화 객체 정보 */
public partial struct STDespawnObjInfo {
	public bool m_bIsDestroy;
	public string m_oKey;
	public System.DateTime m_stDespawnTime;

	public GameObject m_oObj;
}

/** 터치 응답자 정보 */
public partial struct STTouchResponderInfo {
	public Sequence m_oAni;
	public GameObject m_oTouchResponder;
	public System.Action<GameObject> m_oCallback;
}

/** 식별자 정보 */
[MessagePackObject][System.Serializable]
public partial struct STIDInfo {
	[Key(0)] public int m_nID01;
	[Key(1)] public int m_nID02;
	[Key(2)] public int m_nID03;

	#region 상수
	public static readonly STIDInfo INVALID = new STIDInfo() {
		m_nID01 = KCDefine.B_IDX_INVALID, m_nID02 = KCDefine.B_IDX_INVALID, m_nID03 = KCDefine.B_IDX_INVALID
	};
	#endregion			// 상수

	#region 프로퍼티
	[IgnoreMember] public long UniqueID01 => this.UniqueID02 + m_nID01;
	[IgnoreMember] public long UniqueID02 => this.UniqueID03 + (m_nID02 * (long)KCDefine.B_UNIT_IDS_PER_IDS_02);
	[IgnoreMember] public long UniqueID03 => m_nID03 * (long)KCDefine.B_UNIT_IDS_PER_IDS_03;
	#endregion			// 프로퍼티

	#region 함수
	/** 생성자 */
	public STIDInfo(SimpleJSON.JSONNode a_oIDInfo) {
		string oID01Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_1_INT);
		string oID02Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_2_INT);
		string oID03Key = string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_3_INT);

		m_nID01 = (!a_oIDInfo[oID01Key].Value.Equals(KCDefine.B_TEXT_NULL) && a_oIDInfo[oID01Key].Value.Length > KCDefine.B_VAL_0_INT) ? a_oIDInfo[oID01Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID02 = (!a_oIDInfo[oID02Key].Value.Equals(KCDefine.B_TEXT_NULL) && a_oIDInfo[oID02Key].Value.Length > KCDefine.B_VAL_0_INT) ? a_oIDInfo[oID02Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID03 = (!a_oIDInfo[oID03Key].Value.Equals(KCDefine.B_TEXT_NULL) && a_oIDInfo[oID03Key].Value.Length > KCDefine.B_VAL_0_INT) ? a_oIDInfo[oID03Key].AsInt : KCDefine.B_VAL_0_INT;
	}
	#endregion			// 함수

	#region 조건부 함수
#if UNITY_EDITOR || UNITY_STANDALONE
	/** 식별자 정보를 생성한다 */
	public void MakeIDInfo(SimpleJSON.JSONClass a_oOutIDInfo) {
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_1_INT), $"{Mathf.Clamp(m_nID01, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_LEVEL_INFOS)}");
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_2_INT), $"{Mathf.Clamp(m_nID02, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_STAGE_INFOS)}");
		a_oOutIDInfo.Add(string.Format(KCDefine.U_KEY_FMT_ID, KCDefine.B_VAL_3_INT), $"{Mathf.Clamp(m_nID03, KCDefine.B_VAL_0_INT, KCDefine.U_MAX_NUM_CHAPTER_INFOS)}");
	}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
	#endregion			// 조건부 함수
}

/** 인덱스 정보 */
[MessagePackObject][System.Serializable]
public partial struct STIdxInfo {
	[Key(0)] public int m_nX;
	[Key(1)] public int m_nY;
	[Key(2)] public int m_nZ;

	#region 상수
	public static readonly STIdxInfo INVALID = new STIdxInfo() {
		m_nX = KCDefine.B_IDX_INVALID, m_nY = KCDefine.B_IDX_INVALID, m_nZ = KCDefine.B_IDX_INVALID
	};
	#endregion			// 상수
}

/** 빌드 버전 정보 */
[System.Serializable]
public partial struct STBuildVerInfo {
	public int m_nNum;
	public string m_oVer;
}

/** 결제 정보 */
[System.Serializable]
public partial struct STPurchaseInfo {
	public string m_oID;
	public string m_oReceipt;
}

/** 지역화 정보 */
[System.Serializable]
public partial struct STLocalizeInfo {
	public string m_oCountryCode;
	public SystemLanguage m_eSystemLanguage;
	public List<STFontSetInfo> m_oFontSetInfoList;

	#region 상수
	public static readonly STLocalizeInfo INVALID = new STLocalizeInfo() {
		m_eSystemLanguage = SystemLanguage.Unknown
	};
	#endregion			// 상수
}

/** 폰트 세트 정보 */
[System.Serializable]
public partial struct STFontSetInfo {
	public string m_oPath;
	public EFontSet m_eSet;

	#region 상수
	public static readonly STFontSetInfo INVALID = new STFontSetInfo() {
		m_eSet = EFontSet.NONE
	};
	#endregion			// 상수
}

/** 디바이스 정보 */
[System.Serializable]
public partial struct STDeviceInfo {
	public List<string> m_oiOSAdmobTestDeviceIDList;
	public List<string> m_oAndroidAdmobTestDeviceIDList;
}

/** 값 정보 */
[System.Serializable]
public partial struct STValInfo {
	public string m_oVal;
	public string m_oExtraVal;
	public EValType m_eValType;

	#region 상수
	public static readonly STValInfo INVALID = new STValInfo() {
		m_eValType = EValType.NONE
	};
	#endregion			// 상수

	#region 프로퍼티
	public long IntVal => long.TryParse(m_oVal, NumberStyles.Any, null, out long nVal) ? nVal : KCDefine.B_VAL_0_INT;
	public long IntExtraVal => long.TryParse(m_oExtraVal, NumberStyles.Any, null, out long nExtraVal) ? nExtraVal : KCDefine.B_VAL_0_INT;
	
	public double RealVal => double.TryParse(m_oVal, NumberStyles.Any, null, out double dblVal) ? dblVal : KCDefine.B_VAL_0_REAL;
	public double RealExtraVal => double.TryParse(m_oExtraVal, NumberStyles.Any, null, out double dblExtraVal) ? dblExtraVal : KCDefine.B_VAL_0_REAL;
	#endregion			// 프로퍼티

	#region 함수
	/** 생성자 */
	public STValInfo(SimpleJSON.JSONNode a_oValInfo) {
		m_oVal = (!a_oValInfo[KCDefine.B_VAL_1_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oValInfo[KCDefine.B_VAL_1_INT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oValInfo[KCDefine.B_VAL_1_INT] : KCDefine.B_STR_0_INT;
		m_oExtraVal = (!a_oValInfo[KCDefine.B_VAL_2_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oValInfo[KCDefine.B_VAL_2_INT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oValInfo[KCDefine.B_VAL_2_INT] : KCDefine.B_STR_0_INT;
		m_eValType = (!a_oValInfo[KCDefine.B_VAL_0_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oValInfo[KCDefine.B_VAL_0_INT].Value.Length > KCDefine.B_VAL_0_INT) ? (EValType)a_oValInfo[KCDefine.B_VAL_0_INT].AsInt : EValType.NONE;
	}
	#endregion			// 함수
}

/** 공용 정보 */
[System.Serializable]
public partial struct STCommonInfo {
	public bool m_bIsRepeat;

	public string m_oName;
	public string m_oDesc;

	#region 함수
	/** 생성자 */
	public STCommonInfo(SimpleJSON.JSONNode a_oCommonInfo) {
		m_bIsRepeat = (!a_oCommonInfo[KCDefine.U_KEY_REPEAT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oCommonInfo[KCDefine.U_KEY_REPEAT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oCommonInfo[KCDefine.U_KEY_REPEAT].AsInt != KCDefine.B_VAL_0_INT : false;

		m_oName = (!a_oCommonInfo[KCDefine.U_KEY_NAME].Value.Equals(KCDefine.B_TEXT_NULL) && a_oCommonInfo[KCDefine.U_KEY_NAME].Value.Length > KCDefine.B_VAL_0_INT) ? a_oCommonInfo[KCDefine.U_KEY_NAME] : string.Empty;
		m_oDesc = (!a_oCommonInfo[KCDefine.U_KEY_DESC].Value.Equals(KCDefine.B_TEXT_NULL) && a_oCommonInfo[KCDefine.U_KEY_DESC].Value.Length > KCDefine.B_VAL_0_INT) ? a_oCommonInfo[KCDefine.U_KEY_DESC] : string.Empty;
	}
	#endregion			// 함수

	#region 조건부 함수
#if UNITY_EDITOR || UNITY_STANDALONE
	/** 공용 정보를 생성한다 */
	public void MakeCommonInfo(SimpleJSON.JSONClass a_oOutCommonInfo) {
		a_oOutCommonInfo.Add(KCDefine.U_KEY_REPEAT, m_bIsRepeat ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);

		a_oOutCommonInfo.Add(KCDefine.U_KEY_NAME, m_oName ?? string.Empty);
		a_oOutCommonInfo.Add(KCDefine.U_KEY_DESC, m_oDesc ?? string.Empty);
	}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE
	#endregion			// 조건부 함수
}

/** 지속 시간 정보 */
[System.Serializable]
public partial struct STDurationInfo {
	public float m_fDelay;
	public float m_fDuration;
	public float m_fDeltaTime;

	#region 함수
	/** 생성자 */
	public STDurationInfo(SimpleJSON.JSONNode a_oDurationInfo) {
		m_fDelay = (!a_oDurationInfo[KCDefine.B_VAL_0_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oDurationInfo[KCDefine.B_VAL_0_INT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oDurationInfo[KCDefine.B_VAL_0_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDuration = (!a_oDurationInfo[KCDefine.B_VAL_1_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oDurationInfo[KCDefine.B_VAL_1_INT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oDurationInfo[KCDefine.B_VAL_1_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDeltaTime = (!a_oDurationInfo[KCDefine.B_VAL_2_INT].Value.Equals(KCDefine.B_TEXT_NULL) && a_oDurationInfo[KCDefine.B_VAL_2_INT].Value.Length > KCDefine.B_VAL_0_INT) ? a_oDurationInfo[KCDefine.B_VAL_2_INT].AsFloat : KCDefine.B_VAL_0_REAL;
	}
	#endregion			// 함수
}

/** 공용 타입 래퍼 */
[MessagePackObject]
public partial struct STCommonTypeWrapper {
	[Key(0)] public List<int> m_oIntList;
	[Key(1)] public List<float> m_oRealList;
	[Key(2)] public List<string> m_oStrList;

	[Key(10)] public Dictionary<int, int> m_oIntIntDict;
	[Key(11)] public Dictionary<int, float> m_oIntRealDict;
	[Key(12)] public Dictionary<int, string> m_oIntStrDict;

	[Key(20)] public Dictionary<long, int> m_oLongIntDict;
	[Key(21)] public Dictionary<long, float> m_oLongRealDict;
	[Key(22)] public Dictionary<long, string> m_oLongStrDict;

	[Key(30)] public Dictionary<string, int> m_oStrIntDict;
	[Key(31)] public Dictionary<string, float> m_oStrRealDict;
	[Key(32)] public Dictionary<string, string> m_oStrStrDict;
}

/** 경로 정보 */
public partial class CPathInfo {
	public int m_nCost = 0;
	public Vector3Int m_stIdx = Vector3Int.zero;
	
	public CPathInfo m_oPrevPathInfo = null;
}
#endregion			// 기본

#region 제네릭 타입
/** 리스트 래퍼 */
public partial class CListWrapper<T> {
	public List<T> m_oList = new List<T>();
	public List<T> m_oAddList = new List<T>();
	public List<T> m_oRemoveList = new List<T>();
}

/** 딕셔너리 래퍼 */
public partial class CDictWrapper<K, V> {
	public Dictionary<K, V> m_oDict = new Dictionary<K, V>();
	public Dictionary<K, V> m_oAddDict = new Dictionary<K, V>();
	public Dictionary<K, V> m_oRemoveDict = new Dictionary<K, V>();
}
#endregion			// 제네릭 타입

#region 조건부 타입
#if ADS_MODULE_ENABLE
/** 광고 보상 정보 */
public partial struct STAdsRewardInfo {
	public string m_oID;
	public string m_oVal;
}
#endif			// #if ADS_MODULE_ENABLE

#if NOTI_MODULE_ENABLE
/** 알림 정보 */
public partial struct STNotiInfo {
	public bool m_bIsRepeat;

	public string m_oTitle;
	public string m_oSubTitle;
	public string m_oMsg;

	public System.DateTime m_stNotiTime;
}
#endif			// #if NOTI_MODULE_ENABLE

#if UNITY_EDITOR || UNITY_STANDALONE
/** 에디터 레벨 생성 정보 */
public partial class CEditorLevelCreateInfo {
	public int m_nNumLevels = 0;

	public Vector3Int m_stMinNumCells = Vector3Int.zero;
	public Vector3Int m_stMaxNumCells = Vector3Int.zero;
}
#endif			// #if UNITY_EDITOR || UNITY_STANDALONE

#if (UNITY_STANDALONE && GOOGLE_SHEET_ENABLE) && (DEBUG || DEVELOPMENT_BUILD)
/** 구글 시트 정보 */
public partial struct STGoogleSheetInfo {
	public int m_nSrcIdx;
	public int m_nNumCells;

	public string m_oID;
	public string m_oName;
}
#endif			// #if (UNITY_STANDALONE && GOOGLE_SHEET_ENABLE) && (DEBUG || DEVELOPMENT_BUILD)
#endregion			// 조건부 타입
