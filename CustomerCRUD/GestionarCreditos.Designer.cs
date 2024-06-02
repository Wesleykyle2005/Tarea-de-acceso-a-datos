namespace CustomerCRUD
{
    partial class GestionarCreditos
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
            btnDelete = new Button();
            ActualizarBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            dgvDatos = new DataGridView();
            label4 = new Label();
            Customercb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(35, 35, 35);
            btnDelete.Location = new Point(27, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ActualizarBtn
            // 
            ActualizarBtn.FlatStyle = FlatStyle.Flat;
            ActualizarBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            ActualizarBtn.ForeColor = Color.FromArgb(35, 35, 35);
            ActualizarBtn.Location = new Point(137, 177);
            ActualizarBtn.Name = "ActualizarBtn";
            ActualizarBtn.Size = new Size(100, 40);
            ActualizarBtn.TabIndex = 32;
            ActualizarBtn.Text = "Actualizar ";
            ActualizarBtn.UseVisualStyleBackColor = true;
            ActualizarBtn.Click += ActualizarBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            EditBtn.ForeColor = Color.FromArgb(35, 35, 35);
            EditBtn.Location = new Point(137, 132);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(100, 39);
            EditBtn.TabIndex = 31;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            AddBtn.ForeColor = Color.FromArgb(35, 35, 35);
            AddBtn.Location = new Point(27, 132);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 39);
            AddBtn.TabIndex = 30;
            AddBtn.Text = "Añadir";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(35, 35, 35);
            label3.Location = new Point(37, 89);
            label3.Name = "label3";
            label3.Size = new Size(0, 16);
            label3.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(35, 35, 35);
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 28;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(35, 35, 35);
            label1.Location = new Point(37, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            txtName.Location = new Point(137, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 21);
            txtName.TabIndex = 26;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            txtLastName.Location = new Point(137, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 21);
            txtLastName.TabIndex = 25;
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDatos.BackgroundColor = Color.FromArgb(206, 206, 206);
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(206, 206, 206);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            dgvDatos.Location = new Point(0, 223);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(290, 227);
            dgvDatos.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(35, 35, 35);
            label4.Location = new Point(27, 9);
            label4.Name = "label4";
            label4.Size = new Size(105, 16);
            label4.TabIndex = 34;
            label4.Text = "Id del cliente";
            // 
            // Customercb
            // 
            Customercb.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            Customercb.FormattingEnabled = true;
            Customercb.Location = new Point(137, 9);
            Customercb.Name = "Customercb";
            Customercb.Size = new Size(100, 24);
            Customercb.TabIndex = 35;
            // 
            // GestionarCreditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 450);
            Controls.Add(Customercb);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(ActualizarBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtLastName);
            Controls.Add(dgvDatos);
            Name = "GestionarCreditos";
            Text = "Gestionar_Créditos";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button ActualizarBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtLastName;
        private DataGridView dgvDatos;
        private Label label4;
        private ComboBox Customercb;
    }
}