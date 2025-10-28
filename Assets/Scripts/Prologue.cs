using UnityEngine;
using UnityEngine.SceneManagement;

public class Prologue : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("Prologue2");
    }
}
