using DG.Tweening;
using UnityEngine;

public abstract class BaseTweenParams : ScriptableObject
{
    [Header("Default Tween Params Data"), Space(2f)]
    [SerializeField, Space(1f)] float duration = 1f;
    [SerializeField, Space(1f)] float startDelay = 0f;
    [SerializeField, Space(1f)] Ease ease = Ease.Linear;
    [SerializeField, Space(1f)] int loopCount = 1;
    [SerializeField, Space(1f)] LoopType loopType = LoopType.Yoyo;
    [SerializeField, Space(1f)] bool autoKill = true;
    [SerializeField, Space(1f)] bool recyclable = true;
    [SerializeField, Space(1f)] bool relative = false;

    public float Duration { get => duration; }
    public float StartDelay { get => startDelay; }
    public Ease Ease { get => ease; }
    public int LoopCount { get => loopCount; }
    public LoopType LoopType { get => loopType; }
    public bool AutoKill { get => autoKill; }
    public bool Recyclable { get => recyclable; }
    public bool Relative { get => relative; }

    protected Tween baseTween;

    /// <summary>
    /// Returns the default tween params
    /// </summary>
    /// <returns></returns>
    protected TweenParams GetDefaultTweenParams()
    {
        var tweenParams = new TweenParams()
            .SetDelay(StartDelay)
            .SetEase(Ease)
            .SetLoops(LoopCount, loopType)
            .SetAutoKill(AutoKill)
            .SetRecyclable(Recyclable)
            .SetRelative(Relative);
        return tweenParams;
    }

    /// <summary>
    /// Returns the tween to the given gameobject
    /// </summary>
    /// <param name="go">GameObject</param>
    /// <returns></returns>
    public abstract Tween GetTween(GameObject go);

    /// <summary>
    /// Returns the tween params
    /// </summary>
    /// <returns></returns>
    public TweenParams GetTweenParams()
    {
        return GetDefaultTweenParams();
    }
}
