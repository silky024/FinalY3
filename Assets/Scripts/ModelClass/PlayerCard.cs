using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCard
{ 
    protected int player_id;
    protected int card_id;
    protected int level;
    protected int hp;
    protected int atk;
    protected int def;

    public PlayerCard(int player_id, int card_id, int level, int hp, int atk, int def)
    {
        this.player_id = player_id;
        this.card_id = card_id;
        this.level = level;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
    }



    public int getPlayerID()
    {
        return this.player_id;
    }
    public void setPlayerID(int player_id)
    {
        this.player_id = player_id;
    }
    public int getCardID()
    {
        return this.card_id;
    }
    public void setCardID(int card_id)
    {
        this.card_id = card_id;
    }

    public int getLevel()
    {
        return this.level;
    }
    public void setLevel(int level)
    {
        this.level = level;
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
