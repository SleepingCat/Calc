using System;
using System.Collections.Generic;
using System.Linq;
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
using CalcusDTO;
using Calcus.BusinessLayer;


namespace calcus
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // private bool current_operand;
        
        private operands Operands = new operands();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumClick(object sender, RoutedEventArgs e)
        {
            Button A = (Button) sender;
            this.tb_res.Text += A.Content.ToString(); 
            
        }

        private void btnOperatorClick(object sender, RoutedEventArgs e)
        {
            Button A = (Button) sender;
            Operands.firstOperand = Convert.ToDecimal(this.tb_res.Text);
            Operands.Operator = A.Content.ToString();
            this.tb_res.Text = "";
        }

        private void btnExecuteClick(object sender, RoutedEventArgs e)
        {
            Operands.secondOperand = Convert.ToDecimal(this.tb_res.Text);

            IHandler handler = new Handler();
            handler.Process(Operands);
            this.tb_res.Text = Operands.result.ToString();
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            this.tb_res.Text = "";
        }
    }
}
