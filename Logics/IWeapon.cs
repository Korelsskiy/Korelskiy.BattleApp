namespace Logics
{
    public interface IWeapon
    {
        public string Title { get; }
        public int Damage { get; }
        void Shoot();
    }
}