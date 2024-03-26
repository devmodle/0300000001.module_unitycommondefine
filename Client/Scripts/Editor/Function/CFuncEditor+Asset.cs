using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

#if UNITY_EDITOR
using System.IO;
using UnityEditor;

/** 에디터 함수 - 에셋 */
public static partial class CFuncEditor
{
	#region 클래스 함수
	/** 에셋 데이터 베이스 상태를 갱신한다 */
	public static void UpdateAssetDBState(bool a_bIsForceUpdate = false)
	{
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh(a_bIsForceUpdate ? ImportAssetOptions.ForceUpdate : ImportAssetOptions.Default);
	}

	/** 에셋을 로드한다 */
	public static Object LoadAsset(string a_oFilePath)
	{
		CFunc.Assert(a_oFilePath.ExIsValid());
		var oAssets = AssetDatabase.LoadAllAssetsAtPath(a_oFilePath);

		return oAssets.ExIsValid() ? oAssets[KCDefine.B_VAL_0_INT] : null;
	}

	/** 에셋을 저장한다 */
	public static void SaveAsset(Object a_oObj)
	{
		EditorUtility.SetDirty(a_oObj);
		AssetDatabase.SaveAssetIfDirty(a_oObj);
	}

	/** 에셋을 복사한다 */
	public static void CopyAsset(string a_oSrcPath, string a_oDestPath, bool a_bIsOverwrite = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));
		bool bIsValid = a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid();

		// 에셋 복사가 가능 할 경우
		if((bIsValid && CAccessEditor.IsExistsAsset(a_oSrcPath)) && (a_bIsOverwrite || !CAccessEditor.IsExistsAsset(a_oDestPath)))
		{
			CFactoryEditor.MakeDirectories(Path.GetDirectoryName(a_oDestPath).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH), a_bIsAssert);

			// 덮어쓰기 모드 일 경우
			if(a_bIsOverwrite && CAccessEditor.IsExistsAsset(a_oDestPath))
			{
				AssetDatabase.DeleteAsset(a_oDestPath);
			}

			AssetDatabase.CopyAsset(a_oSrcPath, a_oDestPath);
		}
	}

	/** 에셋을 이동한다 */
	public static void MoveAsset(string a_oSrcPath, string a_oDestPath, bool a_bIsOverwrite = true, bool a_bIsAssert = true)
	{
		CFunc.Assert(!a_bIsAssert || (a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid()));
		bool bIsValid = a_oSrcPath.ExIsValid() && a_oDestPath.ExIsValid();

		// 에셋 복사가 가능 할 경우
		if((bIsValid && CAccessEditor.IsExistsAsset(a_oSrcPath)) && (a_bIsOverwrite || !CAccessEditor.IsExistsAsset(a_oDestPath)))
		{
			CFactoryEditor.MakeDirectories(Path.GetDirectoryName(a_oDestPath).Replace(KCDefine.B_TOKEN_R_SLASH, KCDefine.B_TOKEN_SLASH), a_bIsAssert);

			// 덮어쓰기 모드 일 경우
			if(a_bIsOverwrite && CAccessEditor.IsExistsAsset(a_oDestPath))
			{
				AssetDatabase.DeleteAsset(a_oDestPath);
			}

			AssetDatabase.MoveAsset(a_oSrcPath, a_oDestPath);
		}
	}
	#endregion // 클래스 함수
}
#endif // #if UNITY_EDITOR
