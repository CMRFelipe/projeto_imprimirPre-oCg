using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprimirPreçoCg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string linha;
        string stringCompleta;
        public void imprimir()
        {
            string zplCommand = stringCompleta;

            string printerIpAddress = "10.40.2.104"; // Substitua pelo endereço IP da impressora Zebra na rede

            //// Crie uma instância do PrintDialog
            //PrintDialog printDialog = new PrintDialog();

            //// Exiba o diálogo de impressão
            //DialogResult result = printDialog.ShowDialog();

            //string printerIp = Convert.ToString(printDialog.PrinterSettings.PrinterName);
            try
            {
                using (TcpClient client = new TcpClient(printerIpAddress, 9100))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes(zplCommand);
                        stream.Write(buffer, 0, buffer.Length);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar o comando ZPL: {ex.Message}");
            }
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog paste = new OpenFileDialog();


            paste.Filter = "All files (*.txt)|*.txt";
            paste.Title = "Selecione o arquivo";
            paste.ShowDialog();

            string csv = paste.FileName;

            StreamReader lerArquivo = new StreamReader(File.OpenRead(csv));


            while ((linha = lerArquivo.ReadLine()) != null)
            {
                stringCompleta = stringCompleta + linha;
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
