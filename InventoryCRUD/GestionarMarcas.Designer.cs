namespace InventoryCRUD
{
    partial class GestionarMarcas
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
            actualizarButton = new Button();
            dgvDatos = new DataGridView();
            txtName = new TextBox();
            AddButton = new Button();
            Nombre = new Label();
            deleteBtn = new Button();
            editBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // actualizarButton
            // 
            actualizarButton.FlatStyle = FlatStyle.Flat;
            actualizarButton.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            actualizarButton.ForeColor = Color.FromArgb(35, 35, 35);
            actualizarButton.Location = new Point(125, 75);
            actualizarButton.Name = "actualizarButton";
            actualizarButton.Size = new Size(97, 35);
            actualizarButton.TabIndex = 0;
            actualizarButton.Text = "Actualizar";
            actualizarButton.UseVisualStyleBackColor = true;
            actualizarButton.Click += actualizarButton_Click;
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
            dgvDatos.Location = new Point(0, 196);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(234, 165);
            dgvDatos.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            txtName.Location = new Point(103, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(75, 21);
            txtName.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            AddButton.ForeColor = Color.FromArgb(35, 35, 35);
            AddButton.Location = new Point(25, 75);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 35);
            AddButton.TabIndex = 4;
            AddButton.Text = "Agregar";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.ForeColor = Color.FromArgb(35, 35, 35);
            Nombre.Location = new Point(25, 32);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(49, 16);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // deleteBtn
            // 
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.FromArgb(35, 35, 35);
            deleteBtn.Location = new Point(25, 125);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 35);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Eliminar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold);
            editBtn.ForeColor = Color.FromArgb(35, 35, 35);
            editBtn.Location = new Point(125, 125);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(97, 35);
            editBtn.TabIndex = 7;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // GestionarMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(206, 206, 206);
            ClientSize = new Size(234, 361);
            Controls.Add(editBtn);
            Controls.Add(deleteBtn);
            Controls.Add(Nombre);
            Controls.Add(AddButton);
            Controls.Add(txtName);
            Controls.Add(dgvDatos);
            Controls.Add(actualizarButton);
            MaximizeBox = false;
            Name = "GestionarMarcas";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button actualizarButton;
        private DataGridView dgvDatos;
        private TextBox txtName;
        private Button AddButton;
        private Label Nombre;
        private Button deleteBtn;
        private Button editBtn;
    }
}