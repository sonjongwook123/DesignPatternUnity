using UnityEngine;

namespace Chapter.Decorator
{
    [CreateAssetMenu(fileName ="NewWeaponConfig", menuName ="Weapon/Config", order =1)]
    public class WeaponConfig : ScriptableObject,IWeapon
    {
        [Range(0,60)]
        [Tooltip("Rate of firing per second")]
        [SerializeField]
        public float rate;

        [Range(0,50)]
        [Tooltip("Weapon range")]
        [SerializeField]
        float range;

        [Range(0,100)]
        [Tooltip("Weapon strength")]
        [SerializeField]
        public float strength;
        
        [Range(0,5)]
        [Tooltip("Cooldown duration")]
        [SerializeField]
        public float cooldown;

        public string weaponName;
        public GameObject weaponPrefab;
        public string weaponDescription;

        public float Range
        {
            get
            {
                return rate;
            }
        }
        
        public float Strength
        {
            get
            {
                return strength;
            }
        }

        public float Cooldown
        {
            get
            {
                return cooldown;
            }
        }

        public float Rate
        {
            get
            {
                return rate;
            }
        }
    }
}