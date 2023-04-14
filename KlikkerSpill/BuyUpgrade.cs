namespace KlikkerSpill;

public class BuyUpgrade : ICommand
{
    public char Char { get; } = 'K';
    private ClickerGame _game;

    public BuyUpgrade(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.BuyUpgrade();
    }
}