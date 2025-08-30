using System.Collections;
using UnityEngine;

public class ToolManager : MonoBehaviour
{
    [SerializeField] Animator PlayerAnimator;
    [SerializeField] float DelayTime;
    
    public GatheringTool currentTool;
    private SpriteRenderer itemSpriteRenderer;
    bool IsAnim = false;

    private void Awake()
    {
        PlayerAnimator.GetComponent<Animator>();
        itemSpriteRenderer = GetComponent<SpriteRenderer>();
        InitToolData();
    }

    private void Update()
    {
        AnimatorStateInfo PlayerAnimState = PlayerAnimator.GetCurrentAnimatorStateInfo(0);
        if (!PlayerAnimState.IsName("PlayerGathering") && !IsAnim)
        {
            InitToolData();
        }
    }
    private void InitToolData()
    {
        itemSpriteRenderer.sprite = currentTool.Sprite;
        transform.localPosition = currentTool.PositionOffest;
        transform.localRotation = Quaternion.Euler(currentTool.RotationOffset);
        transform.localScale = currentTool.ScaleOffset;
    }


    public IEnumerator RepositionDelay()
    {
        if (!IsAnim) {
            IsAnim = true;
            transform.localPosition = currentTool.AnimOffset01;
            itemSpriteRenderer.sprite = currentTool.Anim01;
            yield return new WaitForSeconds(DelayTime);
            transform.localPosition = currentTool.AnimOffset02;
            itemSpriteRenderer.sprite = currentTool.Anim02;
            IsAnim = false;
        }
    }
}