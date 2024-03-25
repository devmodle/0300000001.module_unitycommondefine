using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DG.Tweening;
using MessagePack;
using EnhancedUI.EnhancedScroller;

#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
using Newtonsoft.Json;
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE

#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
using GoogleSheetsToUnity;
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)

#region 타입
/** 콜백 정보 */
public struct STCallbackInfo
{
	public string m_oKey;
	public System.Action m_oCallback;

	#region 함수
	/** 생성자 */
	public STCallbackInfo(string a_oKey, System.Action a_oCallback)
	{
		m_oKey = a_oKey;
		m_oCallback = a_oCallback;
	}
	#endregion // 함수
}

/** 컴포넌트 정보 */
public struct STComponentInfo
{
	public int m_nID;
	public Component m_oComponent;

	#region 함수
	/** 생성자 */
	public STComponentInfo(int a_nID, Component a_oComponent)
	{
		m_nID = a_nID;
		m_oComponent = a_oComponent;
	}
	#endregion // 함수
}

/** 스크롤러 정보 */
public struct STScrollerInfo
{
	public EnhancedScroller m_oScroller;
	public EnhancedScrollerCellView m_oScrollerCellView;

	#region 함수
	/** 생성자 */
	public STScrollerInfo(EnhancedScroller a_oScroller, EnhancedScrollerCellView a_oScrollerCellView)
	{
		m_oScroller = a_oScroller;
		m_oScrollerCellView = a_oScrollerCellView;
	}
	#endregion // 함수
}

/** 정렬 순서 정보 */
public struct STSortingOrderInfo
{
	public int m_nOrder;
	public string m_oLayer;

	#region 상수
	public static readonly STSortingOrderInfo INVALID = new STSortingOrderInfo()
	{
		m_nOrder = short.MinValue,
		m_oLayer = KCDefine.B_SORTING_L_UNDERGROUND
	};
	#endregion // 상수

	#region 함수
	/** 생성자 */
	public STSortingOrderInfo(int a_nOrder, string a_oLayer)
	{
		m_nOrder = a_nOrder;
		m_oLayer = a_oLayer;
	}
	#endregion // 함수
}

/** 식별자 정보 */
[MessagePackObject]
[System.Serializable]
public struct STIDInfo
{
	[Key(0)] public int m_nID01;
	[Key(1)] public int m_nID02;
	[Key(2)] public int m_nID03;

	#region 상수
	public static readonly STIDInfo INVALID = new STIDInfo()
	{
		m_nID01 = KCDefine.B_IDX_INVALID,
		m_nID02 = KCDefine.B_IDX_INVALID,
		m_nID03 = KCDefine.B_IDX_INVALID
	};
	#endregion // 상수

	#region 프로퍼티
	[IgnoreMember] public ulong UniqueID01 => this.UniqueID02 + ((ulong)m_nID01 * KCDefine.B_UNIT_IDS_PER_IDS_01);
	[IgnoreMember] public ulong UniqueID02 => this.UniqueID03 + ((ulong)m_nID02 * KCDefine.B_UNIT_IDS_PER_IDS_02);
	[IgnoreMember] public ulong UniqueID03 => (ulong)m_nID03 * KCDefine.B_UNIT_IDS_PER_IDS_03;
	#endregion // 프로퍼티

