using JoostenProductions;
using System;
using Tools;
using UnityEngine;

namespace Bario
{
    public class PlayerView : MonoBehaviour
    {
        private float _playersMovementSpeed = 2f;
        //public float PlayerJumpingForce;
        private float _playersMovementDirection = 0f;
        private PlayerInput _inputActionReference;
        private Rigidbody _playersRigidBody;
        private Vector3 _playerVelocity;

        public void Init(SubscriptionProperty<float> moving, float speed)
        {
            _playersMovementSpeed = 2f;
            _playersMovementDirection = moving.Value;
            UpdateManager.SubscribeToUpdate(Move);
        }


        private void Start()
        {

            //_playersRigidBody ??= GetComponent<Rigidbody>();

            //_inputActionReference = new PlayerInput();

            //_inputActionReference.Enable();

            //_inputActionReference.Player.Moving.performed += moving =>
            //{
            //    _playersMovementSpeed = 2f;
            //    _playersMovementDirection = moving.ReadValue<float>();
            //};
            //_inputActionReference.Player.Moving.canceled += moving =>
            //{
            //    _playersMovementSpeed = 0;
            //};
        }
        private void Move()
        {
            Debug.Log("player view");
            _playerVelocity = new Vector3(0f, 0f, _playersMovementDirection * _playersMovementSpeed);
            transform.position += _playerVelocity * Time.deltaTime;
        }

        private void OnDestroy()
        {
            UpdateManager.UnsubscribeFromUpdate(Move);
        }
    }
}
