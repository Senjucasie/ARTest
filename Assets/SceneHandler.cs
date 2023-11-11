using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
   public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
