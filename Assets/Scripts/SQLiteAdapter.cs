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
        Debug.Log(connectionString);
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

    /*public IDataReader insert(string table = "", string columes = "*")
    {
        string sql = "SELECT " + columes + " FROM " + table;
        return query(sql);
    }







    void insertnewPlayer()
    {


    string sql = "INSERT INTO () VALUES" + "(+ player_id + ",'" + username + "') ;" ;  
    
    IDataReader reader = query(sql);

    }*/
      
    

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