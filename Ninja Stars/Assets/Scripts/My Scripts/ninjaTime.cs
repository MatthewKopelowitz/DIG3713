using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjaTime : MonoBehaviour
{
    public string ninjaTimeButton;

    public float slowdownIntensity;

    public bool inNinjaTime;

    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        inNinjaTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ninjaTimeButton) && inNinjaTime==false)
        {
            Time.timeScale = slowdownIntensity;

            Timer();

        }
 
    }

    void Timer()
    {
        StartCoroutine(Duration());
    }

    IEnumerator Duration()
    {
        inNinjaTime = true;
        yield return new WaitForSeconds(duration);
        Time.timeScale = 1;
        inNinjaTime = false;
    }

}
