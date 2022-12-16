using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Data;
using Mono.Data.Sqlite;
using System;
using UnityEngine.UI;

public class AllController : MonoBehaviour
{
    public string DBFileName = "";
    public string DBFolder = "DB";

    List<Card> cards = new List<Card>();
    List<Item> items = new List<Item>();
    List<Deck> player_deck = new List<Deck>(); 
    List<Card> player_card = new List<Card>();

    public Text nameText;
    public Text rareText;
    public Text levelText;
    //public Text cardText;
    //public Text ncardText;


    public Player player = new Player(1, "Yuu", 0, 0, 0);
    public Dictionary<int,Inventory> myinventory = new Dictionary<int, Inventory>();

    //public Inventory myinventory = new Inventory(1, 2, 0);

    public Dictionary<int, Mailbox> mymail = new Dictionary<int, Mailbox>();
    //public Mailbox mailbox = new Mailbox(1, 1, "Welcome new player", "Lootbox", 5);

    public void OpenLootbox() //..............for put to lootbox button
    {
        //myinventory.Add(1, (new Inventory(1, 1, 10)));

        //Debug.Log("check myinventory "+ myinventory[1].getAmount());
        Debug.Log("check myinventory " + myinventory[1].getAmount());
        
        /*if(myinventory[1].getAmount() > 0) // number 1 means loot item_id
        {
            myinventory[1].setAmount(myinventory[1].getAmount()-1);
            int cid = UnityEngine.Random.Range(0, 8);

           
            Card theCard = cards[cid];

            nameText.text = theCard.getCardName();
            rareText.text = theCard.getRarity();
            levelText.text = theCard.getLevel().ToString();
            
            // random card take that random Code here
            player_card.Add(theCard);
        }
        else
        {
            print("error"); // use list player_card  and use foreach for read data in list then insert or update to deck
        }*/

        int cid = UnityEngine.Random.Range(0, 8);


        Card theCard = cards[cid];

        nameText.text = theCard.getCardName();
        rareText.text = theCard.getRarity();
        levelText.text = theCard.getLevel().ToString();
        //cardText.text = player_deck.getCardID();

        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);//...for insert card that random to deck menu
        adapter.insertDeck(player.Id,theCard.getCardID(), theCard.getLevel(), theCard.getHp(), theCard.getAtk(), theCard.getDef());
        adapter.disconnectDatabase();