	#region 함수
	/** 생성자 */
	public STIDInfo(SimpleJSON.JSONNode a_oIDInfo, string a_oFmt = KCDefine.U_KEY_FMT_ID)
	{
		string oID01Key = string.Format(a_oFmt, KCDefine.B_VAL_1_INT);
		string oID02Key = string.Format(a_oFmt, KCDefine.B_VAL_2_INT);
		string oID03Key = string.Format(a_oFmt, KCDefine.B_VAL_3_INT);

		m_nID01 = a_oIDInfo[oID01Key].ExIsValid() ? a_oIDInfo[oID01Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID02 = a_oIDInfo[oID02Key].ExIsValid() ? a_oIDInfo[oID02Key].AsInt : KCDefine.B_VAL_0_INT;
		m_nID03 = a_oIDInfo[oID03Key].ExIsValid() ? a_oIDInfo[oID03Key].AsInt : KCDefine.B_VAL_0_INT;
	}

	/** 생성자 */
	public STIDInfo(int a_nID01, int a_nID02 = KCDefine.B_VAL_0_INT, int a_nID03 = KCDefine.B_VAL_0_INT)
	{
		m_nID01 = a_nID01;
		m_nID02 = a_nID02;
		m_nID03 = a_nID03;
	}
	#endregion // 함수

	#region 조건부 함수
#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	/** 식별자 정보를 저장한다 */
	public void SaveIDInfo(SimpleJSON.JSONNode a_oOutIDInfo, string a_oFmt = KCDefine.U_KEY_FMT_ID)
	{
		a_oOutIDInfo[string.Format(a_oFmt, KCDefine.B_VAL_1_INT)] = $"{m_nID01}";
		a_oOutIDInfo[string.Format(a_oFmt, KCDefine.B_VAL_2_INT)] = $"{m_nID02}";
		a_oOutIDInfo[string.Format(a_oFmt, KCDefine.B_VAL_3_INT)] = $"{m_nID03}";
	}
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 함수
}

/** 인덱스 정보 */
[MessagePackObject]
[System.Serializable]
public struct STIdxInfo : System.IEquatable<STIdxInfo>
{
	[Key(0)] public int m_nIdxA;
	[Key(1)] public int m_nIdxB;
	[Key(2)] public int m_nIdxC;

	#region 상수
	public static readonly STIdxInfo INVALID = new STIdxInfo()
	{
		m_nIdxA = KCDefine.B_IDX_INVALID,
		m_nIdxB = KCDefine.B_IDX_INVALID,
		m_nIdxC = KCDefine.B_IDX_INVALID
	};
	#endregion // 상수

	#region IEquatable
	/** 동일 여부를 검사한다 */
	public bool Equals(STIdxInfo a_stIdxInfo)
	{
		return m_nIdxA == a_stIdxInfo.m_nIdxA &&
			m_nIdxB == a_stIdxInfo.m_nIdxB && m_nIdxC == a_stIdxInfo.m_nIdxC;
	}
	#endregion // IEquatable

	#region operator
	/** 인덱스 정보 => 인덱스로 변환한다 */
	public static implicit operator Vector2Int(STIdxInfo a_stSender)
	{
		return new Vector2Int(a_stSender.m_nIdxA, a_stSender.m_nIdxB);
	}

	/** 인덱스 정보 => 인덱스로 변환한다 */
	public static implicit operator Vector3Int(STIdxInfo a_stSender)
	{
		return new Vector3Int(a_stSender.m_nIdxA, a_stSender.m_nIdxB, a_stSender.m_nIdxC);
	}

	/** 인덱스 => 인덱스 정보로 변환한다 */
	public static implicit operator STIdxInfo(Vector2Int a_stSender)
	{
		return new STIdxInfo(a_stSender.x, a_stSender.y, KCDefine.B_VAL_0_INT);
	}

	/** 인덱스 => 인덱스 정보로 변환한다 */
	public static implicit operator STIdxInfo(Vector3Int a_stSender)
	{
		return new STIdxInfo(a_stSender.x, a_stSender.y, a_stSender.z);
	}
	#endregion // operator

	#region 함수
	/** 생성자 */
	public STIdxInfo(int a_nIdx01, int a_nIdx02, int a_nIdx03 = KCDefine.B_VAL_0_INT)
	{
		m_nIdxA = a_nIdx01;
		m_nIdxB = a_nIdx02;
		m_nIdxC = a_nIdx03;
	}
	#endregion // 함수
}

/** 기록 정보 */
[MessagePackObject]
[System.Serializable]
public struct STRecordInfo
{
	[Key(0)] public bool m_bIsSuccess;
	[Key(1)] public long m_nIntRecord;
	[Key(2)] public double m_dblRealRecord;

