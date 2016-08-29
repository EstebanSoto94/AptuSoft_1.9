 
// Type: Aptusoft.Reportes.CachedNotaCredito
 
 
// version 1.8.0

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Aptusoft.Reportes
{
  [ToolboxBitmap(typeof (ExportOptions), "report.bmp")]
  public class CachedNotaCredito : Component, ICachedReport
  {
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public virtual bool IsCacheable
    {
      get
      {
        return true;
      }
      set
      {
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual bool ShareDBLogonInfo
    {
      get
      {
        return false;
      }
      set
      {
      }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public virtual TimeSpan CacheTimeOut
    {
      get
      {
        return CachedReportConstants.DEFAULT_TIMEOUT;
      }
      set
      {
      }
    }

    public virtual ReportDocument CreateReport()
    {
      NotaCredito notaCredito = new NotaCredito();
      notaCredito.Site = this.Site;
      return (ReportDocument) notaCredito;
    }

    public virtual string GetCustomizedCacheKey(RequestContext request)
    {
      return (string) null;
    }
  }
}
