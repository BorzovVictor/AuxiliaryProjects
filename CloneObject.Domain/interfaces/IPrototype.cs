namespace CloneObject.Domain.interfaces
{
    public interface IPrototype<T>
    {
        T CreateDeepCopy();
    }
}