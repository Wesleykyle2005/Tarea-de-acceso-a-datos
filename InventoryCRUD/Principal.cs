using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SharedModels;

namespace InventoryCRUD
{
    public partial class Principal : Form
    {
        private readonly InventoryRepository _inventoryRepository;
        private readonly MakesRepository _makesRepository;
        public Principal()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _inventoryRepository = new InventoryRepository(connectionString);
            _makesRepository = new MakesRepository(connectionString);
            Actualizar();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            List<Makes> make = _makesRepository.GetAll().ToList();
            Makescb.DataSource = make;
            Makescb.DisplayMember = "Name";
            Makescb.ValueMember = "Id";
        }

        private void Actualizar()
        {
            try
            {
                dgvDatos.DataSource = _inventoryRepository.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionarMarcas_Click(object sender, EventArgs e)
        {
            GestionarMarcas gestionarMarcas = new GestionarMarcas();
            gestionarMarcas.ShowDialog();
            CargarMarcas();       
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            Actualizar();
            CargarMarcas();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !String.IsNullOrEmpty(txtPetName.Text)
                    && !String.IsNullOrEmpty(txtColor.Text)
                    && !String.IsNullOrEmpty(Makescb.Text))
                {
                    _inventoryRepository.Insert(new Inventory()
                    {
                        MakeId = (int)Makescb.SelectedValue,
                        PetName = txtPetName.Text,
                        Color = txtColor.Text,
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
                    && !String.IsNullOrEmpty(Makescb.Text)
                    && !String.IsNullOrEmpty(txtPetName.Text)
                    && !String.IsNullOrEmpty(txtColor.Text)
                    )
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                    Inventory inventory = new Inventory
                    {
                        Id = id,
                        MakeId = (int)Makescb.SelectedValue,
                        PetName = txtPetName.Text,
                        Color = txtColor.Text,
                    };
                    _inventoryRepository.Update(inventory);
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
                    _inventoryRepository.Delete(id);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
