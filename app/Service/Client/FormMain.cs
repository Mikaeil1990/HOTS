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

namespace Client
{
    public partial class FormMain : Form, IMainPageCallback
    {
        List<string> onlinePlayersName;
        List<string> roomsName;
        string selectedHero = null;
        string opponent = "AI";
        List<string> playerInfo;
        string username;
        string email;
        string pass;
        FormGameRoom fgr;
        private ServiceReference.MainPageClient proxy;

        public FormMain(string username, string email, string pass)
        {
            InitializeComponent();
            this.Text = "Welcome to Heroes of the storm " + username + "******* ";
            this.username = username;
            this.email = email;
            this.pass = pass;
            proxy = new MainPageClient(new InstanceContext(this));
            playerInfo = new List<string>();
            playerInfo = proxy.AfterLogin();
            this.labelUserName.Text = "Username: " + playerInfo[0];
            this.labelEmail.Text = "Email: " + playerInfo[2];
            this.labelGAMEs.Text = "Played Games: " + playerInfo[3];
            this.labelWINS.Text = "Wins: " + playerInfo[4];
            //proxy.AfterLogin();
            this.onlinePlayersName = proxy.GetOnlinePlayerNames();
            this.roomsName = proxy.GetOnlineGames();
            this.UpdateListBoxGameRoom();
            this.updateListBoxOnlinePlayers();

        }
        
        private void pbSelectTychus_Click(object sender, EventArgs e)
        {
            pbSelectedHero.Image = Client.Properties.Resources.Tychus;
            selectedHero = "Tychus";
            //btGameReq.Enabled = true;
        }

        private void pbSelectkerrigan_Click(object sender, EventArgs e)
        {
            pbSelectedHero.Image = Client.Properties.Resources.kerrigan;
            selectedHero = "Kerrigan";
            //btGameReq.Enabled = true;
        }

        private void pbSelectTyrael_Click(object sender, EventArgs e)
        {
            pbSelectedHero.Image = Client.Properties.Resources.Tyrael;
            selectedHero = "Tyrael";
            //btGameReq.Enabled = true;
        }

        public void updateListBoxOnlinePlayers()
        {
            this.listBoxOnlinePlayers.Items.Clear();
            //this.listBoxRooms.Items.Clear();
            //this.onlinePlayersName = proxy.GetOnlinePlayerNames();
            //this.roomsName = proxy.GetOnlineGames();
            
            
            foreach (var p in onlinePlayersName)
                {
                    listBoxOnlinePlayers.Items.Add(p);

               
            }
            
            

        }
        public void OnPlayerChange(List<string> players)
        {
            this.onlinePlayersName = players;
            updateListBoxOnlinePlayers();
        }

        public string GetName()
        {
            return username;
        }

        public bool OnRecieveRequest(string reqSender)
        {
            string message ="You have a Game request from "+ reqSender +". Do you accept?";
            const string caption = "ame request";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                labelVS.Text = "VS. " + reqSender;
                opponent = reqSender;
                //this.onlinePlayersName = proxy.GetOnlinePlayerNames();
                //this.updateListBoxOnlinePlayers();
                //this.roomsName = proxy.GetOnlineGames();
                //this.UpdateListBoxGameRoom();
                return true;
            }
            else return false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxy.QuitGame();
        }
        private void UpdateListBoxGameRoom()
        {
            //this.roomsName = proxy.GetOnlineGames();
            foreach (var x in this.roomsName)
            {
                listBoxRooms.Items.Add(x);
            }
        }
        private void btGameReq_Click(object sender, EventArgs e)
        {
            if (listBoxOnlinePlayers.SelectedItem == null)
            {
                MessageBox.Show("Please select a name from list.");
            }
            else
            {
                string reqReciever = listBoxOnlinePlayers.SelectedItem.ToString();
                bool response = false;
                if (listBoxOnlinePlayers.SelectedItem != null && reqReciever != username)
                {
                    response = proxy.SendGameRequest(username, reqReciever);
                    if (response)
                    {
                        
                        labelVS.Text = "VS. " + reqReciever;
                        opponent = reqReciever;
                        roomsName = proxy.GetOnlineGames();
                        onlinePlayersName = proxy.GetOnlinePlayerNames();
                        this.updateListBoxOnlinePlayers();
                        this.UpdateListBoxGameRoom();
                    }
                    else
                    {
                        
                        MessageBox.Show(reqReciever + " refused request.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a player from list.");
                }
            }
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Room respons= proxy.ChooseHeroes(this.selectedHero,this.username);
            if (respons!=null)
            {
                this.OnStartGame(respons);
            }
            //this.OnStartGame();
            //this.Hide();
            //fgr.Show();
        }

        public void OnRoomChanges(List<string> rooms)
        {
            this.roomsName = rooms;
            UpdateListBoxGameRoom();
        }

        private void pbSelectedHero_Click(object sender, EventArgs e)
        {

        }

        public string GetSelectedHero()
        {
            return this.selectedHero;
        }

        public void OnStartGame(Room r)
        {
            this.Hide();
            fgr = new FormGameRoom(r,this.username);
            this.fgr.Show();
        }

        public void GameEnded()
        {
            this.Show();
            fgr.Close();
            this.updateListBoxOnlinePlayers();
            UpdateListBoxGameRoom();
            this.labelUserName.Text = "Username: " + playerInfo[0];
            this.labelEmail.Text = "Email: " + playerInfo[2];
            this.labelGAMEs.Text = "Username: " + playerInfo[3];
            this.labelWINS.Text = "Username: " + playerInfo[4];
        }
    }
}
