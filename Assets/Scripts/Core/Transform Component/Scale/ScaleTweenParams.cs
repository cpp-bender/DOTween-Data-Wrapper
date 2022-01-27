using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Scale Tween Params", fileName = "Scale Tween Params")]
public class ScaleTweenParams : BaseTweenParams
{
    [Header("Scale Tween Params Data")]
    [SerializeField, Space(5f)] bool isSameScaleValue = true;

    [Space(5f)] public float ScaleValue = 1f;
    [Space(5f)] public Vector3 EndValue = Vector3.one;

    private void OnValidate()
    {
        if (isSameScaleValue)
        {
            EndValue = Vector3.one * ScaleValue;
        }
    }

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOScale(EndValue, Duration).SetAs(tweenParams);
        return baseTween;
    }
}
