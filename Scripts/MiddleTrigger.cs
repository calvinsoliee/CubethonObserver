using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.MiddleText();
        //gameManager.BeginningText.SetActive(false);
        gameManager.BeginningTextEnd();
    }
}
