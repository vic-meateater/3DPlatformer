using UnityEngine;

public class PlayerController: BaseController, IFixedUpdate
{
    private readonly PlayerView _player;
    public PlayerController(GameConfig gameConfig) 
    {
        var playerGO = GameObject.Instantiate(gameConfig.PlayerPrefab, Vector3.zero, Quaternion.identity);
        _player = playerGO.GetComponent<PlayerView>();
        AddGameObject(playerGO);
    }

    public void FixedUpdate()
    {
        //
    }
}
