using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Inventory 
{
    protected int player_id;
    protected int item_id;

    public Inventory (int player_id, int item_id)
    {
        this.player_id = player_id;
        this.item_id = item_id;
    }
    public int getPlayerID()
    {
        return this.player_id;
    }
    public int getItemID()
    {
        return this.item_id;
    }
}
