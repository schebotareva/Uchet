using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace WindowsFormsApplication1
{
    public partial class fmClientList : Form
    {

        private DataSet dsClients = new DataSet();
        private DataTable dtClients = new DataTable();

        static string connstring = String.Format("Server={0};Port={1};" +
    "User Id={2};Password={3};Database={4};",
    "localhost",
    "5432",
    "postgres",
    "enterprisedb",
    "postgres");
        // Making connection with Npgsql provider
        NpgsqlConnection conn = new NpgsqlConnection(connstring);


        public fmClientList()
        {
            InitializeComponent();
            ShowClientsList();
        }



        private void ShowClientsList()
        {
            string clients = "SELECT c.id, f|| ' ' || i || ' ' || COALESCE(o,'') as fio, dg.name as gender, date_of_birth, phone, address, dsc FROM clients c LEFT JOIN dic_genders dg ON dg.id = c.r_dic_genders_id";
            NpgsqlDataAdapter daClients = new NpgsqlDataAdapter(clients, conn);
            dsClients.Reset();
            daClients.Fill(dsClients);
            dtClients = dsClients.Tables[0];

            
         //   dtClients.Columns["id"].Vi
            dtClients.Columns["fio"].ColumnName = "ФИО";
            dtClients.Columns["address"].ColumnName = "Адрес";
            dtClients.Columns["gender"].ColumnName = "Пол";
            dtClients.Columns["date_of_birth"].ColumnName = "Дата рождения";
            dtClients.Columns["phone"].ColumnName = "Телефон";
            dtClients.Columns["dsc"].ColumnName = "Комментарий";


            dataGridClients.DataSource = dtClients;
        }
        
        
        
        
        private void buSelectClient_Click(object sender, EventArgs e)
        {
            int selClient = Convert.ToInt32( dataGridClients.CurrentRow.Cells["id"].Value.ToString() );

            fmOrderCard order = (fmOrderCard)this.Owner;
            order.selClientId = selClient;
            
            
            order.lblFIO.Text = dataGridClients.CurrentRow.Cells["ФИО"].Value.ToString();




        }

        private void dataGridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        ////////////////////////////////////////////////////////////////////////////
        
         int selClient = Convert.ToInt32(dataGridClients.CurrentRow.Cells["id"].Value.ToString());

            fmOrderCard order = (fmOrderCard)this.Owner;
            order.selClientId = selClient;


            order.lblFIO.Text = dataGridClients.CurrentRow.Cells["ФИО"].Value.ToString();
            this.Close();


            ///////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
