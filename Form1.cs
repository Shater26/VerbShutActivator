using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace VerbShutActivator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void EnsureElevated()
        {
            if (!IsAdministrator())
            {
                try
                {
                    ProcessStartInfo proc = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        WorkingDirectory = Environment.CurrentDirectory,
                        FileName = Application.ExecutablePath,
                        Verb = "runas"
                    };
                    Process.Start(proc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Se requieren permisos de administrador para esta acción.", "Permisos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Application.Exit();
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            EnsureElevated();

            if (EnableVerboseShutdownPolicy())
            {
                MessageBox.Show("Mensajes detallados activados correctamente mediante Directivas de Grupo Local.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (EnableVerboseShutdownRegistry())
            {
                MessageBox.Show("Este usuario no puede editar Directivas de Grupo Local. Mensajes detallados activados correctamente mediante el Registro de Windows.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron editar las Directivas de Grupo Local. Intente ejecutar el programa de nuevo como administrador. Los cambios no han sido guardados en el Equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            EnsureElevated();

            if (DisableVerboseShutdownPolicy())
            {
                MessageBox.Show("Mensajes detallados desactivados correctamente mediante Directivas de Grupo Local.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DisableVerboseShutdownRegistry())
            {
                MessageBox.Show("Este usuario no puede editar Directivas de Grupo Local. Mensajes detallados desactivados correctamente mediante el Registro de Windows.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron editar las Directivas de Grupo Local. Intente ejecutar el programa de nuevo como administrador. Los cambios no han sido guardados en el Equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EnableVerboseShutdownPolicy()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System", true))
                {
                    if (key != null)
                    {
                        key.SetValue("VerboseStatus", 1, RegistryValueKind.DWord);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private bool EnableVerboseShutdownRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true))
                {
                    if (key != null)
                    {
                        key.SetValue("verbosestatus", 1, RegistryValueKind.DWord);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private bool DisableVerboseShutdownPolicy()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System", true))
                {
                    if (key != null)
                    {
                        key.SetValue("VerboseStatus", 0, RegistryValueKind.DWord);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private bool DisableVerboseShutdownRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true))
                {
                    if (key != null)
                    {
                        key.DeleteValue("verbosestatus", false);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
