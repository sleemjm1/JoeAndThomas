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
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDisplay
            // 
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 20;
            this.listDisplay.Location = new System.Drawing.Point(379, 22);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(455, 624);
            this.listDisplay.TabIndex = 0;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(57, 302);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(219, 65);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal Cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(859, 672);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.listDisplay);
            this.Name = "Form1";
            this.Text = "Card Dealer Deluxe 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button btnDeal;
    }
}

