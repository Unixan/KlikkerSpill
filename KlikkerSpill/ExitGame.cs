namespace KlikkerSpill;

public class ExitGame : ICommand
{
    public char Char { get; } = 'X';
    private ClickerGame _game;

    public ExitGame(ClickerGame game)
    {
        _game = game;
    }
    public void Run()
    {
        _game.ExitGame();
    }
}