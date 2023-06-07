using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNextAction : MonoBehaviour
{
    [SerializeField] GameObject manager;

    private void Start()
    {
        manager.SetActive(false);
    }

    public void OnClickFight()
    {
        // 行動開始
        manager.SetActive(true);
    }
}
