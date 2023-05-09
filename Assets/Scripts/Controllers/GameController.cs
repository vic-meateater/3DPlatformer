using UnityEditor.SceneManagement;
using UnityEngine;

public class GameController: BaseController
{
    private readonly PlayerModel _playerModel;
    private readonly GameConfig _gameConfig;

    public GameController(PlayerModel playerModel, GameConfig gameConfig)
    {
        _playerModel = playerModel;
        _gameConfig = gameConfig;
        var playerController = new PlayerController(gameConfig);
        AddController(playerController);
    }
}

public class InputController
{

}