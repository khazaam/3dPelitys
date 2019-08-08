
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManageri : MonoBehaviour
{

    bool PeliOnLoppunut = false;

	public float restartDelay = 2f;

	public GameObject completeLEvelUI;

	public void CompleteLevel()
	{
		completeLEvelUI.SetActive(true);
	}

    public void EndGame()

    {
        if (PeliOnLoppunut == false)
        {
            PeliOnLoppunut = true;
			Invoke("Restart", restartDelay);
        }

    }

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}



}
