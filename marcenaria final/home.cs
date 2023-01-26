using marcenaria_final.classes;
using System.Data;
using System.Data.SqlClient;

namespace marcenaria_final
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        Banco banco = new Banco();

        addCliente add = new addCliente();


        //abertura de add cliente
        private void button1_Click(object sender, EventArgs e)
        {
            addCliente add = new addCliente();
            add.Show();

        }


        //buscando cliente e abrindo consulta
        private void button4_Click(object sender, EventArgs e)
        {



            if (consulta.Text != "")
            {

                banco.con.Open();

                SqlCommand cmd = new SqlCommand("SELECT id,nome,numero,nf,valor,entrada,despesas,parcelas,pagas,data,descricao FROM clientes WHERE id = '" + int.Parse(consulta.Text) + "'", banco.con);

                SqlDataReader dr = cmd.ExecuteReader();

                addCliente add = new addCliente();

                add.Show();
                add.label10.Text = "Atualizar Cliente";
                add.btnAtualizar.Enabled = true;
                add.btnAtualizar.Visible = true;
                add.btnADD.Enabled = false;
                add.btnADD.Visible = false;

                add.ID.Enabled = true;
                add.ID.Visible = true;
                add.idl.Enabled = true;
                add.idl.Visible = true;

                while (dr.Read())
                {
                    add.ID.Text = dr[0].ToString();
                    add.txtName.Text = dr[1].ToString();
                    add.txtTel.Text = dr[2].ToString();
                    add.txtNF.Text = dr[3].ToString();
                    add.txtValor.Text = dr[4].ToString();
                    add.txtEntrada.Text = dr[5].ToString();
                    add.txtDespesas.Text = dr[6].ToString();
                    add.cbParcelas.Text = dr[7].ToString();
                    add.cbPagas.Text = dr[8].ToString();
                    add.Data.Text = dr[9].ToString();
                    add.txtDesc.Text = dr[10].ToString();
                }

                banco.con.Close();

            }
            if (consulta.Text == "")
            {
                MessageBox.Show("Insira o id do cliente para pesquisar");
            }

        }


        //carregando data grid
        private void button2_Click(object sender, EventArgs e)
        {
            banco.con.Open();

            var sqlQuery = "SELECT * FROM clientes";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, banco.con))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    gridPrincipal.DataSource = dt;
                }
            }
            banco.con.Close();
        }


        //exportacao de arquivo excel
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (gridPrincipal.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                try
                {


                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < gridPrincipal.Columns.Count - 1; i++)
                    {
                        XcelApp.Cells[1, i] = gridPrincipal.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < gridPrincipal.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < gridPrincipal.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = gridPrincipal.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }


        //abertura da tela de calculo
        private void button3_Click(object sender, EventArgs e)
        {
            Calculos cal = new Calculos();

            cal.Show();
        }


        //Consulta por nome
        private void button5_Click(object sender, EventArgs e)
        {

            banco.con.Open();

            var sqlQuery = "SELECT * FROM clientes where nome = '" + consultaNome.Text + "'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, banco.con))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    gridPrincipal.DataSource = dt;
                }
            }
            banco.con.Close();

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
