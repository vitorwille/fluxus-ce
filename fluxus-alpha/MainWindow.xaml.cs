using fluxus_alpha.Classes;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fluxus_alpha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Produtos { get; set; } // importa dados da classe

        public MainWindow()
        {
            InitializeComponent();

            Produtos = new ObservableCollection<Product>
            {
                new Product
                {
                    idProduto = 1,
                    produto = "Tecido Azul",
                    obsProduto = "Cor azul royal",
                    qtdProduto = 10,
                    valorProduto = 15.5f
                },
                new Product
                {
                    idProduto = 2,
                    produto = "Linha Preta",
                    obsProduto = "100% algodão",
                    qtdProduto = 25,
                    valorProduto = 4.2f
                },
                new Product
                {
                    idProduto = 3,
                    produto = "Teste foda",
                    obsProduto = "te amo Sarah <3",
                    qtdProduto = 999,
                    valorProduto = 178.99f
                }
            };

            dgProdutos.ItemsSource = Produtos;
        }
    }
}