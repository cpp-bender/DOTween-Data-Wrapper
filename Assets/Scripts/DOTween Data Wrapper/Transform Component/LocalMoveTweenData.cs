using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Move Tween Data", fileName = "Local Move Tween Data", order = 1)]
public class LocalMoveTweenData : BaseTweenData
{
    [Header("Local Move Tween Data"),Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DOLocalMove(EndValue, Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
