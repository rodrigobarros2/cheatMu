using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace cheatMu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento do botão para capturar o processo
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            // Limpa a ListBox antes de adicionar novos itens
            listBoxMemoria.Items.Clear();

            // Nome do processo que queremos capturar
            string nomeProcesso = "mumad";  // Nome fixo do processo (sem .exe)

            // Lista todos os processos em execução no sistema
            Process[] processos = Process.GetProcesses();

            bool processoEncontrado = false;

            foreach (Process processo in processos)
            {
                // Verifica se o nome do processo é igual a 'mumad'
                if (processo.ProcessName.Equals(nomeProcesso, StringComparison.OrdinalIgnoreCase))
                {
                    listBoxMemoria.Items.Add("Processo encontrado: " + processo.ProcessName);
                    processoEncontrado = true;
                }
            }

            if (!processoEncontrado)
            {
                listBoxMemoria.Items.Add("Processo 'mumad' não encontrado.");
            }
        }
    }
}
