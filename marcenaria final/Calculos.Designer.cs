namespace marcenaria_final
{
    partial class Calculos
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
            this.data1 = new System.Windows.Forms.DateTimePicker();
            this.data2 = new System.Windows.Forms.DateTimePicker();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.CustomFormat = "yyyy/mm/dd";
            this.data1.Location = new System.Drawing.Point(38, 133);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(234, 23);
            this.data1.TabIndex = 0;
            this.data1.Value = new System.DateTime(2023, 1, 25, 0, 0, 0, 0);
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(38, 196);
            this.data2.Name = "data2";
            this.data2.Size = new System.Drawing.Size(234, 23);
            this.data2.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(171, 362);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(179, 56);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ate:";
            // 
            // txtGastos
            // 
            this.txtGastos.Location = new System.Drawing.Point(300, 196);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(234, 23);
            this.txtGastos.TabIndex = 5;
            // 
            // txtGanhos
            // 
            this.txtGanhos.Location = new System.Drawing.Point(300, 136);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(234, 23);
            this.txtGanhos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gastos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ganhos:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(143, 297);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(234, 23);
            this.txtResult.TabIndex = 9;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::marcenaria_final.Properties.Resources.teste;
            this.pictureBox1.Location = new System.Drawing.Point(694, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(107, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 50);
            this.label5.TabIndex = 23;
            this.label5.Text = "Calculo De Gastos e Renda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(568, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(359, 301);
            this.dataGridView1.TabIndex = 24;
            // 
            // Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.txtGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.Name = "Calculos";
            this.Text = "Calculos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker data1;
        private DateTimePicker data2;
        private Button btnCalc;
        private Label label1;
        private Label label2;
        private TextBox txtGastos;
        private TextBox txtGanhos;
        private Label label3;
        private Label label4;
        private TextBox txtResult;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dataGridView1;
    }
}