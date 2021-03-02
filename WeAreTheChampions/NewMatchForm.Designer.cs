
namespace WeAreTheChampions
{
    partial class NewMatchForm
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
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTeam1Score = new System.Windows.Forms.NumericUpDown();
            this.nudTeam2Score = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboResult = new System.Windows.Forms.ComboBox();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "dd.MMM.yyyy hh:mm tt";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(147, 12);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(222, 20);
            this.dtpMatchTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karışlaşma Tarih ve Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Takım2:";
            // 
            // cboTeam1
            // 
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(63, 38);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(165, 21);
            this.cboTeam1.TabIndex = 3;
            this.cboTeam1.SelectedIndexChanged += new System.EventHandler(this.cboTeam1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Takım1:";
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(63, 65);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(165, 21);
            this.cboTeam2.TabIndex = 3;
            this.cboTeam2.SelectedIndexChanged += new System.EventHandler(this.cboTeam2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Takım1 Skor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Takım2 Skor:";
            // 
            // nudTeam1Score
            // 
            this.nudTeam1Score.Location = new System.Drawing.Point(311, 39);
            this.nudTeam1Score.Name = "nudTeam1Score";
            this.nudTeam1Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam1Score.TabIndex = 4;
            // 
            // nudTeam2Score
            // 
            this.nudTeam2Score.Location = new System.Drawing.Point(311, 66);
            this.nudTeam2Score.Name = "nudTeam2Score";
            this.nudTeam2Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam2Score.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sonuç:";
            // 
            // cboResult
            // 
            this.cboResult.FormattingEnabled = true;
            this.cboResult.Location = new System.Drawing.Point(63, 92);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(165, 21);
            this.cboResult.TabIndex = 3;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(256, 119);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(113, 23);
            this.btnCreateMatch.TabIndex = 6;
            this.btnCreateMatch.Text = "Karşılaşma Oluştur";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // NewMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 162);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTeam2Score);
            this.Controls.Add(this.nudTeam1Score);
            this.Controls.Add(this.cboResult);
            this.Controls.Add(this.cboTeam2);
            this.Controls.Add(this.cboTeam1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMatchTime);
            this.MaximizeBox = false;
            this.Name = "NewMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewMatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTeam1Score;
        private System.Windows.Forms.NumericUpDown nudTeam2Score;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Button btnCreateMatch;
    }
}