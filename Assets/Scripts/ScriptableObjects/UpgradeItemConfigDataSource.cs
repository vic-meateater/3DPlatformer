using UnityEngine;

namespace Bario
{
    [CreateAssetMenu(fileName = "UpgradeItemConfigDataSource", menuName = "Game/Items/UpgradeItemConfigDataSource")]
    public class UpgradeItemConfigDataSource : ScriptableObject
    {
        [SerializeField] private UpgradeItemConfig[] _upgradeItemConfigs;

        public UpgradeItemConfig[] UpgradeItemConfigs => _upgradeItemConfigs;
    }
}
