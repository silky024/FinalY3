using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;


public class PlayerControll : MonoBehaviour
{
   /* public string DBFileName = "";
    public string DBFolder = "DB";


    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");
        string name = "";
        int card_id = -1;

        List<Card> card = new List<Card>();


        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "card_id")
                {
                    card_id = Convert.ToInt32(reader.GetValue(i));
                }

                if (reader.GetName(i) == "name")
                {
                    name = "" + reader.GetValue(i);
                }
            }

            card.Add(new Card(card_id, name));
        }
        Debug.Log(card[0].getCardID() + " : " + card[0].getName());


        adapter.disconnectDatabase();

        foreach (var item in card)
        {
            Debug.Log(item.getName());
        }

        
    }
    void Start()
        {
            //insertNewPlayer();
            onLoadfromDatabase();

        }*/
}
