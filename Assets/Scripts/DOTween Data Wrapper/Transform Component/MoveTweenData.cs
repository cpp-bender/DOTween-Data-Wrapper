using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Move Tween Data", fileName = "Move Tween Data", order = 0)]
public class MoveTweenData : BaseTweenData
{
    [Header("Move Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DOMove(EndValue, Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
