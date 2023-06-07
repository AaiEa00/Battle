using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActSuraimu : MonoBehaviour
{
    Animator animator;

    //[SerializeField] GameObject lose;

    private void Start()
    {
        animator = GetComponent<Animator>();
        //lose.SetActive(false);
    }

    // 攻撃(GameManagerで呼び出し)
    public bool Attack(ref int hp, int atk, ref bool canSenshiAct)
    {
        animator.SetTrigger("PlayOnce");

        int random = Random.Range(0, atk / 2);
        hp -= atk / 2 + random + 1;

        canSenshiAct = true;

        return hp < 0;
    }
    
    //public void ProcessGameOver()
    //{
    //    lose.SetActive(true);
    //}

}
