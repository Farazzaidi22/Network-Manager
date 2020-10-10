using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class setuplocalPlayer : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(isLocalPlayer)
        {
            GetComponent<PlayerController>().enabled = true;
        }
        else
        {
            GetComponent<PlayerController>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
