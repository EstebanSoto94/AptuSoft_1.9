 
// Type: Aptusoft.Reportes.Factura002
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using System.ComponentModel;

namespace Aptusoft.Reportes
{
  public class Factura002 : ReportClass
  {
    public override string ResourceName
    {
      get
      {
        return "Factura002.rpt";
      }
      set
      {
      }
    }

    public override bool NewGenerator
    {
      get
      {
        return true;
      }
      set
      {
      }
    }

    public override string FullResourceName
    {
      get
      {
        return "Aptusoft.Reportes.Factura002.rpt";
      }
      set
      {
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section1
    {
      get
      {
        return this.ReportDefinition.Sections[0];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section Section2
    {
      get
      {
        return this.ReportDefinition.Sections[1];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section Section3
    {
      get
      {
        return this.ReportDefinition.Sections[2];
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public Section Section4
    {
      get
      {
        return this.ReportDefinition.Sections[3];
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Section Section5
    {
      get
      {
        return this.ReportDefinition.Sections[4];
      }
    }
  }
}
