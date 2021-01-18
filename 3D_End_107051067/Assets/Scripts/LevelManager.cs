
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }
     public void Quit()
    {
        Application.Quit();
    }
}
