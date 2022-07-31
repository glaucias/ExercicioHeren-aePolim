

namespace HeranPolimEx1.Entites
{   //Classe FUNCIONARIO TERCERIZADO
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        //Para librar a funcão pagamento da classe que herdamos,
        //Precisamos incluir a palavra VIRTUL antes do tipo da classe pagamento
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
        : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
