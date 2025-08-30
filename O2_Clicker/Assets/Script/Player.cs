using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject O2_Icon;
    [SerializeField] GameObject Tool;
    Animator Anim;
    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    void OnClick()
    {
        Anim.SetTrigger("IsGathering");
        StartCoroutine(Tool.GetComponent<ToolManager>().RepositionDelay());
        float x = Random.Range(-1.85f, 1.85f);
        float y = Random.Range(-1.5f, 3.75f);
        Instantiate(O2_Icon, new Vector2(x, y), Quaternion.identity);

        if (GameManager.instance.IsFeverTime)
            return;
        UiManager.instance.FeverTimebar.fillAmount += 0.004f;
    }
}
