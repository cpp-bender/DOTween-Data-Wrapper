using UnityEngine;
using DG.Tweening;

public class TestQuadController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
