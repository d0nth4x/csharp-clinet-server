namespace SupaAppClient
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.PatientsTab = new MetroFramework.Controls.MetroTabPage();
            this.TBNewPatientName = new MetroFramework.Controls.MetroTextBox();
            this.TBNewPatientSurname = new MetroFramework.Controls.MetroTextBox();
            this.TPatientAdd = new MetroFramework.Controls.MetroTile();
            this.TPatientRemove = new MetroFramework.Controls.MetroTile();
            this.PatientsGrid = new MetroFramework.Controls.MetroGrid();
            this.CreatePatientTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ToggleEditMode = new MetroFramework.Controls.MetroToggle();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.switchBtn1 = new SupaAppClient.SwitchBtn();
            this.switchBtn2 = new SupaAppClient.SwitchBtn();
            this.MainTabs.SuspendLayout();
            this.PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            this.CreatePatientTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.PatientsTab);
            this.MainTabs.Controls.Add(this.CreatePatientTab);
            this.MainTabs.Location = new System.Drawing.Point(208, 63);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 1;
            this.MainTabs.Size = new System.Drawing.Size(733, 533);
            this.MainTabs.TabIndex = 0;
            this.MainTabs.UseSelectable = true;
            // 
            // PatientsTab
            // 
            this.PatientsTab.Controls.Add(this.TPatientRemove);
            this.PatientsTab.Controls.Add(this.PatientsGrid);
            this.PatientsTab.HorizontalScrollbarBarColor = true;
            this.PatientsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.PatientsTab.HorizontalScrollbarSize = 10;
            this.PatientsTab.Location = new System.Drawing.Point(4, 38);
            this.PatientsTab.Name = "PatientsTab";
            this.PatientsTab.Size = new System.Drawing.Size(725, 491);
            this.PatientsTab.TabIndex = 0;
            this.PatientsTab.Text = "Pacjenci";
            this.PatientsTab.VerticalScrollbarBarColor = true;
            this.PatientsTab.VerticalScrollbarHighlightOnWheel = false;
            this.PatientsTab.VerticalScrollbarSize = 10;
            // 
            // TBNewPatientName
            // 
            // 
            // 
            // 
            this.TBNewPatientName.CustomButton.Image = null;
            this.TBNewPatientName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TBNewPatientName.CustomButton.Name = "";
            this.TBNewPatientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNewPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNewPatientName.CustomButton.TabIndex = 1;
            this.TBNewPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNewPatientName.CustomButton.UseSelectable = true;
            this.TBNewPatientName.CustomButton.Visible = false;
            this.TBNewPatientName.Lines = new string[0];
            this.TBNewPatientName.Location = new System.Drawing.Point(268, 88);
            this.TBNewPatientName.MaxLength = 32767;
            this.TBNewPatientName.Name = "TBNewPatientName";
            this.TBNewPatientName.PasswordChar = '\0';
            this.TBNewPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNewPatientName.SelectedText = "";
            this.TBNewPatientName.SelectionLength = 0;
            this.TBNewPatientName.SelectionStart = 0;
            this.TBNewPatientName.ShortcutsEnabled = true;
            this.TBNewPatientName.Size = new System.Drawing.Size(200, 23);
            this.TBNewPatientName.TabIndex = 6;
            this.TBNewPatientName.UseSelectable = true;
            this.TBNewPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNewPatientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TBNewPatientSurname
            // 
            // 
            // 
            // 
            this.TBNewPatientSurname.CustomButton.Image = null;
            this.TBNewPatientSurname.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TBNewPatientSurname.CustomButton.Name = "";
            this.TBNewPatientSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNewPatientSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNewPatientSurname.CustomButton.TabIndex = 1;
            this.TBNewPatientSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNewPatientSurname.CustomButton.UseSelectable = true;
            this.TBNewPatientSurname.CustomButton.Visible = false;
            this.TBNewPatientSurname.Lines = new string[0];
            this.TBNewPatientSurname.Location = new System.Drawing.Point(268, 117);
            this.TBNewPatientSurname.MaxLength = 32767;
            this.TBNewPatientSurname.Name = "TBNewPatientSurname";
            this.TBNewPatientSurname.PasswordChar = '\0';
            this.TBNewPatientSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNewPatientSurname.SelectedText = "";
            this.TBNewPatientSurname.SelectionLength = 0;
            this.TBNewPatientSurname.SelectionStart = 0;
            this.TBNewPatientSurname.ShortcutsEnabled = true;
            this.TBNewPatientSurname.Size = new System.Drawing.Size(200, 23);
            this.TBNewPatientSurname.TabIndex = 7;
            this.TBNewPatientSurname.UseSelectable = true;
            this.TBNewPatientSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNewPatientSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TPatientAdd
            // 
            this.TPatientAdd.ActiveControl = null;
            this.TPatientAdd.Enabled = false;
            this.TPatientAdd.Location = new System.Drawing.Point(268, 278);
            this.TPatientAdd.Name = "TPatientAdd";
            this.TPatientAdd.Size = new System.Drawing.Size(111, 71);
            this.TPatientAdd.TabIndex = 4;
            this.TPatientAdd.Text = "Dodaj";
            this.TPatientAdd.UseSelectable = true;
            this.TPatientAdd.Click += new System.EventHandler(this.TPatientAdd_Click);
            // 
            // TPatientRemove
            // 
            this.TPatientRemove.ActiveControl = null;
            this.TPatientRemove.Enabled = false;
            this.TPatientRemove.Location = new System.Drawing.Point(3, 279);
            this.TPatientRemove.Name = "TPatientRemove";
            this.TPatientRemove.Size = new System.Drawing.Size(111, 71);
            this.TPatientRemove.TabIndex = 5;
            this.TPatientRemove.Text = "Usuń";
            this.TPatientRemove.UseSelectable = true;
            this.TPatientRemove.Click += new System.EventHandler(this.TPatientRemove_Click);
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.AllowUserToAddRows = false;
            this.PatientsGrid.AllowUserToDeleteRows = false;
            this.PatientsGrid.AllowUserToOrderColumns = true;
            this.PatientsGrid.AllowUserToResizeRows = false;
            this.PatientsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PatientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PatientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsGrid.EnableHeadersVisualStyles = false;
            this.PatientsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PatientsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PatientsGrid.Location = new System.Drawing.Point(3, 3);
            this.PatientsGrid.MultiSelect = false;
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.ReadOnly = true;
            this.PatientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PatientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PatientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsGrid.Size = new System.Drawing.Size(412, 270);
            this.PatientsGrid.TabIndex = 3;
            // 
            // CreatePatientTab
            // 
            this.CreatePatientTab.Controls.Add(this.metroDateTime1);
            this.CreatePatientTab.Controls.Add(this.TPatientAdd);
            this.CreatePatientTab.Controls.Add(this.TBNewPatientSurname);
            this.CreatePatientTab.Controls.Add(this.TBNewPatientName);
            this.CreatePatientTab.HorizontalScrollbarBarColor = true;
            this.CreatePatientTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CreatePatientTab.HorizontalScrollbarSize = 10;
            this.CreatePatientTab.Location = new System.Drawing.Point(4, 38);
            this.CreatePatientTab.Name = "CreatePatientTab";
            this.CreatePatientTab.Size = new System.Drawing.Size(725, 491);
            this.CreatePatientTab.TabIndex = 1;
            this.CreatePatientTab.Text = "Nowy pacjent";
            this.CreatePatientTab.VerticalScrollbarBarColor = true;
            this.CreatePatientTab.VerticalScrollbarHighlightOnWheel = false;
            this.CreatePatientTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(775, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tryb edycji";
            // 
            // ToggleEditMode
            // 
            this.ToggleEditMode.AutoSize = true;
            this.ToggleEditMode.Location = new System.Drawing.Point(852, 41);
            this.ToggleEditMode.Name = "ToggleEditMode";
            this.ToggleEditMode.Size = new System.Drawing.Size(80, 17);
            this.ToggleEditMode.TabIndex = 4;
            this.ToggleEditMode.Text = "Off";
            this.ToggleEditMode.UseSelectable = true;
            this.ToggleEditMode.CheckedChanged += new System.EventHandler(this.ToggleEditMode_CheckedChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(268, 147);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 8;
            // 
            // switchBtn1
            // 
            this.switchBtn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.switchBtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.switchBtn1.Location = new System.Drawing.Point(94, 271);
            this.switchBtn1.Name = "switchBtn1";
            this.switchBtn1.On = false;
            this.switchBtn1.Size = new System.Drawing.Size(135, 37);
            this.switchBtn1.TabIndex = 5;
            // 
            // switchBtn2
            // 
            this.switchBtn2.BackColor = System.Drawing.Color.Blue;
            this.switchBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.switchBtn2.Location = new System.Drawing.Point(94, 331);
            this.switchBtn2.Name = "switchBtn2";
            this.switchBtn2.On = true;
            this.switchBtn2.Size = new System.Drawing.Size(82, 16);
            this.switchBtn2.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 619);
            this.Controls.Add(this.switchBtn2);
            this.Controls.Add(this.switchBtn1);
            this.Controls.Add(this.ToggleEditMode);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Supa App";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabs.ResumeLayout(false);
            this.PatientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            this.CreatePatientTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTabs;
        private MetroFramework.Controls.MetroTabPage PatientsTab;
        private MetroFramework.Controls.MetroTabPage CreatePatientTab;
        private MetroFramework.Controls.MetroGrid PatientsGrid;
        private MetroFramework.Controls.MetroTile TPatientRemove;
        private MetroFramework.Controls.MetroTile TPatientAdd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle ToggleEditMode;
        private MetroFramework.Controls.MetroTextBox TBNewPatientSurname;
        private MetroFramework.Controls.MetroTextBox TBNewPatientName;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private SwitchBtn switchBtn1;
        private SwitchBtn switchBtn2;
    }
}

