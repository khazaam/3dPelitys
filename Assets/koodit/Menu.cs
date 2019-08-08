
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void AloitaPeli()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
