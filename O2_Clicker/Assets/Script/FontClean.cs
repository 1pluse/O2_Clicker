using UnityEngine;

public class FontClean : MonoBehaviour
{
    [SerializeField] Font[] fonts;

    private void Start()
    {
        foreach (Font font in fonts) 
            font.material.mainTexture.filterMode = FilterMode.Point;
    }
}
