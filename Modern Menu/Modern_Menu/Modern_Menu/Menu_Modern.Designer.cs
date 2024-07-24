namespace Modern_Menu
{
    partial class Menu_Modern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Modern));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.menu_transition = new System.Windows.Forms.Timer(this.components);
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.About = new Guna.UI.WinForms.GunaButton();
            this.BtnDashboard = new Guna.UI.WinForms.GunaButton();
            this.Btn_Menu = new Guna.UI.WinForms.GunaButton();
            this.Sub_menu_01 = new Guna.UI.WinForms.GunaButton();
            this.Sub_menu_02 = new Guna.UI.WinForms.GunaButton();
            this.Settings = new Guna.UI.WinForms.GunaButton();
            this.Btn_LogOut = new Guna.UI.WinForms.GunaButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Activar_Animation = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Activar_Animation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Activar_Animation);
            this.panel1.Controls.Add(this.gunaControlBox3);
            this.panel1.Controls.Add(this.gunaControlBox2);
            this.panel1.Controls.Add(this.gunaControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 71);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu_Modern";
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.CustomClick = true;
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(771, 4);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(41, 36);
            this.gunaControlBox3.TabIndex = 2;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaControlBox2.Location = new System.Drawing.Point(818, 4);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(40, 36);
            this.gunaControlBox2.TabIndex = 1;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(864, 4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(36, 36);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // menu_transition
            // 
            this.menu_transition.Tick += new System.EventHandler(this.menu_transition_Tick);
            // 
            // animation_timer
            // 
            this.animation_timer.Tick += new System.EventHandler(this.animation_timer_Tick);
            // 
            // panelcontainer
            // 
            this.panelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontainer.Location = new System.Drawing.Point(188, 43);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(715, 469);
            this.panelcontainer.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(3, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 10);
            this.panel6.TabIndex = 11;
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.Black;
            this.MenuContainer.Controls.Add(this.Btn_Menu);
            this.MenuContainer.Controls.Add(this.Sub_menu_01);
            this.MenuContainer.Controls.Add(this.Sub_menu_02);
            this.MenuContainer.Location = new System.Drawing.Point(3, 87);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(174, 47);
            this.MenuContainer.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnDashboard);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 78);
            this.panel2.TabIndex = 9;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Black;
            this.dashboard.Controls.Add(this.panel2);
            this.dashboard.Controls.Add(this.MenuContainer);
            this.dashboard.Controls.Add(this.panel4);
            this.dashboard.Controls.Add(this.Settings);
            this.dashboard.Controls.Add(this.About);
            this.dashboard.Controls.Add(this.Btn_LogOut);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboard.Location = new System.Drawing.Point(0, 43);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(188, 469);
            this.dashboard.TabIndex = 1;
            // 
            // About
            // 
            this.About.AnimationHoverSpeed = 0.07F;
            this.About.AnimationSpeed = 0.03F;
            this.About.BaseColor = System.Drawing.Color.Black;
            this.About.BorderColor = System.Drawing.Color.Transparent;
            this.About.DialogResult = System.Windows.Forms.DialogResult.None;
            this.About.FocusedColor = System.Drawing.Color.Empty;
            this.About.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::Modern_Menu.Properties.Resources.info_50px;
            this.About.ImageSize = new System.Drawing.Size(30, 30);
            this.About.Location = new System.Drawing.Point(3, 209);
            this.About.Name = "About";
            this.About.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.About.OnHoverBorderColor = System.Drawing.Color.Black;
            this.About.OnHoverForeColor = System.Drawing.Color.Black;
            this.About.OnHoverImage = null;
            this.About.OnPressedColor = System.Drawing.Color.Black;
            this.About.Size = new System.Drawing.Size(179, 47);
            this.About.TabIndex = 4;
            this.About.Text = "About";
            this.About.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDashboard.AnimationHoverSpeed = 0.07F;
            this.BtnDashboard.AnimationSpeed = 0.03F;
            this.BtnDashboard.BaseColor = System.Drawing.Color.Black;
            this.BtnDashboard.BorderColor = System.Drawing.Color.Black;
            this.BtnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Image = global::Modern_Menu.Properties.Resources.dashboard;
            this.BtnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnDashboard.Location = new System.Drawing.Point(-3, 21);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.BtnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDashboard.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnDashboard.OnHoverImage = null;
            this.BtnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDashboard.Size = new System.Drawing.Size(182, 47);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.AnimationHoverSpeed = 0.07F;
            this.Btn_Menu.AnimationSpeed = 0.03F;
            this.Btn_Menu.BaseColor = System.Drawing.Color.Black;
            this.Btn_Menu.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Menu.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Menu.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu.ForeColor = System.Drawing.Color.White;
            this.Btn_Menu.Image = global::Modern_Menu.Properties.Resources.icons8_top_menu_32;
            this.Btn_Menu.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Menu.Location = new System.Drawing.Point(3, 3);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.Btn_Menu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_Menu.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_Menu.OnHoverImage = null;
            this.Btn_Menu.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Menu.Size = new System.Drawing.Size(176, 47);
            this.Btn_Menu.TabIndex = 2;
            this.Btn_Menu.Text = "Menu";
            this.Btn_Menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Sub_menu_01
            // 
            this.Sub_menu_01.AnimationHoverSpeed = 0.07F;
            this.Sub_menu_01.AnimationSpeed = 0.03F;
            this.Sub_menu_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sub_menu_01.BaseColor = System.Drawing.Color.Black;
            this.Sub_menu_01.BorderColor = System.Drawing.Color.Black;
            this.Sub_menu_01.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sub_menu_01.FocusedColor = System.Drawing.Color.Empty;
            this.Sub_menu_01.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_menu_01.ForeColor = System.Drawing.Color.White;
            this.Sub_menu_01.Image = global::Modern_Menu.Properties.Resources.icons8_sphere_32;
            this.Sub_menu_01.ImageSize = new System.Drawing.Size(30, 30);
            this.Sub_menu_01.Location = new System.Drawing.Point(3, 56);
            this.Sub_menu_01.Name = "Sub_menu_01";
            this.Sub_menu_01.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.Sub_menu_01.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Sub_menu_01.OnHoverForeColor = System.Drawing.Color.White;
            this.Sub_menu_01.OnHoverImage = null;
            this.Sub_menu_01.OnPressedColor = System.Drawing.Color.Black;
            this.Sub_menu_01.Size = new System.Drawing.Size(171, 42);
            this.Sub_menu_01.TabIndex = 4;
            this.Sub_menu_01.Text = "Sub Menu 01";
            this.Sub_menu_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sub_menu_01.Click += new System.EventHandler(this.Sub_menu_01_Click);
            // 
            // Sub_menu_02
            // 
            this.Sub_menu_02.AnimationHoverSpeed = 0.07F;
            this.Sub_menu_02.AnimationSpeed = 0.03F;
            this.Sub_menu_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sub_menu_02.BaseColor = System.Drawing.Color.Black;
            this.Sub_menu_02.BorderColor = System.Drawing.Color.Black;
            this.Sub_menu_02.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Sub_menu_02.FocusedColor = System.Drawing.Color.Empty;
            this.Sub_menu_02.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_menu_02.ForeColor = System.Drawing.Color.White;
            this.Sub_menu_02.Image = global::Modern_Menu.Properties.Resources.icons8_sphere_32;
            this.Sub_menu_02.ImageSize = new System.Drawing.Size(30, 30);
            this.Sub_menu_02.Location = new System.Drawing.Point(3, 104);
            this.Sub_menu_02.Name = "Sub_menu_02";
            this.Sub_menu_02.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.Sub_menu_02.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Sub_menu_02.OnHoverForeColor = System.Drawing.Color.White;
            this.Sub_menu_02.OnHoverImage = null;
            this.Sub_menu_02.OnPressedColor = System.Drawing.Color.Black;
            this.Sub_menu_02.Size = new System.Drawing.Size(171, 42);
            this.Sub_menu_02.TabIndex = 3;
            this.Sub_menu_02.Text = "Sub Menu 02";
            this.Sub_menu_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sub_menu_02.Click += new System.EventHandler(this.Sub_menu_02_Click);
            // 
            // Settings
            // 
            this.Settings.AnimationHoverSpeed = 0.07F;
            this.Settings.AnimationSpeed = 0.03F;
            this.Settings.BaseColor = System.Drawing.Color.Black;
            this.Settings.BorderColor = System.Drawing.Color.Transparent;
            this.Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Settings.FocusedColor = System.Drawing.Color.Empty;
            this.Settings.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = global::Modern_Menu.Properties.Resources.settings;
            this.Settings.ImageSize = new System.Drawing.Size(30, 30);
            this.Settings.Location = new System.Drawing.Point(3, 156);
            this.Settings.Name = "Settings";
            this.Settings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.Settings.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Settings.OnHoverForeColor = System.Drawing.Color.Black;
            this.Settings.OnHoverImage = null;
            this.Settings.OnPressedColor = System.Drawing.Color.Black;
            this.Settings.Size = new System.Drawing.Size(179, 47);
            this.Settings.TabIndex = 3;
            this.Settings.Text = " Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.AnimationHoverSpeed = 0.07F;
            this.Btn_LogOut.AnimationSpeed = 0.03F;
            this.Btn_LogOut.BaseColor = System.Drawing.Color.Black;
            this.Btn_LogOut.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_LogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_LogOut.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_LogOut.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.ForeColor = System.Drawing.Color.White;
            this.Btn_LogOut.Image = global::Modern_Menu.Properties.Resources.close_pane_50px;
            this.Btn_LogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_LogOut.Location = new System.Drawing.Point(3, 262);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.Btn_LogOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Btn_LogOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.Btn_LogOut.OnHoverImage = null;
            this.Btn_LogOut.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_LogOut.Size = new System.Drawing.Size(179, 47);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "Log Out ";
            this.Btn_LogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Modern_Menu.Properties.Resources.icons8_dashboard_layout_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(185, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Activar_Animation
            // 
            this.Activar_Animation.Image = global::Modern_Menu.Properties.Resources.icons8_menu_64;
            this.Activar_Animation.Location = new System.Drawing.Point(3, 0);
            this.Activar_Animation.Name = "Activar_Animation";
            this.Activar_Animation.Size = new System.Drawing.Size(51, 40);
            this.Activar_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Activar_Animation.TabIndex = 3;
            this.Activar_Animation.TabStop = false;
            this.Activar_Animation.Click += new System.EventHandler(this.Activar_Animation_Click);
            // 
            // Menu_Modern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(903, 512);
            this.Controls.Add(this.panelcontainer);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Modern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Activar_Animation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.PictureBox Activar_Animation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer menu_transition;
        private System.Windows.Forms.Timer animation_timer;
        private System.Windows.Forms.Panel panelcontainer;
        private Guna.UI.WinForms.GunaButton About;
        private Guna.UI.WinForms.GunaButton Btn_LogOut;
        private Guna.UI.WinForms.GunaButton Settings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private Guna.UI.WinForms.GunaButton Btn_Menu;
        private Guna.UI.WinForms.GunaButton Sub_menu_01;
        private Guna.UI.WinForms.GunaButton Sub_menu_02;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton BtnDashboard;
        private System.Windows.Forms.FlowLayoutPanel dashboard;
    }
}

