using UnityEditor.SceneManagement;
using UnityEngine;

namespace Bario
{
    public class GameController : BaseController
    {
        private readonly PlayerModel _playerModel;

        public GameController(PlayerModel playerModel, GameConfig gameConfig)
        {
            _playerModel = playerModel;
            var playerController = new PlayerController(gameConfig);
            AddController(playerController);
        }
    }

    public class InputController
    {

    }
}