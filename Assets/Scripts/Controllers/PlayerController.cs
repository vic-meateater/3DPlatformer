using Tools;
using UnityEngine;

namespace Bario.Controllers
{
    public class PlayerController : BaseController
    {
        private readonly PlayerView _player;
        private PlayerInput _inputActionReference;

        public PlayerController(SubscriptionProperty<float> move, GameConfig gameConfig)
        {
            var movementValue = GetInputActionValue(move);
            _player = GetPlayerView(gameConfig);
            _player.Init(movementValue, gameConfig.PlayerSpeed);
        }

        private PlayerView GetPlayerView(GameConfig gameConfig)
        {
            var playerGO = GameObject.Instantiate(gameConfig.PlayerPrefab, Vector3.zero, Quaternion.identity);
            playerGO.TryGetComponent<PlayerView>(out var playerView);
            AddGameObject(playerGO);
            return playerView;
        }

        public GameObject GetGameObject() => _player.gameObject;

        private SubscriptionProperty<float> GetInputActionValue(SubscriptionProperty<float> move)
        {
            _inputActionReference = new PlayerInput();

            _inputActionReference.Enable();

            _inputActionReference.Player.Moving.performed += moving =>
            {
                move.Value = moving.ReadValue<float>();
            };
            _inputActionReference.Player.Moving.canceled += moving =>
            {
                move.Value = 0;
            };

            return move;
        }
    }
}