
namespace ControleRemotoBot
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.ltbConfiguredCommands = new System.Windows.Forms.ListBox();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnGetID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(74, 47);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(312, 23);
            this.txtAdmin.TabIndex = 0;
            this.txtAdmin.Text = "89893407";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin ID";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(74, 8);
            this.txtToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToken.Name = "txtToken";
            this.txtToken.PasswordChar = '*';
            this.txtToken.Size = new System.Drawing.Size(352, 23);
            this.txtToken.TabIndex = 2;
            this.txtToken.Text = "1630386203:AAHWdZ-3t8u1RYLLFRxXW7UN2AuqsiVQDko";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(299, 248);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Location = new System.Drawing.Point(304, 78);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(41, 25);
            this.btnAddCommand.TabIndex = 5;
            this.btnAddCommand.Text = "+";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // ltbConfiguredCommands
            // 
            this.ltbConfiguredCommands.FormattingEnabled = true;
            this.ltbConfiguredCommands.ItemHeight = 15;
            this.ltbConfiguredCommands.Location = new System.Drawing.Point(8, 105);
            this.ltbConfiguredCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbConfiguredCommands.Name = "ltbConfiguredCommands";
            this.ltbConfiguredCommands.Size = new System.Drawing.Size(378, 139);
            this.ltbConfiguredCommands.TabIndex = 6;
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Location = new System.Drawing.Point(346, 78);
            this.btnRemoveCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(41, 25);
            this.btnRemoveCommand.TabIndex = 7;
            this.btnRemoveCommand.Text = "-";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            this.btnRemoveCommand.Click += new System.EventHandler(this.btnRemoveCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Commands:";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(388, 150);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(41, 25);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(388, 174);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(41, 25);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAll.Location = new System.Drawing.Point(387, 78);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(41, 25);
            this.btnAddAll.TabIndex = 11;
            this.btnAddAll.Text = "All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnGetID
            // 
            this.btnGetID.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetID.Location = new System.Drawing.Point(387, 46);
            this.btnGetID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(41, 25);
            this.btnGetID.TabIndex = 12;
            this.btnGetID.Text = "?";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 288);
            this.Controls.Add(this.btnGetID);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveCommand);
            this.Controls.Add(this.ltbConfiguredCommands);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control Bot - Stopped";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.ListBox ltbConfiguredCommands;
        private System.Windows.Forms.Button btnRemoveCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnGetID;
    }
}