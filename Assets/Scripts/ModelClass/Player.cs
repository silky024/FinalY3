using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

public class Player 
{
    protected int id;
    protected string username;
    protected int silver_coin;
    protected int gold_coin;
    protected int diamond;

    public Player(int id, string username, int silver_coin, int gold_coin, int diamond)
    {
        this.id = id;
        this.username = username;
        this.silver_coin = silver_coin;
        this.gold_coin = gold_coin;
        this.diamond = diamond;
    }

    public int getPlayerID()
    {
        return this.id;
    }
    public string getUsername()
    {
        return this.username;
    }
    public int getSilver()
    {
        return this.silver_coin;
    }
    public int getGold()
    {
        return this.gold_coin;
    }
    public int getDiamond()
    {
        return this.diamond;
    }

}
