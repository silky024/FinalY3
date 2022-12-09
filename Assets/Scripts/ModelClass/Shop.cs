using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    protected int item_id;
    protected string item_name;
    protected int silver_coin;
    protected int gold_coin;
    protected int diamond;

    public Shop (int item_id, string item_name, int silver_coin, int gold_coin, int diamond)
    {
        this.item_id = item_id;
        this.item_name = item_name;
        this.silver_coin = silver_coin;
        this.gold_coin = gold_coin;
        this.diamond = diamond;
    }
    
    public int getItemID()
    {
        return this.item_id;
    }
    public string getItemname()
    {
        return this.item_name;
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
