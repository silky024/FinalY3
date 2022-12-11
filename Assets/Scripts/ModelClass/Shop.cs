using System.Collections;
using System.Collections.Generic;


public class Shop
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
    public void setItemID( int item_id)
    {
        this.item_id = item_id;
    }
    public string getItemname()
    {
        return this.item_name;
    }
    public void SetItemname (string item_name)
    {
        this.item_name = item_name;
    }
    public int getSilver()
    {
        return this.silver_coin;
    }
    public void setSilver(int silver_coin)
    {
        this.silver_coin = silver_coin;
    }
    public int getGold()
    {
        return this.gold_coin;
    }
    public void setGold(int gold_coin)
    {
        this.gold_coin = gold_coin;
    }
    public int getDiamond()
    {
        return this.diamond;
    }
    public void setDiamond(int diamond)
    {
        this.diamond = diamond;
    }
}
