using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{

    public GameObject other;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            Destroy(other);
        }
    }
}
