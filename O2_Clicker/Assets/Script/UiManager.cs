using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    static public UiManager instance;

    public float O2_HaveAmount;
    public Image FeverTimebar;
    public string CurrentLocal;

    public GameObject FeverText;
    public TextMeshProUGUI O2_HaveAmountText;
    public TextMeshProUGUI LocalText;
    private void Awake()
    {
        instance = this;
        FeverTimebar.fillAmount = 0;
        FeverText.SetActive(false);
    }

    private void Update()
    {
        O2_HaveAmountText.text = $"{O2_HaveAmount}";
        LocalText.text = $"{CurrentLocal}";
    }
}
