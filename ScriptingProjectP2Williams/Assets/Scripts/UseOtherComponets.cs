using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript AnotherScript;
    private YetAnotherScript YetAnotherScript;
    private BoxCollider boxCol;



    private void Awake()
    {
        AnotherScript = GetComponent<AnotherScript>();
        YetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + AnotherScript.playerScore);
        Debug.Log("The player has died " + YetAnotherScript.numberOfPlayerDeaths + " times");
    }
}

