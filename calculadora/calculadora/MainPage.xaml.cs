using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        Operaciones operador;
       private   float num1, num2;
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            validar(txtNum1.Text, txtNum2.Text);
            operador = new Operaciones(num1, num2);
            var resultado = new {resultado=operador.divicion()};
            var secondPage = new segundaPagina();
            secondPage.BindingContext = resultado;
            Navigation.PushAsync(secondPage);
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            validar(txtNum1.Text, txtNum2.Text);
            operador = new Operaciones(num1, num2);
            var resultado = new { resultado = operador.multiplicacion() };
            var secondPage = new segundaPagina();
            secondPage.BindingContext = resultado;
            Navigation.PushAsync(secondPage);
        
    }

        private void btnRestar_Clicked(object sender, EventArgs e)
        {
            validar(txtNum1.Text, txtNum2.Text);
            operador = new Operaciones(num1, num2);
            var resultado = new { resultado = operador.resta() };
            var secondPage = new segundaPagina();
            secondPage.BindingContext = resultado;
            Navigation.PushAsync(secondPage);
       
    }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            validar(txtNum1.Text, txtNum2.Text);
            operador = new Operaciones(num1, num2);
            var resultado = new { resultado = operador.suma() };
            var secondPage = new segundaPagina();
            secondPage.BindingContext = resultado;
            Navigation.PushAsync(secondPage);
        
    }
        void validar(String num1, String num2)
        {
            this.num1 = (num1 == null || num1.Equals("")) ? 0 : float.Parse(num1);
            this.num2 = (num1 == null || num1.Equals("")) ? 0 : float.Parse(num2);

        }
    }
}
