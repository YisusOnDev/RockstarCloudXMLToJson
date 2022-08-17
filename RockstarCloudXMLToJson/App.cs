using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;

namespace RockstarCloudXMLToFivemJSON
{
    public partial class App : Form
    {
        private List<String> xmlList;
        public App()
        {
            InitializeComponent();
        }

        private void openXMLbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            SetOpenXMLDialogSettings(openFileDialog1);
            openFileDialog1.ShowDialog();
            ConvertXMLToJSON(openFileDialog1.FileName);
        }
        private void saveJSONbtn_Click(object sender, EventArgs e)
        {
            String bigStr = "<GTARace>";
            if (xmlList != null && xmlList.Count > 0)
            {
                // Write big string with all xml data
                foreach (String text in xmlList)
                {
                    bigStr += text;
                }
                bigStr += "</GTARace>";

                // Convert XML to JSON and Save It
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(bigStr);
                String json = JsonConvert.SerializeXmlNode(doc);

                // Finally save usable file
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SetSaveJSONDialogSettings(SaveFileDialog1);
                
                if(SaveFileDialog1.ShowDialog() == DialogResult.OK) {
                    String savePath = SaveFileDialog1.FileName;
                    using (StreamWriter writer = new StreamWriter(savePath))
                    {
                        writer.WriteLine(json);
                        MessageBox.Show("File saved succesfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Error, the XML is not a valid GTA V Cloud XML file, please try another file.");
                }
            }
            else
            {
                MessageBox.Show("Error, the XML is not a valid GTA V Cloud XML file, please try another file.");
            }
        }

        private void SetSaveJSONDialogSettings(SaveFileDialog SaveFileDialog1)
        {
            SaveFileDialog1.Title = "Save Usable JSON File";
            SaveFileDialog1.InitialDirectory = @"C:\";
            SaveFileDialog1.DefaultExt = "json";
            SaveFileDialog1.Filter = "json files (*.json)|*.json";
            SaveFileDialog1.FilterIndex = 1;
            SaveFileDialog1.CheckPathExists = true;
            saveFileDialog1.RestoreDirectory = true;
        }

        private void SetOpenXMLDialogSettings(OpenFileDialog dialog)
        {
            dialog.Title = "Browse and select a valid XML GTA V Cloud File";
            dialog.DefaultExt = "xml";
            dialog.Filter = "xml files (*.xml)|*.xml";
            dialog.FilterIndex = 1;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
        }

        private void ConvertXMLToJSON(String fPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fPath);
            xmlList = new List<String>();
            XmlNodeList elemList = doc.GetElementsByTagName("SpoonerPlacements");
            Debug.WriteLine(elemList);
            for (int i = 0; i < elemList.Count; i++)
            {
                String toAdd = elemList[i].InnerXml;
                xmlList.Add(toAdd);
            }
        }
    }
}
