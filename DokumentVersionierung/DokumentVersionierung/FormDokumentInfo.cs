using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace DokumentVersionierung
{
    public partial class FormDokumentInfo : Form
    {
         
        private ClassDokumentHelper DocHelper { get; set; }

        public FormDokumentInfo()
        {
            InitializeComponent();
            Init();
        }
         

        private void FormDokumentInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                DocHelper.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void Init()
        {
            DocHelper = new ClassDokumentHelper();
            this.classDokumentHelperBindingSource.DataSource = DocHelper;
        }


    }
}
