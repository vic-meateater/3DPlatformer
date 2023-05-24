using Tools;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Bario
{
    public class GameController : BaseController
    {
        private readonly PlayerModel _playerModel;

        public GameController(PlayerModel playerModel, GameConfig gameConfig)
        {
            var move = new SubscriptionProperty<float>();
            _playerModel = playerModel;
            var playerController = new PlayerController(move, gameConfig);
            AddController(playerController);

            var inputController = new InputController(move, _playerModel.Player);
            AddController(inputController);
        }
    }
}