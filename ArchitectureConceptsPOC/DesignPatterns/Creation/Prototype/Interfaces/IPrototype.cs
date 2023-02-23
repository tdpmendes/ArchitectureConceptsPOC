namespace ArchitectureConceptsPOC.SOLID.Prototype.Interfaces
{
                                        //Type Safety
    public interface IPrototype<T> where T : EntidadeGenerica
    {
        public T Clone();
    }
}
