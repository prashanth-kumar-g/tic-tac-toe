;-----------------------------------------------------------------
; Inno Setup Script for Tic Tac Toe (.NET) Desktop Application
;-----------------------------------------------------------------

[Setup]
; 1) Application name shown internally and in registry
AppName=Tic Tac Toe

; 2) Version string used internally (not shown to user)
AppVersion=1.0.0

; 3) Display name shown in Programs & Features and installer window
AppVerName=Tic Tac Toe

; 4) Publisher name (your name or organization)
AppPublisher=Prashanth Kumar G

; 5) File metadata: version shown in .exe properties
VersionInfoVersion=1.0.0
VersionInfoProductVersion=1.0.0

; 6) Default installation path under Program Files
DefaultDirName={pf}\Tic Tac Toe

; 7) Default Start Menu folder name
DefaultGroupName=Tic Tac Toe

; 8) Skip the “Select Start Menu folder” page
DisableProgramGroupPage=yes

; 9) Ensure the application folder is created under Program Files
CreateAppDir=yes

;10) Require administrator privileges
PrivilegesRequired=admin

;11) Prevent setup from asking for restart at end
AlwaysRestart=no

;12) Where to place the compiled Setup.exe (relative to this script)
OutputDir=.\Package

;13) Create a Icon for “Programs and Features” uninstall entry
UninstallDisplayIcon={app}\Tic Tac Toe.exe

;14) Base filename for the installer
OutputBaseFilename=TicTacToe_Setup

;15) Use LZMA compression for smaller installer size
Compression=lzma
SolidCompression=yes

;16) Icon to display on the setup .exe itself
SetupIconFile=bin\Release\images\Tic Tac Toe icon.ico

[Languages]
; Use English for installer UI
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
; Main executable and configuration
Source: "bin\Release\Tic Tac Toe.exe";        DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\Tic Tac Toe.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Release\Tic Tac Toe.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion

; All image assets
Source: "bin\Release\images\*"; DestDir: "{app}\images"; \
  Flags: recursesubdirs createallsubdirs ignoreversion

[Icons]
; Desktop shortcut
Name: "{autodesktop}\Tic Tac Toe"; \
  Filename: "{app}\Tic Tac Toe.exe"; \
  IconFilename: "{app}\images\Tic Tac Toe icon.ico"; \
  WorkingDir: "{app}"

; Start Menu shortcut
Name: "{commonprograms}\Tic Tac Toe"; \
  Filename: "{app}\Tic Tac Toe.exe"; \
  IconFilename: "{app}\images\Tic Tac Toe icon.ico"; \
  WorkingDir: "{app}"

[Run]
; (No post-install actions required)

[UninstallDelete]
; Clean up the images folder on uninstall
Type: filesandordirs; Name: "{app}\images"