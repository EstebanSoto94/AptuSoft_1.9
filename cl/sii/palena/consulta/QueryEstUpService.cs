 
// Type: Aptusoft.cl.sii.palena.consulta.QueryEstUpService
 
 
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

namespace Aptusoft.cl.sii.palena.consulta
{
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [WebServiceBinding(Name = "QueryEstUpSoapBinding", Namespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class QueryEstUpService : SoapHttpClientProtocol
  {
    private SendOrPostCallback getStateOperationCompleted;
    private SendOrPostCallback getVersionMayorOperationCompleted;
    private SendOrPostCallback getVersionMenorOperationCompleted;
    private SendOrPostCallback getVersionPatchOperationCompleted;
    private SendOrPostCallback getEstUpOperationCompleted;
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

    public event getVersionMayorCompletedEventHandler getVersionMayorCompleted;

    public event getVersionMenorCompletedEventHandler getVersionMenorCompleted;

    public event getVersionPatchCompletedEventHandler getVersionPatchCompleted;

    public event getEstUpCompletedEventHandler getEstUpCompleted;

    public QueryEstUpService()
    {
      this.Url = Settings.Default.Aptusoft_cl_sii_palena_consulta_QueryEstUpService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
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

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
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

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
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

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
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

    [SoapRpcMethod("", RequestNamespace = "http://DefaultNamespace", ResponseNamespace = "https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
    [return: SoapElement("getEstUpReturn")]
    public string getEstUp(string RutCompania, string DvCompania, string TrackId, string Token)
    {
      return (string) this.Invoke("getEstUp", new object[4]
      {
        (object) RutCompania,
        (object) DvCompania,
        (object) TrackId,
        (object) Token
      })[0];
    }

    public void getEstUpAsync(string RutCompania, string DvCompania, string TrackId, string Token)
    {
      this.getEstUpAsync(RutCompania, DvCompania, TrackId, Token, (object) null);
    }

    public void getEstUpAsync(string RutCompania, string DvCompania, string TrackId, string Token, object userState)
    {
      if (this.getEstUpOperationCompleted == null)
        this.getEstUpOperationCompleted = new SendOrPostCallback(this.OngetEstUpOperationCompleted);
      this.InvokeAsync("getEstUp", new object[4]
      {
        (object) RutCompania,
        (object) DvCompania,
        (object) TrackId,
        (object) Token
      }, this.getEstUpOperationCompleted, userState);
    }

    private void OngetEstUpOperationCompleted(object arg)
    {
      if (this.getEstUpCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getEstUpCompleted((object) this, new getEstUpCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
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
