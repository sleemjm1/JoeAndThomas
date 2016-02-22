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
            this.btnDeal.Location = new System.Drawing.Point(24, 215);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(167, 52);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // listDisplay
            // 
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 25;
            this.listDisplay.Location = new System.Drawing.Point(505, 28);
            this.listDisplay.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(605, 779);
            this.listDisplay.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(203, 215);
            btnReset.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(167, 52);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset ";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumHands
            // 
            this.txtNumHands.Location = new System.Drawing.Point(214, 81);
            this.txtNumHands.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumHands.Name = "txtNumHands";
            this.txtNumHands.Size = new System.Drawing.Size(154, 30);
            this.txtNumHands.TabIndex = 3;
            // 
            // txtNumCards
            // 
            this.txtNumCards.Location = new System.Drawing.Point(214, 144);
            this.txtNumCards.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumCards.Name = "txtNumCards";
            this.txtNumCards.Size = new System.Drawing.Size(154, 30);
            this.txtNumCards.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. of Hands:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cards per Hand:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1146, 840);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumCards);
            this.Controls.Add(this.txtNumHands);
            this.Controls.Add(btnReset);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.listDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
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

