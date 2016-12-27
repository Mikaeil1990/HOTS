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
    public partial class Login : Form , ILoginCallback
    {
        private ServiceReference.ILogin proxy;
        private InstanceContext context;
        Form mainPageForm;
        //info pass to next form
        string username;
        string password;
        string email;

        public Login()
        {
            InitializeComponent();
            context = new InstanceContext(this);
            proxy = new LoginClient(new InstanceContext(this));
            


        }
        

        public void OnPlayerLogin()
        {
            this.Visible = false;
            mainPageForm = new FormMain(username, email, password);
            mainPageForm.Show();
            //foreach (IGameCallback c in proxy.GetOnlinePlayers())
            //{
            //    notifyOthers(c);
            //}
        }

        

     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.BackColor!=Color.Magenta)
            {
                btnLogin.BackColor = Color.Magenta;
                btnRegister.BackColor = Color.Transparent;
                buttonSubmit.Text = "Login";
                lbEmail.Visible = false;
                textBoxEmail.Visible = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (btnRegister.BackColor != Color.Magenta)
            {
                btnLogin.BackColor = Color.Transparent;
                btnRegister.BackColor = Color.Magenta;
                buttonSubmit.Text = "Register";
                lbEmail.Visible = true;
                textBoxEmail.Visible = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            username= textBox1.Text;
            password = textBox2.Text;
            email = textBoxEmail.Text;
            if (buttonSubmit.Text=="Login")
            {
                if (proxy.Login(username, password))
                {
                    OnPlayerLogin();
                    //Go to next form
                }
                else MessageBox.Show("User name or password not correct");

            }

            if (buttonSubmit.Text == "Register")
            {
                if (proxy.Register(username,password,email))
                {
                    MessageBox.Show("Register successfully! You can login now.");
                }
                else
                {
                    MessageBox.Show("Register unsuccessfully. Please try again.");
                }
            }
            
          
          



        }

        public void sendInf()
        {
            throw new NotImplementedException();
        }
    }
}
