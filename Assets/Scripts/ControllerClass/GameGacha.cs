using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using Mono.Data.Sqlite;

public class GameGacha : MonoBehaviour
{
    /*public void OpenLootbox()
    {

        character.Add(new Card("Rapi", 1));
        character.Add(new Card("Maxi", 1));

        int card_id = Random.Range(0, 8);


        Card theCard = character[card_id];

        Debug.Log(theCard.getCardName());
        Debug.Log(theCard.getLevel());
    }

    public string DBFileName = "";
    public string DBFolder = "DB";
    List<Card> character ;

    

    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");
        string data = "";

        while (reader.Read())
        {
            Card chaCard = new Card();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                data += reader.GetName(i) + " : " + reader.GetValue(i);
            if(reader.GetCardID(i)) == "card_id")
            {
                chaCard.setCardID(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "name")
            {
                chaCard.setName(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "guntype_id")
            {
                chaCard.setGuntype(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "level")
            {
                chaCard.setLevel(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "rarity")
            {
                chaCard.setRarity(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "hp")
            {
                chaCard.setHp(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "atk")
            {
                chaCard.setAtk(reader.GetValue(i));
            }
            else if (reader.GetName(i) == "def")
            {
                chaCard.setDef(reader.GetValue(i));
            }

        }
        data += "\n";
        character.Add(chaCard)
        }
        Debug.Log(data);
        adapter.disconnectDatabase();
    }

    void Start()
    {
        onLoadfromDatabase();
        character = new List<Card>();
    }*/
}
