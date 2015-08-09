namespace ERG
{
    partial class Form1
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
            this.resolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pulses = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ERGoutput = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.bigpolygondrawing = new System.Windows.Forms.PictureBox();
            this.blackcircles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigpolygondrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // resolution
            // 
            this.resolution.Location = new System.Drawing.Point(13, 13);
            this.resolution.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.resolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(120, 20);
            this.resolution.TabIndex = 0;
            this.resolution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolution.ValueChanged += new System.EventHandler(this.resolution_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "resolution (1/x)";
            // 
            // pulses
            // 
            this.pulses.Location = new System.Drawing.Point(13, 40);
            this.pulses.Name = "pulses";
            this.pulses.Size = new System.Drawing.Size(120, 20);
            this.pulses.TabIndex = 2;
            this.pulses.ValueChanged += new System.EventHandler(this.pulses_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pulses";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(13, 67);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(120, 45);
            this.offset.TabIndex = 4;
            this.offset.Scroll += new System.EventHandler(this.offset_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "offset : 0";
            // 
            // ERGoutput
            // 
            this.ERGoutput.AutoSize = true;
            this.ERGoutput.Location = new System.Drawing.Point(12, 115);
            this.ERGoutput.Name = "ERGoutput";
            this.ERGoutput.Size = new System.Drawing.Size(35, 13);
            this.ERGoutput.TabIndex = 6;
            this.ERGoutput.Text = "label4";
            // 
            // translate
            // 
            this.translate.AutoSize = true;
            this.translate.Checked = true;
            this.translate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.translate.Location = new System.Drawing.Point(13, 131);
            this.translate.Name = "translate";
            this.translate.Size = new System.Drawing.Size(67, 17);
            this.translate.TabIndex = 7;
            this.translate.Text = "0 1 -> . x";
            this.translate.UseVisualStyleBackColor = true;
            this.translate.CheckedChanged += new System.EventHandler(this.translate_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(316, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(342, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(368, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(394, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(420, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 20);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(472, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 20);
            this.panel7.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(446, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 20);
            this.panel6.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(498, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 20);
            this.panel8.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Location = new System.Drawing.Point(524, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 20);
            this.panel9.TabIndex = 8;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Location = new System.Drawing.Point(628, 9);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(20, 20);
            this.panel13.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Location = new System.Drawing.Point(576, 9);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(20, 20);
            this.panel11.TabIndex = 8;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Location = new System.Drawing.Point(680, 9);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(20, 20);
            this.panel15.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Location = new System.Drawing.Point(550, 9);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 20);
            this.panel10.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Location = new System.Drawing.Point(654, 9);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(20, 20);
            this.panel14.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Location = new System.Drawing.Point(602, 9);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(20, 20);
            this.panel12.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel16.Location = new System.Drawing.Point(706, 9);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(20, 20);
            this.panel16.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Location = new System.Drawing.Point(732, 9);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(20, 20);
            this.panel17.TabIndex = 8;
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel25.Location = new System.Drawing.Point(940, 9);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(20, 20);
            this.panel25.TabIndex = 8;
            // 
            // panel21
            // 
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel21.Location = new System.Drawing.Point(836, 9);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(20, 20);
            this.panel21.TabIndex = 8;
            // 
            // panel29
            // 
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel29.Location = new System.Drawing.Point(1044, 9);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(20, 20);
            this.panel29.TabIndex = 8;
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel19.Location = new System.Drawing.Point(784, 9);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(20, 20);
            this.panel19.TabIndex = 8;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel27.Location = new System.Drawing.Point(992, 9);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(20, 20);
            this.panel27.TabIndex = 8;
            // 
            // panel23
            // 
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel23.Location = new System.Drawing.Point(888, 9);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(20, 20);
            this.panel23.TabIndex = 8;
            // 
            // panel31
            // 
            this.panel31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel31.Location = new System.Drawing.Point(1096, 9);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(20, 20);
            this.panel31.TabIndex = 8;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel18.Location = new System.Drawing.Point(758, 9);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(20, 20);
            this.panel18.TabIndex = 8;
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel26.Location = new System.Drawing.Point(966, 9);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(20, 20);
            this.panel26.TabIndex = 8;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel22.Location = new System.Drawing.Point(862, 9);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(20, 20);
            this.panel22.TabIndex = 8;
            // 
            // panel30
            // 
            this.panel30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel30.Location = new System.Drawing.Point(1070, 9);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(20, 20);
            this.panel30.TabIndex = 8;
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel20.Location = new System.Drawing.Point(810, 9);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(20, 20);
            this.panel20.TabIndex = 8;
            // 
            // panel28
            // 
            this.panel28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel28.Location = new System.Drawing.Point(1018, 9);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(20, 20);
            this.panel28.TabIndex = 8;
            // 
            // panel24
            // 
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel24.Location = new System.Drawing.Point(914, 9);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(20, 20);
            this.panel24.TabIndex = 8;
            // 
            // panel0
            // 
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel0.Location = new System.Drawing.Point(290, 9);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(20, 20);
            this.panel0.TabIndex = 8;
            // 
            // bigpolygondrawing
            // 
            this.bigpolygondrawing.Location = new System.Drawing.Point(349, 35);
            this.bigpolygondrawing.Name = "bigpolygondrawing";
            this.bigpolygondrawing.Size = new System.Drawing.Size(462, 462);
            this.bigpolygondrawing.TabIndex = 10;
            this.bigpolygondrawing.TabStop = false;
            // 
            // blackcircles
            // 
            this.blackcircles.AutoSize = true;
            this.blackcircles.Checked = true;
            this.blackcircles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blackcircles.Location = new System.Drawing.Point(13, 155);
            this.blackcircles.Name = "blackcircles";
            this.blackcircles.Size = new System.Drawing.Size(74, 17);
            this.blackcircles.TabIndex = 11;
            this.blackcircles.Text = "draw rests";
            this.blackcircles.UseVisualStyleBackColor = true;
            this.blackcircles.CheckedChanged += new System.EventHandler(this.blackcircles_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 508);
            this.Controls.Add(this.blackcircles);
            this.Controls.Add(this.bigpolygondrawing);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.ERGoutput);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.pulses);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel29);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel11);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1142, 546);
            this.MinimumSize = new System.Drawing.Size(293, 192);
            this.Name = "Form1";
            this.Text = "ERG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigpolygondrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pulses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar offset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ERGoutput;
        private System.Windows.Forms.CheckBox translate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.PictureBox bigpolygondrawing;
        private System.Windows.Forms.CheckBox blackcircles;
    }
}

