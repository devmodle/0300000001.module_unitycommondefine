using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.IO;
using System.Linq;
using MessagePack;

/** 함수 - 파일 */
public static partial class CFunc {
	#region 클래스 함수
	/** 바이트를 읽어들인다 */
	public static byte[] ReadBytes(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());

		// 바이트 읽기가 불가능 할 경우
		if(!File.Exists(a_oFilePath)) {
			return null;
		}

		var oBytes = File.ReadAllBytes(a_oFilePath);

		return a_bIsBase64 ?
			System.Convert.FromBase64String((a_oEncoding ?? System.Text.Encoding.Default).GetString(oBytes)) : oBytes;
	}

	/** 바이트를 읽어들인다 */
	public static byte[] ReadBytes(Stream a_oStream, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oStream != null);
		var oBytes = new byte[a_oStream.Length];

		a_oStream.Read(oBytes, KCDefine.B_VAL_0_INT, oBytes.Length);

		return a_bIsBase64 ?
			System.Convert.FromBase64String((a_oEncoding ?? System.Text.Encoding.Default).GetString(oBytes)) : oBytes;
	}

	/** 바이트를 읽어들인다 */
	public static byte[] ReadBytesFromRes(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		var oTextAsset = Resources.Load<TextAsset>(a_oFilePath);

		// 바이트 읽기가 불가능 할 경우
		if(!oTextAsset.ExIsValid()) {
			return null;
		}

		return a_bIsBase64 ?
			System.Convert.FromBase64String((a_oEncoding ?? System.Text.Encoding.Default).GetString(oTextAsset.bytes)) : oTextAsset.bytes;
	}

	/** 문자열을 읽어들인다 */
	public static string ReadStr(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());

		// 문자열 읽기가 불가능 할 경우
		if(!File.Exists(a_oFilePath)) {
			return string.Empty;
		}

		var oBytes = CFunc.ReadBytes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default);

		return a_bIsBase64 ?
			(a_oEncoding ?? System.Text.Encoding.Default).GetString(oBytes) : File.ReadAllText(a_oFilePath, a_oEncoding ?? System.Text.Encoding.Default);
	}

	/** 문자열을 읽어들인다 */
	public static string ReadStr(Stream a_oStream, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oStream != null);
		var oBytes = CFunc.ReadBytes(a_oStream, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default);

		return (a_oEncoding ?? System.Text.Encoding.Default).GetString(oBytes);
	}

	/** 문자열을 읽어들인다 */
	public static string ReadStrFromRes(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		var oTextAsset = Resources.Load<TextAsset>(a_oFilePath);

		// 문자열 읽기가 불가능 할 경우
		if(!oTextAsset.ExIsValid()) {
			return string.Empty;
		}

		var oBytes = CFunc.ReadBytesFromRes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default);
		return a_bIsBase64 ? (a_oEncoding ?? System.Text.Encoding.Default).GetString(oBytes) : oTextAsset.text;
	}

	/** 문자열 라인을 읽어들인다 */
	public static string[] ReadStrLines(string a_oFilePath, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return File.Exists(a_oFilePath) ? File.ReadAllLines(a_oFilePath, a_oEncoding ?? System.Text.Encoding.Default) : null;
	}

	/** 바이트를 기록한다 */
	public static void WriteBytes(string a_oFilePath, byte[] a_oBytes, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oBytes != null && a_oFilePath.ExIsValid()));

		// 바이트 기록이 불가능 할 경우
		if(a_oBytes == null || !a_oFilePath.ExIsValid()) {
			return;
		}

		using(var oWStream = CAccess.GetWriteStream(a_oFilePath)) {
			CFunc.WriteBytes(oWStream, a_oBytes, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default, a_bIsAssert);
		}
	}

	/** 바이트를 기록한다 */
	public static void WriteBytes(FileStream a_oWStream, byte[] a_oBytes, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oWStream != null && a_oBytes != null));

		// 바이트 기록이 불가능 할 경우
		if(a_oWStream == null || a_oBytes == null) {
			return;
		}

		string oBase64Str = System.Convert.ToBase64String(a_oBytes, KCDefine.B_VAL_0_INT, a_oBytes.Length);
		a_oWStream.Write(a_bIsBase64 ? (a_oEncoding ?? System.Text.Encoding.Default).GetBytes(oBase64Str) : a_oBytes);

		a_oWStream.Flush(true);
	}

	/** 문자열을 기록한다 */
	public static void WriteStr(string a_oFilePath,
		string a_oStr, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oStr != null && a_oFilePath.ExIsValid()));

		// 문자열 기록이 불가능 할 경우
		if(a_oStr == null || !a_oFilePath.ExIsValid()) {
			return;
		}

		using(var oWStream = CAccess.GetWriteStream(a_oFilePath)) {
			CFunc.WriteStr(oWStream, a_oStr, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default, a_bIsAssert);
		}
	}

	/** 문자열을 기록한다 */
	public static void WriteStr(FileStream a_oWStream,
		string a_oStr, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oWStream != null && a_oStr != null));

		// 문자열 기록이 불가능 할 경우
		if(a_oWStream == null || a_oStr == null) {
			return;
		}

		var oEncoding = a_oEncoding ?? System.Text.Encoding.Default;
		CFunc.WriteBytes(a_oWStream, oEncoding.GetBytes(a_oStr), a_bIsBase64, oEncoding, a_bIsAssert);
	}

	/** 파일을 복사한다 */
	public static void CopyFile(string a_oSrcPath,
		string a_oDestPath, bool a_bIsOverwrite = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));

		// 파일 복사가 불가능 할 경우
		if(!CFunc.IsEnableCopyFile(a_oSrcPath, a_oDestPath, a_bIsOverwrite)) {
			return;
		}

		var oBytes = CFunc.ReadBytes(a_oSrcPath, false);
		CFunc.WriteBytes(a_oDestPath, oBytes, false, null, a_bIsAssert);
	}

	/** 파일을 복사한다 */
	public static void CopyFile(string a_oSrcPath,
		string a_oDestPath, string a_oIgnoreToken, System.Text.Encoding a_oEncoding = null, bool a_bIsOverwrite = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));

		// 파일 복사가 불가능 할 경우
		if(!CFunc.IsEnableCopyFile(a_oSrcPath, a_oDestPath, a_bIsOverwrite)) {
			return;
		}

		var oEncoding = a_oEncoding ?? System.Text.Encoding.Default;
		var oStrLines = CFunc.ReadStrLines(a_oSrcPath, oEncoding);
		var oStrBuilder = new System.Text.StringBuilder();

		for(int i = 0; i < oStrLines.Length; ++i) {
			// 문자열 추가가 불가능 할 경우
			if(!oStrLines[i].ExIsValid() || oStrLines[i].Contains(a_oIgnoreToken)) {
				continue;
			}

			oStrBuilder.AppendLine(oStrLines[i]);
		}

		CFunc.WriteStr(a_oDestPath, oStrBuilder.ToString(), false, oEncoding, a_bIsAssert);
	}

	/** 파일을 복사한다 */
	public static void CopyFile(string a_oSrcPath,
		string a_oDestPath, string a_oTarget, string a_oReplace, System.Text.Encoding a_oEncoding = null, bool a_bIsOverwrite = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));

		// 파일 복사가 불가능 할 경우
		if(!CFunc.IsEnableCopyFile(a_oSrcPath, a_oDestPath, a_bIsOverwrite)) {
			return;
		}

		var oEncoding = a_oEncoding ?? System.Text.Encoding.Default;
		var oStrLines = CFunc.ReadStrLines(a_oSrcPath, oEncoding);
		var oStrBuilder = new System.Text.StringBuilder();

		for(int i = 0; i < oStrLines.Length; ++i) {
			// 문자열이 유효 할 경우
			if(oStrLines[i] != null) {
				oStrBuilder.AppendLine(oStrLines[i].Replace(a_oTarget, a_oReplace));
			}
		}

		CFunc.WriteStr(a_oDestPath, oStrBuilder.ToString(), false, oEncoding, a_bIsAssert);
	}

	/** 디렉토리를 복사한다 */
	public static void CopyDir(string a_oSrcPath,
		string a_oDestPath, bool a_bIsReplace = true, bool a_bIsOverwrite = true, bool a_bIsAssert = true) {

		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));

		// 디렉토리 복사가 불가능 할 경우
		if(!CFunc.IsEnableCopyDir(a_oSrcPath, a_oDestPath, a_bIsReplace)) {
			return;
		}

		// 대체 모드 일 경우
		if(a_bIsReplace) {
			CFunc.RemoveDir(a_oDestPath, a_bIsAssert: a_bIsAssert);
		}

		CFunc.EnumerateDirectories(a_oSrcPath, (a_oFilePathList, a_oDirPathList) => {
			for(int i = 0; i < a_oFilePathList.Count; ++i) {
				string oDestFilePath = a_oFilePathList[i].Replace(a_oSrcPath, a_oDestPath);
				CFunc.CopyFile(a_oFilePathList[i], oDestFilePath, a_bIsOverwrite, a_bIsAssert);
			}

			return true;
		});
	}

	/** 파일을 제거한다 */
	public static void RemoveFile(string a_oFilePath, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oFilePath.ExIsValid());

		// 파일 제거가 불가능 할 경우
		if(!a_oFilePath.ExIsValid() || !File.Exists(a_oFilePath)) {
			return;
		}

		File.Delete(a_oFilePath);
	}

	/** 디렉토리를 제거한다 */
	public static void RemoveDir(string a_oDirPath, bool a_bIsRecursive = true, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oDirPath.ExIsValid());

		// 디렉토리 제거가 불가능 할 경우
		if(!a_oDirPath.ExIsValid() || !Directory.Exists(a_oDirPath)) {
			return;
		}

		Directory.Delete(a_oDirPath, a_bIsRecursive);
	}

	/** 디렉토리를 순회한다 */
	public static void EnumerateDirectories(string a_oDirPath, System.Func<List<string>, List<string>, bool> a_oCallback, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || (a_oCallback != null && a_oDirPath.ExIsValid()));

		// 디렉토리 순회가 불가능 할 경우
		if(a_oCallback == null || !a_oDirPath.ExIsValid() || !Directory.Exists(a_oDirPath)) {
			return;
		}

		var oDirPaths = Directory.GetDirectories(a_oDirPath);

		// 디렉토리 순회가 불가능 할 경우
		if(!a_oCallback(Directory.GetFiles(a_oDirPath).ToList(), oDirPaths.ToList())) {
			return;
		}

		for(int i = 0; i < oDirPaths.Length; ++i) {
			CFunc.EnumerateDirectories(oDirPaths[i], a_oCallback);
		}
	}

	/** 파일 복사 가능 여부를 검사한다 */
	private static bool IsEnableCopyFile(string a_oSrcPath, string a_oDestPath, bool a_bIsOverwrite) {
		bool bIsValidA = a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid() && File.Exists(a_oSrcPath);
		bool bIsValidB = a_bIsOverwrite || !File.Exists(a_oDestPath);

		return bIsValidA && bIsValidB;
	}

	/** 디렉토리 복사 가능 여부를 검사한다 */
	private static bool IsEnableCopyDir(string a_oSrcPath, string a_oDestPath, bool a_bIsReplace) {
		bool bIsValidA = a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid() && Directory.Exists(a_oSrcPath);
		bool bIsValidB = a_bIsReplace || !Directory.Exists(a_oDestPath);

		return bIsValidA && bIsValidB;
	}
	#endregion // 클래스 함수

	#region 제네릭 클래스 함수
	/** 메세지 팩 객체를 읽어들인다 */
	public static T ReadMsgPackObj<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return MessagePackSerializer.Deserialize<T>(CFunc.ReadBytes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default));
	}

	/** 메세지 팩 객체를 읽어들인다 */
	public static T ReadMsgPackObjFromRes<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return MessagePackSerializer.Deserialize<T>(CFunc.ReadBytesFromRes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default));
	}

	/** 메세지 팩 JSON 객체를 읽어들인다 */
	public static T ReadMsgPackJSONObj<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return CFunc.ReadStr(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default).ExMsgPackJSONStrToObj<T>();
	}

	/** 메세지 팩 JSON 객체를 읽어들인다 */
	public static T ReadMsgPackJSONObjFromRes<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return CFunc.ReadStrFromRes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default).ExMsgPackJSONStrToObj<T>();
	}

	/** 메세지 팩 객체를 기록한다 */
	public static void WriteMsgPackObj<T>(string a_oFilePath, T a_oObj, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oFilePath.ExIsValid());

		// 경로가 유효 할 경우
		if(a_oFilePath.ExIsValid()) {
			CFunc.WriteBytes(a_oFilePath, MessagePackSerializer.Serialize<T>(a_oObj), a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default, a_bIsAssert);
		}
	}

	/** 메세지 팩 JSON 객체를 기록한다 */
	public static void WriteMsgPackJSONObj<T>(string a_oFilePath, T a_oObj, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oFilePath.ExIsValid());

		// 경로가 유효 할 경우
		if(a_oFilePath.ExIsValid()) {
			CFunc.WriteStr(a_oFilePath, a_oObj.ExToMsgPackJSONStr(), a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default, a_bIsAssert);
		}
	}

