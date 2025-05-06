
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LucianoPereyra
{
    public class PiramideCuadrada: IValidatableObject
    {
        
       public int LadoBase { get; }

       public int Altura { get; }

        private double _Apotema;

        public double Apotema => _Apotema;
       

        public PiramideCuadrada(int ladoBase, int altura)
        {
            LadoBase = ladoBase;
            Altura = altura;
            CalcularApotema();
        }

        public PiramideCuadrada()
        {
        }

        private void CalcularApotema()
        {
            _Apotema = Math.Sqrt(Math.Pow(LadoBase / 2.0, 2) + Math.Pow(Altura, 2));
        }

        public double CalcularArea()
        {
            double areaBase = Math.Pow(LadoBase, 2);
            double areaLateral = 2 * (LadoBase * _Apotema);
            return areaBase + areaLateral;
        }

        public double CalcularVolumen()
        {
            return (Math.Pow(LadoBase, 2) * Altura) / 3;
        }

        public string InformarDatos()
        {
           var sb = new StringBuilder();
            sb.AppendLine($"Lado de la base: {LadoBase}");
            sb.AppendLine($"Altura: {Altura}");
            sb.AppendLine($"Apotema: {Apotema}");
            sb.AppendLine($"Área total: {CalcularArea()}");
            sb.AppendLine($"Volumen: {CalcularVolumen()}");
            return sb.ToString();

        }

        public string InformarLadoYAltura()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Lado de la base: {LadoBase}");
            sb.AppendLine($" Altura: {Altura}");
            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (LadoBase <= 0)
            {
                yield return new ValidationResult("El lado de la base debe ser mayor que cero." ,
                    new[] { nameof(LadoBase) }); 
            }
            if (Altura <= 0)
            {
                yield return new ValidationResult("La altura debe ser mayor que cero." ,
                    new[] { nameof(Altura) }); ;
            }

        }
    }
}
