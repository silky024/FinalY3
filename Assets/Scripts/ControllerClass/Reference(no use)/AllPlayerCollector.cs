using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using Mono.Data.Sqlite;
using System;

public class AllPlayerCollector : MonoBehaviour
{
    public string DBFileName = "";
    public string DBFolder = "DB";
    


    public void onLoadfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("card", "*");
        string data = "";

        while (reader.Read())
        {
            for(int i =0; i< reader.FieldCount; i++)
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
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
