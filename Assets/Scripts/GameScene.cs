using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{

    public void Finish()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
