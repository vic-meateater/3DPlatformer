using UnityEngine;

namespace Bario
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Game/Config", order = 1)]
    public class GameConfig : ScriptableObject
    {
        [Header("Prefabs and other setups")]
        [SerializeField] private GameObject mainMenu = null;
        [SerializeField] private GameObject player = null;
        [Header("Player settings")]
        [SerializeField] private float playerSpeed = 1f;
        [Header("Yandex")]
        [SerializeField] private YandexBanner banner = null;

        public GameObject MainMenuPrefab => mainMenu;
        public GameObject PlayerPrefab => player;
        public float PlayerSpeed => playerSpeed;
        public YandexBanner Banner => banner;
    }
}
