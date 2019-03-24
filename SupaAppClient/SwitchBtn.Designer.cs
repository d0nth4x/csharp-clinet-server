namespace SupaAppClient
{
    partial class SwitchBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SwitchBtn
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DoubleBuffered = true;
            this.Name = "SwitchBtn";
            this.Size = new System.Drawing.Size(135, 37);
            this.Click += new System.EventHandler(this.SwitchBtn_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SwitchBtn_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
