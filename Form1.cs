using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listar_nombres_de_archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ListFilesRecursively(string directory)
        {
            foreach (string file in Directory.GetFiles(directory))
            {
                listBoxFiles.Items.Add($"Archivo: {Path.GetFileName(file)}, Extensión: {Path.GetExtension(file)}");
                listBoxFiles.Items.Add("---------------------------------------------------------------------------------------------------");
            }

            foreach (string subdirectory in Directory.GetDirectories(directory))
            {
                ListFilesRecursively(subdirectory);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            string path = @"C:\Users\jesus\OneDrive\Escritorio\MUSICA"; // Cambia esto a la ruta de tu directorio raíz
            ListFilesRecursively(path);
        }
    }
}
