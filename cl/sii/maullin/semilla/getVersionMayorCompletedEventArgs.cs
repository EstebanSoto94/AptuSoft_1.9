﻿ 
// Type: Aptusoft.cl.sii.maullin.semilla.getVersionMayorCompletedEventArgs
 
 
// version 1.8.0

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Aptusoft.cl.sii.maullin.semilla
{
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class getVersionMayorCompletedEventArgs : AsyncCompletedEventArgs
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

    internal getVersionMayorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }
  }
}
