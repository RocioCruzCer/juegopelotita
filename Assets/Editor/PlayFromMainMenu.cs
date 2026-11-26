using UnityEditor;
using UnityEditor.SceneManagement;

// Solo para el editor: al dar Play siempre se empieza en la pantalla principal,
// sin importar que escena este abierta. No afecta al juego compilado.
[InitializeOnLoad]
public static class PlayFromMainMenu
{
    const string MainMenuPath = "Assets/Scenes/MainMenu.unity";

    static PlayFromMainMenu()
    {
        var scene = AssetDatabase.LoadAssetAtPath<SceneAsset>(MainMenuPath);
        if (scene != null) EditorSceneManager.playModeStartScene = scene;
    }
}
