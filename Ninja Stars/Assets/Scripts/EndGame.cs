﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public GameObject boss;
    public GameObject portal;
    public Transform portalPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (boss == null) {
            Instantiate(portal, portalPos.position, Quaternion.identity);
        }
        
    }

}