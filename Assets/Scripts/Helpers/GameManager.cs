using UnityEngine;
using DG.Tweening;

[DefaultExecutionOrder(0)]
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    protected override void Awake()
    {
        base.Awake();
        InitDOTween();
    }

    private void InitDOTween()
    {
        DOTween.Init(true, true, LogBehaviour.Default);
        DOTween.defaultAutoPlay = AutoPlay.None;
    }
}
