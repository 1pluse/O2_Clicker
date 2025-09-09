using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public void OnObjectSetActive(GameObject gameObject) {
        gameObject.SetActive(true);
    }
}
