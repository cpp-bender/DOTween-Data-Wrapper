using UnityEngine;
using DG.Tweening;

public class TestCubeController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
