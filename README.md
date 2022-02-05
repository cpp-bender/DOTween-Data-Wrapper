## DOTween-Data-Wrapper

### Introduction
A component-based DOTween data wrapper (DDW), built specifically to make life easier for developers. It's still under development. 

## Old DOTween Usage

```csharp
    using UnityEngine;
    using DG.Tweening;
 
    public class DOTweenGenericWay : MonoBehaviour
    {
        private Tween tween;

        private void Start()
        {
            tween = transform.DOMoveX(5f, 1f)
                .SetDelay(.2f)
                .SetEase(Ease.OutSine)
                .SetAutoKill(true)
                .SetRecyclable(true)
                .Play();
        }
    }
```
 The example above shows how to do tweening using one of the DOTween's functions. Although, DOTween is a great tweening library. I believe I can make it much more 
 easier for the developers.
 
 ## DDW DOTween Usage
 ```csharp
    using UnityEngine;
    using DG.Tweening;
 
    public class DDWSolution : MonoBehaviour
    {
        public BaseTweenData baseTweenData;

        private Tween tween;

        private void Start()
        {
            tween = baseTweenData.GetTween(gameObject).Play();
        }
    }
```
With the DDW (DOTween Data Wrapper), you don't need to know your tween type (MoveTween, RotateTween, ScaleTween, etc.). You just need a "BaseTweenData" object 
to get the data you need in order to do tweening. At this moment, you migth ask a question 
"How in the earth would it know what tween type I want it to tween?". It is simple indeed. You tell it how to tween in the editor like below.

Note the following
 - In order to use GetTween function, you need to pass in a gameObject which makes the function dependent. There is also a way where you don't need to pass in any argument.
 I will discuss it in the following parts.

## Components
Supports the following components.


- [Transform](#transform)
  - [MoveTween](#movetween)
  - [RotateTween](#rotatetween)
  - [ScaleTween](#scaletween)
