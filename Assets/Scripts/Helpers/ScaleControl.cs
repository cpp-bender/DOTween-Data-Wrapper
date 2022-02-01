using UnityEngine;

public class ScaleControl : MonoBehaviour
{
    public float scaleValue = 1f;

    private void Start()
    {
        
    }

    private void OnValidate()
    {
        transform.localScale = Vector3.one * scaleValue;
    }
}
