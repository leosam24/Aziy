using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAttack : MonoBehaviour
{
    Animator knight;
    
    
    void Start()
    {
        knight = GetComponent<Animator>();
        
    }

    public void knightAttack()
    {
        knight.Play("Move_attack");
        Debug.Log("moveeee");
    }

    public void knightDie()
    {
        knight.Play("Die");

    }


}
