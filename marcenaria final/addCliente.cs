using marcenaria_final.classes;
using System.Data.SqlClient;

namespace marcenaria_final
{
    public partial class addCliente : Form
    {
        public addCliente()
        {
            InitializeComponent();
        }

        Banco banco = new Banco();



        // adicionando cliente
        public void btnAdicionar_Click(object sender, EventArgs e)
        {

            btnADD.Enabled = true;


            if (txtDesc.Text != "" && txtName.Text != "" && txtTel.Text != "" && txtNF.Text != "" &&
                txtValor.Text != "" && txtEntrada.Text != "" && txtDespesas.Text != "" && cbPagas.Text != "" &&
                cbParcelas.Text != "")
            {
                banco.con.Open();
                SqlCommand cmd = new SqlCommand("insert into clientes values(@nome,@numero,@nf," +
                "@valor,@entrada,@despesas,@parcelas,@pagas,@data,@descricao)", banco.con);
                cmd.Parameters.AddWithValue("@nome", txtName.Text);
                cmd.Parameters.AddWithValue("@numero", Int64.Parse(txtTel.Text));
                cmd.Parameters.AddWithValue("@nf", txtNF.Text);
                cmd.Parameters.AddWithValue("@valor", Int64.Parse(txtValor.Text));
                cmd.Parameters.AddWithValue("@entrada", Int64.Parse(txtEntrada.Text));
                cmd.Parameters.AddWithValue("@despesas", Int64.Parse(txtDespesas.Text));
                cmd.Parameters.AddWithValue("@parcelas", int.Parse(cbParcelas.Text));
                cmd.Parameters.AddWithValue("@pagas", int.Parse(cbPagas.Text));
                cmd.Parameters.AddWithValue("@data", Data.Value);
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);

                MessageBox.Show("adicionado");
                this.Close();
                cmd.ExecuteNonQuery();
                banco.con.Close();
            }

            else
            {
                MessageBox.Show("Adicionar todos os dados solicitados");
            }


        }


        //atualizando cliente
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;
            btnAtualizar.Visible = false;

            banco.con.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE clientes " +
                "SET nome=@nome, numero=@numero, nf=@nf, valor=@valor, entrada=@entrada, despesas=@despesas,parcelas=@parcelas,pagas=@pagas, data=@data, descricao=@descricao " +
                "WHERE id = '" + int.Parse(ID.Text) + "'", banco.con);
            cmd.Parameters.AddWithValue("@nome", txtName.Text);
            cmd.Parameters.AddWithValue("@numero", Int64.Parse(txtTel.Text));
            cmd.Parameters.AddWithValue("@nf", txtNF.Text);
            cmd.Parameters.AddWithValue("@valor", Int64.Parse(txtValor.Text));
            cmd.Parameters.AddWithValue("@entrada", Int64.Parse(txtEntrada.Text));
            cmd.Parameters.AddWithValue("@despesas", Int64.Parse(txtDespesas.Text));
            cmd.Parameters.AddWithValue("@parcelas", int.Parse(cbParcelas.Text));
            cmd.Parameters.AddWithValue("@pagas", int.Parse(cbPagas.Text));
            cmd.Parameters.AddWithValue("@data", Data.Value);
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);

            cmd.ExecuteNonQuery();
            banco.con.Close();

            MessageBox.Show("Atualizado");

            this.Close();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
