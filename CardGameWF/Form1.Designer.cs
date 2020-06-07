namespace CardGameWF
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
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Location = new System.Drawing.Point(173, 329);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(407, 125);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Location = new System.Drawing.Point(173, 35);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(407, 125);
            this.pnlPlayer1.TabIndex = 2;
            // 
            // pnlTable
            // 
            this.pnlTable.Location = new System.Drawing.Point(173, 182);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(407, 125);
            this.pnlTable.TabIndex = 2;
            this.pnlTable.Click += new System.EventHandler(this.pnlTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(12, 192);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(80, 100);
            this.pnlDeck.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(675, 289);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 545);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.pnlPlayer2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lblMessage;
    }
}

