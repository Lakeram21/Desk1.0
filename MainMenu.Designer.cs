namespace Mega
{
    partial class MainMenu
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
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnViewQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Location = new System.Drawing.Point(12, 25);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(129, 56);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 253);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.Location = new System.Drawing.Point(12, 177);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(129, 56);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnViewQuote
            // 
            this.btnViewQuote.Location = new System.Drawing.Point(12, 99);
            this.btnViewQuote.Name = "btnViewQuote";
            this.btnViewQuote.Size = new System.Drawing.Size(129, 56);
            this.btnViewQuote.TabIndex = 3;
            this.btnViewQuote.Text = "View Quotes";
            this.btnViewQuote.UseVisualStyleBackColor = true;
            this.btnViewQuote.Click += new System.EventHandler(this.btnViewQuote_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewQuote);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnViewQuote;
    }
}

