using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public bool IsFeverTime;

    private void Awake()
    {
        instance = this;
        IsFeverTime = false;
    }

    private void Update()
    {
        if (UiManager.instance.FeverTimebar.fillAmount >= 1f)
            StartCoroutine(Fevertime());
    }
    IEnumerator Fevertime()
    {
        IsFeverTime = true;
        UiManager.instance.FeverText.SetActive(true);
        UiManager.instance.FeverTimebar.DOFillAmount(0, 10f);
        yield return new WaitForSeconds(10f);
        if (UiManager.instance.FeverTimebar.fillAmount <= 0f)
        {
            IsFeverTime = false;
            UiManager.instance.FeverText.SetActive(false);
        }
    }
}
