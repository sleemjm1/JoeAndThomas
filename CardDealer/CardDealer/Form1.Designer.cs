namespace CardDealer
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
            System.Windows.Forms.Button btnReset;
            this.btnDeal = new System.Windows.Forms.Button();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.txtNumHands = new System.Windows.Forms.TextBox();
            this.txtNumCards = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(51, 146);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(195, 52);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // listDisplay
            // 
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 16;
            this.listDisplay.Location = new System.Drawing.Point(337, 18);
            this.listDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(405, 500);
            this.listDisplay.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(51, 225);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(195, 52);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumHands
            // 
            this.txtNumHands.Location = new System.Drawing.Point(142, 52);
            this.txtNumHands.Name = "txtNumHands";
            this.txtNumHands.Size = new System.Drawing.Size(104, 22);
            this.txtNumHands.TabIndex = 3;
            // 
            // txtNumCards
            // 
            this.txtNumCards.Location = new System.Drawing.Point(142, 92);
            this.txtNumCards.Name = "txtNumCards";
            this.txtNumCards.Size = new System.Drawing.Size(104, 22);
            this.txtNumCards.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Hands:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cards per Hand:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(764, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumCards);
            this.Controls.Add(this.txtNumHands);
            this.Controls.Add(btnReset);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.listDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Card Dealer Deluxe 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.TextBox txtNumHands;
        private System.Windows.Forms.TextBox txtNumCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

