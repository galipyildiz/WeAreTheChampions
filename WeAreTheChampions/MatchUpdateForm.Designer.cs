
namespace WeAreTheChampions
{
    partial class MatchUpdateForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTeam2Score = new System.Windows.Forms.NumericUpDown();
            this.nudTeam1Score = new System.Windows.Forms.NumericUpDown();
            this.cboResult = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sonuç:";
            // 
            // nudTeam2Score
            // 
            this.nudTeam2Score.Location = new System.Drawing.Point(311, 57);
            this.nudTeam2Score.Name = "nudTeam2Score";
            this.nudTeam2Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam2Score.TabIndex = 16;
            // 
            // nudTeam1Score
            // 
            this.nudTeam1Score.Location = new System.Drawing.Point(311, 30);
            this.nudTeam1Score.Name = "nudTeam1Score";
            this.nudTeam1Score.Size = new System.Drawing.Size(58, 20);
            this.nudTeam1Score.TabIndex = 17;
            // 
            // cboResult
            // 
            this.cboResult.FormattingEnabled = true;
            this.cboResult.Location = new System.Drawing.Point(63, 83);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(165, 21);
            this.cboResult.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Takım1 Skor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Takım1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Takım2 Skor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Takım2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Karışlaşma Tarih ve Saati:";
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "dd.MMM.yyyy hh:mm tt";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(147, 3);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(222, 20);
            this.dtpMatchTime.TabIndex = 7;
            // 
            // txtTeam2
            // 
            this.txtTeam2.Enabled = false;
            this.txtTeam2.Location = new System.Drawing.Point(63, 55);
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(165, 20);
            this.txtTeam2.TabIndex = 20;
            // 
            // txtTeam1
            // 
            this.txtTeam1.Enabled = false;
            this.txtTeam1.Location = new System.Drawing.Point(63, 29);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(165, 20);
            this.txtTeam1.TabIndex = 20;
            // 
            // MatchUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 144);
            this.Controls.Add(this.txtTeam1);
            this.Controls.Add(this.txtTeam2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudTeam2Score);
            this.Controls.Add(this.nudTeam1Score);
            this.Controls.Add(this.cboResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMatchTime);
            this.Name = "MatchUpdateForm";
            this.Text = "MatchUpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam2Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeam1Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTeam2Score;
        private System.Windows.Forms.NumericUpDown nudTeam1Score;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.TextBox txtTeam1;
    }
}