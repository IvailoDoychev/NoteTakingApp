using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Mini_Project

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
            ConfigureListView();

        }
        private void ConfigureListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Title", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Timestamp", -2, HorizontalAlignment.Left);
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                LoadSelectedNote(e.Item.Text); 
            }
        }
        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Please enter a title for the note.", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd;
                if (listView1.SelectedItems.Count > 0)
                {
                    // Update existing note
                    cmd = new SqlCommand("UPDATE Notes SET Content = @Content WHERE NoteID = @NoteID", con);
                    cmd.Parameters.AddWithValue("@NoteID", listView1.SelectedItems[0].Text);
                }
                else
                {
                    // Insert new note
                    cmd = new SqlCommand("INSERT INTO Notes (Title, Content) VALUES (@Title, @Content)", con);
                    cmd.Parameters.AddWithValue("@Title", "New Note");  
                }
                cmd.Parameters.AddWithValue("@Content", richTextBox1.Text);
                cmd.ExecuteNonQuery();
            }
            LoadNotes();
        }

        private void LoadSelectedNote(string noteId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Content FROM Notes WHERE NoteID = @NoteID", con);
                cmd.Parameters.AddWithValue("@NoteID", noteId);
                con.Open();
                var content = cmd.ExecuteScalar(); 
                richTextBox1.Text = content?.ToString(); 
                con.Close();
            }
        }


        private void LoadNotes()
        {
            listView1.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT NoteID, Title, Timestamp FROM Notes", con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["NoteID"].ToString());
                        item.SubItems.Add(reader["Title"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Timestamp"]).ToString("g"));
                        listView1.Items.Add(item);
                    }
                }
            }
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Notes WHERE NoteID = @NoteID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NoteID", listView1.SelectedItems[0].Text); 
                    cmd.ExecuteNonQuery();
                }
                LoadNotes();
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }
        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxThemes.SelectedItem == null) return;
            switch (comboBoxThemes.SelectedItem.ToString())
            {
                case "Light":
                    this.BackColor = Color.White;
                    richTextBox1.BackColor = Color.WhiteSmoke;
                    richTextBox1.ForeColor = Color.Black;
                    break;
                case "Dark":
                    this.BackColor = Color.DarkGray;
                    richTextBox1.BackColor = Color.Black;
                    richTextBox1.ForeColor = Color.White;
                    break;
                case "Blue":
                    this.BackColor = Color.LightBlue;
                    richTextBox1.BackColor = Color.Azure;
                    richTextBox1.ForeColor = Color.DarkBlue;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}