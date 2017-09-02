namespace DiskSchedulingAlgorithms
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
            this.btStartNext = new System.Windows.Forms.Button();
            this.lbReadReqs = new System.Windows.Forms.Label();
            this.rtbReadReqs = new System.Windows.Forms.RichTextBox();
            this.lbSelectAlg = new System.Windows.Forms.Label();
            this.cbSelectAlg = new System.Windows.Forms.ComboBox();
            this.btReset = new System.Windows.Forms.Button();
            this.lbAddReq = new System.Windows.Forms.Label();
            this.tbAddReq = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbExampleSelect = new System.Windows.Forms.ComboBox();
            this.btExampleSelect = new System.Windows.Forms.Button();
            this.lbExamples = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStartNext
            // 
            this.btStartNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartNext.Location = new System.Drawing.Point(692, 375);
            this.btStartNext.Name = "btStartNext";
            this.btStartNext.Size = new System.Drawing.Size(75, 23);
            this.btStartNext.TabIndex = 0;
            this.btStartNext.Text = "Start";
            this.btStartNext.UseVisualStyleBackColor = true;
            this.btStartNext.Click += new System.EventHandler(this.BtStartNextClick);
            // 
            // lbReadReqs
            // 
            this.lbReadReqs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReadReqs.AutoSize = true;
            this.lbReadReqs.Location = new System.Drawing.Point(744, 101);
            this.lbReadReqs.Name = "lbReadReqs";
            this.lbReadReqs.Size = new System.Drawing.Size(79, 13);
            this.lbReadReqs.TabIndex = 5;
            this.lbReadReqs.Text = "Read requests:";
            // 
            // rtbReadReqs
            // 
            this.rtbReadReqs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbReadReqs.Enabled = false;
            this.rtbReadReqs.Location = new System.Drawing.Point(737, 117);
            this.rtbReadReqs.Name = "rtbReadReqs";
            this.rtbReadReqs.Size = new System.Drawing.Size(192, 89);
            this.rtbReadReqs.TabIndex = 6;
            this.rtbReadReqs.Text = "";
            // 
            // lbSelectAlg
            // 
            this.lbSelectAlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectAlg.AutoSize = true;
            this.lbSelectAlg.Location = new System.Drawing.Point(738, 16);
            this.lbSelectAlg.Name = "lbSelectAlg";
            this.lbSelectAlg.Size = new System.Drawing.Size(85, 13);
            this.lbSelectAlg.TabIndex = 8;
            this.lbSelectAlg.Text = "Select algorithm:";
            // 
            // cbSelectAlg
            // 
            this.cbSelectAlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectAlg.FormattingEnabled = true;
            this.cbSelectAlg.Location = new System.Drawing.Point(829, 13);
            this.cbSelectAlg.Name = "cbSelectAlg";
            this.cbSelectAlg.Size = new System.Drawing.Size(100, 21);
            this.cbSelectAlg.TabIndex = 9;
            // 
            // btReset
            // 
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btReset.Location = new System.Drawing.Point(854, 375);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 11;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.BtResetClick);
            // 
            // lbAddReq
            // 
            this.lbAddReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddReq.AutoSize = true;
            this.lbAddReq.Location = new System.Drawing.Point(732, 45);
            this.lbAddReq.Name = "lbAddReq";
            this.lbAddReq.Size = new System.Drawing.Size(91, 13);
            this.lbAddReq.TabIndex = 12;
            this.lbAddReq.Text = "Add read request:";
            // 
            // tbAddReq
            // 
            this.tbAddReq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddReq.Location = new System.Drawing.Point(829, 42);
            this.tbAddReq.Name = "tbAddReq";
            this.tbAddReq.Size = new System.Drawing.Size(100, 20);
            this.tbAddReq.TabIndex = 13;
            this.tbAddReq.Text = "0";
            this.tbAddReq.TextChanged += new System.EventHandler(this.TbAddReqTextChanged);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(854, 68);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAddClick);
            // 
            // cbExampleSelect
            // 
            this.cbExampleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExampleSelect.FormattingEnabled = true;
            this.cbExampleSelect.Items.AddRange(new object[] {
            "Random",
            "Starvation"});
            this.cbExampleSelect.Location = new System.Drawing.Point(692, 329);
            this.cbExampleSelect.Name = "cbExampleSelect";
            this.cbExampleSelect.Size = new System.Drawing.Size(156, 21);
            this.cbExampleSelect.TabIndex = 15;
            // 
            // btExampleSelect
            // 
            this.btExampleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExampleSelect.Location = new System.Drawing.Point(854, 327);
            this.btExampleSelect.Name = "btExampleSelect";
            this.btExampleSelect.Size = new System.Drawing.Size(75, 23);
            this.btExampleSelect.TabIndex = 16;
            this.btExampleSelect.Text = "Select";
            this.btExampleSelect.UseVisualStyleBackColor = true;
            this.btExampleSelect.Click += new System.EventHandler(this.BtExampleSelectClick);
            // 
            // lbExamples
            // 
            this.lbExamples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExamples.AutoSize = true;
            this.lbExamples.Location = new System.Drawing.Point(689, 313);
            this.lbExamples.Name = "lbExamples";
            this.lbExamples.Size = new System.Drawing.Size(55, 13);
            this.lbExamples.TabIndex = 17;
            this.lbExamples.Text = "Examples:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 410);
            this.Controls.Add(this.lbExamples);
            this.Controls.Add(this.btExampleSelect);
            this.Controls.Add(this.cbExampleSelect);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbAddReq);
            this.Controls.Add(this.lbAddReq);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.cbSelectAlg);
            this.Controls.Add(this.lbSelectAlg);
            this.Controls.Add(this.rtbReadReqs);
            this.Controls.Add(this.lbReadReqs);
            this.Controls.Add(this.btStartNext);
            this.Name = "MainForm";
            this.Text = "Disk Scheduling algorithm";
            this.SizeChanged += new System.EventHandler(this.Form1SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStartNext;
        private System.Windows.Forms.Label lbReadReqs;
        private System.Windows.Forms.RichTextBox rtbReadReqs;
        private System.Windows.Forms.Label lbSelectAlg;
        private System.Windows.Forms.ComboBox cbSelectAlg;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbAddReq;
        private System.Windows.Forms.TextBox tbAddReq;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbExampleSelect;
        private System.Windows.Forms.Button btExampleSelect;
        private System.Windows.Forms.Label lbExamples;
    }
}

