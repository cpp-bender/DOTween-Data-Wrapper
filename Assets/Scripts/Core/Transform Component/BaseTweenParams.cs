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
    [Space(1f)] public bool relative = false;

    protected Tween baseTween;

    /// <summary>
    /// Gets the default tween params
    /// </summary>
    /// <returns></returns>
    protected TweenParams GetDefaultTweenParams()
    {
        var tweenParams = new TweenParams()
            .SetDelay(startDelay)
            .SetEase(ease)
            .SetLoops(loopCount, loopType)
            .SetAutoKill(autoKill)
            .SetRecyclable(recyclable)
            .SetRelative(relative);
        return tweenParams;
    }

    /// <summary>
    /// Gets the tween to the given gameobject
    /// </summary>
    /// <param name="go">GameObject</param>
    /// <returns></returns>
    public abstract Tween GetTween(GameObject go);
}
