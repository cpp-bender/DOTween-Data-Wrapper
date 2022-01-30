using DG.Tweening;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public MoveTweenData moveTweenData;
    public BaseTweenData baseTweenData;

    private Tween moveTween;
    private Tween baseTween;

    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
