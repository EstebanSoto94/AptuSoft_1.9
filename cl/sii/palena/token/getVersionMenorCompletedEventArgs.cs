﻿ 
// Type: Aptusoft.cl.sii.palena.token.getVersionMenorCompletedEventArgs
 
 
// version 1.8.0

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace Aptusoft.cl.sii.palena.token
{
  [GeneratedCode("System.Web.Services", "4.0.30319.1")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  public class getVersionMenorCompletedEventArgs : AsyncCompletedEventArgs
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

    internal getVersionMenorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }
  }
}
