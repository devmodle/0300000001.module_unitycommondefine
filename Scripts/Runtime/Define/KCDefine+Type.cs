using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if MSG_PACK_ENABLE
using MessagePack;
#endif			// #if MSG_PACK_ENABLE

#if ADS_ENABLE
//! 광고 보상 정보
public struct STAdsRewardInfo {
	public string m_oName;
	public string m_oValue;
}
#endif			// #if ADS_ENABLE

#if MSG_PACK_ENABLE
//! 버전 정보
[MessagePackObject]
[System.Serializable]
public struct STVersionInfo {
	[Key(0)] public string m_oVersion;
	[Key(1)] public Dictionary<string, string> m_oExtraInfoList;
}

//! 커스텀 타입 래퍼
[MessagePackObject]
public struct STCustomTypeWrapper {
	[Key(0)] public List<string> m_oStringList;

	[Key(1)] public Dictionary<string, bool> m_oBoolMapList;
	[Key(2)] public Dictionary<string, int> m_oIntMapList;
	[Key(3)] public Dictionary<string, float> m_oFloatMapList;
	[Key(4)] public Dictionary<string, string> m_oStringMapList;
}
#endif			// #if MSG_PACK_ENABLE
