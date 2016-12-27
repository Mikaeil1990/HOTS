using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public List<string> info { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Hero { get; set; }
        public Classes.IFigure HeroFigure { get; set; }
        [DataMember]
        public string Email { get; set; }
        public IMainPageCallBack callBack;
        public ICBGameRoom GRCallback;
        public Player()
        {

        }
        public Player(string N, string H)
        {
            this.Name = N;
            this.Hero = H;
            
            //this.fixHeroFigure();
            //this.Email = E;

        }
        public Player(string N, IMainPageCallBack cb)
        {
            this.Name = N;
            this.callBack = cb;
           


        }
        //public void fixHeroFigure()
        //{
        //    switch (Hero)
        //    {
        //        case "Kerrigan":
        //            {
        //                this.HeroFigure = new Classes.Karrigan(); break;
        //            }
        //        case "Tyrael":
        //            {
        //                this.HeroFigure = new Classes.Tyreal(); break;
        //            }
        //        case "Tychus":
        //            {
        //                this.HeroFigure = new Classes.Tychus(); break;
        //            }
        //        default:
        //            break;
        //    }
        //}
    }

    [DataContract]
    public class Room
    {
        [DataMember]
        public string RoomName { get; set; }
        [DataMember]
        public Player player1 { get; set; }
        [DataMember]
        public Player player2 { get; set; }
        [DataMember]
        public Player Winner { get; set; }
        [DataMember]
        public List<int> movesArray { get; set; }

        public Room(Player one, Player two)
        {
            RoomName = one.Name + " VS." + two.Name;
            player1 = one;
            player2 = two;
            

        }
        
    }
    //1st Endpoint for login and register that connected to the database + callback
    [ServiceContract(Namespace = "server", CallbackContract = typeof(ILoginCallBack))]
    public interface ILogin
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        bool Register(string userName, string password, string email);
        [OperationContract]
        bool Login(string userName, string password);
    }


    public interface ILoginCallBack
    {

        [OperationContract]
        void sendInf();



    }
    //2nd Endpoint for Main form that runs everything till game starts
    [ServiceContract(Namespace = "server", CallbackContract = typeof(IMainPageCallBack))]
    public interface IMainPage
    {
        [OperationContract]
        List<string> AfterLogin();
        [OperationContract]
        void QuitGame();
        [OperationContract]
        List<string> GetOnlinePlayerNames();
        [OperationContract]
        List<string> GetOnlineGames();
        [OperationContract]
        bool SendGameRequest(string reqSender, string reqReciever);
        [OperationContract]
        Room ChooseHeroes(string heroName,string playerName);
        [OperationContract]
        bool StartRoom(Room room);
        //[OperationContract]
        //Room getMyroom(string playerName);
        //TODO
        [OperationContract]
        string GetReplays();
        
        [OperationContract]
        bool Options();

    }
    public interface IMainPageCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnPlayerChange(List<string> players);
        [OperationContract(IsOneWay = true)]
        void OnRoomChanges(List<string> rooms);
        [OperationContract]
        string GetName();
        [OperationContract]
        bool OnRecieveRequest(string reqSender);
        [OperationContract]
        string GetSelectedHero();
        [OperationContract(IsOneWay = true)]
        void OnStartGame(Room room);
        [OperationContract(IsOneWay = true)]
        void GameEnded();


    }


    //3rd Endpoint for running Games + it's callback
    [ServiceContract(Namespace = "server", CallbackContract = typeof(ICBGameRoom))]
    public interface IGameRoom
    {

        // TODO: Add your service operations here
        //choose 1,..,4 to inform next player about the move and get a bool back if game finishs return True
        [OperationContract(IsOneWay = true)]
        void move(int i);
        [OperationContract(IsOneWay = true)]
        void QuitGameRoom();
        [OperationContract(IsOneWay = true)]
        void SendMessage(string msg);
        [OperationContract(IsOneWay = true)]
        void Connect(string roomName, string username);


    }

    public interface ICBGameRoom
    {
        [OperationContract(IsOneWay = true)]
        void onTurnChanges(int sefHp, int selfMana, int oppHp, int oppMana);
        [OperationContract(IsOneWay = true)]
        void onMessageRecieve(string message);
        [OperationContract(IsOneWay = true)]
        void onGameEnded(string username);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Service.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
