using System;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Adapter.CodigoExistente
{
    public class Servico : IServico
    {
        public bool Executar(BaseRequest request)
        {
            try
            {
                Console.WriteLine("Executando Request: ");
                Console.WriteLine($"Id: {request.Id}");

                foreach (var item in request.Parametros)
                {
                    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
                }

                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