	#region 함수
	/** 생성자 */
	public STRecordInfo(long a_nIntRecord, double a_dblRealRecord, bool a_bIsSuccess)
	{
		m_bIsSuccess = a_bIsSuccess;
		m_nIntRecord = a_nIntRecord;
		m_dblRealRecord = a_dblRealRecord;
	}
	#endregion // 함수
}

/** 빌드 버전 정보 */
[System.Serializable]
public struct STBuildVerInfo
{
	public int m_nNum;
	public string m_oVer;
}

/** 결제 정보 */
[System.Serializable]
public struct STPurchaseInfo
{
	public string m_oID;
	public string m_oReceipt;
}

/** 지역화 정보 */
[System.Serializable]
public struct STLocalizeInfo
{
	public string m_oCountryCode;
	public SystemLanguage m_eSystemLanguage;
	public List<STFontSetInfo> m_oFontSetInfoList;

	#region 상수
	public static readonly STLocalizeInfo INVALID = new STLocalizeInfo()
	{
		m_eSystemLanguage = SystemLanguage.Unknown
	};
	#endregion // 상수
}

/** 폰트 세트 정보 */
[System.Serializable]
public struct STFontSetInfo
{
	public string m_oPath;
	public EFontSet m_eSet;

	#region 상수
	public static readonly STFontSetInfo INVALID = new STFontSetInfo()
	{
		m_eSet = EFontSet.NONE
	};
	#endregion // 상수
}

/** 디바이스 정보 */
[System.Serializable]
public struct STDeviceInfo
{
	public List<string> m_oiOSAdmobTestDeviceIDList;
	public List<string> m_oAndroidAdmobTestDeviceIDList;
}

/** 값 정보 */
[MessagePackObject]
[System.Serializable]
public struct STValInfo : System.IEquatable<STValInfo>
{
	[Key(1)] public decimal m_dmVal;
	[Key(11)] public EValType m_eValType;

	#region 상수
	public static readonly STValInfo INVALID = new STValInfo()
	{
		m_eValType = EValType.NONE
	};
	#endregion // 상수

	#region IEquatable
	/** 동일 여부를 검사한다 */
	public bool Equals(STValInfo a_stValInfo)
	{
		return m_dmVal == a_stValInfo.m_dmVal && m_eValType == a_stValInfo.m_eValType;
	}
	#endregion // IEquatable

	#region 함수
	/** 생성자 */
	public STValInfo(SimpleJSON.JSONNode a_oValInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT)
	{
		m_dmVal = decimal.TryParse(a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT], NumberStyles.Any, null, out decimal dmVal) ? dmVal : KCDefine.B_VAL_0_INT;
		m_eValType = a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].ExIsValid() ? (EValType)a_oValInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].AsInt : EValType.NONE;
	}

	/** 생성자 */
	public STValInfo(EValType a_eValType, decimal a_dmVal)
	{
		m_dmVal = a_dmVal;
		m_eValType = a_eValType;
	}
	#endregion // 함수

	#region 조건부 함수
#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	/** 값 정보를 저장한다 */
	public void SaveValInfo(SimpleJSON.JSONNode a_oOutValInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT)
	{
		a_oOutValInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT] = $"{(int)m_eValType}";
		a_oOutValInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT] = (m_eValType == EValType.INT) ? $"{m_dmVal:0}" : $"{m_dmVal:0.0}";
	}
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 함수
}

/** 공용 정보 */
[System.Serializable]
public struct STCommonInfo
{
	public bool m_bIsFlags01;
	public bool m_bIsFlags02;
	public bool m_bIsFlags03;

	public string m_oName;
	public string m_oDesc;

	#region 함수
	/** 생성자 */
	public STCommonInfo(SimpleJSON.JSONNode a_oCommonInfo)
	{
		string oFlags01Key = string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_1_INT);
		string oFlags02Key = string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_2_INT);
		string oFlags03Key = string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_3_INT);

		m_bIsFlags01 = a_oCommonInfo[oFlags01Key].ExIsValid() ? a_oCommonInfo[oFlags01Key].AsInt != KCDefine.B_VAL_0_INT : false;
		m_bIsFlags02 = a_oCommonInfo[oFlags02Key].ExIsValid() ? a_oCommonInfo[oFlags02Key].AsInt != KCDefine.B_VAL_0_INT : false;
		m_bIsFlags03 = a_oCommonInfo[oFlags03Key].ExIsValid() ? a_oCommonInfo[oFlags03Key].AsInt != KCDefine.B_VAL_0_INT : false;

		m_oName = a_oCommonInfo[KCDefine.U_KEY_NAME].ExIsValid() ? a_oCommonInfo[KCDefine.U_KEY_NAME] : string.Empty;
		m_oDesc = a_oCommonInfo[KCDefine.U_KEY_DESC].ExIsValid() ? a_oCommonInfo[KCDefine.U_KEY_DESC] : string.Empty;
	}
	#endregion // 함수

	#region 조건부 함수
