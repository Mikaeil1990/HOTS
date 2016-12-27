using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;
using System.ServiceModel;
using Service.Classes;

namespace Client
{
    public partial class FormGameRoom : Form, IGameRoomCallback
    {
        Room room;
        string userName;
        private ServiceReference.GameRoomClient proxy;
        IFigure play1;
        IFigure play2;
        List<IFigure> players;
        
        
        public FormGameRoom(Room r, string username)
        {
            InitializeComponent();
            players = new List<IFigure>();
            room = r;
            this.userName = username;

            this.Startup();
            proxy = new GameRoomClient(new InstanceContext(this));
            proxy.Connect(r.RoomName,username);
        }

        //First method after setting up everything for startup
        public void Startup()
        {
            this.Text = "Room " + room.RoomName+" ----- Good Luck "+userName;
            LbPlayer1.Text = room.player1.Name;
            LbPlayer2.Text = room.player2.Name;

            //making figure for players and fill in the picBoxes
            switch (room.player1.Hero)
            {
                case "Kerrigan":
                    {
                        this.play1 = new Karrigan(); break;
                    }
                case "Tyrael":
                    {
                        this.play1 = new Tyreal(); break;
                    }
                case "Tychus":
                    {
                        this.play1 = new Tychus(); break;
                    }
                default:
                    break;
            }
            switch (room.player2.Hero)
            {
                case "Kerrigan":
                    {
                        this.play2 = new Karrigan(); break;
                    }
                case "Tyrael":
                    {
                        this.play2 = new Tyreal(); break;
                    }
                case "Tychus":
                    {
                        this.play2 = new Tychus(); break;
                    }
                default:
                    break;
            }
            players.Add(play1);
            players.Add(play2);
            pictureBox1.Image = play1.getImage();
            pictureBox2.Image = play2.getImage();
            panel1.Visible = true;
            panel2.Visible = true;
            progressBar1.Value = players[0].Health;
            progressBar2.Value = players[1].Health;

            foreach (var item in players)
            {
                richTextBox1.Text += item.Talk() + "\n";
            }
            
        }
        public void onGameEnded(string username)
        {
            MessageBox.Show(username + " won!");
            this.Close();
        }

        public void onMessageRecieve(string message)
        {
            
                richTextBox1.AppendText(Environment.NewLine + message);
                
            
        }

        public void onTurnChanges(int selfHp, int selfMana, int oppHp, int oppMana)
        {
            
            progressBar1.Value = selfHp;
            progressBar3.Value = selfMana;
            progressBar2.Value = oppHp;
            progressBar4.Value = oppMana;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mes = textBox1.Text;
            //onMessageRecieve(mes);
            textBox1.Text = "";
            proxy.SendMessage(mes);
        }

        private void btRefill_Click(object sender, EventArgs e)
        {
            proxy.move(3);
        }

        private void btAttack_Click(object sender, EventArgs e)
        {
            proxy.move(1);
        }

        private void btUlty_Click(object sender, EventArgs e)
        {
            proxy.move(2);
        }

      
    }
}
  