namespace MegaDesk1._0
{
    partial class SearchQuotes
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
            this.backQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchQuery = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backQuoteButton
            // 
            this.backQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backQuoteButton.Location = new System.Drawing.Point(16, 492);
            this.backQuoteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backQuoteButton.Name = "backQuoteButton";
            this.backQuoteButton.Size = new System.Drawing.Size(161, 47);
            this.backQuoteButton.TabIndex = 9;
            this.backQuoteButton.Text = "<- Main Menu";
            this.backQuoteButton.UseVisualStyleBackColor = true;
            this.backQuoteButton.Click += new System.EventHandler(this.BackQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mega Desk Search Quotes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchResults
            // 
            this.searchResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResults.Location = new System.Drawing.Point(51, 177);
            this.searchResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchResults.Multiline = true;
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(961, 272);
            this.searchResults.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search For Material:";
            // 
            // submitSearch
            // 
            this.submitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSearch.Location = new System.Drawing.Point(520, 123);
            this.submitSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitSearch.Name = "submitSearch";
            this.submitSearch.Size = new System.Drawing.Size(100, 28);
            this.submitSearch.TabIndex = 14;
            this.submitSearch.Text = "Submit";
            this.submitSearch.UseVisualStyleBackColor = true;
            this.submitSearch.Click += new System.EventHandler(this.SubmitSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Oak, Rosewood, Veneer, Laminate, and Pine";
            // 
            // searchQuery
            // 
            this.searchQuery.FormattingEnabled = true;
            this.searchQuery.Location = new System.Drawing.Point(271, 123);
            this.searchQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(216, 24);
            this.searchQuery.TabIndex = 16;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backQuoteButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox searchQuery;
    }
}