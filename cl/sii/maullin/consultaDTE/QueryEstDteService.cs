 
// Type: Aptusoft.cl.sii.maullin.consultaDTE.QueryEstDteService
 
 
// version 1.8.0

using Aptusoft.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace Aptusoft.cl.sii.maullin.consultaDTE
{
  [WebServiceBinding(Name = "QueryEstDteSoapBinding", Namespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class QueryEstDteService : SoapHttpClientProtocol
  {
    private SendOrPostCallback getStateOperationCompleted;
    private SendOrPostCallback getEstDteOperationCompleted;
    private SendOrPostCallback getVersionMayorOperationCompleted;
    private SendOrPostCallback getVersionMenorOperationCompleted;
    private SendOrPostCallback getVersionPatchOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public new string Url
    {
      get
      {
        return base.Url;
      }
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get
      {
        return base.UseDefaultCredentials;
      }
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event getStateCompletedEventHandler getStateCompleted;

    public event getEstDteCompletedEventHandler getEstDteCompleted;

    public event getVersionMayorCompletedEventHandler getVersionMayorCompleted;

    public event getVersionMenorCompletedEventHandler getVersionMenorCompleted;

    public event getVersionPatchCompletedEventHandler getVersionPatchCompleted;

    public QueryEstDteService()
    {
      this.Url = Settings.Default.Aptusoft_cl_sii_maullin_consultaDTE_QueryEstDteService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    [return: SoapElement("getStateReturn")]
    public string getState()
    {
      return (string) this.Invoke("getState", new object[0])[0];
    }

    public void getStateAsync()
    {
      this.getStateAsync((object) null);
    }

    public void getStateAsync(object userState)
    {
      if (this.getStateOperationCompleted == null)
        this.getStateOperationCompleted = new SendOrPostCallback(this.OngetStateOperationCompleted);
      this.InvokeAsync("getState", new object[0], this.getStateOperationCompleted, userState);
    }

    private void OngetStateOperationCompleted(object arg)
    {
      if (this.getStateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getStateCompleted((object) this, new getStateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    [return: SoapElement("getEstDteReturn")]
    public string getEstDte(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token)
    {
      return (string) this.Invoke("getEstDte", new object[11]
      {
        (object) RutConsultante,
        (object) DvConsultante,
        (object) RutCompania,
        (object) DvCompania,
        (object) RutReceptor,
        (object) DvReceptor,
        (object) TipoDte,
        (object) FolioDte,
        (object) FechaEmisionDte,
        (object) MontoDte,
        (object) Token
      })[0];
    }

    public void getEstDteAsync(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token)
    {
      this.getEstDteAsync(RutConsultante, DvConsultante, RutCompania, DvCompania, RutReceptor, DvReceptor, TipoDte, FolioDte, FechaEmisionDte, MontoDte, Token, (object) null);
    }

    public void getEstDteAsync(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token, object userState)
    {
      if (this.getEstDteOperationCompleted == null)
        this.getEstDteOperationCompleted = new SendOrPostCallback(this.OngetEstDteOperationCompleted);
      this.InvokeAsync("getEstDte", new object[11]
      {
        (object) RutConsultante,
        (object) DvConsultante,
        (object) RutCompania,
        (object) DvCompania,
        (object) RutReceptor,
        (object) DvReceptor,
        (object) TipoDte,
        (object) FolioDte,
        (object) FechaEmisionDte,
        (object) MontoDte,
        (object) Token
      }, this.getEstDteOperationCompleted, userState);
    }

    private void OngetEstDteOperationCompleted(object arg)
    {
      if (this.getEstDteCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getEstDteCompleted((object) this, new getEstDteCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    [return: SoapElement("getVersionMayorReturn")]
    public string getVersionMayor()
    {
      return (string) this.Invoke("getVersionMayor", new object[0])[0];
    }

    public void getVersionMayorAsync()
    {
      this.getVersionMayorAsync((object) null);
    }

    public void getVersionMayorAsync(object userState)
    {
      if (this.getVersionMayorOperationCompleted == null)
        this.getVersionMayorOperationCompleted = new SendOrPostCallback(this.OngetVersionMayorOperationCompleted);
      this.InvokeAsync("getVersionMayor", new object[0], this.getVersionMayorOperationCompleted, userState);
    }

    private void OngetVersionMayorOperationCompleted(object arg)
    {
      if (this.getVersionMayorCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getVersionMayorCompleted((object) this, new getVersionMayorCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    [return: SoapElement("getVersionMenorReturn")]
    public string getVersionMenor()
    {
      return (string) this.Invoke("getVersionMenor", new object[0])[0];
    }

    public void getVersionMenorAsync()
    {
      this.getVersionMenorAsync((object) null);
    }

    public void getVersionMenorAsync(object userState)
    {
      if (this.getVersionMenorOperationCompleted == null)
        this.getVersionMenorOperationCompleted = new SendOrPostCallback(this.OngetVersionMenorOperationCompleted);
      this.InvokeAsync("getVersionMenor", new object[0], this.getVersionMenorOperationCompleted, userState);
    }

    private void OngetVersionMenorOperationCompleted(object arg)
    {
      if (this.getVersionMenorCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getVersionMenorCompleted((object) this, new getVersionMenorCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    [return: SoapElement("getVersionPatchReturn")]
    public string getVersionPatch()
    {
      return (string) this.Invoke("getVersionPatch", new object[0])[0];
    }

    public void getVersionPatchAsync()
    {
      this.getVersionPatchAsync((object) null);
    }

    public void getVersionPatchAsync(object userState)
    {
      if (this.getVersionPatchOperationCompleted == null)
        this.getVersionPatchOperationCompleted = new SendOrPostCallback(this.OngetVersionPatchOperationCompleted);
      this.InvokeAsync("getVersionPatch", new object[0], this.getVersionPatchOperationCompleted, userState);
    }

    private void OngetVersionPatchOperationCompleted(object arg)
    {
      if (this.getVersionPatchCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getVersionPatchCompleted((object) this, new getVersionPatchCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState)
    {
      base.CancelAsync(userState);
    }

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
