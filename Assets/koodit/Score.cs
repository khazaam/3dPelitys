
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Kuinka pitkälle pääsee
    void Update()
    {

        scoreText.text = player.position.z.ToString("0");

    }
}
