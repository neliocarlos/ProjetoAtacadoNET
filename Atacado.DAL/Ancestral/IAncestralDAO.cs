namespace Atacado.DAL.Ancestral
{
    public interface IAncenstralDAO<T> :
        IActionCreateDAO<T>,
        IActionReadDAO<T>,
        IActionUpdateDAO<T>,
        IActionDeleteDAO<T>
    {

    }
}