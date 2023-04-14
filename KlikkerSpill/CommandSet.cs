namespace KlikkerSpill;

public class CommandSet
{
    private ICommand[] _commands;

    public CommandSet(ClickerGame game)
    {
        _commands = new ICommand[]{
            new AddPoints(game),
            new BuyUpgrade(game),
            new BuySuperUpgrade(game),
            new ExitGame(game),
        };
    }

    public void Run(char UserChoice)
    {
        var validCommand = GetValidCommand(UserChoice);
        if (validCommand == null) return;
        validCommand.Run();
    }

    private ICommand? GetValidCommand(char userChoice)
    {
        return _commands.FirstOrDefault(command => command.Char == userChoice);
    }
}