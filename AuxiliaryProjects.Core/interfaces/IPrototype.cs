namespace AuxiliaryProjects.Core.interfaces
{
    public interface IPrototype<T>
    {
        T CreateDeepCopy();
    }
}