using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Move Tween Params", fileName = "Move Tween Params")]
public class MoveTweenParams : BaseTweenParams
{
    [Header("Move Tween Params Data")]
    [SerializeField, Space(5f)] Vector3 endValue = Vector3.zero;

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOMove(endValue, duration).SetAs(tweenParams);
        return baseTween;
    }
}
