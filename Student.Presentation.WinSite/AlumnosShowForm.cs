using log4net;
using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Log;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.Common.Logic.Resources;

namespace Student.Presentation.WinSite
{
    public partial class AlumnosShowForm : Form
    {
        private IStudentBL IStudentBl = new StudentBL();
        public static readonly ILogger Log = new Logger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public AlumnosShowForm()
        {
            try
            {
                InitializeComponent();
                ChangeLanguage();
                DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Txt);
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IStudentBl.LoadDates();
                DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Txt);
                FormatUtil.ChangeFormat("Txt");
                MessageBox.Show($"Archivo de registro seleccionado {FormatUtil.Format()}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError(ex.Message);
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError(ex.Message);
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }

        }

        private void BtnJso_Click(object sender, EventArgs e)
        {

            try
            {
                DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Json);
                FormatUtil.ChangeFormat("Json");
                MessageBox.Show($"Archivo de registro seleccionado {FormatUtil.Format()}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            try
            {
                DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Xml);
                FormatUtil.ChangeFormat("Xml");
                MessageBox.Show($"Archivo de registro seleccionado {FormatUtil.Format()}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string format = FormatUtil.Format();
                if (CBoxSelect.SelectedIndex != -1)
                {
                    DataGrid.DataSource = IStudentBl.GetSelect((TypeFormat)Enum.Parse(typeof(TypeFormat), format), textValue.Text, (Campo)Enum.Parse(typeof(Campo), CBoxSelect.Text));
                }
                else
                {
                    MessageBox.Show("Elige un campo");

                    DataGrid.DataSource = IStudentBl.GetAll((TypeFormat)Enum.Parse(typeof(TypeFormat), format));
                }
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }

        }
        private void MessageError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSql_Click(object sender, EventArgs e)
        {
            try
            {
                DataGrid.DataSource = IStudentBl.GetAll(TypeFormat.Spl);
                FormatUtil.ChangeFormat("Sql");
                MessageBox.Show($"Archivo de registro seleccionado {FormatUtil.Format()}", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (ArgumentNullException ex)
            {
                MessageError("Problema interno");
                Log.Error(ex);
            }
            catch (FileNotFoundException ex)
            {
                MessageError("Fallo en el registro , archivo no encontrado");
                Log.Error(ex);
            }
            catch (FileLoadException ex)
            {
                MessageError("Fallo en el registro , no se pudo cargar el archivo");
                Log.Error(ex);
            }
            catch (FormatException ex)
            {
                MessageError("Los datos introducidos no tienen el formato correcto");
                Log.Error(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageError("No se tiene autarizacion para escribir en el archivo");
                Log.Error(ex);
            }
        }
        private void ChangeLanguage()
        {
            menuToolStripMenuItem.Text = Language.menuToolStripMenuItem;
            registroToolStripMenuItem.Text = Language.registroToolStripMenuItem;
            lblValor.Text = Language.lblValor;
            lblCampo.Text = Language.lblCampo;
            BtnFiltrar.Text = Language.BtnFiltrar;
            BtnSql.Text = Language.BtnSql;

        }

    }
}
