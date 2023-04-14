﻿namespace KlikkerSpill;

public class ClickerGame
{
    public int Points { get; private set; } = 0;
    private int _pointsPerClick = 1;
    private int _pointsPerClickIncrease = 1;

    public void AddPoints()
    {
        Points += _pointsPerClick;
    }

    public void BuyUpgrade()
    {
        if (Points < 10) return;
        Points -= 10;
        _pointsPerClick += _pointsPerClickIncrease;
    }

    public void BuySuperUpgrade()
    {
        if (Points < 100) return;
        Points -= 100;
        _pointsPerClickIncrease++;
    }

    public void ExitGame()
    {
        Environment.Exit(0);
    }
}