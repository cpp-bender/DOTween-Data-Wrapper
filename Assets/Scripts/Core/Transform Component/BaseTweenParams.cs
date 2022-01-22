using DG.Tweening;
using UnityEngine;

public abstract class BaseTweenParams : ScriptableObject
{
    [Header("Default Tween Params Data")]
    [Space(1f)] public float duration = 1f;
    [Space(1f)] public float startDelay = 0f;
    [Space(1f)] public Ease ease = Ease.Linear;
    [Space(1f)] public int loopCount = 1;
    [Space(1f)] public LoopType loopType = LoopType.Yoyo;
    [Space(1f)] public bool autoKill = true;
    [Space(1f)] public bool recyclable = true;

    protected Tween baseTween;

    protected TweenParams GetDefaultTweenParams()
    {
        var tweenParams = new TweenParams()
            .SetAutoKill(autoKill)
            .SetDelay(startDelay)
            .SetEase(ease).SetLoops(loopCount, loopType)
            .SetRecyclable(recyclable);
        return tweenParams;
    }

    public abstract Tween GetTween(GameObject go);
}
