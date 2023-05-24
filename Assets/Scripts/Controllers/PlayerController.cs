using Tools;
using UnityEngine;

namespace Bario
{
    public class PlayerController : BaseController, IFixedUpdate
    {
        private readonly PlayerView _player;
        private readonly PlayerInput _inputActionReference;
        private float _playersMovementDirection;
        //private readonly GameConfig _gameConfig;

        public PlayerController(SubscriptionProperty<float> move, GameConfig gameConfig)
        {

            //_gameConfig = gameConfig;
            _inputActionReference = new PlayerInput();

            _inputActionReference.Enable();

            _inputActionReference.Player.Moving.performed += moving =>
            {
                _playersMovementDirection = moving.ReadValue<float>();
                move.Value = moving.ReadValue<float>();
            };
            //_inputActionReference.Player.Moving.canceled += moving =>
            //{
            //    PlayersMovementSpeed = 0;
            //};
            _player = GetPlayerView(gameConfig);
            _player.Init(move, gameConfig.PlayerSpeed);
        }

        private PlayerView GetPlayerView(GameConfig gameConfig)
        {
            var playerGO = GameObject.Instantiate(gameConfig.PlayerPrefab, Vector3.zero, Quaternion.identity);
            playerGO.TryGetComponent<PlayerView>(out var playerView);
            AddGameObject(playerGO);
            return playerView;
        }

        public GameObject GetGameObject() => _player.gameObject;

        public void FixedUpdate()
        {
            //
        }
    }
}