        //Debug.Log(theCard.getCardName());
        //Debug.Log(theCard.getLevel());
        

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
                    if (reader.GetName(i) == "card_id")
                    {
                        card_id = Convert.ToInt32(reader.GetValue(i));
                    }
                    if (reader.GetName(i) == "name")
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
                //Debug.Log(cards);
            }


            adapter.disconnectDatabase();
    }

    public void onLoadDeckfromDatabase()
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("deck", "*");


        int player_id = 0;
        int card_id = 0;
        int level = 0;
        int hp = 0;
        int atk = 0;
        int def = 0;



        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "player_id")
                {
                    player_id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "card_id")
                {
                    card_id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "level")
                {
                    level = Convert.ToInt32(reader.GetValue(i));
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
            player_deck.Add(new Deck(player_id, card_id, level, hp, atk, def));
            //Debug.Log(player_deck);
        }


        adapter.disconnectDatabase();
    }

    //List<Item> items = new List<Item>();
    public void addMailItem()//...............for mail get item button........
    {
        //Mailbox mails = new Mailbox (1,)
        Item theItem = new Item(1, "Lootbox"); 

        print("add item from mail");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        //adapter.insertItem(11, "Ramdom Card");
        player.Silver_coin = player.Silver_coin + 500;
        player.Diamond = player.Diamond + 6000;
        //player.setGold(player.getGold() + 5);

        adapter.updatePlayerSilver(player.Silver_coin);
        adapter.updatePlayerDiamond(player.Diamond);
        if ( !myinventory.ContainsKey(theItem.getItemID())) {


            adapter.insertInvenItem(player.Id, theItem.getItemID(), 5);//.....???? feel something wrong
        }
        else
        {
            // update
            Inventory i = myinventory[theItem.getItemID()];
            i.setAmount(i.getAmount() + 5);
            // adapter.update.....
        }
        


        adapter.disconnectDatabase();

    }
    public void onLoadItemfromDatabase() ///item
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("item", "*");

        int item_id = 0;
        string name = "";

        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "item_id")
                {
                    item_id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "name")
                {
                    name = "" + reader.GetValue(i);
                }
            }
            items.Add(new Item(item_id, name));
            //Debug.Log(items);
        }

    }
    public void onLoadPlayerfromDatabase() 
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("player", "*");

        int id = 0;
        string username = "";
        int silver_coin = 0;
        int gold_coin = 0;
        int diamond = 0;



        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "player_id")
                {
                    id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "username")
                {
                    username = "" + reader.GetValue(i);
                }
                if (reader.GetName(i) == "silver")
                {
                    silver_coin = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "gold")
                {
                    gold_coin = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "diamond")
                {
                    diamond = Convert.ToInt32(reader.GetValue(i));
                }

            }
            player.Id = id;
            player.Username = username;
            player.Silver_coin = silver_coin;
            player.Gold_coin = gold_coin;
            player.Diamond = diamond;
            print(player.Silver_coin);
            // add gold
            // add diamon
        }



        adapter.disconnectDatabase();
    }

    public void addItemlootbox()// for add lootbot to inven and update player currency from shop
    {
        print("buy lootbox");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        player.Diamond = player.Diamond - 300;
        adapter.insertItemfromShop(player.Id, 1, 1); //???
        adapter.updatePlayerDiamond(player.Diamond);

        adapter.disconnectDatabase();
    }
    public void addItemflashdrive()// for add flashdrive to inven and update player currency from shop
    {
        print("buy flashdrive");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        player.Gold_coin = player.Gold_coin - 100;
        adapter.insertItemfromShop(player.Id, 2, 100);
        adapter.updatePlayerGold(player.Gold_coin);

        adapter.disconnectDatabase();

    }
    public void addPacksilver()//for update pack silver and update buy cost
    {
        print("buy silver");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        player.Diamond = player.Diamond - 200;
        player.Silver_coin = player.Silver_coin + 200;
        adapter.updatePlayerSilver(player.Silver_coin);
        adapter.updatePlayerDiamond(player.Diamond);

        adapter.disconnectDatabase();
    }
    public void addPackgold()////for update pack silver and update buy cost
    {
        print("buy gold");
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        player.Diamond = player.Diamond - 200;
        player.Gold_coin = player.Gold_coin + 50;
        adapter.updatePlayerGold(player.Gold_coin);
        adapter.updatePlayerDiamond(player.Diamond);

        adapter.disconnectDatabase();
    }
    

    List<Shop> shops = new List<Shop>();
    public void onLoadShopfromDatabase() // for insert item to inven after buy 
    {
        SQLiteAdapter adapter = new SQLiteAdapter(DBFileName, DBFolder);
        IDataReader reader = adapter.select("shop", "*");

        int item_id = 0;
        string item_name = "";
        int silver_coin = 0;
        int gold_coin = 0;
        int diamond = 0;



        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == "item_id")
                {
                    item_id = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "item_name")
                {
                    item_name = "" + reader.GetValue(i);
                }
                if (reader.GetName(i) == "silver")
                {
                    silver_coin = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "gold")
                {
                    gold_coin = Convert.ToInt32(reader.GetValue(i));
                }
                if (reader.GetName(i) == "diamond")
                {
                    diamond = Convert.ToInt32(reader.GetValue(i));
                }
                shops.Add(new Shop(item_id, item_name, silver_coin, gold_coin, diamond));

            }
            
        }

        adapter.disconnectDatabase();
    }

    void Start()
    {
        onLoadfromDatabase();
        onLoadPlayerfromDatabase();
        onLoadShopfromDatabase();
        onLoadItemfromDatabase();
        myinventory.Add(1, (new Inventory(1, 1, 10)));
    }

    void Update()
    {
            // update your UI here;
            // cardAmoutn.text = myinventory[1].amount;
    }


    
}
