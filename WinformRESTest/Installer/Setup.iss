#define MyAppName "RESTest"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "DevElkami"
#define MyAppURL "https://github.com/DevElkami/RESTest"
#define MyAppDescription "RESTest"
#define MyAppCopyright "(c) 2023, DevElkami. See LICENSE.TXT for details."

[Setup]
AppId={{8277a415-ca33-477f-a272-b871ccbd9755}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=..\..\LICENSE
OutputBaseFilename=RESTest-{#MyAppVersion}
Compression=none
SolidCompression=yes
VersionInfoVersion={#MyAppVersion}
VersionInfoDescription={#MyAppDescription}
VersionInfoTextVersion={#MyAppVersion}
ArchitecturesInstallIn64BitMode=x64
VersionInfoCopyright={#MyAppCopyright}
DisableReadyMemo=yes
AlwaysShowComponentsList=no
DisableReadyPage=yes
CloseApplications=no
OutputDir=Output
MinVersion=6.1sp1
PrivilegesRequiredOverridesAllowed=dialog
WizardStyle=modern

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: ..\bin\Release\net7.0-windows7.0\publish\win-x64\WinformRESTest.exe; DestDir: {app}; Flags: ignoreversion overwritereadonly uninsremovereadonly;
Source: ..\bin\Release\net7.0-windows7.0\publish\win-x64\*.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly uninsremovereadonly;
Source: ..\..\LICENSE; DestDir: {app}; Flags: overwritereadonly uninsremovereadonly; DestName: LICENSE.TXT

[Icons]
Name: {group}\RESTest; Filename: {app}\WinformRESTest.exe; Flags: excludefromshowinnewinstall
Name: "{userdesktop}\{#MyAppName}"; Filename: "{app}\WinformRESTest.exe"; Tasks: desktopicon