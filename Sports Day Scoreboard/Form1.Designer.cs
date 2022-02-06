namespace Sports_Day_Scoreboard
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
            this.Heading = new System.Windows.Forms.Label();
            this.SubHeading = new System.Windows.Forms.Label();
            this.HeadingsHolder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GRajputs = new System.Windows.Forms.GroupBox();
            this.RajputsScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LiveIndicator = new System.Windows.Forms.Label();
            this.GMughals = new System.Windows.Forms.GroupBox();
            this.MughalsScore = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GAryans = new System.Windows.Forms.GroupBox();
            this.AryansScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GSpartans = new System.Windows.Forms.GroupBox();
            this.SpartansScore = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GVikings = new System.Windows.Forms.GroupBox();
            this.VikingsScore = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ScoreWrapper = new System.Windows.Forms.GroupBox();
            this.GRajputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GMughals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GAryans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GSpartans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.GVikings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.ScoreWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Heading.Font = new System.Drawing.Font("Segoe UI", 47.75F, System.Drawing.FontStyle.Bold);
            this.Heading.ForeColor = System.Drawing.Color.Crimson;
            this.Heading.Location = new System.Drawing.Point(236, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(607, 86);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "PORKKALAM 2K19";
            // 
            // SubHeading
            // 
            this.SubHeading.AutoSize = true;
            this.SubHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold);
            this.SubHeading.ForeColor = System.Drawing.Color.Crimson;
            this.SubHeading.Location = new System.Drawing.Point(297, 79);
            this.SubHeading.Name = "SubHeading";
            this.SubHeading.Size = new System.Drawing.Size(426, 59);
            this.SubHeading.TabIndex = 1;
            this.SubHeading.Text = "Final Scoreboard";
            this.SubHeading.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // HeadingsHolder
            // 
            this.HeadingsHolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeadingsHolder.Location = new System.Drawing.Point(-3, 0);
            this.HeadingsHolder.Name = "HeadingsHolder";
            this.HeadingsHolder.Size = new System.Drawing.Size(1113, 149);
            this.HeadingsHolder.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(62, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "RAJPUTS";
            // 
            // GRajputs
            // 
            this.GRajputs.Controls.Add(this.RajputsScore);
            this.GRajputs.Controls.Add(this.pictureBox1);
            this.GRajputs.Controls.Add(this.label4);
            this.GRajputs.Location = new System.Drawing.Point(94, 57);
            this.GRajputs.Name = "GRajputs";
            this.GRajputs.Size = new System.Drawing.Size(299, 279);
            this.GRajputs.TabIndex = 11;
            this.GRajputs.TabStop = false;
            // 
            // RajputsScore
            // 
            this.RajputsScore.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RajputsScore.ForeColor = System.Drawing.Color.White;
            this.RajputsScore.Location = new System.Drawing.Point(30, 83);
            this.RajputsScore.Name = "RajputsScore";
            this.RajputsScore.Size = new System.Drawing.Size(237, 168);
            this.RajputsScore.TabIndex = 14;
            this.RajputsScore.Text = "0";
            this.RajputsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sports_Day_Scoreboard.Properties.Resources.frame_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LiveIndicator
            // 
            this.LiveIndicator.AutoSize = true;
            this.LiveIndicator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LiveIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.LiveIndicator.ForeColor = System.Drawing.Color.Red;
            this.LiveIndicator.Location = new System.Drawing.Point(708, 84);
            this.LiveIndicator.Name = "LiveIndicator";
            this.LiveIndicator.Size = new System.Drawing.Size(71, 51);
            this.LiveIndicator.TabIndex = 15;
            this.LiveIndicator.Text = "⚫";
            this.LiveIndicator.Click += new System.EventHandler(this.Label8_Click);
            // 
            // GMughals
            // 
            this.GMughals.Controls.Add(this.MughalsScore);
            this.GMughals.Controls.Add(this.pictureBox2);
            this.GMughals.Controls.Add(this.label6);
            this.GMughals.Location = new System.Drawing.Point(94, 356);
            this.GMughals.Name = "GMughals";
            this.GMughals.Size = new System.Drawing.Size(299, 279);
            this.GMughals.TabIndex = 15;
            this.GMughals.TabStop = false;
            // 
            // MughalsScore
            // 
            this.MughalsScore.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MughalsScore.ForeColor = System.Drawing.Color.White;
            this.MughalsScore.Location = new System.Drawing.Point(34, 83);
            this.MughalsScore.Name = "MughalsScore";
            this.MughalsScore.Size = new System.Drawing.Size(237, 168);
            this.MughalsScore.TabIndex = 14;
            this.MughalsScore.Text = "0";
            this.MughalsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sports_Day_Scoreboard.Properties.Resources.frame_;
            this.pictureBox2.Location = new System.Drawing.Point(9, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 207);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(54, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "MUGHALS";
            // 
            // GAryans
            // 
            this.GAryans.Controls.Add(this.AryansScore);
            this.GAryans.Controls.Add(this.pictureBox3);
            this.GAryans.Controls.Add(this.label10);
            this.GAryans.Location = new System.Drawing.Point(440, 57);
            this.GAryans.Name = "GAryans";
            this.GAryans.Size = new System.Drawing.Size(299, 279);
            this.GAryans.TabIndex = 15;
            this.GAryans.TabStop = false;
            // 
            // AryansScore
            // 
            this.AryansScore.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AryansScore.ForeColor = System.Drawing.Color.White;
            this.AryansScore.Location = new System.Drawing.Point(31, 83);
            this.AryansScore.Name = "AryansScore";
            this.AryansScore.Size = new System.Drawing.Size(237, 168);
            this.AryansScore.TabIndex = 14;
            this.AryansScore.Text = "0";
            this.AryansScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sports_Day_Scoreboard.Properties.Resources.frame_;
            this.pictureBox3.Location = new System.Drawing.Point(9, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(281, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(68, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 50);
            this.label10.TabIndex = 4;
            this.label10.Text = "ARYANS";
            // 
            // GSpartans
            // 
            this.GSpartans.Controls.Add(this.SpartansScore);
            this.GSpartans.Controls.Add(this.pictureBox4);
            this.GSpartans.Controls.Add(this.label12);
            this.GSpartans.Location = new System.Drawing.Point(440, 356);
            this.GSpartans.Name = "GSpartans";
            this.GSpartans.Size = new System.Drawing.Size(299, 279);
            this.GSpartans.TabIndex = 15;
            this.GSpartans.TabStop = false;
            // 
            // SpartansScore
            // 
            this.SpartansScore.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpartansScore.ForeColor = System.Drawing.Color.White;
            this.SpartansScore.Location = new System.Drawing.Point(31, 83);
            this.SpartansScore.Name = "SpartansScore";
            this.SpartansScore.Size = new System.Drawing.Size(237, 168);
            this.SpartansScore.TabIndex = 14;
            this.SpartansScore.Text = "0";
            this.SpartansScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sports_Day_Scoreboard.Properties.Resources.frame_;
            this.pictureBox4.Location = new System.Drawing.Point(9, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 207);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(47, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 50);
            this.label12.TabIndex = 4;
            this.label12.Text = "SPARTANS";
            // 
            // GVikings
            // 
            this.GVikings.Controls.Add(this.VikingsScore);
            this.GVikings.Controls.Add(this.pictureBox5);
            this.GVikings.Controls.Add(this.label14);
            this.GVikings.Location = new System.Drawing.Point(778, 57);
            this.GVikings.Name = "GVikings";
            this.GVikings.Size = new System.Drawing.Size(299, 279);
            this.GVikings.TabIndex = 15;
            this.GVikings.TabStop = false;
            // 
            // VikingsScore
            // 
            this.VikingsScore.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VikingsScore.ForeColor = System.Drawing.Color.White;
            this.VikingsScore.Location = new System.Drawing.Point(31, 83);
            this.VikingsScore.Name = "VikingsScore";
            this.VikingsScore.Size = new System.Drawing.Size(237, 168);
            this.VikingsScore.TabIndex = 14;
            this.VikingsScore.Text = "0";
            this.VikingsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sports_Day_Scoreboard.Properties.Resources.frame_;
            this.pictureBox5.Location = new System.Drawing.Point(9, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(281, 207);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(70, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 50);
            this.label14.TabIndex = 4;
            this.label14.Text = "VIKINGS";
            // 
            // ScoreWrapper
            // 
            this.ScoreWrapper.Controls.Add(this.GRajputs);
            this.ScoreWrapper.Controls.Add(this.GVikings);
            this.ScoreWrapper.Controls.Add(this.GMughals);
            this.ScoreWrapper.Controls.Add(this.GSpartans);
            this.ScoreWrapper.Controls.Add(this.GAryans);
            this.ScoreWrapper.Location = new System.Drawing.Point(0, 149);
            this.ScoreWrapper.Name = "ScoreWrapper";
            this.ScoreWrapper.Size = new System.Drawing.Size(1110, 704);
            this.ScoreWrapper.TabIndex = 16;
            this.ScoreWrapper.TabStop = false;
            this.ScoreWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.ScoreWrapper_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1110, 852);
            this.Controls.Add(this.ScoreWrapper);
            this.Controls.Add(this.LiveIndicator);
            this.Controls.Add(this.SubHeading);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.HeadingsHolder);
            this.Name = "Form1";
            this.Text = "Sports Meet 2k19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.GRajputs.ResumeLayout(false);
            this.GRajputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GMughals.ResumeLayout(false);
            this.GMughals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GAryans.ResumeLayout(false);
            this.GAryans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GSpartans.ResumeLayout(false);
            this.GSpartans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.GVikings.ResumeLayout(false);
            this.GVikings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ScoreWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label SubHeading;
        private System.Windows.Forms.Label HeadingsHolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GRajputs;
        private System.Windows.Forms.Label LiveIndicator;
        private System.Windows.Forms.Label RajputsScore;
        private System.Windows.Forms.GroupBox GMughals;
        private System.Windows.Forms.Label MughalsScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GAryans;
        private System.Windows.Forms.Label AryansScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GSpartans;
        private System.Windows.Forms.Label SpartansScore;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GVikings;
        private System.Windows.Forms.Label VikingsScore;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox ScoreWrapper;
    }
}

