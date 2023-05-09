using UnityEngine;

namespace Bario
{
    public class PlayerController : BaseController, IFixedUpdate
    {
        private readonly PlayerView _player;
        private readonly GameConfig _gameConfig;

        public PlayerController(GameConfig gameConfig)
        {
            _gameConfig = gameConfig;
            _player = GetPlayerView(_gameConfig);
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