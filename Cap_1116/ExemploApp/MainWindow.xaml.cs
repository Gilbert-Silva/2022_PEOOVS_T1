using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExemploApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Aluno obj;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            obj = new Aluno(txt1.Text);
            txt2.Text = obj.Iniciais();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[] vetor = obj.Senha();
            Random r = new Random();
            int x = r.Next(0, vetor.Length);
            txt2.Text = vetor[x].ToString();
        }
    }
}
