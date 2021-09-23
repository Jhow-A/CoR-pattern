using System;

namespace CoRPattern
{
    // ConcreteHandler
    public class GerenteProjeto : Autorizador
    {
        private const int AutoridadeDias = 5;

        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= AutoridadeDias)
                AprovarLicenca(nome, dias);
            else
                _autorizador?.AutorizarLicenca(nome, dias);
        }

        private void AprovarLicenca(string nome, int dias) =>
            Console.WriteLine($"O Gerente de Projeto aprovou {dias} dias de licença remunerada para: {nome} \n");
    }
}
