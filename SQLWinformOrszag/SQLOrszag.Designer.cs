namespace SQLWinformOrszag
{
    partial class SQLOrszag
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
            this.ListBoxOrszag = new System.Windows.Forms.ListBox();
            this.KivalOrszag = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.OrszNev = new System.Windows.Forms.Label();
            this.Fovar = new System.Windows.Forms.Label();
            this.Terul = new System.Windows.Forms.Label();
            this.Nepesseg = new System.Windows.Forms.Label();
            this.Allamform = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.Orszagnevtext = new System.Windows.Forms.TextBox();
            this.Fovarostext = new System.Windows.Forms.TextBox();
            this.Terulettext = new System.Windows.Forms.TextBox();
            this.Nepessegtext = new System.Windows.Forms.TextBox();
            this.AllamFormatext = new System.Windows.Forms.TextBox();
            this.KivalOrszag.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxOrszag
            // 
            this.ListBoxOrszag.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxOrszag.FormattingEnabled = true;
            this.ListBoxOrszag.Location = new System.Drawing.Point(0, 0);
            this.ListBoxOrszag.Name = "ListBoxOrszag";
            this.ListBoxOrszag.Size = new System.Drawing.Size(171, 450);
            this.ListBoxOrszag.TabIndex = 0;
            this.ListBoxOrszag.SelectedIndexChanged += new System.EventHandler(this.ListBoxOrszag_SelectedIndexChanged);
            // 
            // KivalOrszag
            // 
            this.KivalOrszag.Controls.Add(this.AllamFormatext);
            this.KivalOrszag.Controls.Add(this.Nepessegtext);
            this.KivalOrszag.Controls.Add(this.Terulettext);
            this.KivalOrszag.Controls.Add(this.Fovarostext);
            this.KivalOrszag.Controls.Add(this.Orszagnevtext);
            this.KivalOrszag.Controls.Add(this.IDText);
            this.KivalOrszag.Controls.Add(this.Allamform);
            this.KivalOrszag.Controls.Add(this.Nepesseg);
            this.KivalOrszag.Controls.Add(this.Terul);
            this.KivalOrszag.Controls.Add(this.Fovar);
            this.KivalOrszag.Controls.Add(this.OrszNev);
            this.KivalOrszag.Controls.Add(this.ID);
            this.KivalOrszag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KivalOrszag.Location = new System.Drawing.Point(171, 0);
            this.KivalOrszag.Name = "KivalOrszag";
            this.KivalOrszag.Size = new System.Drawing.Size(629, 450);
            this.KivalOrszag.TabIndex = 1;
            this.KivalOrszag.TabStop = false;
            this.KivalOrszag.Text = "Kiválasztott Országok területei";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(10, 23);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // OrszNev
            // 
            this.OrszNev.AutoSize = true;
            this.OrszNev.Location = new System.Drawing.Point(5, 56);
            this.OrszNev.Name = "OrszNev";
            this.OrszNev.Size = new System.Drawing.Size(60, 13);
            this.OrszNev.TabIndex = 1;
            this.OrszNev.Text = "OrszagNev";
            this.OrszNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fovar
            // 
            this.Fovar.AutoSize = true;
            this.Fovar.Location = new System.Drawing.Point(6, 80);
            this.Fovar.Name = "Fovar";
            this.Fovar.Size = new System.Drawing.Size(45, 13);
            this.Fovar.TabIndex = 2;
            this.Fovar.Text = "Főváros";
            this.Fovar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Terul
            // 
            this.Terul.AutoSize = true;
            this.Terul.Location = new System.Drawing.Point(6, 109);
            this.Terul.Name = "Terul";
            this.Terul.Size = new System.Drawing.Size(40, 13);
            this.Terul.TabIndex = 3;
            this.Terul.Text = "Terület";
            this.Terul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nepesseg
            // 
            this.Nepesseg.AutoSize = true;
            this.Nepesseg.Location = new System.Drawing.Point(3, 135);
            this.Nepesseg.Name = "Nepesseg";
            this.Nepesseg.Size = new System.Drawing.Size(55, 13);
            this.Nepesseg.TabIndex = 4;
            this.Nepesseg.Text = "Népesség";
            this.Nepesseg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Allamform
            // 
            this.Allamform.AutoSize = true;
            this.Allamform.Location = new System.Drawing.Point(3, 171);
            this.Allamform.Name = "Allamform";
            this.Allamform.Size = new System.Drawing.Size(58, 13);
            this.Allamform.TabIndex = 5;
            this.Allamform.Text = "Államforma";
            this.Allamform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Allamform.Click += new System.EventHandler(this.Allamform_Click);
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(33, 24);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(121, 20);
            this.IDText.TabIndex = 6;
            // 
            // Orszagnevtext
            // 
            this.Orszagnevtext.Location = new System.Drawing.Point(71, 49);
            this.Orszagnevtext.Name = "Orszagnevtext";
            this.Orszagnevtext.Size = new System.Drawing.Size(103, 20);
            this.Orszagnevtext.TabIndex = 7;
            // 
            // Fovarostext
            // 
            this.Fovarostext.Location = new System.Drawing.Point(57, 73);
            this.Fovarostext.Name = "Fovarostext";
            this.Fovarostext.Size = new System.Drawing.Size(116, 20);
            this.Fovarostext.TabIndex = 8;
            // 
            // Terulettext
            // 
            this.Terulettext.Location = new System.Drawing.Point(60, 106);
            this.Terulettext.Name = "Terulettext";
            this.Terulettext.Size = new System.Drawing.Size(113, 20);
            this.Terulettext.TabIndex = 9;
            // 
            // Nepessegtext
            // 
            this.Nepessegtext.Location = new System.Drawing.Point(65, 138);
            this.Nepessegtext.Name = "Nepessegtext";
            this.Nepessegtext.Size = new System.Drawing.Size(108, 20);
            this.Nepessegtext.TabIndex = 10;
            // 
            // AllamFormatext
            // 
            this.AllamFormatext.Location = new System.Drawing.Point(66, 172);
            this.AllamFormatext.Name = "AllamFormatext";
            this.AllamFormatext.Size = new System.Drawing.Size(107, 20);
            this.AllamFormatext.TabIndex = 11;
            // 
            // SQLOrszag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KivalOrszag);
            this.Controls.Add(this.ListBoxOrszag);
            this.Name = "SQLOrszag";
            this.Text = "SQLOrszag";
            this.Load += new System.EventHandler(this.SQLOrszag_Load);
            this.KivalOrszag.ResumeLayout(false);
            this.KivalOrszag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOrszag;
        private System.Windows.Forms.GroupBox KivalOrszag;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox Fovarostext;
        private System.Windows.Forms.TextBox Orszagnevtext;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label Allamform;
        private System.Windows.Forms.Label Nepesseg;
        private System.Windows.Forms.Label Terul;
        private System.Windows.Forms.Label Fovar;
        private System.Windows.Forms.Label OrszNev;
        private System.Windows.Forms.TextBox AllamFormatext;
        private System.Windows.Forms.TextBox Nepessegtext;
        private System.Windows.Forms.TextBox Terulettext;
    }
}

