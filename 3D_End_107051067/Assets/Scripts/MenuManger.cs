
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public void StartGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("3DGame");
    }

    public void EndGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
