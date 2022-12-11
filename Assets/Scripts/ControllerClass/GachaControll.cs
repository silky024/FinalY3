using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System;
using UnityEngine.UI;

public class GachaControll : MonoBehaviour
{
    public string DBFileName = "";
    public string DBFolder = "DB";

    List<Card> cards = new List<Card>();

    public Text nameText;


    public Player player = new Player(1, "Mark", 0 , 0, 0);

    public void OpenLootbox()
    {

        int cid = UnityEngine.Random.Range(0, 10);

        
        Card theCard = cards[cid];

        nameText.text = theCard.getCardName();

        //SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        //adapter.insertCard(theCard.name, theCard.hp, theCard.Level);
        //adapter.disconnectDatabase();

        Debug.Log(theCard.getCardName());
        Debug.Log(theCard.getLevel());
    }

    public void addItem()
    {
        print("add ramdome card");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        //adapter.insertItem(11, "Ramdom Card");
        player.Silver_coin = player.Silver_coin + 5;
        //player.setGold(player.getGold() + 5);

        adapter.updatePlayerSilver(player.Silver_coin);

        adapter.disconnectDatabase();

    }

    public void onLoadPlayerfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("player", "*");


        string name = "";
        int silver_coin = 0;
        int gold_coin = 0;
        int diamon = 0;
       


        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "silver")
                {
                    silver_coin = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "name")
                {
                    name = "" + reader.GetValue(i);
                }
                if (reader.GetName(i) == "gold")
                {
                    gold_coin = Convert.ToInt32(reader.GetValue(i));
                }
         
            }
            //player.name = name;
            player.Silver_coin = silver_coin;
            print(player.Silver_coin);
            // add gold
            // add diamon
        }



        adapter.disconnectDatabase();
        /*foreach (var item in Card)
        {
            Debug.Log(item.getName());
        }*/
    }

    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");


        string name = "";
        int card_id = 0;
        int guntype_id = 0;
        int level = 0;
        string rarity = "";
        int hp = 0;
        int atk = 0;
        int def = 0;

        

        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if(reader.GetName(i) == "card_id")
                {
                    card_id = Convert.ToInt32(reader.GetValue(i));
                }
                if(reader.GetName(i) == "name")
                {
                    name = "" + reader.GetValue(i);
                }
                if (reader.GetName(i) == "guntype_id")
                {
                    guntype_id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "level")
                {
                    level = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "rarity")
                {
                    rarity = "" + reader.GetValue(i);
                }
                if (reader.GetName(i) == "hp")
                {
                    hp = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "atk")
                {
                    atk = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "def")
                {
                    def = Convert.ToInt32(reader.GetValue(i));
                }
            }
            cards.Add(new Card(card_id, name, guntype_id, level, rarity, hp, atk, def));
            Debug.Log(cards);
        }
        
        
        adapter.disconnectDatabase();
    }


    void Start()
    {
        onLoadfromDatabase();
        onLoadPlayerfromDatabase();


    }



}
