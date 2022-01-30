using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Rotate Quaternion Tween Data", fileName = "Rotate Quaternion Tween Data", order = 4)]
public class RotateQuaternionTweenData : BaseTweenData
{
    [Header("Rotate Quaternion Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DORotateQuaternion(Quaternion.Euler(EndValue), Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
