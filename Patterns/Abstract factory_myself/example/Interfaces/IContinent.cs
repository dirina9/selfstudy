namespace Interfaces
{
    public interface IContinent
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}
