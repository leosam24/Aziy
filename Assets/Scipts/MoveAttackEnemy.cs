using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttackEnemy : MonoBehaviour
{
    Animator evilBug;
    void Start()
    {
        evilBug = GetComponent<Animator>();
    }

    public void evilBugAttack()
    {
        evilBug.Play("move_attack");
    }
}
