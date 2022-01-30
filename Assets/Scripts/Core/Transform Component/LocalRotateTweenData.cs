using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Rotate Tween Data", fileName = "Local Rotate Tween Data", order = 3)]
public class LocalRotateTweenData : BaseTweenData
{
    [Header("Local Rotate Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;
    [SerializeField, Space(1f)] RotateMode rotateMode = RotateMode.Fast;

    public Vector3 EndValue { get => endValue; }
    public RotateMode RotateMode { get => rotateMode; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DOLocalRotate(EndValue, Duration, RotateMode).SetAs(baseTweemParams);
        return baseTween;
    }
}
