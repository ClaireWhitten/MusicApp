using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {

        public User CurrentUser { get; set; }
        public Form1()
        {

            InitializeComponent();

        }

      

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text;
            string lastName = txt_LastName.Text;
            string email = txt_createEmail.Text;
            string password = txt_createPassword.Text;

            var context = new MusicAppContext();
            
            if (context.Users.FirstOrDefault(u => u.Email == txt_createEmail.Text) != null)
            {
                MessageBox.Show("This user already has an account. You can log in.");
                txt_FirstName.Clear();
                txt_LastName.Clear();
                txt_createEmail.Clear();
                txt_createPassword.Clear();
            } else
            {
                //using (MusicAppContext context = new MusicAppContext())
                //{
                    context.Users.Add(new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Password = password
                    });
                    context.SaveChanges();
                    MessageBox.Show($"You have successfully created an account for {firstName} {lastName}. Now you can log in.");
                    txt_FirstName.Clear();
                    txt_LastName.Clear();
                    txt_createEmail.Clear();
                    txt_createPassword.Clear();
                //}
            }

           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
      
            using (MusicAppContext context = new MusicAppContext())
            {
              
                User user = context.Users.FirstOrDefault(u => u.Email == txtLoginEmail.Text);
                if (user == null)
                {
                    MessageBox.Show("There is no existing account for this email. Create an account.");
                    txt_LoginPassword.Clear();
                    txtLoginEmail.Clear();
                }
                else
                {  // add password encryption here later 
                    if (user.Password == txt_LoginPassword.Text)
                    {
                        CurrentUser = user;
                        Form2 form2 = new Form2(CurrentUser);
                        form2.ShowDialog();
                    } 
                    else
                    {
                        MessageBox.Show($"You've entered the wrong password for {user.FirstName} {user.LastName}.Try again.");
                        txt_LoginPassword.Clear();
                        txtLoginEmail.Clear();
                    }
                }
            }
        }
    }
}
