 
// Type: Aptusoft.cl.sii.palena.consultaDTE.getStateCompletedEventArgs
 
 
// version 1.8.0

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Aptusoft.cl.sii.palena.consultaDTE
{
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class getStateCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    public string Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (string) this.results[0];
      }
    }

    internal getStateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }
  }
}
