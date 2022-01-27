using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Move Tween Params", fileName = "Local Move Tween Params")]
public class LocalMoveTweenParams : BaseTweenParams
{
    [Header("Local Move Tween Params Data"), Space(5f)]
    public Vector3 EndValue = Vector3.zero;

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOLocalMove(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
