namespace CodePatternsAPI.Factories
{
    public class GenericFactory
    {
        public static T Create<T>() where T : class, new()
        {
            return new T();
        }
    }
}
