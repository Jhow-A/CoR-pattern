using System;

namespace CoRPattern
{
    // ConcreteHandler
    public class SetorRH : Autorizador
    {
        private const int AutoridadeDias = 30;

        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= AutoridadeDias)
                AprovarLicenca(nome, dias);
            else
                Console.WriteLine($"Não foi possível autorizar a licença de {dias} dias para {nome}.\n *** Comunique a Diretoria ***\n");
        }
        private void AprovarLicenca(string nome, int dias) => 
            Console.WriteLine($"O setor de RH aprovou {dias} dias de licença remunerada para: {nome} \n");
    }
}
