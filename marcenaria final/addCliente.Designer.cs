namespace marcenaria_final
{
    partial class addCliente
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
            this.btnADD = new System.Windows.Forms.Button();
            this.cbPagas = new System.Windows.Forms.ComboBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParcelas = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.idl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnADD.Location = new System.Drawing.Point(126, 507);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(230, 54);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Adicionar";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbPagas
            // 
            this.cbPagas.FormattingEnabled = true;
            this.cbPagas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbPagas.Location = new System.Drawing.Point(492, 244);
            this.cbPagas.Name = "cbPagas";
            this.cbPagas.Size = new System.Drawing.Size(121, 23);
            this.cbPagas.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(452, 300);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(221, 23);
            this.Data.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 23);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // cbParcelas
            // 
            this.cbParcelas.FormattingEnabled = true;
            this.cbParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbParcelas.Location = new System.Drawing.Point(492, 201);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(121, 23);
            this.cbParcelas.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(126, 195);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 23);
            this.txtTel.TabIndex = 6;
            // 
            // txtNF
            // 
            this.txtNF.Location = new System.Drawing.Point(126, 249);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(230, 23);
            this.txtNF.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(126, 305);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(230, 23);
            this.txtValor.TabIndex = 8;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(126, 358);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(230, 23);
            this.txtEntrada.TabIndex = 9;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(126, 413);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(230, 23);
            this.txtDespesas.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nota Fiscal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Despesas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parcelas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pagas";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(452, 387);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(305, 185);
            this.txtDesc.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descrição";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(48, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(322, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "Adicionar Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::marcenaria_final.Properties.Resources.teste;
            this.pictureBox1.Location = new System.Drawing.Point(524, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.Location = new System.Drawing.Point(126, 507);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 54);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(126, 101);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 23);
            this.ID.TabIndex = 23;
            this.ID.Visible = false;
            // 
            // idl
            // 
            this.idl.AutoSize = true;
            this.idl.Enabled = false;
            this.idl.Location = new System.Drawing.Point(48, 101);
            this.idl.Name = "idl";
            this.idl.Size = new System.Drawing.Size(18, 15);
            this.idl.TabIndex = 24;
            this.idl.Text = "ID";
            this.idl.Visible = false;
            this.idl.Click += new System.EventHandler(this.label11_Click);
            // 
            // addCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 648);
            this.Controls.Add(this.idl);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cbParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.cbPagas);
            this.Controls.Add(this.btnADD);
            this.Name = "addCliente";
            this.Text = "addCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        public Label label10;
        public Button btnADD;
        public ComboBox cbPagas;
        public DateTimePicker Data;
        public TextBox txtName;
        public ComboBox cbParcelas;
        public TextBox txtTel;
        public TextBox txtNF;
        public TextBox txtValor;
        public TextBox txtEntrada;
        public TextBox txtDespesas;
        public TextBox txtDesc;
        public Button btnAtualizar;
        public TextBox ID;
        public Label idl;
    }
}