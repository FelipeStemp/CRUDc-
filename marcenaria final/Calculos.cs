using marcenaria_final.classes;
using System.Data;
using System.Data.SqlClient;

namespace marcenaria_final
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        Banco banco = new Banco();

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
        }


        //realizando calculo e carregando uma tabela entre datas do sql
        private void btnCalc_Click(object sender, EventArgs e)
        {

            //selecionando e abrindo grid
            banco.con.Open();

            string datap = data1.Value.Date.ToString("yyyy-MM-dd");
            string dataf = data2.Value.Date.ToString("yyyy-MM-dd");


            var sqlQuery = "SELECT valor, despesas, data FROM clientes WHERE data >= '" + datap + "' AND data<= '" + dataf + "'";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, banco.con))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            banco.con.Close();

            //calculos da grid

            decimal valorgastos = 0;
            decimal valorganho = 0;


            foreach (DataGridViewRow col in dataGridView1.Rows)
            {
                valorgastos = valorgastos + Convert.ToDecimal(col.Cells[1].Value);
                valorganho = valorganho + Convert.ToDecimal(col.Cells[0].Value);

            }

            decimal total = valorganho - valorgastos;

            txtGastos.Text = Convert.ToString(valorgastos);
            txtGanhos.Text = Convert.ToString(valorganho);
            txtResult.Text = Convert.ToString(total);
        }

    }

}
