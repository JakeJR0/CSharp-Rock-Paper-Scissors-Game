namespace Rock_Paper_Scissors
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userChoiceLabel = new System.Windows.Forms.Label();
            this.computerChoiceLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(465, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // userChoiceLabel
            // 
            this.userChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userChoiceLabel.Location = new System.Drawing.Point(12, 244);
            this.userChoiceLabel.Name = "userChoiceLabel";
            this.userChoiceLabel.Size = new System.Drawing.Size(441, 32);
            this.userChoiceLabel.TabIndex = 1;
            this.userChoiceLabel.Text = "Your Choice: ";
            this.userChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerChoiceLabel
            // 
            this.computerChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.computerChoiceLabel.Location = new System.Drawing.Point(22, 197);
            this.computerChoiceLabel.Name = "computerChoiceLabel";
            this.computerChoiceLabel.Size = new System.Drawing.Size(431, 39);
            this.computerChoiceLabel.TabIndex = 2;
            this.computerChoiceLabel.Text = "Computer Choice: ";
            this.computerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.computerScoreLabel.Location = new System.Drawing.Point(17, 141);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(436, 38);
            this.computerScoreLabel.TabIndex = 3;
            this.computerScoreLabel.Text = "Computer Score: 0";
            this.computerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreLabel.Location = new System.Drawing.Point(17, 102);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(436, 37);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Your Score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Title.Location = new System.Drawing.Point(27, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(426, 49);
            this.Title.TabIndex = 5;
            this.Title.Text = "Rock Paper Scissors";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.SkyBlue;
            this.rockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rockButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rockButton.Location = new System.Drawing.Point(34, 369);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(110, 35);
            this.rockButton.TabIndex = 6;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.SkyBlue;
            this.paperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.paperButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paperButton.Location = new System.Drawing.Point(182, 369);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(110, 35);
            this.paperButton.TabIndex = 7;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.BackColor = System.Drawing.Color.SkyBlue;
            this.scissorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scissorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scissorButton.Location = new System.Drawing.Point(332, 369);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(110, 35);
            this.scissorButton.TabIndex = 8;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = false;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resultLabel.Location = new System.Drawing.Point(22, 293);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(431, 42);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Result: None";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(465, 446);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.computerChoiceLabel);
            this.Controls.Add(this.userChoiceLabel);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "App";
            this.Text = "Rock Paper Scissors Game";
            this.Load += new System.EventHandler(this.App_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.Label userChoiceLabel;
        private System.Windows.Forms.Label computerChoiceLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

