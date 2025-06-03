using Microsoft.VisualBasic;

namespace esEmpleado
{
    public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadocivil;
        private DateTime fechaingreso;
        private double basico;
        private Cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNacimiento, char estadocivil, DateTime fechaingreso, double basico, Cargos cargo)
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
        public Cargos Cargo { get => cargo; set => cargo = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Jubilacion { get => jubilacion; }
        public double Salario { get => salario; }
        public double Adiciona { get => adicional; }

        private int antiguedad;
        private int edad;
        private int jubilacion;
        private double salario;
        private double adicional = 0;

        public void calcAntiguedad(DateTime fechaingreso)
        {
            antiguedad = DateTime.Now.Year - fechaingreso.Year;
        }

        public void calcEdad(DateTime fechadenacimiento)
        {
            edad = DateTime.Now.Year - fechadenacimiento.Year;
        }

        public void calcJubilacion()
        {
            jubilacion = 65 - (DateTime.Now.Year - fechaDeNacimiento.Year);
        }

        public void calcSalario(double basico, int antiguedad, char estadocivil, Cargos cargo)
        {
            if (antiguedad > 0 && antiguedad < 21)
            {
                adicional = basico * (antiguedad / 100.0);
            }
            else
            {
                adicional = basico * 0.25;
            }

            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional = adicional * 1.50;
            }

            if (estadocivil == 'c')
            {
                adicional += 150000;
            }

            salario = basico + adicional;
        }
    }
}
