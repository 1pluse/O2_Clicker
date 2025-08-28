using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject O2_Icon;
    Animator Anim;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    void OnClick()
    {
        Anim.SetTrigger("IsGathering");
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-1.5f, 3.75f);
        Instantiate(O2_Icon, new Vector2(x, y), Quaternion.identity);

        if (GameManager.instance.IsFeverTime)
            return;
        GameManager.instance.FeverTimebar.fillAmount += 0.004f;
    }
}
