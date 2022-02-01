using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Local Rotate Quaternion Tween Data", fileName = "Local Rotate Quaternion Tween Data", order = 5)]
public class LocalRotateQuaternionTweenData : BaseTweenData
{
    [Header("Local Rotate Quaternion Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.zero;

    public Vector3 EndValue { get => endValue; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DOLocalRotateQuaternion(Quaternion.Euler(EndValue), Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
