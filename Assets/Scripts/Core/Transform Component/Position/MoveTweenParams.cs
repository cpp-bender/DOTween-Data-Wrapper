using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Move Tween Params", fileName = "Move Tween Params")]
public class MoveTweenParams : BaseTweenParams
{
    [Header("Move Tween Params Data"), Space(5f)]
    public Vector3 EndValue = Vector3.zero;

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOMove(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
