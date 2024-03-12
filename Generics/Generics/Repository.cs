namespace Generics
{
    public class Repository<T, U> /*where T : class*/ /*where T : BaseEntity*/ /*where T : struct*/ /*where T : new()*/
                                    where T : U
    {
    }
}