#if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
	/** JSON 객체를 읽어들인다 */
	public static T ReadJSONObj<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return CFunc.ReadStr(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default).ExJSONStrToObj<T>();
	}

	/** JSON 객체를 읽어들인다 */
	public static T ReadJSONObjFromRes<T>(string a_oFilePath, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null) {
		CFunc.Assert(a_oFilePath.ExIsValid());
		return CFunc.ReadStrFromRes(a_oFilePath, a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default).ExJSONStrToObj<T>();
	}

	/** JSON 객체를 기록한다 */
	public static void WriteJSONObj<T>(string a_oFilePath, T a_oObj, bool a_bIsBase64, System.Text.Encoding a_oEncoding = null, bool a_bIsNeedsRoot = false, bool a_bIsPretty = false, bool a_bIsAssert = true) {
		CFunc.Assert(!a_bIsAssert || a_oFilePath.ExIsValid());

		// 경로가 유효 할 경우
		if(a_oFilePath.ExIsValid()) {
			CFunc.WriteStr(a_oFilePath, a_oObj.ExToJSONStr(a_bIsNeedsRoot, a_bIsPretty), a_bIsBase64, a_oEncoding ?? System.Text.Encoding.Default, a_bIsAssert);
		}
	}
#endif // #if NEWTON_SOFT_JSON_SERIALIZE_DESERIALIZE_ENABLE
	#endregion // 제네릭 클래스 함수
}
