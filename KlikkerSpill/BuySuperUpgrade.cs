namespace KlikkerSpill;

public class BuySuperUpgrade : ICommand
{
    public char Char { get; } = 'S';
    private ClickerGame _game;

    public BuySuperUpgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.BuySuperUpgrade();
    }
}