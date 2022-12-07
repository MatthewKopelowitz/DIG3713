using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public GameObject boss;
    public GameObject portal;
    public Transform portalPos;

    public bool spawnedPortal;

    // Start is called before the first frame update
    void Start()
    {
        spawnedPortal = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null && spawnedPortal==false) {
            Instantiate(portal, portalPos.position, Quaternion.identity);
            spawnedPortal = true;
        }
        
    }

}