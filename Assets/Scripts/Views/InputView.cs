using Tools;
using UnityEngine;

public class InputView: MonoBehaviour
{
    protected float _speed;
    private SubscriptionProperty<float> _moving;

    public void Init(SubscriptionProperty<float> moving, float speed)
    {
        _speed = speed;
        _moving = moving;
    }
}