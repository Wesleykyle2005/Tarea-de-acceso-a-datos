using SharedModels;
namespace CustomerCRUD
{
    public partial class Principal : Form
    {

        private readonly CustomersRepository _customersRepository;
        public Principal()
        {
            _customersRepository = new CustomersRepository();
            InitializeComponent();
            ActualizarCustomers();
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            ActualizarCustomers();
        }

        private void ActualizarCustomers()
        {
            dgvDatos.DataSource = _customersRepository.GetAll();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
            };
            _customersRepository.Insert(customer);
            ActualizarCustomers();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0
                   && dgvDatos.SelectedRows[0].Cells[0].Value != null
                   && !String.IsNullOrEmpty(txtName.Text)
                   && !String.IsNullOrEmpty(txtLastName.Text)
                   )
            {
                Customer customer = new Customer
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                };
                _customersRepository.Update(customer);
                ActualizarCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0
                   && dgvDatos.SelectedRows[0].Cells[0].Value != null
             )
            {
                int id = (int)dgvDatos.SelectedRows[0].Cells[0].Value;
                _customersRepository.Delete(id);
                ActualizarCustomers();
            }
        }

        private void btnGestionarMarcas_Click(object sender, EventArgs e)
        {
            GestionarCreditos gestionarCreditos = new GestionarCreditos();
            gestionarCreditos.ShowDialog();
        }
    }
}
