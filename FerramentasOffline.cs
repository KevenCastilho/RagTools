using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RagTools
{
    public partial class FerramentasOffline : Form
    {
        public FerramentasOffline()
        {
            InitializeComponent();
            btnAbrir.MouseEnter += new EventHandler(button1_MouseEnter);
            btnAbrir.MouseLeave += new EventHandler(button1_MouseLeave);
            btnVoltar.MouseEnter += new EventHandler(button6_MouseEnter);
            btnVoltar.MouseLeave += new EventHandler(button6_MouseLeave);
            txtCreditos.MouseEnter += new EventHandler(txtCreditos_MouseEnter);
            txtCreditos.MouseLeave += new EventHandler(txtCreditos_MouseLeave);
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string PastaExecutaveis = "\\Executaveis\\";
            string DiretorioExecutaveis = DiretorioAtual + PastaExecutaveis;
            if (!Directory.Exists(DiretorioExecutaveis))
            {
                Directory.CreateDirectory(DiretorioExecutaveis);
            }
            DirectoryInfo Executaveis = new DirectoryInfo(DiretorioExecutaveis);
            FileInfo[] Programas = Executaveis.GetFiles("*.exe", SearchOption.TopDirectoryOnly);
            if (Programas.Length < 1)
            {
                cboProgramas.Items.Add("Nenhum Programa Encontrado!");
                cboProgramas.Enabled = false;
                cboProgramas.SelectedIndex = 0;
                btnAbrir.Enabled = false;
            }

            foreach (FileInfo exe in Programas)
            {
                cboProgramas.Items.Remove(exe.Name);
                cboProgramas.Items.Add(exe.Name);
            }
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbrir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btnAbrir.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_MINI_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Botão 6

        void button6_MouseLeave(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_1));
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void button6_MouseEnter(object sender, EventArgs e)
        {
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BTN_2));
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        // Txt Créditos
        void txtCreditos_MouseLeave(object sender, EventArgs e)
        {

            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }


        void txtCreditos_MouseEnter(object sender, EventArgs e)
        {
            Cursor cur = new Cursor(Properties.Resources.link.Handle);
            this.Cursor = cur;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cursor cur = new Cursor(Properties.Resources.point.Handle);
            this.Cursor = cur;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/keven.castilho");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu Menu = new MainMenu();
            Menu.Show();
            this.Visible = false;
        }

        private void btnSprites_Click(object sender, EventArgs e)
        {
            Sprites SpriteList = new Sprites();
            SpriteList.Show();
            this.Visible = false;
        }

        private void btnSimuladores_Click(object sender, EventArgs e)
        {
            Simuladores SimuladoresList = new Simuladores();
            SimuladoresList.Show();
            this.Visible = false;
        }

        private void btnDBOld_Click(object sender, EventArgs e)
        {
            DB_Old NavegaDBOld = new DB_Old();
            NavegaDBOld.Show();
            this.Visible = false;
        }

        private void txtCreditos_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linktr.ee/keven.castilho");
        }

        private void btnDBRe_Click(object sender, EventArgs e)
        {
            DB_RE NavegaDB_RE = new DB_RE();
            NavegaDB_RE.Show();
            this.Visible = false;
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            Adicional NavegaAdicional = new Adicional();
            NavegaAdicional.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string PastaExecutaveis = "\\Executaveis\\";
            string DiretorioExecutaveis = DiretorioAtual + PastaExecutaveis;
            if (String.IsNullOrEmpty(cboProgramas.Text.ToString()))
            {
                MessageBox.Show("Selecione um item antes de continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String ItemSelecionado = cboProgramas.SelectedItem.ToString();
            ProcessStartInfo Programa = new ProcessStartInfo(DiretorioExecutaveis+ItemSelecionado);
            Process.Start(Programa).WaitForExit();
        }

        private void cboProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DiretorioAtual = Directory.GetCurrentDirectory();
            string executaveis = "\\Executaveis\\";
            string DiretorioExecutaveis = DiretorioAtual + executaveis;

        }
    }
}
