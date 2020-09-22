using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if MSG_PACK_ENABLE
using MessagePack;
#endif			// #if MSG_PACK_ENABLE

#region 기본
//! 빌드 버전
[System.Serializable]
public struct STBuildVersion {
	public int m_nNumber;
	public string m_oVersion;
}
#endregion			// 기본

#region 조건부 타입
#if MSG_PACK_ENABLE
//! 버전
[MessagePackObject]
[System.Serializable]
public struct STVersion {
	[Key(0)] public string m_oVersion;
	[Key(1)] public Dictionary<string, string> m_oExtraInfoList;
}

//! 공용 커스텀 타입 래퍼
[MessagePackObject]
public struct STCommonCustomTypeWrapper {
	[Key(0)] public List<bool> m_oBoolList;
	[Key(1)] public List<int> m_oIntList;
	[Key(2)] public List<float> m_oFloatList;
	[Key(3)] public List<string> m_oStringList;

	[Key(4)] public Dictionary<string, bool> m_oBoolMapList;
	[Key(5)] public Dictionary<string, int> m_oIntMapList;
	[Key(6)] public Dictionary<string, float> m_oFloatMapList;
	[Key(7)] public Dictionary<string, string> m_oStringMapList;
}
#endif			// #if MSG_PACK_ENABLE

#if ADS_MODULE_ENABLE
//! 광고 보상 정보
public struct STAdsRewardInfo {
	public string m_oName;
	public string m_oValue;
}
#endif			// #if ADS_MODULE_ENABLE

#if FIREBASE_MODULE_ENABLE && FIREBASE_REMOTE_CONFIG_ENABLE
//! 디바이스 속성
[System.Serializable]
public struct STDeviceConfig {
	public List<string> m_oiOSAdsIDList;
	public List<string> m_oAndroidAdsIDList;
}

//! 빌드 버전 속성
[System.Serializable]
public struct STBuildVersionConfig {
	public STBuildVersion m_stMacVersion;
	public STBuildVersion m_stWindowsVersion;

	public STBuildVersion m_stiOSVersion;

	public STBuildVersion m_stGoogleVersion;
	public STBuildVersion m_stOneStoreVersion;
	public STBuildVersion m_stGalaxyStoreVersion;
}
#endif			// #if FIREBASE_MODULE_ENABLE && FIREBASE_REMOTE_CONFIG_ENABLE

#if LOCAL_NOTI_MODULE_ENABLE
//! 로컬 알림 정보
public struct STLocalNotiInfo {
	public string m_oTitle;
	public string m_oMsg;

#if UNITY_IOS
	public System.TimeSpan m_stDeltaTime;
#else
	public int m_nID;
	public System.DateTime m_stNotiTime;
#endif			// #if UNITY_IOS
}
#endif			// #if LOCAL_NOTI_MODULE_ENABLE
#endregion			// 조건부 타입
