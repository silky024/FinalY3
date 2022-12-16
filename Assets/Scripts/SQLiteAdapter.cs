using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using Mono.Data.Sqlite;

using System;


public class SQLiteAdapter //: MonoBehaviour
{

    public string DBFileName = "";
    public string DBFolder = "DB";

    private IDbConnection dbcon;
    private IDbCommand dbcommd;

    public SQLiteAdapter(string DBFileName, string DBFolder)
    {
        this.DBFileName = DBFileName;
        this.DBFolder = DBFolder;
    }

    public void connectDatabase()
    {
        string connectionString = "URI=file:" + Application.dataPath + "/" + this.DBFolder + "/" + this.DBFileName;

        this.dbcon = new SqliteConnection(connectionString);
        this.dbcon.Open();

        this.dbcommd = this.dbcon.CreateCommand();
        //Debug.Log(connectionString);
    }

    public void disconnectDatabase()
    {
        this.dbcommd.Dispose();

        this.dbcon.Close();
        this.dbcon.Dispose();
    }

    public IDataReader query(string sql)
    {
        IDataReader reader;
        try
        {
            connectDatabase();
            this.dbcommd.CommandText = sql;
            reader = this.dbcommd.ExecuteReader();
        } catch (Exception excp)
        {
            Debug.Log(excp);
            reader = null;
        }
        return reader;
    }

    public IDataReader select(string table = "", string columes = "*")
    {
        string sql = "SELECT " + columes + " FROM " + table;
        return query(sql);
    }

    public IDataReader insertDeck(int player_id, int card_id, int level, int hp, int atk, int def )
    {
        string sql = "INSERT INTO deck (player_id, card_id, level, hp, atk, def) VALUES (" + player_id +"," + card_id +"," + level +","+ hp +"," + atk + ","+ def + ")";
        return query(sql);
    }

    public IDataReader insertItem(int item_id, string name)
    {
        string sql = "INSERT INTO item (item_id,name) VALUES (" + item_id + ",'" + name + "')";
        return query(sql);
    }
    public IDataReader insertInvenItem(int player_id, int item_id, int amount) //from mail to inven
    {
        string sql = "INSERT INTO inventory (player_id,item_id,amount) VALUES ("+player_id+"," + item_id + "," + amount + ")";
        return query(sql);
    }
    public IDataReader insertItemfromShop(int player_id, int item_id, int amount) //from shop to inven
    {
        string sql = "INSERT INTO inventory ( player_id, item_id, amount) VALUES (" + player_id + "," + item_id + "," + amount + ")";
        return query(sql);
    }


    public IDataReader updatePlayerSilver(int silver)
    {
        string sql = "UPDATE player SET silver = " + silver + " WHERE player_id = 1";
        return query(sql);
    }
    public IDataReader updatePlayerGold(int gold)
    {
        string sql = "UPDATE player SET gold = " + gold + " WHERE player_id = 1";
        return query(sql);
    }
    public IDataReader updatePlayerDiamond(int diamond)
    {
        string sql = "UPDATE player SET diamond = " + diamond + " WHERE player_id = 1";
        return query(sql);
    }
    public IDataReader updateLootboxamount(int amount)
    {
        string sql = "UPDATE inventory SET amount = " + amount + " WHERE player_id = 1, item_id = 1";
        return query(sql);
    }
    public IDataReader updateLootboxflasdriveamount(int amount)
    {
        string sql = "UPDATE inventory SET amount = " + amount + " WHERE player_id = 1, item_id = 2";
        return query(sql);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*connectDatabase();
        this.dbcommd.CommandText = "SELECT * FROM card";
        IDataReader reader = this.dbcommd.ExecuteReader();
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
        disconnectDatabase();*/