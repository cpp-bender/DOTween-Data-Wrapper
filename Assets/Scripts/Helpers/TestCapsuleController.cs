using UnityEngine;
using DG.Tweening;

public class TestCapsuleController : BaseTestController
{
    private void Start()
    {
        baseTween = baseTweenData.GetTween(gameObject).Play();
    }
}
