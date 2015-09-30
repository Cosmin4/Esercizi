using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Persona
    {
        //ATRIBUTI 
        private string _nome = "";
        private float _salario = 0.0F;
        private DateTime _dataDiNascita;

     

        //PROPERTY
        public string Nome
        { 
            get {return _nome; }
            set {_nome=value;} 
        }
        public float Salario
        {
            get {return _salario; }
            set {_salario = (value >= 0 ? value : 0.0f); }
        }
        /*public DateTime DataDiNAscita
        {
            get {return _dataDiNascita;}
            set {_dataDiNascita = (value < DateTime.now) ? value : DateTime.now;}
        }
        */
        public DateTime DataDiNascita
        {
            get
            {
                return _dataDiNascita;
            }

            set
            {
                _dataDiNascita = value;
            }
        }

        //COSTRUTTORI
        public Persona(string nome, float salario, DateTime dataDiNascita)
            {
                this.Nome = nome;
                this.Salario = salario;
                this.DataDiNascita = dataDiNascita;
            }
        public override string ToString()
        {
            return "Nome: " + this.Nome + "\nSalario: " + this.Salario + "\nData di nascita: " + this.DataDiNascita.ToString("dd-mm-yyyy");
        }



    }
}
