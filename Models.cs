using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Serialization;

namespace XmlReader2
{
    public class Models
    {
        public class Project
        {
            public string UNITS { get; set;}

            public string DOORS { get; set;}

            public string HANDLES { get; set;}

            public string WORKTOPS { get; set;}

            public string PLINTHS { get; set;}

            public string PLINTHSCORNERS { get; set; }

            public string PLINTHLEGS { get; set;}

            public string SEALS { get; set;}

            public string SEALSCORNERS { get; set;}

            public string CORNICES { get; set;}

            public string CORNICESPARTS { get; set;}

            public string FILLERS { get; set;}

            public string APPLIANCES { get; set;}

            public string SINKS { get; set;}

            public string EXTRAS { get; set;}

            public string VISIBLESIDES { get; set;}

        }

        public class Doors2
        {
            [XmlElement (ElementName = "GROUP")]
            public string Group { get; set; }

            [XmlElement(ElementName = "CODE")]
            public string Code { get; set; }

            [XmlElement(ElementName = "TYPE")]
            public string Type { get; set; }

            [XmlElement(ElementName = "MODEL")]
            public string Model { get; set; }

            [XmlElement(ElementName = "MATERIAL")]
            public string Material { get; set; }

            [XmlElement(ElementName = "DIRECTION")]
            public string Direction { get; set; }

            [XmlElement(ElementName = "OPENDIRECTION")]
            public string OpenDirection { get; set; }

            [XmlElement(ElementName = "MODULEPOSE")]
            public int ModulePose { get; set; }

            [XmlElement(ElementName = "BRAND")]
            public string Brand { get; set; }

            [XmlElement(ElementName = "MODUL")]
            public string Modul { get; set; }

            [XmlElement(ElementName = "H")]
            public int H { get; set; }

            [XmlElement(ElementName = "W")]
            public int W { get; set; }

            [XmlElement(ElementName = "MATROTA")]
            public int MatRota { get; set; }

            [XmlElement(ElementName = "QUANTITY")]
            public decimal Quantity { get; set; }
        }

        public class Doors3
        {
            public string[] GROUP { get; set; }

            public string[] CODE { get; set; }

            public string[] TYPE { get; set; }

        }

        public class Doors
        {
            public string Group { get; set; }

            public string Code { get; set; }

            public string Type { get; set; }

            public string Model { get; set; }

            public string Material { get; set; }

            public string Direction { get; set; }

            public string OpenDirection { get; set; }

            public int ModulePose { get; set; }

            public string Brand { get; set; }

            public string Modul { get; set; }

            public int H { get; set; }

            public int W { get; set; }

            public int MatRota { get; set; }

            public decimal Quantity { get; set; }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Personel
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Telefon { get; set; }
            public string Mail_Adres { get; set; }
        }

    }
}
