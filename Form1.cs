using System.ComponentModel;

namespace Aula10estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<string> veiculos = new List<string>(); 
        List<string> temporaria = new List<string>();
        void atualizarListatemporaria()
        {
            temporaria.Clear();
            temporaria.AddRange(veiculos);
        }
        public bool verificarsealgofoiapagado(string item)
        {
            if (temporaria.Contains(item))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool textboxestavazio(TextBox texto)
        {
            if(texto.Text == "")
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        void AdicionarVeiculos()
        {
            if(veiculos.Count >= 5)
            {
                MessageBox.Show("Você atingiu o limite maximo");
                return;
            }
            if(textboxestavazio(txt_Placa) == true)
            {
                MessageBox.Show("Preencha o formulario");
                return;
            }
            int contador = veiculos.Count;
            string nome = txt_Placa.Text;
            if(nome.Length == 6)
            {
                if (!veiculos.Contains(nome))
                {
                    veiculos.Add($"[Vaga] {contador + 1} - {nome}");
                    MessageBox.Show("Parabéns o veiculo foi adicionado com sucesso");
                }
                else
                {
                    MessageBox.Show("O veiculo ja se encontra no nosso estacionamento");
                }
            }
            else
            {
                MessageBox.Show("A placa informada não possui caracteres minimo de (6)");
            }
           


        } 
        void atualizarinteface()
        {
            
            int quantidade_cadastrada = veiculos.Count();
            lbl_contador.Text = $"{quantidade_cadastrada}";
            list_veiculos.Clear();
            foreach (var item in veiculos)
            {
                list_veiculos.Items.Add(item);
            }
        }
        void removerveiculos()
        {
            if(listaestavazia() == true)
            {
                MessageBox.Show("Você nao pode remover");
                return;
            }
            veiculos.RemoveAt(0);
            atualizarListatemporaria();
            atualizarinteface();

        }
        bool listaestavazia()
        {
            if(veiculos.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_estacionar_Click(object sender, EventArgs e)
        {
            
            AdicionarVeiculos();
            for (int i = 0; i < veiculos.Count; i++) 
            {
                list_veiculos.Items.Add($"[Vaga] {i} - {veiculos[i]}");
            }
            atualizarinteface();
            list_veiculos.Show();
        }


        private void btn_retirar_Click(object sender, EventArgs e)
        {
            if(veiculos.Count <= 0)
            {
                MessageBox.Show("Não existem veiculos para retirar");
                return;
            }
            string ultimoNumero = veiculos[veiculos.Count() - 1];
            removerveiculos();
            atualizarinteface();
            list_veiculos.Clear();
            atualizarinteface();
            
            
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if(listaestavazia() == true)
            {
                MessageBox.Show("O sistema esta fechando");
                Update();
                Environment.Exit(0);

            }
            else
            {
                MessageBox.Show("O sistema só pode fechar quando todos os carros estiverem fora");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}