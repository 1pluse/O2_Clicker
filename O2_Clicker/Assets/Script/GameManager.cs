using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public float O2_HaveAmount;
    public bool IsFeverTime;
    public Image FeverTimebar;
    public string CurrentLocal;

    [SerializeField] GameObject FeverText;
    [SerializeField] TextMeshProUGUI O2_HaveAmountText;
    [SerializeField] TextMeshProUGUI LocalText;
    private void Awake()
    {
        instance = this;
        FeverTimebar.fillAmount = 0;
        IsFeverTime = false;
        FeverText.SetActive(false);
    }

    private void Update()
    {
        if (FeverTimebar.fillAmount >= 1f)
            StartCoroutine(Fevertime());
        O2_HaveAmountText.text = $"{O2_HaveAmount}";
        LocalText.text = $"{CurrentLocal}";
    }
    IEnumerator Fevertime()
    {
        IsFeverTime = true;
        FeverText.SetActive(true);
        FeverTimebar.DOFillAmount(0, 10f);
        yield return new WaitForSeconds(10f);
        if (FeverTimebar.fillAmount <= 0f)
        {
            IsFeverTime = false;
            FeverText.SetActive(false);
        }
    }
}
