using UnityEngine;

public class BeginningTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.BeginningText();
    }
}
