using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject O2_Icon;
    [SerializeField] float ClickLimittime;
    Animator Anim;
    bool IsCorutin;

    private void Awake()
    {
        Anim = GetComponent<Animator>();
    }

    void OnClick()
    {
        if(!IsCorutin)
        StartCoroutine(NextStateAnim("isGathering"));
    }

    IEnumerator NextStateAnim(string AnimState)
    {
        IsCorutin = true;
        Anim.SetBool(AnimState, true);
        float x = Random.Range(-2.25f, 2.25f);
        float y = Random.Range(-2.75f, 2.75f);
        Instantiate(O2_Icon, new Vector2(x, y), Quaternion.identity);
        yield return new WaitForSeconds(ClickLimittime);
        Anim.SetBool(AnimState, false);
        IsCorutin = false;
    }
}
