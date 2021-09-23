using System;

namespace CoRPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            GerenteProjeto gerenteProjeto = new ();
            SupervisorEquipe supervisorEquipe = new ();
            SetorRH setorRH = new ();

            gerenteProjeto.ProximoAutorizador(supervisorEquipe);
            supervisorEquipe.ProximoAutorizador(setorRH);

            gerenteProjeto.AutorizarLicenca("Gabriel", 3);
            gerenteProjeto.AutorizarLicenca("Amanda", 12);
            gerenteProjeto.AutorizarLicenca("Matheus", 24);
            gerenteProjeto.AutorizarLicenca("Alice", 45);
        }
    }
}
