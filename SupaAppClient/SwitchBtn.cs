using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupaAppClient
{
    public partial class SwitchBtn : UserControl
    //public partial class SwitchBtn : Button
    {

        bool on;

        public bool On { get => on; set { on = value; Refresh(); } }

        public SwitchBtn()
        {
            InitializeComponent();
        }

        private void SwitchBtn_Load(object sender, EventArgs e)
        {

        }

        //private void SwitchBtn_OnPaint(object sender, EventArgs e)
        //{
            
        //}

        private void SwitchBtn_Paint(object sender, PaintEventArgs e)
        {
            if (On)
            {
                this.BackColor = Color.Blue;
                e.Graphics.FillRectangle(Brushes.Green, new RectangleF(0, 0, Width*0.1f, Height));

            }
            else
            {
                BackColor = SystemColors.ButtonFace;
                e.Graphics.FillRectangle(Brushes.Green, new RectangleF(.9f * Width, 0, Width * 0.1f, Height));

            }
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            On = !On;
            Refresh();
        }
    }
}
