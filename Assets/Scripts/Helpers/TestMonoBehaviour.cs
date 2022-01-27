using DG.Tweening;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public MoveTweenParams moveTweenData;

    private Tween moveTween;

    private void Start()
    {
        moveTween = transform.DOMove(moveTweenData.EndValue, moveTweenData.Duration)
            .SetAs(moveTweenData.GetTweenParams())
            .Play();
    }
}
