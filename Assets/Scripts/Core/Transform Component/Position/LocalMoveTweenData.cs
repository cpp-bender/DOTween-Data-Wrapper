using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Move Tween Data", fileName = "Local Move Tween Data")]
public class LocalMoveTweenData : BaseTweenData
{
    [Header("Local Move Tween Params Data"),Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOLocalMove(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
