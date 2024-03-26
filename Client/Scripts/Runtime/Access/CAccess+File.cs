using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using System.IO;

/** 접근자 - 파일 */
public static partial class CAccess
{
	#region 클래스 함수
	/** 읽기용 스트림을 반환한다 */
	public static FileStream GetReadStream(string a_oPathFile)
	{
		CFunc.Assert(a_oPathFile.ExIsValid());
		return File.Exists(a_oPathFile) ? File.Open(a_oPathFile, FileMode.Open, FileAccess.Read) : null;
	}

	/** 쓰기용 스트림을 반환한다 */
	public static FileStream GetWriteStream(string a_oPathFile)
	{
		CFunc.Assert(a_oPathFile.ExIsValid());
		string oDirPath = Path.GetDirectoryName(a_oPathFile).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH);

		// 디렉토리 생성이 필요 할 경우
		if(oDirPath.ExIsValid() && !Directory.Exists(oDirPath))
		{
			Directory.CreateDirectory(oDirPath);
		}

		return File.Open(a_oPathFile, FileMode.Create, FileAccess.Write);
	}
	#endregion // 클래스 함수
}
