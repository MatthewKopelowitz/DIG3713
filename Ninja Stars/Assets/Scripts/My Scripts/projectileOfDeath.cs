using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileOfDeath : MonoBehaviour
{
    public string attackButton;
    public GameObject attackSphere;
    public float attackTime;

    public GameObject spriteHolder;
    private float xPos;     //Original x position of sphere relative to player

    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        attackSphere.SetActive(false);

        xPos = attackSphere.transform.localPosition.x;

        animator = spriteHolder.GetComponent <Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(attackButton))
        {
            Attack();
        }

        if (spriteHolder.GetComponent<SpriteRenderer>().flipX == true)
        {
            attackSphere.transform.localPosition = new Vector2((-1) * xPos - 0.5f, attackSphere.transform.localPosition.y);
        }
        else
        {
            attackSphere.transform.localPosition = new Vector2(xPos, attackSphere.transform.localPosition.y);
        }
    }

    void Attack()
    {
        StartCoroutine(TheAttackOfDeath());
    }

    IEnumerator TheAttackOfDeath()
    {
        attackSphere.SetActive(true);
        animator.SetBool("isAttacking", true);
        yield return new WaitForSeconds(attackTime);
        attackSphere.SetActive(false);
        animator.SetBool("isAttacking", false);
    }
}
