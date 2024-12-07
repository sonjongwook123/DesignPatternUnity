namespace Chapter.Decorator
{
    public class Weapon : IWeapon
    {
        public float Range
        {
            get
            {
                return _config.Range;
            }
        }
        
        public float Strength
        {
            get
            {
                return _config.Strength;
            }
        }

        public float Cooldown
        {
            get
            {
                return _config.Cooldown;
            }
        }

        public float Rate
        {
            get
            {
                return _config.Rate;
            }
        }
        
        private readonly WeaponConfig _config;
        
        public Weapon(WeaponConfig weaponConfig)
        {
            _config = weaponConfig;
        }
    }
}