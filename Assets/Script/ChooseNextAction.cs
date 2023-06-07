using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNextAction : MonoBehaviour
{
    [SerializeField] GameObject senshi;
    [SerializeField] GameObject suraimu;

    private void Start()
    {
        senshi.SetActive(false);
        suraimu.SetActive(false);
    }

    public void OnClickFight()
    {
        // せんしが行動開始
        senshi.SetActive(true);
    }
}
