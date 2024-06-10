using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUnit_App1
{
    public partial class Form1 : Form
    {
        string filePath = "connection.ini";
        private SqlConnection sqlConnection;
        bool checkConnection = false;
        private string script = "SMCDatenManagementTool.sql";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void CreateIniFile(string filePath, string server, string database, string username, string password)
        {
            // Überprüfet, ob die INI-Datei bereits existiert
            if (!File.Exists(filePath))
            {
                // Verschlüsselet die Verbindungsinformationen
                string encryptedServer = ProtectString(server);
                string encryptedDatabase = ProtectString(database);
                string encryptedUsername = ProtectString(username);
                string encryptedPassword = ProtectString(password);

                // erstellet die INI-Datei
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Schreibet die verschlüsselten Verbindungsinformationen in die Datei
                    sw.WriteLine("[SQLServer]");
                    sw.WriteLine("Server=" + encryptedServer);
                    sw.WriteLine("Database=" + encryptedDatabase);
                    sw.WriteLine("Benutzername=" + encryptedUsername);
                    sw.WriteLine("Passwort=" + encryptedPassword);
                }

                if (File.Exists(filePath))
                {
                    MessageBox.Show("conniction.ini-Datei wurde erstellen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        public  string ProtectString(string input)
        {
            // Konvertiert den Eingabe-String in ein Byte-Array mit Unicode-Kodierung.
            byte[] bytes = Encoding.Unicode.GetBytes(input);

            // Verschlüsselt das Byte-Array mit der ProtectedData-Klasse.
            // ProtectedData.Protect verwendet die Data Protection API (DPAPI) von Windows.
            // - Das zweite Argument , das zusätzliche Daten für die Verschlüsselung bereitstellen kann (hier null).
            // - Das dritte Argument bedeutet, dass alle Benutzer auf dem Computer die Daten entschlüsseln können.
            byte[] protectedBytes = ProtectedData.Protect(bytes, optionalEntropy: null, DataProtectionScope.LocalMachine);

            // Konvertiert das verschlüsselte Byte-Array in einen Base64-String und gibt ihn zurück.
            return Convert.ToBase64String(protectedBytes);
        }

        private void SQLConn(string servername, string dbname, string benutzer, string passwort)
        {
            // Verbindungszeichenfolge zur SQL Server-Datenbank
            string connectionString = $"Data Source={servername};Initial Catalog={dbname};User ID={benutzer};Password={passwort}";
            try
            {
                // Verbindung zur Datenbank herstellen
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    checkConnection = true;
                    if (File.Exists(script))
                    {
                        string[] commands = File.ReadAllText(script).Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string commandText in commands)
                        {
                            using (SqlCommand command = new SqlCommand(commandText, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("SQL-Skript wurde erfolgreich ausgeführt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("SQL-Skript wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                if (checkConnection)
                {
                    MessageBox.Show($"Fehler beim Ausführen des Skripts. {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Fehler beim Verbindungsaufbau. {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLConn(txtServername.Text, txtDatenbankname.Text, txtUserpassword.Text, txtSQLuser.Text);
        }

     

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (checkConnection)
            {
                CreateIniFile(filePath, txtServername.Text, txtDatenbankname.Text, txtUserpassword.Text, txtSQLuser.Text);
            }
            else
            {
                MessageBox.Show("Bitte die Verbindung zuerst testen.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerbindungstesten_Click(object sender, EventArgs e)
        {
            SQLConn(txtServername.Text, txtDatenbankname.Text, txtUserpassword.Text, txtSQLuser.Text);
        }
    }
}
