using UnityEngine;
using DG.Tweening;

public class TestCylinderController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
