using UnityEditor;
using UnityEngine;

public static class BuildScript
{
    public static void BuildWindows()
    {
        string[] scenes = {
            "Assets/Scenes/SampleScene.unity"  // �r���h�ΏۂƂȂ�V�[���̃p�X
        };

        BuildPipeline.BuildPlayer(scenes, "Build/Windows/MyGame.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
        Debug.Log("Build completed!");
    }
}
