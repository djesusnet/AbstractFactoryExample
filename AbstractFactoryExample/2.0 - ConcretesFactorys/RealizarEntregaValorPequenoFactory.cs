using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryExample.Enums;

namespace AbstractFactoryExample.AbstractFactory
{
    public class RealizarEntregaValorPequenoFactory : RealizarEntregaFactory
    {
        public override Entrega CriarEntrega(string localidade, Tipo tipo, string produto)
        {
           return EntregaCreator.Criar(localidade, tipo, produto);
        }

        public override Pedido CriarPedido()
        {
           return PedidoCreator.Criar(Tipo.Normal);
        }

      
    }
}
