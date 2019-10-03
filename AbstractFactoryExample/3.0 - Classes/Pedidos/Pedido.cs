using AbstractFactoryExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.AbstractFactory
{

    // AbstractProduct 
    public abstract class Pedido
    {
        public Tipo Tipo { get; set; }
        public abstract void RealizarEntrega(Entrega entrega);

        protected Pedido(Tipo tipo)
        {
            Tipo = tipo;

        }

    }
    public class PedidoValorPequeno : Pedido
    {
        public PedidoValorPequeno(Tipo tipo) : base(tipo) { }

        public override void RealizarEntrega(Entrega entrega)
        {
            // Processo de entrega
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Realizado com sucesso o pedido com valor pequeno  - Produto:  " + entrega.Produto);
            Console.WriteLine("Localidade:  " + entrega.Localidade);
            Console.WriteLine("TipoEntrega:   " + entrega.Tipo);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }

    // Produto Concreto
    public class PedidoValorMedio : Pedido
    {
        public PedidoValorMedio(Tipo tipo) : base(tipo) { }
        public override void RealizarEntrega(Entrega entrega)
        {
            // Processo de entrega
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Realizado com sucesso o pedido com valor médio  - Produto:  " + entrega.Produto);
            Console.WriteLine("Localidade:  " + entrega.Localidade);
            Console.WriteLine("TipoEntrega:   " + entrega.Tipo);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }

    // Produto Concreto
    public class PedidoValorGrande : Pedido
    {
        public PedidoValorGrande(Tipo tipo) : base(tipo) { }

        public override void RealizarEntrega(Entrega entrega)
        {
            // Processo de entrega
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Realizado com sucesso o pedido com valor grande  - Produto:  " + entrega.Produto);
            Console.WriteLine("Localidade:  " + entrega.Localidade);
            Console.WriteLine("TipoEntrega:   " + entrega.Tipo);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }

    public class PedidoCreator
    {
        public static Pedido Criar(Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.Normal:
                    return new PedidoValorPequeno(tipo);
                case Tipo.Express:
                    return new PedidoValorMedio(tipo);
                case Tipo.Personalizado:
                    return new PedidoValorGrande(tipo);
                default:
                    throw new ApplicationException("Tipo de Entrega desconhecido.");
            }
        }
    }
}
