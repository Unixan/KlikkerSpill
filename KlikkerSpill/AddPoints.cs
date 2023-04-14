namespace KlikkerSpill;

public class AddPoints : ICommand
{
    public char Char { get; } = ' ';
    private ClickerGame _game;

    public AddPoints(ClickerGame game)
    {
        _game = game;
    }
    public void Run()
    {
        _game.AddPoints();
    }
}