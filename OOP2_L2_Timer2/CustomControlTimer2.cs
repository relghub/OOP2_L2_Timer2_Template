using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_L2_Timer2
{
    public abstract class CustomControlTimerBase : Control
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            PaintControl(pe.Graphics);
        }

        protected abstract void PaintControl(Graphics graphics);
    }
    public partial class CustomControlTimer2 : CustomControlTimerBase
    {
        private System.Windows.Forms.Timer? timer;

        public CustomControlTimer2()
        {
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        protected override void PaintControl(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.LightCyan, 0, 0, Width, Height);
            graphics.DrawString(DateTime.Now.ToLongTimeString(), Font, new SolidBrush(ForeColor), 0, 0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }

}
