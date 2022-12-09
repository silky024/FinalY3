using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected int item_id;
    protected string name;

    public Item(int item_id, string name)
    {
        this.item_id = item_id;
        this.name = name;



    }
    public int getItemID()
    {
        return this.item_id;
    }
    public string getName()
    {
        return this.name;
    }

}
