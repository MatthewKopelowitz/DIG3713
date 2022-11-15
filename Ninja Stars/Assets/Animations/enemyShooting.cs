using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    private float breakTime;
    public float startTime;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        breakTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(breakTime<=0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            breakTime = startTime;
        }
        else
        {
            breakTime -= Time.deltaTime;
        }
    }
}
