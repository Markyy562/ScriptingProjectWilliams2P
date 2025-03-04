using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponet : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
          }
    }
}
