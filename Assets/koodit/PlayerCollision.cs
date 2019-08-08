
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ //collision kamaa

    public PlayerMovement movement;


    void OnCollisionEnter(UnityEngine.Collision collisionInfo) //pitää olla rigidbodi ja collider jotta toimii. Näköään myös ekana toi unityengine. muut
    {
        if (collisionInfo.collider.tag == "Este")
        {
            movement.enabled = false;
            FindObjectOfType<GameManageri>().EndGame();
        }
    }

}
