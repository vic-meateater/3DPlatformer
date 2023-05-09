using UnityEngine;

namespace Bario
{
    public class Root : MonoBehaviour
    {
        [SerializeField] private Transform _uiRoot;
        [SerializeField] private GameConfig _gameConfig;

        private MainController _mainController;

        private void Start()
        {
            var playerModel = new PlayerModel(_gameConfig.PlayerSpeed);
            _mainController = new MainController(playerModel, _uiRoot, _gameConfig);
            playerModel.State.Value = GameState.Menu;
        }

        private void OnDestroy()
        {
            _mainController?.Dispose();
        }

        private void FixedUpdate()
        {
            Debug.Log(UpdateController.GetFixedUpdates.Count);
            foreach (var update in UpdateController.GetFixedUpdates)
            {
                update.FixedUpdate();
            }
        }
    }
}