using Tools;

public class PlayerModel
{
    public Player Player { get; private set; }
    public SubscriptionProperty<GameState> State { get; private set; }

    public PlayerModel(float speed)
    {
        Player = new Player(speed);
        State = new SubscriptionProperty<GameState>();
    }
}

public enum GameState
{
    None,
    Menu,
    Game,
}

public class Player
{
    private readonly float _speed;
    public Player(float speed)
    {
        _speed = speed;
    }
}
