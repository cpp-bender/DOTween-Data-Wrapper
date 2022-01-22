using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Wrapper/Move Tween Params", fileName = "Move Tween Params")]
public class MoveTweenParams : BaseTweenParams
{
    [Header("Move Tween Params Data")]
    [SerializeField, Space(5f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    /// <summary>
    /// Gets the tween attached to the given gameobject
    /// </summary>
    /// <param name="go">GameObject</param>
    /// <returns></returns>
    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOMove(endValue, duration).SetAs(tweenParams);
        return baseTween;
    }
}
