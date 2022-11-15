using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backwardsFixer : MonoBehaviour
{
    float xPos;

    // Start is called before the first frame update
    void Start()
    {
        xPos = transform.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SpriteRenderer>().flipX == true)
        {
            transform.localPosition = new Vector2(xPos - 0.5f, transform.localPosition.y);
        }
        else
        {
            transform.localPosition = new Vector2(xPos, transform.localPosition.y);
        }
    }
}
