'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30306.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace HowToBindToMDB.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As HowToBindToMDB.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New HowToBindToMDB.Properties.Settings())), HowToBindToMDB.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return HowToBindToMDB.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Se" & "curity Info=True")>
        Public ReadOnly Property nwindConnectionString As String
            Get
                Return(CStr((Me("nwindConnectionString"))))
            End Get
        End Property
    End Class
End Namespace
