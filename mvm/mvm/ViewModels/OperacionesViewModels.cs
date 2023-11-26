using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace mvm.ViewModels
{
    public class OperacionesViewModels : ViewModelBase
    {
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor3;
        public int Valor3
        {
            get { return valor3; }
            set
            {
                if (valor3 != value)
                {
                    valor3 = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultado;
        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Sumar { protected set; get; }

        public ICommand Restar { protected set; get; }

        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }



        public OperacionesViewModels()
        {
            Sumar = new Command(() =>
            {
                Resultado = Valor1 + Valor2 + Valor3;

            });

            Restar = new Command(() =>
            {
                Resultado = Valor1 - Valor2 - Valor3;
            });


            Multiplicar = new Command(() =>
            {
                Resultado = Valor1 * Valor2 * Valor3;

            });

            Dividir = new Command(() =>
            {
                if (Valor2 != 0 && Valor3 != 0)
                {
                    Resultado = Valor1 / (Valor2 * Valor3);
                }
                else
                {
                   
                }

            });
        }
    }
}