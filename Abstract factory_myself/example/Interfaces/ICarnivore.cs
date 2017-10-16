namespace Interfaces
{
    public interface ICarnivore : IAnimal
    {
       void Eat(IHerbivore herbivore);
    }
}