#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	/** 공용 정보를 저장한다 */
	public void SaveCommonInfo(SimpleJSON.JSONNode a_oOutCommonInfo)
	{
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_1_INT), m_bIsFlags01 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_2_INT), m_bIsFlags02 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);
		a_oOutCommonInfo.Add(string.Format(KCDefine.U_KEY_FMT_FLAGS, KCDefine.B_VAL_3_INT), m_bIsFlags03 ? KCDefine.B_STR_1_INT : KCDefine.B_STR_0_INT);

		a_oOutCommonInfo.Add(KCDefine.U_KEY_NAME, m_oName ?? string.Empty);
		a_oOutCommonInfo.Add(KCDefine.U_KEY_DESC, m_oDesc ?? string.Empty);
	}
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 함수
}

/** 시간 정보 */
[System.Serializable]
public struct STTimeInfo
{
	public float m_fDelay;
	public float m_fDuration;
	public float m_fDeltaTime;

	#region 함수
	/** 생성자 */
	public STTimeInfo(SimpleJSON.JSONNode a_oTimeInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT)
	{
		m_fDelay = a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].ExIsValid() ? a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDuration = a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT].ExIsValid() ? a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT].AsFloat : KCDefine.B_VAL_0_REAL;
		m_fDeltaTime = a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_2_INT].ExIsValid() ? a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_2_INT].AsFloat : KCDefine.B_VAL_0_REAL;
	}
	#endregion // 함수

	#region 조건부 함수
#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	/** 시간 정보를 저장한다 */
	public void SaveTimeInfo(SimpleJSON.JSONNode a_oTimeInfo, int a_nSrcIdx = KCDefine.B_VAL_0_INT)
	{
		a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_0_INT] = $"{m_fDelay:0.0}";
		a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_1_INT] = $"{m_fDuration:0.0}";
		a_oTimeInfo[a_nSrcIdx + KCDefine.B_VAL_2_INT] = $"{m_fDeltaTime:0.0}";
	}
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
	#endregion // 조건부 함수
}

/** 키 정보 */
public struct STKeyInfo
{
	public string m_oKey;
	public EKeyType m_eKeyType;

	#region 함수
	/** 생성자 */
	public STKeyInfo(string a_oKey, EKeyType a_eKeyType)
	{
		m_oKey = a_oKey;
		m_eKeyType = a_eKeyType;
	}
	#endregion // 함수
}

/** 테이블 정보 */
public struct STTableInfo
{
	public string m_oID;
	public string m_oTableName;
	public Dictionary<System.Type, Dictionary<string, string>> m_oSheetNameDictContainer;
	public Dictionary<System.Type, Dictionary<string, List<string>>> m_oExtraSheetNameDictContainer;
	public Dictionary<System.Type, Dictionary<string, List<STKeyInfo>>> m_oKeyInfoDictContainer;

	#region 함수
	/** 생성자 */
	public STTableInfo(string a_oID, string a_oTableName, Dictionary<System.Type, Dictionary<string, string>> a_oSheetNameDictContainer = null, Dictionary<System.Type, Dictionary<string, List<string>>> a_oExtraSheetNameDictContainer = null, Dictionary<System.Type, Dictionary<string, List<STKeyInfo>>> a_oKeyInfoDictContainer = null)
	{
		m_oID = a_oID;
		m_oTableName = a_oTableName;
		m_oSheetNameDictContainer = a_oSheetNameDictContainer ?? new Dictionary<System.Type, Dictionary<string, string>>();
		m_oExtraSheetNameDictContainer = a_oExtraSheetNameDictContainer ?? new Dictionary<System.Type, Dictionary<string, List<string>>>();
		m_oKeyInfoDictContainer = a_oKeyInfoDictContainer ?? new Dictionary<System.Type, Dictionary<string, List<STKeyInfo>>>();
	}
	#endregion // 함수
}

