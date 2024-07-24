using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Menu
{
    public partial class Menu_Modern : Form
    {
        public Menu_Modern()
        {
            InitializeComponent();
        }


        bool menuExpand = false;
        private void menu_transition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 140)
                {
                    menu_transition.Stop();
                    menuExpand = true;
                }
            }
            else {

                MenuContainer.Height -= 10;
                if(MenuContainer.Height<=40){
                    menu_transition.Stop();
                    menuExpand = false;
                }
                  
            }
        }

       
        bool animationExpand = true;
        private void animation_timer_Tick(object sender, EventArgs e)
        {
            if (animationExpand)
            {

                dashboard.Width -= 5;
                if (dashboard.Width <= 54)
                {
                    animationExpand = false;
                    animation_timer.Stop();
                }
            }

            else {
                dashboard.Width += 5;
                if (dashboard.Width >= 188) {
                    animationExpand = true;
                    animation_timer.Stop();
                
                }
            
            }
        }

        private void Activar_Animation_Click(object sender, EventArgs e)
        {
            animation_timer.Start();
        }

       
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        
        }
        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            Menu_Modern Tpl = new Menu_Modern();
            Tpl.Show();
            this.Visible = false;
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            menu_transition.Start();
        }

        private void Sub_menu_01_Click(object sender, EventArgs e)
        {
            uc_SubMenu01 sub1 = new uc_SubMenu01();
            addUserControl(sub1);
            
        }

        private void Sub_menu_02_Click(object sender, EventArgs e)
        {
            uc_SubMenu02 sub2 = new uc_SubMenu02();
            addUserControl(sub2);
        }

        private void Settings_Click_1(object sender, EventArgs e)
        {
            uc_settings Uc = new uc_settings();
            addUserControl(Uc);
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tens a certeza que desejas sair?", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {
            uc_About Ut = new uc_About();
            addUserControl(Ut);
        }

       
      
       
      

       

       

       

       

        

       
        
    }
}
