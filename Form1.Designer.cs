namespace Mini_Project
{
    partial class Form1
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
            richTextBox1 = new RichTextBox();
            listView1 = new ListView();
            btnNewNote = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            fontDialog1 = new FontDialog();
            textBoxTitle = new Button();
            comboBoxThemes = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ScrollBar;
            richTextBox1.Location = new Point(27, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(497, 255);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(549, 84);
            listView1.Name = "listView1";
            listView1.Size = new Size(218, 253);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // btnNewNote
            // 
            btnNewNote.Location = new Point(139, 361);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(75, 23);
            btnNewNote.TabIndex = 2;
            btnNewNote.Text = "New Note";
            btnNewNote.UseMnemonic = false;
            btnNewNote.UseVisualStyleBackColor = true;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 361);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Save Note";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSaveNote_Click;
            // 
            // button3
            // 
            button3.Location = new Point(359, 361);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 4;
            button3.Text = "Delete Note";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteNote_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(605, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Saved Notes";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "New Note";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(542, 373);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(123, 26);
            textBoxTitle.TabIndex = 7;
            textBoxTitle.Text = "Change Font";
            textBoxTitle.UseVisualStyleBackColor = true;
            textBoxTitle.Click += btnChangeFont_Click;
            // 
            // comboBoxThemes
            // 
            comboBoxThemes.FormattingEnabled = true;
            comboBoxThemes.Items.AddRange(new object[] { "Light", "Dark", "Blue" });
            comboBoxThemes.Location = new Point(671, 373);
            comboBoxThemes.Name = "comboBoxThemes";
            comboBoxThemes.Size = new Size(121, 23);
            comboBoxThemes.TabIndex = 8;
            comboBoxThemes.Click += comboBoxThemes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 52);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "Title:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
            Controls.Add(label1);
            Controls.Add(comboBoxThemes);
            Controls.Add(textBoxTitle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnNewNote);
            Controls.Add(listView1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ListView listView1;
        private Button btnNewNote;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private FontDialog fontDialog1;
        private Button textBoxTitle;
        private ComboBox comboBoxThemes;
        private Label label1;
    }
}