
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    { //fysiikkaa varten parempi on aina käyttää ohjeiden mukaan fixedupdatea

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //lasketaan jottei kaikki mene rikki

        if (Input.GetKey("d")) //DOWNtest
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a")) //DOWNtest
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -2)
        {
            FindObjectOfType<GameManageri>().EndGame();
        }

    }
}
