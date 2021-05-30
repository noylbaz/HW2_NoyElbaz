//NOY ELBAZ 315073122
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HW2_NoyElbaz
{

    public partial class Form1 : Form
    {
        private readonly BindingSource tblBS = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Dialog_Click(object sender, EventArgs e)
        {
            using (Form2 fr2 = new Form2())
            {
                if (fr2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dataGridView1.Columns.Clear();
                    tblBS.DataSource = fr2.QueryEx;
                    dataGridView1.DataSource = tblBS;
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = true;
                }
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                SqlConnection con;
                string connectionString;
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30";
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sqlCommand = $"Delete TblStudents where Id={dataGridView1.Rows[row].Cells[0].Value}";
                command = new SqlCommand(sqlCommand, con);
                adapter.DeleteCommand = new SqlCommand(sqlCommand, con);
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                con.Close();
                dataGridView1.Rows.RemoveAt(row);
                database1DataSet.AcceptChanges();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tblStudentsTableAdapter.Fill(this.database1DataSet.TblStudents);
        }

        private void Shift_Esc(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                dataGridView1.DataSource = this.database1DataSet.TblStudents;
            }
        }
    }
}
