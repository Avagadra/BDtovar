using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class SpisokTovarov : Form
    {
        SqlDataAdapter pagingAdapter;
        DataSet pagingDS;
        int pageSize = 15;
        int maxItem = 0;
        int nowItem = 0;
        int scrollVal;
        string connectionString = @"Data Source=DBsrv\Demo;Initial Catalog=007ca2_chernavina_v4;Integrated Security=True";
        string sql = "select [Артикул], [Наименование], [Стоимость], [Производитель], [Описание], [Кол-во на складе], [Изображение] from Товары";
        string sql1 = "select count(ID) from Товары";
        string sqlFiltr = "";
        string sqlSortV = "";
        string sqlSearch = "";
        string sqlFiltrMax = "";
        string sqlSearchMax = "";

        public SpisokTovarov()
        {
            InitializeComponent();

            string[] sort = { "По убыванию", "По возрастанию" };
            string[] filtr = { "Все производители", "Aquatech", "Balsax", "Gamma", "Kuusamo", "LumiCom", "Momoi", "SevereLand", "Stinger", "Ultron",  "Usami", "Westin" };

            comboBoxSortV.Items.AddRange(sort);
            comboBoxFilter.Items.AddRange(filtr);

            scrollVal = 0;
            dataGridSpisokTovarov.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSpisokTovarov.AllowUserToAddRows = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql1, connection);
            labelMaxItem.Text = command.ExecuteScalar().ToString();
            maxItem = Convert.ToInt32(command.ExecuteScalar());


            pagingAdapter = new SqlDataAdapter(sql, connection);
            pagingDS = new DataSet();

            pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "Authors_table");

            dataGridSpisokTovarov.DataSource = pagingDS;
            dataGridSpisokTovarov.DataMember = "Authors_table";

            connection.Close();
        }

        public void Create()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            sql = "select [Артикул], [Наименование], [Стоимость], [Производитель], [Описание], [Кол-во на складе], [Изображение] from Товары";
            if ((comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители") || textBoxSearch.Text != "")
                sql += " WHERE ";
            sql += sqlFiltr;
            if (comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители" && textBoxSearch.Text != "")
                sql += " AND ";
            sql += sqlSearch;
            sql += sqlSortV;

            pagingAdapter = new SqlDataAdapter(sql, connection);
            pagingDS = new DataSet();
            connection.Open();
            pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "Authors_table");

            dataGridSpisokTovarov.DataSource = pagingDS;
            dataGridSpisokTovarov.DataMember = "Authors_table";
            scrollVal = 0;

            connection.Close();
        }
        public void Max()
        {
            sql1 = "select count(ID) from Товары";
            if ((comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители") || textBoxSearch.Text != "")
                sql1 += " WHERE ";
            sql1 += sqlFiltrMax;
            if (comboBoxFilter.Text != "" && comboBoxFilter.Text != "Все производители" && textBoxSearch.Text != "")
                sql1 += " AND ";
            sql1 += sqlSearchMax;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql1, connection);
            labelNowItem.Text = command.ExecuteScalar().ToString();
            maxItem = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal - pageSize;
            if (scrollVal <= 0)
            {
                scrollVal = 0;
            }
            pagingDS.Clear();
            pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "authors_table");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            scrollVal = scrollVal + pageSize;
            if (scrollVal >= maxItem)
            {
                scrollVal = maxItem - pageSize;
            }
            else
            {
                pagingDS.Clear();
                pagingAdapter.Fill(pagingDS, scrollVal, pageSize, "authors_table");
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxFilter.Text == "Aquatech")
            {
                sqlFiltr = "[Производитель]='Aquatech'";
                sqlFiltrMax = "[Производитель]='Aquatech'";
            }
            else if (comboBoxFilter.Text == "Balsax")
            {
                sqlFiltr = "[Производитель]='Balsax'";
                sqlFiltrMax = "[Производитель]='Balsax'";
            }
            else if (comboBoxFilter.Text == "Gamma")
            {
                sqlFiltr = "[Производитель]='Gamma'";
                sqlFiltrMax = "[Производитель]='Gamma'";
            }
            else if (comboBoxFilter.Text == "Kuusamo")
            {
                sqlFiltr = "[Производитель]='Kuusamo'";
                sqlFiltrMax = "[Производитель]='Kuusamo'";
            }
            else if (comboBoxFilter.Text == "LumiCom")
            {
                sqlFiltr = "[Производитель]='LumiCom'";
                sqlFiltrMax = "[Производитель]='LumiCom'";
            }
            else if (comboBoxFilter.Text == "Momoi")
            {
                sqlFiltr = "[Производитель]='Momoi'";
                sqlFiltrMax = "[Производитель]='Momoi'";
            }
            else if (comboBoxFilter.Text == "SevereLand")
            {
                sqlFiltr = "[Производитель]='SevereLand'";
                sqlFiltrMax = "[Производитель]='SevereLand'";
            }
            else if (comboBoxFilter.Text == "Stinger")
            {
                sqlFiltr = "[Производитель]='Stinger'";
                sqlFiltrMax = "[Производитель]='Stinger'";
            }
            else if (comboBoxFilter.Text == "Ultron")
            {
                sqlFiltr = "[Производитель]='Ultron'";
                sqlFiltrMax = "[Производитель]='Ultron'";
            }
            else if (comboBoxFilter.Text == "Usami")
            {
                sqlFiltr = "[Производитель]='Usami'";
                sqlFiltrMax = "[Производитель]='Usami'";
            }
            else if (comboBoxFilter.Text == "Westin")
            {
                sqlFiltr = "[Производитель]='Westin'";
                sqlFiltrMax = "[Производитель]='Westin'";
            }
            else
            {
                sqlFiltr = "";
                sqlFiltrMax = "";
            }

            Max();
            Create();
        }

 

        private void comboBoxSortV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSortV.Text == "По убыванию")
            {
                sqlSortV = "order by Стоимость DESC";
            }
            else if (comboBoxSortV.Text == "По возрастанию")
            {
                sqlSortV = "order by Стоимость ASC";
            }

            Create();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            sqlSearch = String.Format("[Наименование] like '{0}%'", textBoxSearch.Text);
            sqlSearchMax = String.Format("[Наименование] like '{0}%'", textBoxSearch.Text);
            if (textBoxSearch.Text == "")
            {
                sqlSearch = "";
                sqlSearchMax = "";
            }
            Max();
            Create();
        }

        private void dataGridMaterial_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            for (int i = 0; i < dataGridSpisokTovarov.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridSpisokTovarov[5, i].Value) < 0)
                    dataGridSpisokTovarov.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
            }
        }
    }
}
