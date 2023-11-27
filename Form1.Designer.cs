namespace U4_P1_Parte_2
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
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            txtMonto = new TextBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDeposito = new Button();
            btnRetiro = new Button();
            groupBox3 = new GroupBox();
            txtSaldo = new TextBox();
            btnNuevo = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ltsRetiros = new ListBox();
            lstDepositos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos";
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(417, 33);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(177, 34);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir Cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(122, 82);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(265, 31);
            txtMonto.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(122, 35);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(265, 31);
            txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Location = new Point(43, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacciones";
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(57, 52);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(234, 34);
            btnDeposito.TabIndex = 5;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnRetiro
            // 
            btnRetiro.Location = new Point(314, 52);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(234, 34);
            btnRetiro.TabIndex = 6;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(ltsRetiros);
            groupBox3.Controls.Add(lstDepositos);
            groupBox3.Location = new Point(43, 309);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(600, 250);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(448, 173);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(131, 31);
            txtSaldo.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(448, 210);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 34);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 145);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 8;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 37);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 7;
            label4.Text = "Retiros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 37);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 6;
            label3.Text = "Depositos";
            // 
            // ltsRetiros
            // 
            ltsRetiros.FormattingEnabled = true;
            ltsRetiros.ItemHeight = 25;
            ltsRetiros.Location = new Point(265, 65);
            ltsRetiros.Name = "ltsRetiros";
            ltsRetiros.Size = new Size(152, 179);
            ltsRetiros.TabIndex = 1;
            // 
            // lstDepositos
            // 
            lstDepositos.FormattingEnabled = true;
            lstDepositos.ItemHeight = 25;
            lstDepositos.Location = new Point(81, 65);
            lstDepositos.Name = "lstDepositos";
            lstDepositos.Size = new Size(152, 179);
            lstDepositos.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 571);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestion de cuenta de ahorros ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAbrir;
        private TextBox txtMonto;
        private TextBox txtCliente;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnDeposito;
        private Button btnRetiro;
        private TextBox txtSaldo;
        private Button btnNuevo;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListBox ltsRetiros;
        private ListBox lstDepositos;
    }
}