 
// Type: Aptusoft.Properties.Settings
 
 
// version 1.8.0

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Aptusoft.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings settings = Settings.defaultInstance;
        return settings;
      }
    }

    [DefaultSettingValue("server=localhost;User Id=root;password=123456;database=Aptusoft;Persist Security Info=True")]
    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.ConnectionString)]
    public string AptusoftConnectionString
    {
      get
      {
        return (string) this["AptusoftConnectionString"];
      }
    }

    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("https://maullin.sii.cl/DTEWS/QueryEstUp.jws")]
    public string Aptusoft_cl_sii_maullin_consulta_QueryEstUpService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_maullin_consulta_QueryEstUpService"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("https://maullin.sii.cl/DTEWS/QueryEstDte.jws")]
    public string Aptusoft_cl_sii_maullin_consultaDTE_QueryEstDteService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_maullin_consultaDTE_QueryEstDteService"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("https://maullin.sii.cl/DTEWS/CrSeed.jws")]
    public string Aptusoft_cl_sii_maullin_semilla_CrSeedService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_maullin_semilla_CrSeedService"];
      }
    }

    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("https://maullin.sii.cl/DTEWS/GetTokenFromSeed.jws")]
    public string Aptusoft_cl_sii_maullin_token_GetTokenFromSeedService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_maullin_token_GetTokenFromSeedService"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("https://palena.sii.cl/DTEWS/QueryEstUp.jws")]
    public string Aptusoft_cl_sii_palena_consulta_QueryEstUpService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_palena_consulta_QueryEstUpService"];
      }
    }

    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("https://palena.sii.cl/DTEWS/QueryEstDte.jws")]
    public string Aptusoft_cl_sii_palena_consultaDTE_QueryEstDteService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_palena_consultaDTE_QueryEstDteService"];
      }
    }

    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DebuggerNonUserCode]
    [ApplicationScopedSetting]
    [DefaultSettingValue("https://palena.sii.cl/DTEWS/CrSeed.jws")]
    public string Aptusoft_cl_sii_palena_semilla_CrSeedService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_palena_semilla_CrSeedService"];
      }
    }

    [ApplicationScopedSetting]
    [DebuggerNonUserCode]
    [SpecialSetting(SpecialSetting.WebServiceUrl)]
    [DefaultSettingValue("https://palena.sii.cl/DTEWS/GetTokenFromSeed.jws")]
    public string Aptusoft_cl_sii_palena_token_GetTokenFromSeedService
    {
      get
      {
        return (string) this["Aptusoft_cl_sii_palena_token_GetTokenFromSeedService"];
      }
    }
  }
}
