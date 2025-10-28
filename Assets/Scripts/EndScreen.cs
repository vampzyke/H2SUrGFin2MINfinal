using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
