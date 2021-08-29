namespace pilang_installer
{
    public abstract class Strings
    {
        public string BTN_INSTALL = "Install";
        public string WELCOME = "Press 'Install' to install pilang on this machine. You can change the installation path below.";
        public string STEP_DIRECTORY = "Creating and filling runtime directory...";
        public string STEP_REGISTRY = "Referencing runtime in system registry...";
        public string FINISHED = "Finished installing successfully! For the changes to take effect, (re)open all running terminal instances. You can close this window now.";

        public string BTN_CHANGE = "(change)";
        public string INSTALLATION_PATH = "Installation path: {0}";
    }

    public class EnglishStrings : Strings
    {
        // is standard
    }

    public class GermanStrings : Strings
    {
        public string BTN_INSTALL = "Installieren";
        public string WELCOME = "Drücken Sie 'Installieren', um pilang auf diesem Computer zu installieren. Sie können das Installations-Verzeichnis unten anpassen.";
        public string STEP_DIRECTORY = "Laufzeit-Ordner wird erstellt und gefüllt...";
        public string STEP_REGISTRY = "Laufzeit wird im Register verzeichnet...";
        public string FINISHED = "Installation erfolgreich abgeschlossen! Für das Inkrafttreten der Änderungen ist es nötig, alle Terminal-Instanzen (neu) zu öffnen. Dieses Fenster kann jetzt geschlossen werden.";

        public string BTN_CHANGE = "(ändern)";
        public string INSTALLATION_PATH = "Installations-Verzeichnis: {0}";
    }
}