using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StreamingDB
{
    public class XML
    {
        private string xmlPath;

        public XML(string xmlPath)
        {
            this.xmlPath = xmlPath;
        }

        public void OpenXml()
        {
            try
            {
                if (System.IO.File.Exists(xmlPath))
                {
                    Process.Start(new ProcessStartInfo {
                        FileName = xmlPath,
                        UseShellExecute= true
                    });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
