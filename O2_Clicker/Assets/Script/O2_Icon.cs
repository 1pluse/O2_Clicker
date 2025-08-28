using DG.Tweening;
using System.Xml;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class O2_Icon : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI valueText;
    [SerializeField] float duration = 1.25f;
    [SerializeField] float fadeduration = 5f;
    public float O2_Value;
    SpriteRenderer spriteRenderer;
    float Lifetime = 0;

    private void Start()
    {
        if (GameManager.instance.IsFeverTime)
        {
            GameManager.instance.O2_HaveAmount += (O2_Value * 2f);
            valueText.text = $"+{O2_Value * 2f}";
        }
        else {
            valueText.text = $"+{O2_Value}";
            GameManager.instance.O2_HaveAmount += (O2_Value);
        }


        spriteRenderer = GetComponent<SpriteRenderer>();
        transform.DOMove(transform.position + Vector3.up * 0.4f, duration);
        spriteRenderer.DOFade(0, fadeduration);
        valueText.DOFade(0, fadeduration);
    }

    private void LateUpdate()
    {
        Lifetime += Time.deltaTime;
        if (Lifetime > 2.25f)
            Destroy(gameObject);
    }
}
