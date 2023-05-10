﻿using Tools;
using UnityEngine;

namespace Bario
{
    public class PlayerView : MonoBehaviour
    {
        public float PlayersMovementSpeed = 2f;
        public float PlayerJumpingForce;
        private float _playersMovementDirection = 0;
        private PlayerInput _inputActionReference;
        private Rigidbody _playersRigidBody;

        private void Start()
        {

            _playersRigidBody ??= GetComponent<Rigidbody>();

            _inputActionReference = new PlayerInput();

            _inputActionReference.Enable();

            _inputActionReference.Player.Moving.performed += moving =>
            {
                _playersMovementDirection = moving.ReadValue<float>();
            };
        }

        private void FixedUpdate()
        {
            _playersRigidBody.velocity =
                new Vector3(_playersRigidBody.velocity.x, _playersRigidBody.velocity.y, _playersMovementDirection * PlayersMovementSpeed);
        }
    }
}
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