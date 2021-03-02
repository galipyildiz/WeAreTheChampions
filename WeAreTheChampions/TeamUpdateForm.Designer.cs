
namespace WeAreTheChampions
{
    partial class TeamUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lviColors = new System.Windows.Forms.ListView();
            this.lstTeamColors = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım Adı:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(69, 22);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(175, 20);
            this.txtTeamName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lviColors
            // 
            this.lviColors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lviColors.HideSelection = false;
            this.lviColors.Location = new System.Drawing.Point(9, 16);
            this.lviColors.Name = "lviColors";
            this.lviColors.Size = new System.Drawing.Size(235, 97);
            this.lviColors.TabIndex = 3;
            this.lviColors.UseCompatibleStateImageBehavior = false;
            // 
            // lstTeamColors
            // 
            this.lstTeamColors.FormattingEnabled = true;
            this.lstTeamColors.Location = new System.Drawing.Point(69, 49);
            this.lstTeamColors.Name = "lstTeamColors";
            this.lstTeamColors.Size = new System.Drawing.Size(175, 69);
            this.lstTeamColors.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renkleri:";
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(250, 16);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(89, 23);
            this.btnAddColor.TabIndex = 2;
            this.btnAddColor.Text = "Renk Ekle";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstTeamColors);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takım Bilgileri";
            // 
            // btnRemoveColor
            // 
            this.btnRemoveColor.Location = new System.Drawing.Point(250, 49);
            this.btnRemoveColor.Name = "btnRemoveColor";
            this.btnRemoveColor.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveColor.TabIndex = 5;
            this.btnRemoveColor.Text = "Renk Sil";
            this.btnRemoveColor.UseVisualStyleBackColor = true;
            this.btnRemoveColor.Click += new System.EventHandler(this.btnRemoveColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddColor);
            this.groupBox2.Controls.Add(this.lviColors);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 120);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renkler";
            // 
            // TeamUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "TeamUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeamUpdateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lviColors;
        private System.Windows.Forms.ListBox lstTeamColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveColor;
    }
}