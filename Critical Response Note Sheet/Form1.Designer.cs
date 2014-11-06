namespace Critical_Response_Note_Sheet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medium = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.presenter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conveychoice = new System.Windows.Forms.ComboBox();
            this.mainMessage = new System.Windows.Forms.RichTextBox();
            this.connection = new System.Windows.Forms.RichTextBox();
            this.getMainMessage1 = new System.Windows.Forms.RichTextBox();
            this.getMainMessage2 = new System.Windows.Forms.RichTextBox();
            this.getMainMessage3 = new System.Windows.Forms.RichTextBox();
            this.explain1 = new System.Windows.Forms.RichTextBox();
            this.explain2 = new System.Windows.Forms.RichTextBox();
            this.explain3 = new System.Windows.Forms.RichTextBox();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.SAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(55, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(498, 22);
            this.name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "In the";
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(55, 35);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(100, 22);
            this.medium.TabIndex = 1;
            this.ToolTips.SetToolTip(this.medium, "Genre: Article, film, book, TED Talk, etc.?");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "entitled";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(221, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(323, 22);
            this.title.TabIndex = 2;
            this.ToolTips.SetToolTip(this.title, "Title of work");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(550, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = ",";
            // 
            // presenter
            // 
            this.presenter.Location = new System.Drawing.Point(15, 63);
            this.presenter.Name = "presenter";
            this.presenter.Size = new System.Drawing.Size(100, 22);
            this.presenter.TabIndex = 3;
            this.ToolTips.SetToolTip(this.presenter, "Author, presenter, creator etc.?");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "wants us to";
            // 
            // conveychoice
            // 
            this.conveychoice.FormattingEnabled = true;
            this.conveychoice.Items.AddRange(new object[] {
            "know",
            "understand",
            "be able to"});
            this.conveychoice.Location = new System.Drawing.Point(207, 61);
            this.conveychoice.Name = "conveychoice";
            this.conveychoice.Size = new System.Drawing.Size(121, 24);
            this.conveychoice.TabIndex = 4;
            this.conveychoice.Text = "select one...";
            this.conveychoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainMessage
            // 
            this.mainMessage.Location = new System.Drawing.Point(13, 92);
            this.mainMessage.Name = "mainMessage";
            this.mainMessage.Size = new System.Drawing.Size(540, 72);
            this.mainMessage.TabIndex = 5;
            this.mainMessage.Text = "";
            this.ToolTips.SetToolTip(this.mainMessage, "State the most important reason for the work here");
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(12, 315);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(541, 70);
            this.connection.TabIndex = 12;
            this.connection.Text = "";
            this.ToolTips.SetToolTip(this.connection, "How does this connect or relate to other things we are working on in class like a" +
                    "nd/or your own life, experience, or perspective?");
            // 
            // getMainMessage1
            // 
            this.getMainMessage1.Location = new System.Drawing.Point(12, 170);
            this.getMainMessage1.Name = "getMainMessage1";
            this.getMainMessage1.Size = new System.Drawing.Size(100, 46);
            this.getMainMessage1.TabIndex = 6;
            this.getMainMessage1.Text = "";
            this.ToolTips.SetToolTip(this.getMainMessage1, "What does the author say/do/show to convey their main message?");
            // 
            // getMainMessage2
            // 
            this.getMainMessage2.Location = new System.Drawing.Point(12, 223);
            this.getMainMessage2.Name = "getMainMessage2";
            this.getMainMessage2.Size = new System.Drawing.Size(100, 43);
            this.getMainMessage2.TabIndex = 8;
            this.getMainMessage2.Text = "";
            this.ToolTips.SetToolTip(this.getMainMessage2, "What does the author say/do/show to convey their main message?");
            // 
            // getMainMessage3
            // 
            this.getMainMessage3.Location = new System.Drawing.Point(12, 272);
            this.getMainMessage3.Name = "getMainMessage3";
            this.getMainMessage3.Size = new System.Drawing.Size(100, 37);
            this.getMainMessage3.TabIndex = 10;
            this.getMainMessage3.Text = "";
            this.ToolTips.SetToolTip(this.getMainMessage3, "What does the author say/do/show to convey their main message?");
            // 
            // explain1
            // 
            this.explain1.Location = new System.Drawing.Point(122, 171);
            this.explain1.Name = "explain1";
            this.explain1.Size = new System.Drawing.Size(431, 46);
            this.explain1.TabIndex = 7;
            this.explain1.Text = "";
            this.ToolTips.SetToolTip(this.explain1, "Explain how this connects to the main message.");
            // 
            // explain2
            // 
            this.explain2.Location = new System.Drawing.Point(122, 223);
            this.explain2.Name = "explain2";
            this.explain2.Size = new System.Drawing.Size(431, 43);
            this.explain2.TabIndex = 9;
            this.explain2.Text = "";
            this.ToolTips.SetToolTip(this.explain2, "Explain how this connects to the main message.");
            // 
            // explain3
            // 
            this.explain3.Location = new System.Drawing.Point(122, 272);
            this.explain3.Name = "explain3";
            this.explain3.Size = new System.Drawing.Size(431, 37);
            this.explain3.TabIndex = 11;
            this.explain3.Text = "";
            this.ToolTips.SetToolTip(this.explain3, "Explain how this connects to the main message.");
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(12, 392);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(541, 27);
            this.SAVE.TabIndex = 13;
            this.SAVE.Text = "SAVE";
            this.ToolTips.SetToolTip(this.SAVE, "Save as an RTF file in essay format");
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 431);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.explain3);
            this.Controls.Add(this.explain2);
            this.Controls.Add(this.explain1);
            this.Controls.Add(this.getMainMessage3);
            this.Controls.Add(this.getMainMessage2);
            this.Controls.Add(this.getMainMessage1);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.mainMessage);
            this.Controls.Add(this.conveychoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.presenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CRITICAL RESPONSE NOTE SHEET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox presenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox conveychoice;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.RichTextBox mainMessage;
        private System.Windows.Forms.RichTextBox connection;
        private System.Windows.Forms.RichTextBox getMainMessage1;
        private System.Windows.Forms.RichTextBox getMainMessage2;
        private System.Windows.Forms.RichTextBox getMainMessage3;
        private System.Windows.Forms.RichTextBox explain1;
        private System.Windows.Forms.RichTextBox explain2;
        private System.Windows.Forms.RichTextBox explain3;
        private System.Windows.Forms.Button SAVE;
    }
}

