using System;
using UnityEngine;

public class MainMenuController: BaseController
{
    private readonly PlayerModel _playerModel;
    private readonly Transform _uiRoot;
    private readonly GameConfig _gameConfig;

    public MainMenuController(PlayerModel playerModel, Transform uiRoot, GameConfig gameConfig)
    {
        _playerModel = playerModel;
        _uiRoot = uiRoot;
        _gameConfig = gameConfig;
        CreateView();
    }

    private void CreateView()
    {
        var mainMenuGO = GameObject.Instantiate(_gameConfig.MainMenuPrefab, _uiRoot);
        AddGameObject(mainMenuGO);

        var mainMenuView = mainMenuGO.GetComponent<MainMenuView>();
        mainMenuView.Init(StartGame);
    }

    private void StartGame()
    {
        _playerModel.State.Value = GameState.Game;
    }
}
