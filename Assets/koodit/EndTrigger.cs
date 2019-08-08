
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManageri pelimanaKeri;

    void OnTriggerEnter()
    {
		pelimanaKeri.CompleteLevel();
    }

}
