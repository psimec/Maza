; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Maza"
#define MyAppVersion "1.0"
#define MyAppPublisher "Maza"
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "PI_t18024_Maza.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{25C97851-786E-4895-8C9C-9BE7289B23A8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\PI_t18024_Maza.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\EnvDTE.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\EnvDTE80.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Kriptiranje.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Kriptiranje.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.Build.Framework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.Build.Tasks.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.Build.Utilities.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.MSXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.ReportViewer.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.ReportViewer.DataVisualization.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.ReportViewer.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.ReportViewer.ProcessingObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.ReportViewer.WinForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.SqlServer.Types.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.ComponentModelHost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Data.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Data.Services.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Debugger.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Debugger.InteropA.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.GraphModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.ManagedInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.OLE.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.ProjectAggregator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Shell.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Shell.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Shell.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Shell.Interop.9.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.Shell.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.TemplateWizardInterface.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.TextManager.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.TextManager.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.TextManager.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.VSHelp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Microsoft.VisualStudio.WCFReference.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\PI_t18024_Maza.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\PI_t18024_Maza.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\stdole.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\System.Threading.Tasks.Dataflow.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\VSLangProj.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\VSLangProj2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Simovic\Documents\r18024\PI_t18024_Maza\PI_t18024_Maza\bin\Release\VSLangProj80.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
