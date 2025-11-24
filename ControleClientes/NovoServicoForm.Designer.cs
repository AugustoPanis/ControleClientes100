namespace ControleClientes
{
    partial class Cadast
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
            comboBoxTipo = new ComboBox();
            buttonCancelTipo = new Button();
            buttonSalvarTipo = new Button();
            buttonExcluirTipo = new Button();
            textBoxValor = new TextBox();
            labelValor = new Label();
            labelTipo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(242, 153);
            comboBoxTipo.Margin = new Padding(3, 2, 3, 2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(141, 23);
            comboBoxTipo.TabIndex = 0;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // buttonCancelTipo
            // 
            buttonCancelTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelTipo.Location = new Point(518, 314);
            buttonCancelTipo.Name = "buttonCancelTipo";
            buttonCancelTipo.Size = new Size(84, 23);
            buttonCancelTipo.TabIndex = 3;
            buttonCancelTipo.Text = "Cancelar";
            buttonCancelTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelTipo.UseVisualStyleBackColor = true;
            buttonCancelTipo.Click += buttonCancelTipo_Click;
            // 
            // buttonSalvarTipo
            // 
            buttonSalvarTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalvarTipo.Location = new Point(608, 314);
            buttonSalvarTipo.Name = "buttonSalvarTipo";
            buttonSalvarTipo.Size = new Size(90, 23);
            buttonSalvarTipo.TabIndex = 2;
            buttonSalvarTipo.Text = "Salvar";
            buttonSalvarTipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalvarTipo.UseVisualStyleBackColor = true;
            buttonSalvarTipo.Click += buttonSalvarTipo_Click;
            // 
            // buttonExcluirTipo
            // 
            buttonExcluirTipo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcluirTipo.Location = new Point(0, 314);
            buttonExcluirTipo.Name = "buttonExcluirTipo";
            buttonExcluirTipo.Size = new Size(66, 23);
            buttonExcluirTipo.TabIndex = 4;
            buttonExcluirTipo.Text = "Excluir";
            buttonExcluirTipo.UseVisualStyleBackColor = true;
            buttonExcluirTipo.Click += buttonExcluirTipo_Click;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(242, 212);
            textBoxValor.Margin = new Padding(3, 2, 3, 2);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(141, 23);
            textBoxValor.TabIndex = 1;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelValor.Location = new Point(279, 185);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(56, 25);
            labelValor.TabIndex = 22;
            labelValor.Text = "Valor";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(242, 126);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(141, 25);
            labelTipo.TabIndex = 21;
            labelTipo.Text = "Tipo de Serviço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 71);
            label1.Name = "label1";
            label1.Size = new Size(222, 37);
            label1.TabIndex = 23;
            label1.Text = "Cadastrar Serviço";
            // 
            // Cadast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(700, 339);
            Controls.Add(label1);
            Controls.Add(comboBoxTipo);
            Controls.Add(buttonCancelTipo);
            Controls.Add(buttonSalvarTipo);
            Controls.Add(buttonExcluirTipo);
            Controls.Add(textBoxValor);
            Controls.Add(labelValor);
            Controls.Add(labelTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Cadast";
            Text = "Cadastrar Serviço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipo;
        private Button buttonCancelTipo;
        private Button buttonSalvarTipo;
        private Button buttonExcluirTipo;
        private TextBox textBoxValor;
        private Label labelValor;
        private Label labelTipo;
        private Label label1;
    }
}