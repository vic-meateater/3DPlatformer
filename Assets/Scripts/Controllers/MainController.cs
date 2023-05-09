using System;
using System.Collections.Generic;
using UnityEngine;

public class MainController: BaseController
{
    private readonly PlayerModel _playerModel;
    private readonly Transform _uiRoot;
    private readonly GameConfig _gameConfig;


    private BaseController _currentController;


    public MainController(PlayerModel playerModel, Transform uiRoot, GameConfig gameConfig) 
    { 
        _playerModel = playerModel;
        _uiRoot = uiRoot;
        _gameConfig = gameConfig;
        playerModel.State.SubscribeOnChange(OnGameStateChanged);

    }

    private void OnGameStateChanged(GameState state)
    {
        _currentController?.Dispose();
        
        switch (state)
        {
            case GameState.None:
                break;
            case GameState.Menu:
                _currentController = new MainMenuController(_playerModel, _uiRoot, _gameConfig);
                AddController(_currentController);
                break;
            case GameState.Game:
                _currentController = new GameController(_playerModel, _gameConfig);
                AddController(_currentController);
                break;
        }
    }
}
