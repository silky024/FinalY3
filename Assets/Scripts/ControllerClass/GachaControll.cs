using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System;

public class GachaControll : MonoBehaviour
{
    public string DBFileName = "";
    public string DBFolder = "DB";



    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");
        string name = "";
        int card_id = -1;
        int guntype_id = -1;
        int level = 1;
        string rarity = "";
        int hp = 100;
        int atk = 100;
        int def = 100;

        List<Card> cards = new List<Card>();

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
        foreach (var item in Card)
        {
            Debug.Log(item.getName());
        }
    }


    void Start()
    {
        onLoadfromDatabase();
        
    }



}
