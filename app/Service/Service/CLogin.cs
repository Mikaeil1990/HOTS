using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Service.Classes;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class HOTS : ILogin , IMainPage, IGameRoom
    {
        
        //private IMainPageCallBack thisPlayer;
        private List<IMainPageCallBack> onlinePlayers= new List<IMainPageCallBack>();
        private List<string> onlinePlayerNames = new List<string>();
        private List<Room> gameRooms = new List<Room>();
        private List<Match>matchList = new List<Match>();
        private List<string> RoomsName = new List<string>();
        private List<string> PlayerInfo=new List<string>();
        private Dictionary<ICBGameRoom, Match> CallbackToMatch = new Dictionary<ICBGameRoom, Match>();
        string userName;
        IFactory fac=new Factory();
        

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<IMainPageCallBack> GetOnlinePlayers()
        {
            return onlinePlayers;
        }
        
        public bool Login(string userName, string password)
        {
            MySqlConnection connection =
                new MySqlConnection("server= athena01.fhict.local;database=dbi327148;uid=dbi327148;password=TnDaP0zd9b");

                //open the connection 
                connection.Open();
            string strQuery1 = "Select * from acount where name='" + userName + "' and Password='" +
                               password + "'";
            MySqlCommand  myCommand = new MySqlCommand(strQuery1, connection);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            connection.Close();
            
            //filling user information list to pass it to user form afterLogin()
            if (ds.Tables[0].Rows.Count != 1)
                return false;
            DataRow dr = ds.Tables[0].Rows[0];
            
            if (ds.Tables[0].Rows.Count>0)
            {
                PlayerInfo.Clear();
                PlayerInfo.Add(dr["name"].ToString());
                PlayerInfo.Add(dr["Password"].ToString());
                PlayerInfo.Add(dr["EmailAddress"].ToString());
                PlayerInfo.Add(dr["Games"].ToString());
                PlayerInfo.Add(dr["WIns"].ToString());
                this.userName = dr["name"].ToString();
                //IMainPageCallBack thisPlayer = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
                //onlinePlayers.Add(thisPlayer);
                //onlinePlayerNames.Add(userName);
                //if user is in the database we need to login him

                return true;
            }
            return false;

        }


        public bool Register(string userName, string password, string email)
        {
            
            MySqlConnection cn= new MySqlConnection();
            MySqlConnection connection =
                 new MySqlConnection("server= athena01.fhict.local;database=dbi327148;uid=dbi327148;password=TnDaP0zd9b");

            //open the connection 
            connection.Open();

            //check existence
            string strQuery2 = "Select * from acount where name='" + userName + "'";
            MySqlCommand myCommand2 = new MySqlCommand(strQuery2, connection);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand2);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return false;
            }


            //insert(save new account)
            string strQuery1 = "Insert into acount(name, Password, EmailAddress) VALUES ('" + userName + "','" + password + "', '"+ email+"')";
            MySqlCommand myCommand = new MySqlCommand(strQuery1, connection);
            int Status = myCommand.ExecuteNonQuery();
            connection.Close();
            //check if inserted successfully
            if (Status>0)
            {
                //register successfully
                return true;
            }
            return false;

        }

        //IMainPage : here start my our second interface implementation
        public List<string> AfterLogin()
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            //thisPlayer = client;
            onlinePlayers.Add(client);
            onlinePlayerNames.Add(userName);
            
            foreach (var c in onlinePlayers)
            {
                if (c != client)
                {
                    c.OnPlayerChange(this.onlinePlayerNames);
                }
            }
            return this.PlayerInfo;
            
        }

        public void QuitGame()
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            bool found = false;
            foreach (var c in onlinePlayers)
            {
                if (c == client)
                {
                    found = true;
                }
                
               
            }
            if (found == true)
            {
                onlinePlayers.Remove(client);
                onlinePlayerNames.Remove(userName);
            }
            foreach (var c in onlinePlayers)
            {
                c.OnPlayerChange(this.onlinePlayerNames);
                c.OnRoomChanges(this.RoomsName);
            }
            
        }

        public List<string> GetOnlinePlayerNames()
        {
            return this.onlinePlayerNames;
        }

        public List<string> GetOnlineGames()
        {
            return this.RoomsName;
        }
        private void updateLists(string reqSender, string reqReciever)
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            

        }
        //Database nrofgame update
        public void AddDatabaseNrofGame(string p1, string p2)
        {
            MySqlConnection connection =
                   new MySqlConnection("server= athena01.fhict.local;database=dbi327148;uid=dbi327148;password=TnDaP0zd9b");
            int answer = -7;
            foreach (var item in onlinePlayerNames)
            {
                if (item==p1||item==p2)
                {
                    connection.Open();
                    string query = " SELECT * FROM acount Where" + " name='" + item + "'";
                    MySqlCommand myCommand2 = new MySqlCommand(query, connection);
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand2);
                    DataSet ds = new DataSet();
                    myAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        answer = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
                    }

                    string qquery = "UPDATE acount SET Games='" + (answer + 1) + "' WHERE" + " name='" + item + "'";
                    MySqlCommand MyCommand3 = new MySqlCommand(qquery, connection);
                    MyCommand3.ExecuteScalar();
                    connection.Close();
                }
            }
        }
        public bool SendGameRequest(string reqSender, string reqReciever)
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            bool response = false; 
            foreach (var c in onlinePlayers)
            {
                if (c!=client && c.GetName()==reqReciever)
                {
                    response=c.OnRecieveRequest(reqSender);
                    if (response)
                    {
                        
                        Service.Room room = new Room(new Player(reqSender,client),new Player(reqReciever,c));

                        Match match = new Match(room);
                        this.AddDatabaseNrofGame(reqReciever,reqSender);
                        this.gameRooms.Add(room);
                        this.matchList.Add(match);
                        this.RoomsName.Add(room.RoomName);
                        this.onlinePlayerNames.Remove(reqSender);
                        this.onlinePlayerNames.Remove(reqReciever);
                        foreach (var cli in onlinePlayers)
                        {
                            if (cli != client)
                            {
                                cli.OnRoomChanges(this.RoomsName);
                                cli.OnPlayerChange(this.onlinePlayerNames);

                            }
                        }
                        //if(room.LPlayerHero!=null && room.RPlayerHero!=null)
                        //{
                        //    StartRoom(room);
                        //}
                    }
                }
            }
            //
            return response;
            
        }

        public string GetReplays()
        {
            throw new NotImplementedException();
        }

        public Room ChooseHeroes(string heroName, string playerName)
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            bool find = false;
            foreach (var R in gameRooms)
            {
                if (R.player1.Name==playerName)
                {
                    R.player1.Hero = heroName;
                    R.player1.HeroFigure = fac.createFigure(heroName);
                    //R.player1.fixHeroFigure();
                    find = true;
                    if (R.player1.Hero!=null&& R.player2.Hero != null)
                    {
                        this.StartRoom(R);
                        return R;
                    }
                }
                if (R.player2.Name==playerName)
                {
                    R.player2.Hero = heroName;
                    R.player2.HeroFigure = fac.createFigure(heroName);

                    //R.player2.fixHeroFigure();
                    find = true;
                    if (R.player1.Hero != null && R.player2.Hero != null)
                    {
                        this.StartRoom(R);
                        return R;
                    }
                }
                
            }


            if (!find)
            {
                Service.Room room = new Room(new Player(playerName,heroName),new Player("AI","Kerrigan"));
                this.AddDatabaseNrofGame(playerName, "AI");
                this.gameRooms.Add(room);
                this.StartRoom(room);
                return room;
            }

            return null;
        }

        public bool Options()
        {
            throw new NotImplementedException();
        }
        //public Room getMyroom(string playerName)
        //{
        //    foreach (var r in gameRooms)
        //    {
        //        if (r.player1.Name==playerName||r.player2.Name==playerName)
        //        {
        //            return r;
        //        }
        //    }
        //    return null;
        //}
        public bool StartRoom(Room room)
        {
            IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            Console.WriteLine("YOOhahahaha "+room.RoomName);
            if (room.player1.callBack != null&& room.player1.callBack!=client)
            {
                room.player1.callBack.OnStartGame(room);
            }
            if (room.player2.callBack != null && room.player2.callBack != client)
            {
                room.player2.callBack.OnStartGame(room);
            }

            //IMainPageCallBack client = OperationContext.Current.GetCallbackChannel<IMainPageCallBack>();
            //if (opponent == "AI")
            //{
            //    Service.Room room = new Room(this.userName, heroName, "AI", "Karrigen");
            //    client.OnStartGame(room);
            //}
            //else
            //{
            //    Service.Room room = new Room(this.userName, heroName, opponent, );
            //    client.OnStartGame(room);
            //}
            return false;
        }

        //implementation of 3rd interface, GameRoom
        public void move(int i)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            Match aMatch = CallbackToMatch[callback];
            aMatch.MakeMove(i);
        }

        public void SendMessage(string msg)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            //return this.userName + ": " + msg;
            Match aMatch = CallbackToMatch[callback];
            aMatch.SendMessage(msg);
        }

        public void Connect(string roomName, string username)
        {
            Match theMatch = matchList.FirstOrDefault(x => x.Room.RoomName == roomName);
            if (theMatch==null)
            {
                return;
            }
            var callback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            CallbackToMatch[callback] = theMatch;
            if (username==theMatch.Room.player1.Name)
            {
                theMatch.Room.player1.GRCallback = callback;
            }
            else if (username == theMatch.Room.player2.Name)
            {
                theMatch.Room.player2.GRCallback = OperationContext.Current.GetCallbackChannel<ICBGameRoom>();
            }

        }

        public void QuitGameRoom()
        {
            throw new NotImplementedException();
        }
    }


}
