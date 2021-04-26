namespace AuxiliaryProjects.Domain.interfaces
{
    public interface IPrototype<T>
    {
        T CreateDeepCopy();
    }
}