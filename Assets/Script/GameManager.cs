using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ����
    [SerializeField] GameObject senshi;
    ActSenshi actSenshi;
    int senshiHP = 15;
    int senshiAtk = 5;
    bool canSenshiAct = true;

    // ���炢��
    [SerializeField] GameObject suraimu;
    ActSuraimu actSuraimu;
    int suraimuHP = 3;
    int suraimuAtk = 2;

    bool isGameOver = false;

    [SerializeField] GameObject win;


    private void Start()
    {
        actSenshi = senshi.GetComponent<ActSenshi>();
        actSuraimu = suraimu.GetComponent<ActSuraimu>();

        win.SetActive(false);
    }

    private void Update()
    {
        if (!isGameOver)
        {
            if (canSenshiAct)
            {
                // �X���C����HP���Ȃ��Ȃ��true
                if (actSenshi.Attack(ref suraimuHP, senshiAtk, ref canSenshiAct))
                {
                    isGameOver = true;
                    win.SetActive(true);
                }
            }
            else
            {
                if (actSuraimu.Attack(ref senshiHP, suraimuAtk, ref canSenshiAct))
                {
                    isGameOver = true;
                }
            }
        }
    }

    public void QuitGame()
    {
        // �Q�[�����I��
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
