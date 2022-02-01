using DG.Tweening;
using UnityEngine;

public class TestSphereController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
