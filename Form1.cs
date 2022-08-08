using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace XmlReader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var path = @"D:\Deneme.xml";
            List<Details> detailsList = new List<Details>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nodeList = doc.SelectNodes("/Invoice/InvoiceHeader");
            foreach (XmlNode node in nodeList)
            {
                // create details class for each InvoiceHeader
                Details detail = new Details();
                detail.Number = new List<string>();

                // loop over child nodes to get Name and all Number elements
                foreach (XmlNode child in node.ChildNodes)
                {
                    // check node name to decide how to handle the values               
                    if (child.Name == "Name")
                    {
                        detail.Name = child.InnerText;
                    }
                    else if (child.Name == "Number")
                    {
                        detail.Number.Add(child.InnerText);
                    }
                }
                detailsList.Add(detail);
            }
        }

        public class Details
        {
            public string Name { get; set; }
            public List<string> Number { get; set; }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //    var path = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul_Kisa_Doors.xml";
            //    List<Models.Doors> doorsList = new List<Models.Doors>();
            //    XmlDocument doc = new XmlDocument();
            //    doc.Load(path);
            //    XmlNodeList nodeList = doc.SelectNodes("/PROJECT/DOORS");
            //    foreach (XmlNode node in nodeList)
            //    {
            //        // create details class for each InvoiceHeader
            //        Models.Doors doors = new Models.Doors();


            //        // loop over child nodes to get Name and all Number elements
            //        foreach (XmlNode child in node.ChildNodes)
            //        {
            //            // check node name to decide how to handle the values               
            //            if (child.Name == "GROUP")
            //            {
            //                doors.Group = child.InnerText;
            //            }
            //            else if (child.Name == "CODE")
            //            {
            //                doors.Code = child.InnerText;
            //            }
            //            else if (child.Name == "TYPE")
            //            {
            //                doors.Type = child.InnerText;
            //            }
            //            else if (child.Name == "MODEL")
            //            {
            //                doors.Model = child.InnerText;
            //            }
            //            else if (child.Name == "MATERIAL")
            //            {
            //                doors.Material = child.InnerText;
            //            }
            //            else if (child.Name == "DIRECTION")
            //            {
            //                doors.Direction = child.InnerText;
            //            }
            //            else if (child.Name == "OPENDIRECTION")
            //            {
            //                doors.OpenDirection = child.InnerText;
            //            }
            //            else if (child.Name == "MODULPOSE" && child.InnerText != "")
            //            {
            //                doors.ModulePose = Convert.ToInt32(child.InnerText);
            //            }
            //            else if (child.Name == "BRAND")
            //            {
            //                doors.Brand = child.InnerText;
            //            }
            //            else if (child.Name == "MODUL")
            //            {
            //                doors.Modul = child.InnerText;
            //            }
            //            else if (child.Name == "H" && child.InnerText != "")
            //            {
            //                doors.H = Convert.ToInt32(child.InnerText);
            //            }
            //            else if (child.Name == "W" && child.InnerText != "")
            //            {
            //                doors.W = Convert.ToInt32(child.InnerText);
            //            }
            //            else if (child.Name == "MATROTA" && child.InnerText != "")
            //            {
            //                doors.MatRota = Convert.ToInt32(child.InnerText);
            //            }
            //            else if (child.Name == "QUANTITY" && child.InnerText != "")
            //            {
            //                doors.Quantity = Convert.ToDecimal(child.InnerText);
            //            }

            //        }
            //        doorsList.Add(doors);
            //}

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Models.Project project = new Models.Project();

            //foreach (var prop in project.GetType().GetProperties())
            //{
            //    MessageBox.Show(prop.Name.ToString());
            //}

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nodeList = doc.SelectNodes("/PROJECT/*");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\Deneme.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Models.Product>), new XmlRootAttribute("Products"));
            StreamReader stringReader = new StreamReader(path);

            List<Models.Product> productList = (List<Models.Product>)serializer.Deserialize(stringReader);

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            //var path = @"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\1-Modul_Kisa_Doors.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Models.DOORS>), new XmlRootAttribute("PROJECT"));
            StreamReader streamReader = new StreamReader(@"C:\Users\BitegKullanici1\Desktop\Adeko XML Örnek ve Açıklamaları\Örnek 1\Deneme2.xml");

            List<Models.DOORS> doorslist = (List<Models.DOORS>)serializer.Deserialize(streamReader);
        }
    }
}
