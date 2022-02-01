using UnityEngine;
using DG.Tweening;

public class TestPlaneController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
