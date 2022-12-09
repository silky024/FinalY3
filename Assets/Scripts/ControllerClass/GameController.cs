using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using Mono.Data.Sqlite;




public class GameController : MonoBehaviour
{
   /* public void OpenLootbox()
    {
        
        character.Add(new Card("Rapi",1));
        character.Add(new Card("Maxi",1));

        int cid = Random.Range(0, 2);


        Card theCard = character[cid];
        
        Debug.Log(theCard.getCardName());
        Debug.Log(theCard.getLevel());
    }

    public string DBFileName = "";
    public string DBFolder = "DB";
    List<Card> character = new List<Card>();



    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");
        string data = "";

        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                data += reader.GetName(i) + " : " + reader.GetValue(i);
            }
            data += "\n";
        }
        Debug.Log(data);
        adapter.disconnectDatabase();
    }

    void Start()
    {
        onLoadfromDatabase();
    }*/
}
