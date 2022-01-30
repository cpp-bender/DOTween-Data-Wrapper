using DG.Tweening;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public BaseTweenData tweenData;

    private Tween tween;

    private void Start()
    {
        tween = tweenData.GetTween(gameObject).Play();
    }
}
