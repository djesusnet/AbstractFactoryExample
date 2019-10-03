using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.AbstractFactory
{

    // Abstract Factory
    public abstract class RealizarEntregaFactory
    {
        public abstract Pedido CriarPedido();
        public abstract Entrega CriarEntrega(string localidade, Tipo tipo, string produto);
    }
}
