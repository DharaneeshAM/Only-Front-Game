using UnityEngine;

public class End : MonoBehaviour
{
    public GameManger gameManger;

    void OnTriggerEnter ()
    {
        gameManger.CompletLavel();
    }
}