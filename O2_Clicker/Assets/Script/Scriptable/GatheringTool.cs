using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "GatheringTool", menuName = "Scriptable Objects/GatheringTool")]
public class GatheringTool : ScriptableObject
{
    [Header("Base Information")]
    public string Name;
    public string Description;
    public Image Icon;
    public Sprite Sprite;
    
    [Header("Offset")]    
    public Vector3 PositionOffest;
    public Vector3 RotationOffset;
    public Vector3 ScaleOffset;
    public Vector3 AnimOffset01;
    public Vector3 AnimOffset02;

    [Header("Stat")]
    public float GatherAmount;

    public Sprite Anim01;
    public Sprite Anim02;
}
