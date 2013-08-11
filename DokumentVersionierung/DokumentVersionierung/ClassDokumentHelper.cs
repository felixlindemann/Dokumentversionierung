using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.IO;
using System.Windows.Forms;

namespace DokumentVersionierung
{
    class ClassDokumentHelper
    {

        #region Init

        public ClassDokumentHelper()
        {
            init();
        }

        public ClassDokumentHelper(Document doc)
        {
            this.doc = doc;
            init();
        }

        private void init()
        {
            Revision = 0;
            Version = 0;
            Build = 0;
            String value = ReadDocumentProperty("Revision");
            if (value == null) { Revision = 0; } else { Revision = int.Parse(value); }
            value = ReadDocumentProperty("Version");
            if (value == null) { Version = 0; } else { Version = int.Parse(value); }
            value = ReadDocumentProperty("Build");
            if (value == null) { Build = 0; } else { Build = int.Parse(value); }
            value = ReadDocumentProperty("DocTitle");
            if (value == null) { DocTitle = "Neues Doc"; } else { DocTitle = value; }


        }

        #endregion

        #region Properties

        private Boolean Saving = false;

        public int Revision { get; set; }
        public int Version { get; set; }
        public int Build { get; set; }
        public String DocTitle { get; set; }
        private Document doc;

        #endregion

        #region Functions

        private Document getDoc()
        {
            if (this.doc == null) { this.doc = Globals.ThisAddIn.Application.ActiveDocument; }
            return doc;
        }

        private string ReadDocumentProperty(string propertyName)
        {
            Microsoft.Office.Core.DocumentProperties properties;
            Document doc = this.getDoc();
            properties = (Microsoft.Office.Core.DocumentProperties)
                 doc.CustomDocumentProperties;
            if (properties.Cast<DocumentProperty>().Where(c => c.Name == propertyName).Count() > 0)
                return properties[propertyName].Value.ToString();


            return null;
        }

        #endregion

        #region voids

        private void WriteDocumentProperty(string propertyName, string value)
        {
            Microsoft.Office.Core.DocumentProperties properties;
            Document doc = this.getDoc();
            properties = (Microsoft.Office.Core.DocumentProperties)
                 doc.CustomDocumentProperties;
            if (properties.Cast<DocumentProperty>().Where(c => c.Name == propertyName).Count() == 0)
                properties.Add(propertyName, false, MsoDocProperties.msoPropertyTypeString, Guid.NewGuid().ToString());
            properties[propertyName].Value = value;

        }
        private void writeProperties()
        {
            WriteDocumentProperty("Revision", Revision + "");
            WriteDocumentProperty("Version", Version + "");
            WriteDocumentProperty("Build", Build + "");
            WriteDocumentProperty("DocTitle", DocTitle + "");
        }
        public void RaiseRevision()
        {
            Console.WriteLine("RaiseRevision");
            this.Revision++;
            this.Version = 0;
            this.Build = 1;
            Save();
        }

        public void RaiseVersion()
        {
            Console.WriteLine("RaiseVersion");
            this.Version++;
            this.Build = 1;
            Save();
        }

        public void RaiseBuild()
        {
            Console.WriteLine("RaiseBuild");
            this.Build++;
            Save();
        }

        public void Save()
        {
            Saving = true;
            try
            {
                writeProperties();
                Document doc = getDoc();
                FileInfo f = new FileInfo(doc.FullName);
                String strFileName = String.Format(@"{0}\{1} - v.{2}.{3}.{4}.docx", f.Directory.FullName, DocTitle, Revision, Version, Build);

              
                object missing = System.Reflection.Missing.Value;
                object fileName = strFileName;
                object format = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault;

                doc.SaveAs(ref fileName, ref format, ref missing, ref missing,
                           ref missing, ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing, ref missing,
                           ref missing, ref missing, ref missing, ref missing);
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
                throw;
            }
            Saving = false;
        }

        #endregion


    }

}
