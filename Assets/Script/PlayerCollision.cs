using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMoment moment;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstac")
        {
            moment.enabled = false;
            FindObjectOfType<GameManger>().EngGame();
        }
    }
}
