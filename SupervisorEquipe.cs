using System;

namespace CoRPattern
{
    // ConcreteHandler
    public class SupervisorEquipe : Autorizador
    {
        private const int AutoridadeDias = 15;

        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= AutoridadeDias)
                AprovarLicenca(nome, dias);
            else
                _autorizador?.AutorizarLicenca(nome, dias);
        }
        private void AprovarLicenca(string nome, int dias) =>
            Console.WriteLine($"O Supervisor da Equipe aprovou {dias} dias de licença remunerada para: {nome} \n");
    }
}
