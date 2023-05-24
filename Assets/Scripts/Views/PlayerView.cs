using JoostenProductions;
using Tools;
using UnityEngine;

namespace Bario
{
    public class PlayerView : MonoBehaviour
    {
        private float _playersMovementSpeed = 2f;
        private IReadOnlySubscriptionProperty<float> _playersMovementDirection;
        private Vector3 _playerVelocity;

        public void Init(IReadOnlySubscriptionProperty<float> moving, float speed)
        {
            _playersMovementSpeed = speed;
            _playersMovementDirection = moving;
            UpdateManager.SubscribeToUpdate(Move);
        }

        private void Move()
        {
            _playerVelocity = new Vector3(0f, 0f, _playersMovementDirection.Value * _playersMovementSpeed);
            transform.position += _playerVelocity * Time.deltaTime;
        }

        private void OnDestroy()
        {
            UpdateManager.UnsubscribeFromUpdate(Move);
        }
    }
}
