using Microsoft.VisualBasic;

namespace Empleado
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadocivil;
        private DateTime fechaingreso;
        private double basico;
        private string cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadocivil, DateTime fechaingreso, double basico, string cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaDeNacimiento = fechaDeNacimiento;
            this.Estadocivil = estadocivil;
            this.Fechaingreso = fechaingreso;
            this.Basico = basico;
            this.Cargo = cargo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char Estadocivil { get => estadocivil; set => estadocivil = value; }
        public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
        public double Basico { get => basico; set => basico = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}