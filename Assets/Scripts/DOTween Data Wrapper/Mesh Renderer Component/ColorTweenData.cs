using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "DOTween Utilities/Color Tween Data", fileName = "Color Tween Data", order = 7)]
public class ColorTweenData : BaseTweenData
{
    [Header("Color Tween Data"), Space(2f)]
    [SerializeField, Space(1f)] Color endValue = Color.white;

    public Color EndValue { get => endValue; set => endValue = value; }

    public override Tween GetTween(GameObject go)
    {
        baseTween = go.GetComponent<MeshRenderer>().material.DOColor(EndValue, Duration).SetAs(baseTweemParams);
        return baseTween;
    }
}
