using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Move Tween Data", fileName = "Move Tween Data")]
public class MoveTweenData : BaseTweenData
{
    [Header("Move Tween Params Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOMove(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
