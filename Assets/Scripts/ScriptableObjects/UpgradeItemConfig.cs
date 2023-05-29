using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bario
{
    [CreateAssetMenu(fileName = "UpgradeItemConfig", menuName = "Game/Items/Upgr Items Config")]
    public class UpgradeItemConfig : ScriptableObject
    {
        [SerializeField] private ItemConfig _itemConfig;
        [SerializeField] private UpgradeType _upgradeType;
        [SerializeField] private int _upgradeAmount;

        public int Id => _itemConfig.Id;
        public UpgradeType UpgradeType => _upgradeType;
        public int UpgradeAmount => _upgradeAmount;
    }
}

public enum UpgradeType
{
    None,
    Speed,
    Size
}
