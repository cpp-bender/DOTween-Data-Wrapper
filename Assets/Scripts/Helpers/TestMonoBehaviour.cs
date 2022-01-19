using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(GameManager.Instance.name);
    }
}
