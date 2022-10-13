using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileOfDeath : MonoBehaviour
{
    public string attackButton;
    public GameObject attackSphere;
    public float attackTime;

    // Start is called before the first frame update
    void Start()
    {
        attackSphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackButton))
        {
            Attack();
        }
    }

    void Attack()
    {
        StartCoroutine(TheAttackOfDeath());
    }

    IEnumerator TheAttackOfDeath()
    {
        attackSphere.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        attackSphere.SetActive(false);
    }
}
