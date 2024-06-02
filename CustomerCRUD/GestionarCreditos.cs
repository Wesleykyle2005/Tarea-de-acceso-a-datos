using SharedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCRUD
{
    public partial class GestionarCreditos : Form
    {
        private readonly CreditRiskRepository _creditRiskRepository;
        private readonly CustomersRepository _customersRepository;
        public GestionarCreditos()
        {
            _creditRiskRepository = new CreditRiskRepository();
            _customersRepository = new CustomersRepository();
            InitializeComponent();
            Actualizar();
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            Customercb.DataSource = _customersRepository.GetAll().ToList();
            Customercb.DisplayMember = "CustomerId";
            Customercb.ValueMember = "Id";

        }

        private void Actualizar()
        {

            try
            {
                dgvDatos.DataSource = _creditRiskRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !String.IsNullOrEmpty(txtName.Text)
                    && !String.IsNullOrEmpty(txtLastName.Text)
                   )
                {
                    _creditRiskRepository.Insert(new CreditRisks()
                    {
                        CustomerId = (int)Customercb.SelectedValue,
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                    });
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    dgvDatos.SelectedRows.Count > 0
                    && dgvDatos.SelectedRows[0].Cells[0].Value != null
                    && !String.IsNullOrEmpty(Customercb.Text)
                    && !String.IsNullOrEmpty(txtName.Text)
                    && !String.IsNullOrEmpty(txtLastName.Text)
                    )
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                    CreditRisks creditRisks = new CreditRisks
                    {
                        Id = id,
                        CustomerId =(int)Customercb.SelectedValue,
                        FirstName = txtName.Text,
                        LastName = txtLastName.Text,
                    };
                    _creditRiskRepository.Update(creditRisks);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.SelectedRows.Count > 0
                    && dgvDatos.SelectedRows[0].Cells[0].Value != null
                    )
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                    _creditRiskRepository.Delete(id);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
