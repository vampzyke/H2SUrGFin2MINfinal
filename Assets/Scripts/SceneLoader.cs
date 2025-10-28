using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string nextScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }
  
}
