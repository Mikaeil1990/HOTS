using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.ServiceModel;

namespace Service
{
    public class Match
    {
        public readonly Room Room;
        public bool player1turn;
        public Match(Room room)
        {
            Room = room;
            player1turn = true;
        }
        public void AddDatabaseWinner(string Winner)
        {
            MySqlConnection connection =
                   new MySqlConnection("server= athena01.fhict.local;database=dbi327148;uid=dbi327148;password=TnDaP0zd9b");
            int answer = -7;
            
                    connection.Open();
                    string query = " SELECT * FROM acount Where" + " name='" + Winner + "'";
                    MySqlCommand myCommand2 = new MySqlCommand(query, connection);
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand2);
                    DataSet ds = new DataSet();
                    myAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        answer = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
                    }

                    string qquery = "UPDATE acount SET Wins='" + (answer + 1) + "' WHERE" + " name='" + Winner + "'";
                    MySqlCommand MyCommand3 = new MySqlCommand(qquery, connection);
                    MyCommand3.ExecuteScalar();
                    connection.Close();
                
            
        }
        public void SendMessage(string message)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            if (Room.player1.GRCallback == callback)
            { message = Room.player1.Name + ": " + message;}
            if (Room.player2.GRCallback == callback)
            { message = Room.player2.Name + ": " + message;}
            Room.player1.GRCallback.onMessageRecieve(message);
            Room.player2.GRCallback.onMessageRecieve(message);
        }

        public void MakeMove(int i)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            var selfplayer = (Room.player1.GRCallback == callback) ? Room.player1 : Room.player2;
            var oppplayer = (Room.player1.GRCallback == callback) ? Room.player2 : Room.player1;


            if ((Room.player2.GRCallback == callback && player1turn)||(Room.player1.GRCallback == callback && !player1turn))
            {
                return;
            }


                switch (i)
            {
                case 1:
                    selfplayer.HeroFigure.Attack(oppplayer.HeroFigure);
                    break;
                case 2:
                    selfplayer.HeroFigure.ulty(oppplayer.HeroFigure);
                    break;
                case 3:
                    selfplayer.HeroFigure.Refill();
                    break;
            }

            player1turn = !player1turn;

            if (Room.player1.HeroFigure.Health <= 0)
            {
                Room.player1.GRCallback.onGameEnded(Room.player2.Name);
                Room.player2.GRCallback.onGameEnded(Room.player2.Name);
                AddDatabaseWinner(Room.player2.Name);
                Room.player1.callBack.GameEnded();
                Room.player2.callBack.GameEnded();

            }

            if (Room.player2.HeroFigure.Health <= 0)
            {
                Room.player1.GRCallback.onGameEnded(Room.player1.Name);
                Room.player2.GRCallback.onGameEnded(Room.player1.Name);
                AddDatabaseWinner(Room.player1.Name);
                Room.player1.callBack.GameEnded();
                Room.player2.callBack.GameEnded();
                
            }

            Room.player1.GRCallback.onTurnChanges(Room.player1.HeroFigure.Health, Room.player1.HeroFigure.Mana, Room.player2.HeroFigure.Health, Room.player2.HeroFigure.Mana);
            Room.player2.GRCallback.onTurnChanges(Room.player1.HeroFigure.Health, Room.player1.HeroFigure.Mana, Room.player2.HeroFigure.Health, Room.player2.HeroFigure.Mana);


        }
    }
}
    