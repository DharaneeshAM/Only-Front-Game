using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool gamehesEnded = false;

    public float restartdela = 2f;

    public GameObject CompletLevelUI;
    public void CompletLavel ()
    {
        CompletLevelUI.SetActive(true);
    }
    public void EngGame()
    {
        if (gamehesEnded == false)
        {
            gamehesEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartdela);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}