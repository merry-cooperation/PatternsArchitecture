public sealed class MySingleton
{
    private MySingleton() { }
    public static MySingleton Instance { get; } = new MySingleton();
}
