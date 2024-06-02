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
using SharedModels;

namespace InventoryCRUD
{
    public partial class GestionarMarcas : Form
    {

        private readonly MakesRepository _makesRepository;
        public GestionarMarcas()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            _makesRepository = new MakesRepository(connectionString);
            Actualizar();

        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {             
               dgvDatos.DataSource = _makesRepository.GetAll();
            }
            catch (Exception ex)
            {         
                MessageBox.Show("Error al obtener los datos" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtName.Text))
                {
                    _makesRepository.Insert(new Makes()
                    {
                        Name = txtName.Text
                    });
                }
                else
                {
                    MessageBox.Show("No se admiten nombres en blanco" , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    dgvDatos.SelectedRows.Count > 0
                    && dgvDatos.SelectedRows[0].Cells[0].Value != null
                    )
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                    _makesRepository.Delete(id);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    dgvDatos.SelectedRows.Count > 0
                    && dgvDatos.SelectedRows[0].Cells[0].Value != null
                    && !String.IsNullOrEmpty(txtName.Text)
                    )
                {
                    int id = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
                    Makes make = new Makes{
                        Id = id,
                        Name = txtName.Text,
                    };

                    _makesRepository.Update(make);
                    Actualizar();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
