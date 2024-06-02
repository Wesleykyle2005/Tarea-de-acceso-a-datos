namespace InventoryCRUD
{
    partial class Principal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvDatos = new DataGridView();
            btnGestionarMarcas = new Button();
            txtPetName = new TextBox();
            txtColor = new TextBox();
            Makescb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddBtn = new Button();
            EditBtn = new Button();
            ActualizarBtn = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.FromArgb(206, 206, 206);
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(206, 206, 206);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(206, 206, 206);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(206, 206, 206);
            dataGridViewCellStyle2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.FromArgb(206, 206, 206);
            dgvDatos.Location = new Point(0, 211);
            dgvDatos.Margin = new Padding(0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(484, 250);
            dgvDatos.TabIndex = 0;
            // 
            // btnGestionarMarcas
            // 
            btnGestionarMarcas.FlatStyle = FlatStyle.Flat;
            btnGestionarMarcas.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            btnGestionarMarcas.ForeColor = Color.FromArgb(35, 35, 35);
            btnGestionarMarcas.Location = new Point(346, 60);
            btnGestionarMarcas.Name = "btnGestionarMarcas";
            btnGestionarMarcas.Size = new Size(100, 50);
            btnGestionarMarcas.TabIndex = 1;
            btnGestionarMarcas.Text = "Gestionar marcas";
            btnGestionarMarcas.UseVisualStyleBackColor = true;
            btnGestionarMarcas.Click += btnGestionarMarcas_Click;
            // 
            // txtPetName
            // 
            txtPetName.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            txtPetName.Location = new Point(155, 75);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 21);
            txtPetName.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            txtColor.Location = new Point(155, 115);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 21);
            txtColor.TabIndex = 3;
            // 
            // Makescb
            // 
            Makescb.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            Makescb.FormattingEnabled = true;
            Makescb.Location = new Point(155, 38);
            Makescb.Name = "Makescb";
            Makescb.Size = new Size(100, 24);
            Makescb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(35, 35, 35);
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 5;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(35, 35, 35);
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 6;
            label2.Text = "PetColor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(35, 35, 35);
            label3.Location = new Point(35, 123);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 7;
            label3.Text = "Color";
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            AddBtn.ForeColor = Color.FromArgb(35, 35, 35);
            AddBtn.Location = new Point(25, 166);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 35);
            AddBtn.TabIndex = 8;
            AddBtn.Text = "Añadir Autos";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            EditBtn.ForeColor = Color.FromArgb(35, 35, 35);
            EditBtn.Location = new Point(135, 166);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(100, 35);
            EditBtn.TabIndex = 9;
            EditBtn.Text = "Editar Auto";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // ActualizarBtn
            // 
            ActualizarBtn.FlatStyle = FlatStyle.Flat;
            ActualizarBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            ActualizarBtn.ForeColor = Color.FromArgb(35, 35, 35);
            ActualizarBtn.Location = new Point(245, 166);
            ActualizarBtn.Name = "ActualizarBtn";
            ActualizarBtn.Size = new Size(100, 35);
            ActualizarBtn.TabIndex = 10;
            ActualizarBtn.Text = "Actualizar";
            ActualizarBtn.UseVisualStyleBackColor = true;
            ActualizarBtn.Click += ActualizarBtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(35, 35, 35);
            btnDelete.Location = new Point(355, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Eliminar Autos";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Principal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(206, 206, 206);
            ClientSize = new Size(484, 461);
            Controls.Add(btnDelete);
            Controls.Add(ActualizarBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Makescb);
            Controls.Add(txtColor);
            Controls.Add(txtPetName);
            Controls.Add(btnGestionarMarcas);
            Controls.Add(dgvDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnGestionarMarcas;
        private TextBox txtPetName;
        private TextBox txtColor;
        private ComboBox Makescb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddBtn;
        private Button EditBtn;
        private Button ActualizarBtn;
        private Button btnDelete;
    }
}