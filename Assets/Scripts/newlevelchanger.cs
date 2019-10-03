using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevelchanger : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("splash");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menuscreen");
    }
    public void GotoGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void WinGame()
    {
        SceneManager.LoadScene("winscreen");
    }
}
