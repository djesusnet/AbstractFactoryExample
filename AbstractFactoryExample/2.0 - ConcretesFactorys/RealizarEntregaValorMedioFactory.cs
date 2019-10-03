using AbstractFactoryExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.AbstractFactory
{
    public class RealizarEntregaValorMedioFactory : RealizarEntregaFactory
    {
        public override Entrega CriarEntrega(string localidade, Tipo tipo, string produto)
        {
            return EntregaCreator.Criar(localidade, tipo, produto);
        }

        public override Pedido CriarPedido()
        {
            return PedidoCreator.Criar(Tipo.Express);
        }
    }
}
