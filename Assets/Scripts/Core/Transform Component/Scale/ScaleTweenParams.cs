using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Scale Tween Params", fileName = "Scale Tween Params")]
public class ScaleTweenParams : BaseTweenParams
{
    [Header("Scale Tween Params Data")]
    [SerializeField, Space(1f)] bool isSameScaleValue = true;
    [SerializeField, Space(1f)] float scaleValue = 1f;
    [SerializeField, Space(1f)] Vector3 endValue = Vector3.one;

    private void OnValidate()
    {
        if (isSameScaleValue)
        {
            endValue = Vector3.one * scaleValue;
        }
    }

    public override Tween GetTween(GameObject go)
    {
        var tweenParams = GetDefaultTweenParams();
        baseTween = go.transform.DOScale(endValue, duration).SetAs(tweenParams);
        return baseTween;
    }
}
