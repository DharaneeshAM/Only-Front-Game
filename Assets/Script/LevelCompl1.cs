using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelCompl1 : MonoBehaviour
{
    public void LevelNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
