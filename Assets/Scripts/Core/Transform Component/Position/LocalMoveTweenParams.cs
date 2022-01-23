using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Move Tween Params", fileName = "Local Move Tween Params")]
public class LocalMoveTweenParams : BaseTweenParams
{
    [Header("Local Move Tween Params Data")]
    [SerializeField, Space(5f)] Vector3 endValue = Vector3.zero;

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOLocalMove(endValue, duration).SetAs(tweenParams);
        return baseTween;
    }
}
