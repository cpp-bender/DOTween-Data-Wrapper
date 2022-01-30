using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Scale Tween Data", fileName = "Scale Tween Data", order = 6)]
public class ScaleTweenData : BaseTweenData
{
    [Header("Scale Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] bool isSameScaleValue = true;
    [SerializeField, Space(1f)] private float scaleValue = 1f;
    [SerializeField, Space(1f)] private Vector3 endValue = Vector3.one;

    public float ScaleValue { get => scaleValue; }
    public Vector3 EndValue { get => endValue; }

    private void OnValidate()
    {
        if (isSameScaleValue)
        {
            endValue = Vector3.one * ScaleValue;
        }
    }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.transform.DOScale(EndValue, Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
