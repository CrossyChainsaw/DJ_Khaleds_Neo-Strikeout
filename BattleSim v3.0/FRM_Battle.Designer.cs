﻿
namespace BattleSim_v3._0
{
    partial class FRM_Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Battle));
            this.PB_Player1_NeoFighter = new System.Windows.Forms.PictureBox();
            this.PB_Player2_NeoFighter = new System.Windows.Forms.PictureBox();
            this.BTN_Player1_Attack = new System.Windows.Forms.Button();
            this.BTN_Player2_Attack = new System.Windows.Forms.Button();
            this.LBL_Player1_Health = new System.Windows.Forms.Label();
            this.LBL_Player2_Health = new System.Windows.Forms.Label();
            this.RB_P2_Attack1 = new System.Windows.Forms.RadioButton();
            this.GB_P2 = new System.Windows.Forms.GroupBox();
            this.RB_P2_Attack3 = new System.Windows.Forms.RadioButton();
            this.RB_P2_Attack2 = new System.Windows.Forms.RadioButton();
            this.GB_P1 = new System.Windows.Forms.GroupBox();
            this.RB_P1_Attack3 = new System.Windows.Forms.RadioButton();
            this.RB_P1_Attack2 = new System.Windows.Forms.RadioButton();
            this.RB_P1_Attack1 = new System.Windows.Forms.RadioButton();
            this.LBL_Damage = new System.Windows.Forms.Label();
            this.LBL_Status_P2 = new System.Windows.Forms.Label();
            this.LBL_Status_P1 = new System.Windows.Forms.Label();
            this.LBL_Events = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).BeginInit();
            this.GB_P2.SuspendLayout();
            this.GB_P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Player1_NeoFighter
            // 
            this.PB_Player1_NeoFighter.Location = new System.Drawing.Point(9, 10);
            this.PB_Player1_NeoFighter.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Player1_NeoFighter.Name = "PB_Player1_NeoFighter";
            this.PB_Player1_NeoFighter.Size = new System.Drawing.Size(300, 264);
            this.PB_Player1_NeoFighter.TabIndex = 0;
            this.PB_Player1_NeoFighter.TabStop = false;
            // 
            // PB_Player2_NeoFighter
            // 
            this.PB_Player2_NeoFighter.Location = new System.Drawing.Point(440, 9);
            this.PB_Player2_NeoFighter.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Player2_NeoFighter.Name = "PB_Player2_NeoFighter";
            this.PB_Player2_NeoFighter.Size = new System.Drawing.Size(300, 265);
            this.PB_Player2_NeoFighter.TabIndex = 1;
            this.PB_Player2_NeoFighter.TabStop = false;
            // 
            // BTN_Player1_Attack
            // 
            this.BTN_Player1_Attack.Location = new System.Drawing.Point(9, 278);
            this.BTN_Player1_Attack.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Player1_Attack.Name = "BTN_Player1_Attack";
            this.BTN_Player1_Attack.Size = new System.Drawing.Size(300, 31);
            this.BTN_Player1_Attack.TabIndex = 2;
            this.BTN_Player1_Attack.Text = "Attack";
            this.BTN_Player1_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player1_Attack.Click += new System.EventHandler(this.BTN_Player1_Attack_Click);
            // 
            // BTN_Player2_Attack
            // 
            this.BTN_Player2_Attack.Enabled = false;
            this.BTN_Player2_Attack.Location = new System.Drawing.Point(440, 278);
            this.BTN_Player2_Attack.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Player2_Attack.Name = "BTN_Player2_Attack";
            this.BTN_Player2_Attack.Size = new System.Drawing.Size(300, 31);
            this.BTN_Player2_Attack.TabIndex = 3;
            this.BTN_Player2_Attack.Text = "Attack";
            this.BTN_Player2_Attack.UseVisualStyleBackColor = true;
            this.BTN_Player2_Attack.Click += new System.EventHandler(this.BTN_Player2_Attack_Click);
            // 
            // LBL_Player1_Health
            // 
            this.LBL_Player1_Health.Location = new System.Drawing.Point(8, 311);
            this.LBL_Player1_Health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Player1_Health.Name = "LBL_Player1_Health";
            this.LBL_Player1_Health.Size = new System.Drawing.Size(105, 13);
            this.LBL_Player1_Health.TabIndex = 4;
            this.LBL_Player1_Health.Text = "Health";
            // 
            // LBL_Player2_Health
            // 
            this.LBL_Player2_Health.Location = new System.Drawing.Point(442, 311);
            this.LBL_Player2_Health.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Player2_Health.Name = "LBL_Player2_Health";
            this.LBL_Player2_Health.Size = new System.Drawing.Size(107, 13);
            this.LBL_Player2_Health.TabIndex = 5;
            this.LBL_Player2_Health.Text = "Health";
            // 
            // RB_P2_Attack1
            // 
            this.RB_P2_Attack1.AutoSize = true;
            this.RB_P2_Attack1.Checked = true;
            this.RB_P2_Attack1.Location = new System.Drawing.Point(5, 17);
            this.RB_P2_Attack1.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P2_Attack1.Name = "RB_P2_Attack1";
            this.RB_P2_Attack1.Size = new System.Drawing.Size(100, 17);
            this.RB_P2_Attack1.TabIndex = 6;
            this.RB_P2_Attack1.TabStop = true;
            this.RB_P2_Attack1.Text = "Player2 Attack1";
            this.RB_P2_Attack1.UseVisualStyleBackColor = true;
            // 
            // GB_P2
            // 
            this.GB_P2.Controls.Add(this.RB_P2_Attack3);
            this.GB_P2.Controls.Add(this.RB_P2_Attack2);
            this.GB_P2.Controls.Add(this.RB_P2_Attack1);
            this.GB_P2.Location = new System.Drawing.Point(440, 349);
            this.GB_P2.Margin = new System.Windows.Forms.Padding(2);
            this.GB_P2.Name = "GB_P2";
            this.GB_P2.Padding = new System.Windows.Forms.Padding(2);
            this.GB_P2.Size = new System.Drawing.Size(300, 81);
            this.GB_P2.TabIndex = 7;
            this.GB_P2.TabStop = false;
            this.GB_P2.Text = "Player2 Ability";
            // 
            // RB_P2_Attack3
            // 
            this.RB_P2_Attack3.AutoSize = true;
            this.RB_P2_Attack3.Location = new System.Drawing.Point(5, 59);
            this.RB_P2_Attack3.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P2_Attack3.Name = "RB_P2_Attack3";
            this.RB_P2_Attack3.Size = new System.Drawing.Size(100, 17);
            this.RB_P2_Attack3.TabIndex = 8;
            this.RB_P2_Attack3.Text = "Player2 Attack3";
            this.RB_P2_Attack3.UseVisualStyleBackColor = true;
            // 
            // RB_P2_Attack2
            // 
            this.RB_P2_Attack2.AutoSize = true;
            this.RB_P2_Attack2.Location = new System.Drawing.Point(5, 38);
            this.RB_P2_Attack2.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P2_Attack2.Name = "RB_P2_Attack2";
            this.RB_P2_Attack2.Size = new System.Drawing.Size(100, 17);
            this.RB_P2_Attack2.TabIndex = 7;
            this.RB_P2_Attack2.Text = "Player2 Attack2";
            this.RB_P2_Attack2.UseVisualStyleBackColor = true;
            // 
            // GB_P1
            // 
            this.GB_P1.Controls.Add(this.RB_P1_Attack3);
            this.GB_P1.Controls.Add(this.RB_P1_Attack2);
            this.GB_P1.Controls.Add(this.RB_P1_Attack1);
            this.GB_P1.Location = new System.Drawing.Point(9, 344);
            this.GB_P1.Margin = new System.Windows.Forms.Padding(2);
            this.GB_P1.Name = "GB_P1";
            this.GB_P1.Padding = new System.Windows.Forms.Padding(2);
            this.GB_P1.Size = new System.Drawing.Size(300, 81);
            this.GB_P1.TabIndex = 9;
            this.GB_P1.TabStop = false;
            this.GB_P1.Text = "Player1 Ability";
            // 
            // RB_P1_Attack3
            // 
            this.RB_P1_Attack3.AutoSize = true;
            this.RB_P1_Attack3.Location = new System.Drawing.Point(5, 59);
            this.RB_P1_Attack3.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P1_Attack3.Name = "RB_P1_Attack3";
            this.RB_P1_Attack3.Size = new System.Drawing.Size(100, 17);
            this.RB_P1_Attack3.TabIndex = 8;
            this.RB_P1_Attack3.Text = "Player1 Attack3";
            this.RB_P1_Attack3.UseVisualStyleBackColor = true;
            // 
            // RB_P1_Attack2
            // 
            this.RB_P1_Attack2.AutoSize = true;
            this.RB_P1_Attack2.Location = new System.Drawing.Point(5, 38);
            this.RB_P1_Attack2.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P1_Attack2.Name = "RB_P1_Attack2";
            this.RB_P1_Attack2.Size = new System.Drawing.Size(100, 17);
            this.RB_P1_Attack2.TabIndex = 7;
            this.RB_P1_Attack2.Text = "Player1 Attack2";
            this.RB_P1_Attack2.UseVisualStyleBackColor = true;
            // 
            // RB_P1_Attack1
            // 
            this.RB_P1_Attack1.AutoSize = true;
            this.RB_P1_Attack1.Checked = true;
            this.RB_P1_Attack1.Location = new System.Drawing.Point(5, 17);
            this.RB_P1_Attack1.Margin = new System.Windows.Forms.Padding(2);
            this.RB_P1_Attack1.Name = "RB_P1_Attack1";
            this.RB_P1_Attack1.Size = new System.Drawing.Size(100, 17);
            this.RB_P1_Attack1.TabIndex = 6;
            this.RB_P1_Attack1.TabStop = true;
            this.RB_P1_Attack1.Text = "Player1 Attack1";
            this.RB_P1_Attack1.UseVisualStyleBackColor = true;
            // 
            // LBL_Damage
            // 
            this.LBL_Damage.Location = new System.Drawing.Point(313, 9);
            this.LBL_Damage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Damage.Name = "LBL_Damage";
            this.LBL_Damage.Size = new System.Drawing.Size(123, 50);
            this.LBL_Damage.TabIndex = 10;
            this.LBL_Damage.Text = "LBL_Damage";
            this.LBL_Damage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Status_P2
            // 
            this.LBL_Status_P2.AutoSize = true;
            this.LBL_Status_P2.Location = new System.Drawing.Point(442, 324);
            this.LBL_Status_P2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Status_P2.Name = "LBL_Status_P2";
            this.LBL_Status_P2.Size = new System.Drawing.Size(67, 13);
            this.LBL_Status_P2.TabIndex = 12;
            this.LBL_Status_P2.Text = "Status: Clear";
            // 
            // LBL_Status_P1
            // 
            this.LBL_Status_P1.AutoSize = true;
            this.LBL_Status_P1.Location = new System.Drawing.Point(8, 324);
            this.LBL_Status_P1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Status_P1.Name = "LBL_Status_P1";
            this.LBL_Status_P1.Size = new System.Drawing.Size(67, 13);
            this.LBL_Status_P1.TabIndex = 13;
            this.LBL_Status_P1.Text = "Status: Clear";
            // 
            // LBL_Events
            // 
            this.LBL_Events.Location = new System.Drawing.Point(313, 145);
            this.LBL_Events.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Events.Name = "LBL_Events";
            this.LBL_Events.Size = new System.Drawing.Size(123, 263);
            this.LBL_Events.TabIndex = 14;
            this.LBL_Events.Text = "LBL_Events";
            this.LBL_Events.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 451);
            this.Controls.Add(this.LBL_Events);
            this.Controls.Add(this.LBL_Status_P1);
            this.Controls.Add(this.LBL_Status_P2);
            this.Controls.Add(this.LBL_Damage);
            this.Controls.Add(this.GB_P1);
            this.Controls.Add(this.GB_P2);
            this.Controls.Add(this.LBL_Player2_Health);
            this.Controls.Add(this.LBL_Player1_Health);
            this.Controls.Add(this.BTN_Player2_Attack);
            this.Controls.Add(this.BTN_Player1_Attack);
            this.Controls.Add(this.PB_Player2_NeoFighter);
            this.Controls.Add(this.PB_Player1_NeoFighter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_Battle";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.FRM_Battle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player1_NeoFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Player2_NeoFighter)).EndInit();
            this.GB_P2.ResumeLayout(false);
            this.GB_P2.PerformLayout();
            this.GB_P1.ResumeLayout(false);
            this.GB_P1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Player1_NeoFighter;
        private System.Windows.Forms.PictureBox PB_Player2_NeoFighter;
        private System.Windows.Forms.Button BTN_Player1_Attack;
        private System.Windows.Forms.Button BTN_Player2_Attack;
        private System.Windows.Forms.Label LBL_Player1_Health;
        private System.Windows.Forms.Label LBL_Player2_Health;
        private System.Windows.Forms.RadioButton RB_P2_Attack1;
        private System.Windows.Forms.GroupBox GB_P2;
        private System.Windows.Forms.RadioButton RB_P2_Attack2;
        private System.Windows.Forms.RadioButton RB_P2_Attack3;
        private System.Windows.Forms.GroupBox GB_P1;
        private System.Windows.Forms.RadioButton RB_P1_Attack3;
        private System.Windows.Forms.RadioButton RB_P1_Attack2;
        private System.Windows.Forms.RadioButton RB_P1_Attack1;
        private System.Windows.Forms.Label LBL_Damage;
        private System.Windows.Forms.Label LBL_Status_P2;
        private System.Windows.Forms.Label LBL_Status_P1;
        private System.Windows.Forms.Label LBL_Events;
    }
}