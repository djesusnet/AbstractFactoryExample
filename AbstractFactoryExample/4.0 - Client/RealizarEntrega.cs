using AbstractFactoryExample.Enums;
using System;

namespace AbstractFactoryExample.AbstractFactory
{
    // Client Class
    public class RealizarEntrega
    {
        private readonly Pedido _pedido;
        private readonly Entrega _entrega;

        public RealizarEntrega(RealizarEntregaFactory factory, Entrega entrega)
        {
            _pedido = factory.CriarPedido();
            _entrega = factory.CriarEntrega(entrega.Localidade, entrega.Tipo, entrega.Produto);
        }

        public void RealizarAtendimentoEntrega()
        {
            _pedido.RealizarEntrega(_entrega);
        }

        public static RealizarEntrega RealizarEntregaProduto(Entrega entrega)
        {
            switch (entrega.Tipo)
            {
                case Tipo.Normal:
                    return new RealizarEntrega(new RealizarEntregaValorPequenoFactory(), entrega);
                case Tipo.Express:
                    return new RealizarEntrega(new RealizarEntregaValorMedioFactory(), entrega);
                case Tipo.Personalizado:
                    return new RealizarEntrega(new RealizarEntregaValorGrandeFactory(), entrega);
                default:
                    throw new ApplicationException("Não foi possível identificar a entrega");
            }
        }
    }
}
