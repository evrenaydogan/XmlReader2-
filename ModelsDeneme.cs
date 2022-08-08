using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader2
{
    public class ModelsDeneme
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class PROJECT
        {

            private PROJECTUNITS[] uNITSField;

            private PROJECTDOORS[] dOORSField;

            private PROJECTHANDLES[] hANDLESField;

            private PROJECTWORKTOPS wORKTOPSField;

            private PROJECTDATABANDS dATABANDSField;

            private PROJECTPANELS pANELSField;

            private PROJECTPLINTHS pLINTHSField;

            private PROJECTPLINTHSCORNERS pLINTHSCORNERSField;

            private PROJECTPLINTHLEGS[] pLINTHLEGSField;

            private PROJECTSEALS sEALSField;

            private PROJECTSEALSCORNERS sEALSCORNERSField;

            private PROJECTCORNICES cORNICESField;

            private PROJECTFILLERS fILLERSField;

            private PROJECTAPPLIANCES aPPLIANCESField;

            private PROJECTSINKS sINKSField;

            private PROJECTSANITARIES sANITARIESField;

            private PROJECTEXTRAS eXTRASField;

            private PROJECTGENERAL[] gENERALField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("UNITS")]
            public PROJECTUNITS[] UNITS
            {
                get
                {
                    return this.uNITSField;
                }
                set
                {
                    this.uNITSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DOORS")]
            public PROJECTDOORS[] DOORS
            {
                get
                {
                    return this.dOORSField;
                }
                set
                {
                    this.dOORSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("HANDLES")]
            public PROJECTHANDLES[] HANDLES
            {
                get
                {
                    return this.hANDLESField;
                }
                set
                {
                    this.hANDLESField = value;
                }
            }

            /// <remarks/>
            public PROJECTWORKTOPS WORKTOPS
            {
                get
                {
                    return this.wORKTOPSField;
                }
                set
                {
                    this.wORKTOPSField = value;
                }
            }

            /// <remarks/>
            public PROJECTDATABANDS DATABANDS
            {
                get
                {
                    return this.dATABANDSField;
                }
                set
                {
                    this.dATABANDSField = value;
                }
            }

            /// <remarks/>
            public PROJECTPANELS PANELS
            {
                get
                {
                    return this.pANELSField;
                }
                set
                {
                    this.pANELSField = value;
                }
            }

            /// <remarks/>
            public PROJECTPLINTHS PLINTHS
            {
                get
                {
                    return this.pLINTHSField;
                }
                set
                {
                    this.pLINTHSField = value;
                }
            }

            /// <remarks/>
            public PROJECTPLINTHSCORNERS PLINTHSCORNERS
            {
                get
                {
                    return this.pLINTHSCORNERSField;
                }
                set
                {
                    this.pLINTHSCORNERSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("PLINTHLEGS")]
            public PROJECTPLINTHLEGS[] PLINTHLEGS
            {
                get
                {
                    return this.pLINTHLEGSField;
                }
                set
                {
                    this.pLINTHLEGSField = value;
                }
            }

            /// <remarks/>
            public PROJECTSEALS SEALS
            {
                get
                {
                    return this.sEALSField;
                }
                set
                {
                    this.sEALSField = value;
                }
            }

            /// <remarks/>
            public PROJECTSEALSCORNERS SEALSCORNERS
            {
                get
                {
                    return this.sEALSCORNERSField;
                }
                set
                {
                    this.sEALSCORNERSField = value;
                }
            }

            /// <remarks/>
            public PROJECTCORNICES CORNICES
            {
                get
                {
                    return this.cORNICESField;
                }
                set
                {
                    this.cORNICESField = value;
                }
            }

            /// <remarks/>
            public PROJECTFILLERS FILLERS
            {
                get
                {
                    return this.fILLERSField;
                }
                set
                {
                    this.fILLERSField = value;
                }
            }

            /// <remarks/>
            public PROJECTAPPLIANCES APPLIANCES
            {
                get
                {
                    return this.aPPLIANCESField;
                }
                set
                {
                    this.aPPLIANCESField = value;
                }
            }

            /// <remarks/>
            public PROJECTSINKS SINKS
            {
                get
                {
                    return this.sINKSField;
                }
                set
                {
                    this.sINKSField = value;
                }
            }

            /// <remarks/>
            public PROJECTSANITARIES SANITARIES
            {
                get
                {
                    return this.sANITARIESField;
                }
                set
                {
                    this.sANITARIESField = value;
                }
            }

            /// <remarks/>
            public PROJECTEXTRAS EXTRAS
            {
                get
                {
                    return this.eXTRASField;
                }
                set
                {
                    this.eXTRASField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("GENERAL")]
            public PROJECTGENERAL[] GENERAL
            {
                get
                {
                    return this.gENERALField;
                }
                set
                {
                    this.gENERALField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTUNITS
        {

            private string gROUPField;

            private string cODEField;

            private string uNIQUECODEField;

            private string mODELField;

            private string mATERIALField;

            private string dMATERIALField;

            private string hANDLEMODELField;

            private string dGLASSMATERIALField;

            private string dIRECTIONField;

            private string mODULPOSEField;

            private string h1Field;

            private string w1Field;

            private string d1Field;

            private string d2Field;

            private string uNITAREAM2Field;

            private string nOTCHTYPEField;

            private string xField;

            private string yField;

            private string zField;

            private object sIDESField;

            private object sIDESMATField;

            private string qUANTITYField;

            private string uNITNOTEField;

            /// <remarks/>
            public string GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public string CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public string UNIQUECODE
            {
                get
                {
                    return this.uNIQUECODEField;
                }
                set
                {
                    this.uNIQUECODEField = value;
                }
            }

            /// <remarks/>
            public string MODEL
            {
                get
                {
                    return this.mODELField;
                }
                set
                {
                    this.mODELField = value;
                }
            }

            /// <remarks/>
            public string MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public string DMATERIAL
            {
                get
                {
                    return this.dMATERIALField;
                }
                set
                {
                    this.dMATERIALField = value;
                }
            }

            /// <remarks/>
            public string HANDLEMODEL
            {
                get
                {
                    return this.hANDLEMODELField;
                }
                set
                {
                    this.hANDLEMODELField = value;
                }
            }

            /// <remarks/>
            public string DGLASSMATERIAL
            {
                get
                {
                    return this.dGLASSMATERIALField;
                }
                set
                {
                    this.dGLASSMATERIALField = value;
                }
            }

            /// <remarks/>
            public string DIRECTION
            {
                get
                {
                    return this.dIRECTIONField;
                }
                set
                {
                    this.dIRECTIONField = value;
                }
            }

            /// <remarks/>
            public string MODULPOSE
            {
                get
                {
                    return this.mODULPOSEField;
                }
                set
                {
                    this.mODULPOSEField = value;
                }
            }

            /// <remarks/>
            public string H1
            {
                get
                {
                    return this.h1Field;
                }
                set
                {
                    this.h1Field = value;
                }
            }

            /// <remarks/>
            public string W1
            {
                get
                {
                    return this.w1Field;
                }
                set
                {
                    this.w1Field = value;
                }
            }

            /// <remarks/>
            public string D1
            {
                get
                {
                    return this.d1Field;
                }
                set
                {
                    this.d1Field = value;
                }
            }

            /// <remarks/>
            public string D2
            {
                get
                {
                    return this.d2Field;
                }
                set
                {
                    this.d2Field = value;
                }
            }

            /// <remarks/>
            public string UNITAREAM2
            {
                get
                {
                    return this.uNITAREAM2Field;
                }
                set
                {
                    this.uNITAREAM2Field = value;
                }
            }

            /// <remarks/>
            public string NOTCHTYPE
            {
                get
                {
                    return this.nOTCHTYPEField;
                }
                set
                {
                    this.nOTCHTYPEField = value;
                }
            }

            /// <remarks/>
            public string X
            {
                get
                {
                    return this.xField;
                }
                set
                {
                    this.xField = value;
                }
            }

            /// <remarks/>
            public string Y
            {
                get
                {
                    return this.yField;
                }
                set
                {
                    this.yField = value;
                }
            }

            /// <remarks/>
            public string Z
            {
                get
                {
                    return this.zField;
                }
                set
                {
                    this.zField = value;
                }
            }

            /// <remarks/>
            public object SIDES
            {
                get
                {
                    return this.sIDESField;
                }
                set
                {
                    this.sIDESField = value;
                }
            }

            /// <remarks/>
            public object SIDESMAT
            {
                get
                {
                    return this.sIDESMATField;
                }
                set
                {
                    this.sIDESMATField = value;
                }
            }

            /// <remarks/>
            public string QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public string UNITNOTE
            {
                get
                {
                    return this.uNITNOTEField;
                }
                set
                {
                    this.uNITNOTEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTDOORS
        {

            private string gROUPField;

            private string cODEField;

            private string tYPEField;

            private string mODELField;

            private string mATERIALField;

            private string dIRECTIONField;

            private string mODULPOSEField;

            private object bRANDField;

            private string hField;

            private string wField;

            private string mATROTAField;

            private string qUANTITYField;

            /// <remarks/>
            public string GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public string CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public string TYPE
            {
                get
                {
                    return this.tYPEField;
                }
                set
                {
                    this.tYPEField = value;
                }
            }

            /// <remarks/>
            public string MODEL
            {
                get
                {
                    return this.mODELField;
                }
                set
                {
                    this.mODELField = value;
                }
            }

            /// <remarks/>
            public string MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public string DIRECTION
            {
                get
                {
                    return this.dIRECTIONField;
                }
                set
                {
                    this.dIRECTIONField = value;
                }
            }

            /// <remarks/>
            public string MODULPOSE
            {
                get
                {
                    return this.mODULPOSEField;
                }
                set
                {
                    this.mODULPOSEField = value;
                }
            }

            /// <remarks/>
            public object BRAND
            {
                get
                {
                    return this.bRANDField;
                }
                set
                {
                    this.bRANDField = value;
                }
            }

            /// <remarks/>
            public string H
            {
                get
                {
                    return this.hField;
                }
                set
                {
                    this.hField = value;
                }
            }

            /// <remarks/>
            public string W
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            public string MATROTA
            {
                get
                {
                    return this.mATROTAField;
                }
                set
                {
                    this.mATROTAField = value;
                }
            }

            /// <remarks/>
            public string QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTHANDLES
        {

            private string gROUPField;

            private string cODEField;

            private string mODELField;

            private string qUANTITYField;

            /// <remarks/>
            public string GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public string CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public string MODEL
            {
                get
                {
                    return this.mODELField;
                }
                set
                {
                    this.mODELField = value;
                }
            }

            /// <remarks/>
            public string QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTWORKTOPS
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object l1Field;

            private object l2Field;

            private object tField;

            private object uNITLENGTHField;

            private object uNITMTULWIDTHField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object L1
            {
                get
                {
                    return this.l1Field;
                }
                set
                {
                    this.l1Field = value;
                }
            }

            /// <remarks/>
            public object L2
            {
                get
                {
                    return this.l2Field;
                }
                set
                {
                    this.l2Field = value;
                }
            }

            /// <remarks/>
            public object T
            {
                get
                {
                    return this.tField;
                }
                set
                {
                    this.tField = value;
                }
            }

            /// <remarks/>
            public object UNITLENGTH
            {
                get
                {
                    return this.uNITLENGTHField;
                }
                set
                {
                    this.uNITLENGTHField = value;
                }
            }

            /// <remarks/>
            public object UNITMTULWIDTH
            {
                get
                {
                    return this.uNITMTULWIDTHField;
                }
                set
                {
                    this.uNITMTULWIDTHField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTDATABANDS
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object lField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTPANELS
        {

            private object gROUPField;

            private object cODEField;

            private object uNIQUECODEField;

            private object tYPEField;

            private object lField;

            private object wField;

            private object tField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object qUANTITYField;

            private object mODULField;

            private object uNITNOTEField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object UNIQUECODE
            {
                get
                {
                    return this.uNIQUECODEField;
                }
                set
                {
                    this.uNIQUECODEField = value;
                }
            }

            /// <remarks/>
            public object TYPE
            {
                get
                {
                    return this.tYPEField;
                }
                set
                {
                    this.tYPEField = value;
                }
            }

            /// <remarks/>
            public object L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public object W
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            public object T
            {
                get
                {
                    return this.tField;
                }
                set
                {
                    this.tField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }

            /// <remarks/>
            public object UNITNOTE
            {
                get
                {
                    return this.uNITNOTEField;
                }
                set
                {
                    this.uNITNOTEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTPLINTHS
        {

            private object gROUPField;

            private object cODEField;

            private object uNIQUECODEField;

            private object mATERIALField;

            private object hField;

            private object lField;

            private object mODULField;

            private object uNITNOTEField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object UNIQUECODE
            {
                get
                {
                    return this.uNIQUECODEField;
                }
                set
                {
                    this.uNIQUECODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object H
            {
                get
                {
                    return this.hField;
                }
                set
                {
                    this.hField = value;
                }
            }

            /// <remarks/>
            public object L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }

            /// <remarks/>
            public object UNITNOTE
            {
                get
                {
                    return this.uNITNOTEField;
                }
                set
                {
                    this.uNITNOTEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTPLINTHSCORNERS
        {

            private object gROUPField;

            private object cODEField;

            private object uNIQUECODEField;

            private object mATERIALField;

            private object qUANTITYField;

            private object mODULField;

            private object uNITNOTEField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object UNIQUECODE
            {
                get
                {
                    return this.uNIQUECODEField;
                }
                set
                {
                    this.uNIQUECODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }

            /// <remarks/>
            public object UNITNOTE
            {
                get
                {
                    return this.uNITNOTEField;
                }
                set
                {
                    this.uNITNOTEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTPLINTHLEGS
        {

            private string gROUPField;

            private string cODEField;

            private string hField;

            private string qUANTITYField;

            private string mODULField;

            /// <remarks/>
            public string GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public string CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public string H
            {
                get
                {
                    return this.hField;
                }
                set
                {
                    this.hField = value;
                }
            }

            /// <remarks/>
            public string QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public string MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTSEALS
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object lField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTSEALSCORNERS
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTCORNICES
        {

            private object gROUPField;

            private object cODEField;

            private object uNIQUECODEField;

            private object mATERIALField;

            private object mATERIALUCASEField;

            private object lField;

            private object mODULField;

            private object uNITNOTEField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object UNIQUECODE
            {
                get
                {
                    return this.uNIQUECODEField;
                }
                set
                {
                    this.uNIQUECODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object MATERIALUCASE
            {
                get
                {
                    return this.mATERIALUCASEField;
                }
                set
                {
                    this.mATERIALUCASEField = value;
                }
            }

            /// <remarks/>
            public object L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }

            /// <remarks/>
            public object UNITNOTE
            {
                get
                {
                    return this.uNITNOTEField;
                }
                set
                {
                    this.uNITNOTEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTFILLERS
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIAL_BODYField;

            private object mATERIAL_DOORField;

            private object hField;

            private object wField;

            private object dField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL_BODY
            {
                get
                {
                    return this.mATERIAL_BODYField;
                }
                set
                {
                    this.mATERIAL_BODYField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL_DOOR
            {
                get
                {
                    return this.mATERIAL_DOORField;
                }
                set
                {
                    this.mATERIAL_DOORField = value;
                }
            }

            /// <remarks/>
            public object H
            {
                get
                {
                    return this.hField;
                }
                set
                {
                    this.hField = value;
                }
            }

            /// <remarks/>
            public object W
            {
                get
                {
                    return this.wField;
                }
                set
                {
                    this.wField = value;
                }
            }

            /// <remarks/>
            public object D
            {
                get
                {
                    return this.dField;
                }
                set
                {
                    this.dField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTAPPLIANCES
        {

            private object gROUPField;

            private object cODEField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTSINKS
        {

            private object gROUPField;

            private object cODEField;

            private object bRANDField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object BRAND
            {
                get
                {
                    return this.bRANDField;
                }
                set
                {
                    this.bRANDField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTSANITARIES
        {

            private object gROUPField;

            private object cODEField;

            private object bRANDField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object BRAND
            {
                get
                {
                    return this.bRANDField;
                }
                set
                {
                    this.bRANDField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTEXTRAS
        {

            private object gROUPField;

            private object cODEField;

            private object qUANTITYField;

            private object qUANTITY_UNITField;

            private object tYPEField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY_UNIT
            {
                get
                {
                    return this.qUANTITY_UNITField;
                }
                set
                {
                    this.qUANTITY_UNITField = value;
                }
            }

            /// <remarks/>
            public object TYPE
            {
                get
                {
                    return this.tYPEField;
                }
                set
                {
                    this.tYPEField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class PROJECTGENERAL
        {

            private object gROUPField;

            private object cODEField;

            private object mATERIALField;

            private object bRANDField;

            private object qUANTITYField;

            private object mODULField;

            /// <remarks/>
            public object GROUP
            {
                get
                {
                    return this.gROUPField;
                }
                set
                {
                    this.gROUPField = value;
                }
            }

            /// <remarks/>
            public object CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public object MATERIAL
            {
                get
                {
                    return this.mATERIALField;
                }
                set
                {
                    this.mATERIALField = value;
                }
            }

            /// <remarks/>
            public object BRAND
            {
                get
                {
                    return this.bRANDField;
                }
                set
                {
                    this.bRANDField = value;
                }
            }

            /// <remarks/>
            public object QUANTITY
            {
                get
                {
                    return this.qUANTITYField;
                }
                set
                {
                    this.qUANTITYField = value;
                }
            }

            /// <remarks/>
            public object MODUL
            {
                get
                {
                    return this.mODULField;
                }
                set
                {
                    this.mODULField = value;
                }
            }
        }



    }
}
