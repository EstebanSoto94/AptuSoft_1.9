using BarcodeLib;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aptusoft
{
    public partial class frmCodeBar : Form
    {
        Barcode b = new BarcodeLib.Barcode();
        private frmCodeBar intance;
        private List<string> aa = new List<string>();
        public frmCodeBar()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Trim().Length != 0)
            {

                errorProvider1.Clear();
                int W = Convert.ToInt32(this.txtWidth.Text.Trim());
                int H = Convert.ToInt32(this.txtHeight.Text.Trim());
                b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

                //barcode alignment
                switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
                {
                    case "Izquierda": b.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                    case "Derecha": b.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                    default: b.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
                }//switch

                BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
                switch (cbEncodeType.SelectedItem.ToString().Trim())
                {
                    case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                    case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                    case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                    case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                    case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                    case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                    case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                    case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                    case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                    case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                    case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                    case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                    case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                    case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                    case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                    case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                    case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                    case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                    case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                    case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                    case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                    case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                    case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                    case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                    case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                    case "FIM": type = BarcodeLib.TYPE.FIM; break;
                    case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                    default: MessageBox.Show("Please specify the encoding type."); break;
                }//switch

                try
                {
                    if (type != BarcodeLib.TYPE.UNSPECIFIED)
                    {
                        b.IncludeLabel = this.chkGenerateLabel.Checked;

                        b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

                        //label alignment and position
                        switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                        {
                            case "BOTTOMLEFT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                            case "BOTTOMRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                            case "TOPCENTER": b.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                            case "TOPLEFT": b.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                            case "TOPRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                            default: b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                        }//switch

                        //===== Encoding performed here =====
                        barcode.BackgroundImage = b.Encode(type, this.txtData.Text.Trim(), this.btnForeColor.BackColor, this.btnBackColor.BackColor, W, H);
                        //===================================

                        //show the encoding time
                        this.lblEncodingTime.Text = "(" + Math.Round(b.EncodingTime, 0, MidpointRounding.AwayFromZero).ToString() + "ms)";

                        txtEncoded.Text = b.EncodedValue;

                        //tsslEncodedType.Text = "Encoding Type: " + b.EncodedType.ToString();
                    }//if

                    //reposition the barcode image to the middle
                    barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
                }//try
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    switch (msg)
                    {
                        case "EENCODE-1: Input data not allowed to be blank.":
                            MessageBox.Show("La entrada de datos esta vacia,\n\rverifique que el texto sea corecto he intente nuevamente.");
                            break;
                    }
                }
            }
            else
            {
                errorProvider1.SetError(txtData, "Se necesita Codigo Valido para Crear Codigo De Barras.");
            }
        }
        public void generateCodeBar(string texto)
        {
            if (File.Exists(@"C:\Aptusoft\ticket.jpg"))
            {
                File.Delete(@"C:\Aptusoft\ticket.jpg");
            }
            if (texto.Trim().Length != 0)
            {

                int W = Convert.ToInt32(300);
                int H = Convert.ToInt32(150);
                b.Alignment = BarcodeLib.AlignmentPositions.CENTER;


                BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
               // type = BarcodeLib.TYPE.CODE39_Mod43;
                type = BarcodeLib.TYPE.CODE93;
                b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
                barcode.BackgroundImage = b.Encode(type, texto, Color.White, Color.Black, W, H);
            
           
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                     /* JPG */  savetype = BarcodeLib.SaveTypes.JPG;
                     
                b.SaveImage("C:\\Aptusoft\\Reportes\\ticket.jpg", savetype);
            }
                
           
        }
        private void frmCodeBar_Load(object sender, EventArgs e)
        {
            txtCoppie.Text = "1";
            this.cbEncodeType.SelectedIndex = 1;
            this.cbBarcodeAlign.SelectedIndex = 0;
            this.cbLabelLocation.SelectedIndex = 0;
            this.txtData.Focus();
            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));

            int i = 0;
            foreach (object o in cbRotateFlip.Items)
            {
                if (o.ToString().Trim().ToLower() == "rotatenoneflipnone")
                    break;
                i++;
            }//foreach
            this.cbRotateFlip.SelectedIndex = i;

            //Show library version
          //  this.tslblLibraryVersion.Text = "Barcode Library Version: " + BarcodeLib.Barcode.Version.ToString();

            this.btnBackColor.BackColor = this.b.BackColor;
            this.btnForeColor.BackColor = this.b.ForeColor;
        }
        string[] bb = new string[2];
            public void set_codigo(string codigo)
        {
            if (File.Exists("temp.txt"))
            {
                File.Delete("temp.txt");
            }
            StreamWriter r = new StreamWriter("temp.txt");
            r.WriteLine(codigo);
            //this.bb.SetValue(codigo, 0);
            r.Close();
            //this.btnEncode.Focus();
        }
        void carga()
        {
            if (File.Exists("temp.txt"))
            {
                StreamReader re = new StreamReader("temp.txt");
                this.txtData.Clear();
                this.textBox1.Clear();
                this.txtData.Text = re.ReadLine();
                this.textBox1.Text = txtData.Text;
                re.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 2;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* GIF */  savetype = BarcodeLib.SaveTypes.GIF; break;
                    case 3: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 4: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 5: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }//switch
                b.SaveImage(sfd.FileName, savetype);
            }//if
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.b.ForeColor = cdialog.Color;
                    this.btnForeColor.BackColor = cdialog.Color;
                }//if
            }//using
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cdialog = new ColorDialog())
            {
                cdialog.AnyColor = true;
                if (cdialog.ShowDialog() == DialogResult.OK)
                {
                    this.b.BackColor = cdialog.Color;
                    this.btnBackColor.BackColor = cdialog.Color;
                }//if
            }//using
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            btnEncode_Click(sender, e);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML Files|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        sw.Write(b.XML);
                    }//using
                }//if
            }//using
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
             using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (BarcodeLib.BarcodeXML XML = new BarcodeLib.BarcodeXML())
                    {
                        XML.ReadXml(ofd.FileName);

                        //load image from xml
                        this.barcode.Width = XML.Barcode[0].ImageWidth;
                        this.barcode.Height = XML.Barcode[0].ImageHeight;
                        this.barcode.BackgroundImage = BarcodeLib.Barcode.GetImageFromXML(XML);

                        //populate the screen
                        this.txtData.Text = XML.Barcode[0].RawData;
                        this.chkGenerateLabel.Checked = XML.Barcode[0].IncludeLabel;

                        switch (XML.Barcode[0].Type)
                        {
                            case "UCC12":
                            case "UPCA":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("UPC-A");
                                break;
                            case "UCC13":
                            case "EAN13":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("EAN-13");
                                break;
                            case "Interleaved2of5":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Interleaved 2 of 5");
                                break;
                            case "Industrial2of5":
                            case "Standard2of5":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Standard 2 of 5");
                                break;
                            case "LOGMARS":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("LOGMARS");
                                break;
                            case "CODE39":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 39");
                                break;
                            case "CODE39Extended":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 39 Extended");
                                break;
                            case "CODE39_Mod43": 
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 39 Mod 43");
                                break;
                            case "Codabar":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Codabar");
                                break;
                            case "PostNet":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("PostNet");
                                break;
                            case "ISBN":
                            case "BOOKLAND":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Bookland/ISBN");
                                break;
                            case "JAN13":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("JAN-13");
                                break;
                            case "UPC_SUPPLEMENTAL_2DIGIT":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("UPC 2 Digit Ext.");
                                break;
                            case "MSI_Mod10":
                            case "MSI_2Mod10":
                            case "MSI_Mod11":
                            case "MSI_Mod11_Mod10":
                            case "Modified_Plessey":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("MSI");
                                break;
                            case "UPC_SUPPLEMENTAL_5DIGIT":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("UPC 5 Digit Ext.");
                                break;
                            case "UPCE":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("UPC-E");
                                break;
                            case "EAN8":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("EAN-8");
                                break;
                            case "USD8":
                            case "CODE11":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 11");
                                break;
                            case "CODE128":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 128");
                                break;
                            case "CODE128A":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 128-A");
                                break;
                            case "CODE128B":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 128-B");
                                break;
                            case "CODE128C":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 128-C");
                                break;
                            case "ITF14":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("ITF-14");
                                break;
                            case "CODE93":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Code 93");
                                break;
                            case "FIM":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("FIM");
                                break;
                            case "Pharmacode":
                                this.cbEncodeType.SelectedIndex = this.cbEncodeType.FindString("Pharmacode");
                                break;

                            default: throw new Exception("ELOADXML-1: Unsupported encoding type in XML.");
                        }//switch

                        this.txtEncoded.Text = XML.Barcode[0].EncodedValue;
                        this.btnForeColor.BackColor = ColorTranslator.FromHtml(XML.Barcode[0].Forecolor);
                        this.btnBackColor.BackColor = ColorTranslator.FromHtml(XML.Barcode[0].Backcolor); ;
                        this.txtWidth.Text = XML.Barcode[0].ImageWidth.ToString();
                        this.txtHeight.Text = XML.Barcode[0].ImageHeight.ToString();
                        
                        //populate the local object
                        btnEncode_Click(sender, e);

                        //reposition the barcode image to the middle
                        barcode.Location = new Point((this.barcode.Location.X + this.barcode.Width / 2) - barcode.Width / 2, (this.barcode.Location.Y + this.barcode.Height / 2) - barcode.Height / 2);
                    }//using
                }//if
            }//using
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = (int)new frmBuscaProductos("bar", ref this.intance).ShowDialog();
            //this.txtData.Text = this.Codigo; 
            carga();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("temp.jpg"))
            {
                File.Delete("temp.jpg");
            }
            BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
           savetype = BarcodeLib.SaveTypes.JPG; 
           b.SaveImage("C:\\Aptusoft\\temp.jpg",savetype);
       
               ReportDocument reportDocument = new ReportDocument();
               reportDocument.Load("C:\\AptuSoft\\reportes\\barcode.rpt");
               reportDocument.SetParameterValue("imagenpath", "C:\\aptusoft\\temp.jpg");
               string str = new LeeXml().cargarDatos("barcode");
               reportDocument.PrintOptions.PrinterName = str;
               reportDocument.PrintToPrinter(Convert.ToInt32(txtCoppie.Text.ToString()), false, 1, Convert.ToInt32(txtCoppie.Text.ToString()));
               reportDocument.Close();
           
            //printDocument1.Print();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void frmCodeBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("temp.txt"))
            {
                File.Delete("temp.txt");
            }if(File.Exists("temp.jpg")){
                File.Delete("temp.jpg");
            }
        }

        private void txtCoppie_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCoppie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
