using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiskSchedulingAlgorithms
{
    using DiskSchedulingAlgorithms.Algorithms;

    public partial class MainForm : Form
    {
        enum Schedule
        {
            Fcfs,
            Sstf,
            Scan,
            CScan,
            Look,
            CLook
        };

        enum Preset
        {
            Random,
            Starvation
        };

        private readonly Operatingsystem os;
        private readonly List<IScheduleStrategy> schedules; 

        public MainForm()
        {
            this.InitializeComponent();
            this.os = new Operatingsystem();
            this.schedules = new List<IScheduleStrategy>();
            this.GenerateStrategys();
            foreach (IScheduleStrategy strategyString in this.schedules)
            {
                this.cbSelectAlg.Items.Add(strategyString.GetName());
            }
            this.cbSelectAlg.Text = this.cbSelectAlg.Items[0].ToString();
            this.cbExampleSelect.Text = this.cbExampleSelect.Items[0].ToString();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.DrawGid(e);
            this.DrawPoints(e);
        }

        private void GenerateStrategys()
        {
            this.schedules.Add(new FcfsSchedule());
            this.schedules.Add(new SstfSchedule());
            this.schedules.Add(new ScanSchedule());
            this.schedules.Add(new CScanSchedule());
            this.schedules.Add(new LookSchedule());
            this.schedules.Add(new CLookSchedule());
        }

        private IScheduleStrategy GetSchedule(Schedule schedule)
        {
            IScheduleStrategy tempSchedule;
            switch (schedule)
            {
                case Schedule.Fcfs:
                    tempSchedule = this.schedules[0];
                    break;
                case Schedule.Sstf:
                    tempSchedule = this.schedules[1];
                    break;
                case Schedule.Scan:
                    tempSchedule = this.schedules[2];
                    break;
                case Schedule.CScan:
                    tempSchedule = this.schedules[3];
                    break;
                case Schedule.Look:
                    tempSchedule = this.schedules[4];
                    break;
                case Schedule.CLook:
                    tempSchedule = this.schedules[5];
                    break;
                default:
                    return null;
            }
            return tempSchedule;
        }

        private void DrawPoints(PaintEventArgs e)
        {
            if (this.os.AlreadyRead.Count == 0) return;

            int previousRequest = 0;

            int startWidth = 50; 
            int widthSize = this.Width - 300 - startWidth;

            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
 
            Pen p = new Pen(Color.Black, 2);

            int row = 0;
            foreach (int prime in this.os.AlreadyRead)
            {
                float x = Convert.ToSingle((widthSize * previousRequest)*0.01);
                float x2 = Convert.ToSingle((widthSize * prime) / 100);
                if (row > 0)
                {
                    e.Graphics.DrawLine(p, startWidth + x, 80 + row * 30, startWidth + x2, 80 + (row + 1) * 30);
                }

                string drawString = (prime).ToString();
                e.Graphics.FillEllipse(drawBrush, startWidth + x2 - 5, 80 + (row + 1) * 30 - 5, 10, 10);
                e.Graphics.DrawString(drawString, drawFont, drawBrush, startWidth + x2 + 10 -5, 70 + (row + 1) * 30 - 5, drawFormat);
                previousRequest = prime;
                row++;
            }
        }

        private void DrawGid(PaintEventArgs e)
        {
            
            int startWidth = 50;
            int startHeight = 70;
            int widthSize = this.Width - 300 - startWidth;
            int size = 100;

            e.Graphics.DrawLine(Pens.Black, widthSize + startWidth, 0, widthSize + startWidth, this.Height);
            e.Graphics.DrawLine(Pens.Black, startWidth, 0, startWidth, this.Height);
            e.Graphics.DrawLine(Pens.Black, startWidth, startHeight, widthSize + startWidth, startHeight);

            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            for (int i = 0; i < size / 5 + 1; i++)
            {
                string drawString = (i * 5).ToString();

                float x = startWidth + i * (widthSize / (size / 5));
                float y = 50;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);

            }
            drawFont.Dispose();
            drawBrush.Dispose();
        }

        private void Form1SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void BtStartNextClick(object sender, EventArgs e)
        {
            if (this.os.AlreadyRead.Count == 0)
            {
                this.btStartNext.Text = @"Next";
            }


            this.os.AddScheduleStrategy(this.GetSchedule((Schedule)this.cbSelectAlg.SelectedIndex));
            this.os.ReadNext();
            if (this.os.ReadRequests.Count == 0)
            {
                this.btStartNext.Enabled = false;
            }
            this.Refresh();
        }
      
        private void BtResetClick(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void BtAddClick(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(this.tbAddReq.Text);
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
            this.Add(value);
        }

        private void Add(int value)
        {
            this.os.AddReadRequest(value);

            this.rtbReadReqs.Text += (this.rtbReadReqs.Text.Length > 0 ? ", " : "") + value;
            this.btStartNext.Enabled = true;
        }

        private void Reset()
        {
            this.os.Reset();

            this.rtbReadReqs.Text = "";
            this.btStartNext.Text = @"Start";
            this.btStartNext.Enabled = true;

            this.Refresh();
        }

        private static bool IsIntegerValue(string text)
        {
            int parsedValue;
            return Int32.TryParse(text, out parsedValue);
        }

        private static void OnlyAcceptNumbers(Control tb)
        {
            if (!IsIntegerValue(tb.Text))
            {
                tb.Text = @"0";
            }
        }

        private void TbAddReqTextChanged(object sender, EventArgs e)
        {
            OnlyAcceptNumbers(this.tbAddReq);
        }

        private void BtExampleSelectClick(object sender, EventArgs e)
        {
            this.Reset();
            List<int> random;
            switch ((Preset)this.cbExampleSelect.SelectedIndex)
            {
                case Preset.Random:
                    random = new List<int> { 23, 45, 34, 21, 56, 78, 12, 45, 67, 34, 56 };
                    break;
                case Preset.Starvation:
                    random = new List<int> { 23, 34, 80, 12, 33, 22, 12, 45, 34, 56, 45, 30, 25, 1 };
                    break;
                default:
                    random = new List<int> { 23, 4, 5, 65, 45, 65 };
                    break;
            }

            foreach (int value in random)
            {
                this.Add(value);
            }
        }
    }
}
