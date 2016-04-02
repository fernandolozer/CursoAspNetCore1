using static System.Console;
using System;
using System.ComponentModel;

namespace LinguagemCS6
{
    class ExpressoesNameOf
    {
        static void Main(string[] args)
        {
            string factory = "microsoft";
            DateTime lancto = new DateTime(2015, 5, 15);
            WriteLine($"fabricante: {factory} - lançamento: {lancto}");
            WriteLine($"fabricante: {nameof(factory)} - lançamento: {nameof(lancto)}");

            var c = new carro2 { ID = 1, Modelo = "bmw X3", Ano = 2012, Cor = "azul" };
            WriteLine($"{nameof(c.Modelo)}: {c.Modelo}");

            Console.ReadLine();
        }
    }

    public class carro2
    {
        //if (modelo == null)
        //    throw new ArgumentException("modelo");
        public int ID { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }

    class Livro : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _titulo;

        public string Titulo
        {
            get { return _titulo ?? ""; }
            set
            {
                if (_titulo != value)
                {
                    _titulo = value;
                    OnPropertyChanged(nameof(Titulo));
                };
            }
        }

        protected virtual void OnPropertyChanged(string livro)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(livro));
        }
    }
}
