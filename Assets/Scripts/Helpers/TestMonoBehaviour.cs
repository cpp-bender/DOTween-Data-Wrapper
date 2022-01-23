using DG.Tweening;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public BaseTweenParams moveTweenParams;

    private Tween moveTween;

    private void Start()
    {
        moveTween = moveTweenParams.GetTween(gameObject).Play();
    }
}
