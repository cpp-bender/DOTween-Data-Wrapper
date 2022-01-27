using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Scale Tween Params", fileName = "Scale Tween Params")]
public class ScaleTweenParams : BaseTweenParams
{
    [Header("Scale Tween Params Data"), Space(2f)]
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
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOScale(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
