using UnityEngine.SceneManagement;

public class GameSceneManager
{
    public static void HandleLoadScene(Scenes scene)
    {
        SceneManager.LoadScene(GetScene(scene));
    }

    public static string GetScene(Scenes value)
    {
        string[] values = { "TitleScene", "MainScene", "ResultSuccessScene", "ResultFailureScene" };
        return values[(int)value];
    }

    public enum Scenes
    {
        Title,
        Main,
        ResultSuccess,
        ResultFailure
    }
}
