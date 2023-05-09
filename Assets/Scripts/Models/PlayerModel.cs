using Tools;

namespace Bario
{
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
}