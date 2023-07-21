namespace Aula10estacionamento
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_contador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_veiculos = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_estacionar = new System.Windows.Forms.Button();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox2.Controls.Add(this.lbl_contador);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.list_veiculos);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(416, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista do estacionamento";
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Location = new System.Drawing.Point(85, 19);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(17, 19);
            this.lbl_contador.TabIndex = 2;
            this.lbl_contador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "veiculos";
            // 
            // list_veiculos
            // 
            this.list_veiculos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list_veiculos.Location = new System.Drawing.Point(20, 37);
            this.list_veiculos.Name = "list_veiculos";
            this.list_veiculos.Size = new System.Drawing.Size(197, 121);
            this.list_veiculos.TabIndex = 0;
            this.list_veiculos.UseCompatibleStateImageBehavior = false;
            this.list_veiculos.View = System.Windows.Forms.View.List;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(346, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 173);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.btn_fechar);
            this.groupBox1.Controls.Add(this.btn_retirar);
            this.groupBox1.Controls.Add(this.btn_estacionar);
            this.groupBox1.Controls.Add(this.txt_Placa);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(45, 119);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(173, 27);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "fechar o estacionamento";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(165, 69);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(75, 23);
            this.btn_retirar.TabIndex = 2;
            this.btn_retirar.Text = "retirar";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_estacionar
            // 
            this.btn_estacionar.Location = new System.Drawing.Point(26, 69);
            this.btn_estacionar.Name = "btn_estacionar";
            this.btn_estacionar.Size = new System.Drawing.Size(75, 23);
            this.btn_estacionar.TabIndex = 1;
            this.btn_estacionar.Text = "estacionar";
            this.btn_estacionar.UseVisualStyleBackColor = true;
            this.btn_estacionar.Click += new System.EventHandler(this.btn_estacionar_Click);
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(26, 40);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(214, 26);
            this.txt_Placa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(36, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 171);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 236);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private ListView list_veiculos;
        private Label lbl_contador;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button btn_fechar;
        private Button btn_retirar;
        private Button btn_estacionar;
        private TextBox txt_Placa;
        private Panel panel1;
    }
}