/** 공용 타입 래퍼 */
[MessagePackObject]
public struct STCommonTypeWrapper
{
	[Key(0)] public List<int> m_oIntList;
	[Key(1)] public List<float> m_oRealList;
	[Key(2)] public List<string> m_oStrList;
}

#if ADS_MODULE_ENABLE
/** 광고 보상 정보 */
public struct STAdsRewardInfo {
	public string m_oID;
	public string m_oVal;

	#region 상수
	public static readonly STAdsRewardInfo INVALID = new STAdsRewardInfo() {
		m_oID = string.Empty, m_oVal = string.Empty
	};
	#endregion // 상수
}
#endif // #if ADS_MODULE_ENABLE

#if NOTI_MODULE_ENABLE
/** 알림 정보 */
public struct STNotiInfo
{
	public string m_oMsg;
	public string m_oTitle;
	public string m_oSubTitle;

	public bool m_bIsRepeat;
	public System.DateTime m_stNotiTime;
}
#endif // #if NOTI_MODULE_ENABLE

#if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
/** 구글 시트 로드 정보 */
public struct STGoogleSheetLoadInfo
{
	public int m_nSrcIdx;
	public int m_nNumRows;
	public string m_oID;
	public string m_oSheetName;
	public GstuSpreadSheet m_oGoogleSheet;

	#region 상수
	public static readonly STGoogleSheetLoadInfo INVALID = new STGoogleSheetLoadInfo()
	{
		m_nSrcIdx = KCDefine.B_IDX_INVALID
	};
	#endregion // 상수

	#region 함수
	/** 생성자 */
	public STGoogleSheetLoadInfo(string a_oID, string a_oSheetName, int a_nSrcIdx, int a_nNumRows, GstuSpreadSheet a_oGoogleSheet)
	{
		m_oID = a_oID;
		m_nSrcIdx = a_nSrcIdx;
		m_nNumRows = a_nNumRows;
		m_oSheetName = a_oSheetName;
		m_oGoogleSheet = a_oGoogleSheet;
	}
	#endregion // 함수
}

/** 구글 시트 저장 정보 */
public struct STGoogleSheetSaveInfo
{
	public int m_nSrcIdx;
	public int m_nNumRows;
	public string m_oID;
	public string m_oSheetName;

	#region 상수
	public static readonly STGoogleSheetSaveInfo INVALID = new STGoogleSheetSaveInfo()
	{
		m_nSrcIdx = KCDefine.B_IDX_INVALID
	};
	#endregion // 상수

	#region 함수
	/** 생성자 */
	public STGoogleSheetSaveInfo(string a_oID, string a_oSheetName, int a_nSrcIdx, int a_nNumRows)
	{
		m_oID = a_oID;
		m_nSrcIdx = a_nSrcIdx;
		m_nNumRows = a_nNumRows;
		m_oSheetName = a_oSheetName;
	}
	#endregion // 함수
}

/** 로드 구글 시트 정보 */
public struct STLoadGoogleSheetInfo
{
	public string m_oID;
	public string m_oTableName;
	public List<(string, int)> m_oSheetInfoList;

	#region 함수
	/** 생성자 */
	public STLoadGoogleSheetInfo(string a_oID, string a_oTableName, List<(string, int)> a_oSheetInfoList = null)
	{
		m_oID = a_oID;
		m_oTableName = a_oTableName;
		m_oSheetInfoList = a_oSheetInfoList ?? new List<(string, int)>();
	}
	#endregion // 함수
}

/** 저장 구글 시트 정보 */
public struct STSaveGoogleSheetInfo
{
	public string m_oID;
	public string m_oTableName;
	public List<(string, List<List<string>>)> m_oSheetInfoListContainer;

	#region 함수
	/** 생성자 */
	public STSaveGoogleSheetInfo(string a_oID, string a_oTableName, List<(string, List<List<string>>)> a_oSheetInfoListContainer = null)
	{
		m_oID = a_oID;
		m_oTableName = a_oTableName;
		m_oSheetInfoListContainer = a_oSheetInfoListContainer ?? new List<(string, List<List<string>>)>();
	}
	#endregion // 함수
}
#endif // #if ENABLE_GOOGLESHEET && (DEBUG || DEVELOPMENT_BUILD)
#endregion // 타입
