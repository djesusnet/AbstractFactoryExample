using AbstractFactoryExample.Enums;
using System.Collections.Generic;

namespace AbstractFactoryExample.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            
 
            var entregas = new List<Entrega>
            {
                EntregaCreator.Criar("São Paulo", Tipo.Normal, " Tenis Adidas"),
                EntregaCreator.Criar("Lisboa ", Tipo.Express, " Tenis Nike"),
                EntregaCreator.Criar("Coimbra  ", Tipo.Personalizado, "  Tv 54")
            };

            entregas.ForEach(v => RealizarEntrega.RealizarEntregaProduto(v).RealizarAtendimentoEntrega());
        }
    }
}
