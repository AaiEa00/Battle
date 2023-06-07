using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActSenshi : MonoBehaviour
{
    Animator animator;

    //[SerializeField] GameObject win;

    private void Start()
    {
        animator = GetComponent<Animator>();
        //win.SetActive(false);
    }

    // 攻撃(GameManagerで呼び出し)
    public bool Attack(ref int hp, int atk, ref bool canSenshiAct)
    {
        animator.SetTrigger("PlayOnce");

        // アニメーション終了待機
        //StartCoroutine(WaitForAnimation());
        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).IsName("SenshiAttack"));
        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
        {
            // 何もしない
            Debug.Log("何もしてない");
        }

        int random = Random.Range(0, atk / 2);
        hp-= atk / 2 + random + 1;

        canSenshiAct = false;

        return hp <= 0;
    }


    //IEnumerator WaitForAnimation()
    //{
    //    while (animator.GetCurrentAnimatorStateInfo(0).IsName("SenshiAttack")
    //            && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f)
    //    {
    //        yield return null;
    //    }

    //    yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

    //    Debug.Log("wait");
    //}
    //public void ProcessGameOver()
    //{
    //    win.SetActive(true);
    //}
}