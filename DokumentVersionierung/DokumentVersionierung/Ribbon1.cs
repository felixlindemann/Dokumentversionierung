using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace DokumentVersionierung
{
    public partial class Ribbon1
    {

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                FormDokumentInfo frm = new FormDokumentInfo();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private Document getDoc()
        {
            return Globals.ThisAddIn.Application.ActiveDocument;
        }

        private ClassDokumentHelper getDocHelper()
        {
            return new ClassDokumentHelper(Globals.ThisAddIn.Application.ActiveDocument);
        }

        private void buttonRaiseBuild_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseBuild();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRaiseVer_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseVersion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRaiseRev_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseRevision();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseRevision();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRaiseBulild2_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseBuild();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRaiseVer2_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                getDocHelper().RaiseVersion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonMarkExtraDocument_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdBrightGreen);
        }

        private void buttonRemoveMarker_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdNoHighlight);
        }

        private void buttonWrong_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdRed);
        }

        private void buttonEdit_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdYellow);
        }

        private void buttonDoubleCheck_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdPink);
        }

        private void markAsSelection(WdColorIndex color)
        {
            try
            {
                Globals.ThisAddIn.Application.Selection.Range.HighlightColorIndex = color;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler beim Setzen einer Markierung");
            }

        }

        private void buttonNoAddValue_Click(object sender, RibbonControlEventArgs e)
        {
            markAsSelection(WdColorIndex.wdTurquoise);
        }
    }
}
