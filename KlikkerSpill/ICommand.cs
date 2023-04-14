namespace KlikkerSpill;

public interface ICommand
{
    void Run();
    char Char { get; }
}