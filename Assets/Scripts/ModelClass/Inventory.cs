using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Inventory 
{
    protected int player_id;
    protected int item_id;
    protected int amount;

    public Inventory (int player_id, int item_id, int amount)
    {
        this.player_id = player_id;
        this.item_id = item_id;
        this.amount = amount;
    }
    public int getPlayerID()
    {
        return this.player_id;
    }
    public void setPlayerID(int player_id)
    {
        this.player_id = player_id;
    }

    public int getItemID()
    {
        return this.item_id;
    }
    public void setItemID(int item_id)
    {
        this.item_id = item_id;
    }

    public int getAmount()
    {
        return this.amount;
    }
    public void setAmount(int amount)
    {
        this.amount = amount;
    }
}
