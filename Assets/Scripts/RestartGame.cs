using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        Obstacles.ExtraSpeed = 0;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Obstacles.ExtraSpeed = 0;
    }
}
