using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
}
