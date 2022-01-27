using DG.Tweening;
using UnityEngine;

public abstract class BaseTweenParams : ScriptableObject
{
    [Header("Default Tween Params Data")]
    [Space(1f)] public float Duration = 1f;
    [Space(1f)] public float StartDelay = 0f;
    [Space(1f)] public Ease Ease = Ease.Linear;
    [Space(1f)] public int LoopCount = 1;
    [Space(1f)] public LoopType LoopType = LoopType.Yoyo;
    [Space(1f)] public bool AutoKill = true;
    [Space(1f)] public bool Recyclable = true;
    [Space(1f)] public bool Relative = false;

    protected Tween baseTween;

    /// <summary>
    /// Gets the default tween params
    /// </summary>
    /// <returns></returns>
    protected TweenParams GetDefaultTweenParams()
    {
        var tweenParams = new TweenParams()
            .SetDelay(StartDelay)
            .SetEase(Ease)
            .SetLoops(LoopCount, LoopType)
            .SetAutoKill(AutoKill)
            .SetRecyclable(Recyclable)
            .SetRelative(Relative);
        return tweenParams;
    }

    /// <summary>
    /// Gets the tween to the given gameobject
    /// </summary>
    /// <param name="go">GameObject</param>
    /// <returns></returns>
    public abstract Tween GetTween(GameObject go);

    public TweenParams GetTweenParams()
    {
        return GetDefaultTweenParams();
    }
}
