using DG.Tweening;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public BaseTweenParams moveTweenParams;
    public ScaleTweenParams scaleTweenParams;

    private Tween moveTween;
    private Tween scaleTween;

    private void Start()
    {
        scaleTween = scaleTweenParams.GetTween(gameObject)
            .OnKill(delegate 
            {
                Debug.Log("Tween killed");
            })
            .Play();
    }
}
