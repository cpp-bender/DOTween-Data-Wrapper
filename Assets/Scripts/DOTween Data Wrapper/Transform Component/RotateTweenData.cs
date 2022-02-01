using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Rotate Tween Data", fileName = "Rotate Tween Data", order = 2)]
public class RotateTweenData : BaseTweenData
{
    [Header("Rotate Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;
    [SerializeField, Space(1f)] RotateMode rotateMode = RotateMode.Fast;

    public Vector3 EndValue { get => endValue; }
    public RotateMode RotateMode { get => rotateMode; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DORotate(EndValue, Duration, RotateMode).SetAs(baseTweemParams);
        return baseTween;
    }
}
