namespace Logics
{
    public interface IWarItem
    {
        public string Name { get; }
        public IWeapon Weapon { get; }
        void Destroying();
        void Shoot();
    }
}