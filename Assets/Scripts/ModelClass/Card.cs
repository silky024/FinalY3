using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    protected int card_id;
    protected string name;
    protected int guntype_id;
    protected int level;
    protected string rarity;
    protected int hp;
    protected int atk;
    protected int def;

    public Card(int card_id, string name,int guntype_id, int level, string rarity, int hp, int atk, int def )
    {
        this.card_id = card_id;
        this.name = name;
        this.guntype_id = guntype_id;
        this.level = level;
        this.rarity = rarity;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
    }

    public int getCardID()
    {
        return this.card_id;
    }
    public void setCardID( int card_id)
    {
        this.card_id = card_id;
    }

    public string getCardName()
    {
        return this.name;
    }
    public void setCardName(string name)
    {
        this.name = name;
    }

    public int getGuntype()
    {
        return this.guntype_id;
    }
    public void setGuntype(int guntype_id)
    {
        this.guntype_id = guntype_id;
    }

    public int getLevel()
    {
         return this.level;
    }
    public void setLevel(int level)
    {
        this.level = level;
    }

    public string getRarity()
    {
        return this.rarity;
    }
    public void setRarity(string rarity)
    {
        this.rarity = rarity;
    }

    public int getHp()
    {
        return this.hp;
    }
    public void setHp(int hp)
    {
        this.hp = hp;
    }

    public int getAtk()
    {
        return this.atk;
    }
    public void setAtk(int atk)
    {
        this.atk = atk;
    }

    public int getDef()
    {
        return this.def;
    }
    public void setDef(int def)
    {
        this.def = def;
    }


}
