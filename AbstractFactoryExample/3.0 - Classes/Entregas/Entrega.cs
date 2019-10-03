using AbstractFactoryExample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample.AbstractFactory
{
    // AbstractProduct 
    public abstract class Entrega
    {
        public string Localidade { get; set; }
        public Tipo Tipo { get; set; }

        public string Produto { get; set; }

        protected Entrega(string localidade, Tipo tipo, string produto)
        {
            Localidade = localidade;
            Tipo = tipo;
            Produto = produto;
        }

    }
    public class EntregaNormal : Entrega
    {
        public EntregaNormal(string localidade, Tipo tipo, string produto) : base(localidade, tipo, produto)
        {
        }
    }

    // Produto Concreto
    public class EntregaExpress : Entrega
    {
        public EntregaExpress(string localidade, Tipo tipo, string produto) : base(localidade, tipo, produto)
        {
        }
    }

    // Produto Concreto
    public class EntregaPersonalizado : Entrega
    {
        public EntregaPersonalizado(string localidade, Tipo tipo, string produto) : base(localidade, tipo, produto)
        {
        }
    }

    public class EntregaCreator
    {
        public static Entrega Criar(string Localidade, Tipo tipo, string Produto)
        {
            switch (tipo)
            {
                case Tipo.Normal:
                    return new EntregaNormal(Localidade, tipo, Produto);
                case Tipo.Express:
                    return new EntregaExpress(Localidade, tipo, Produto);
                case Tipo.Personalizado:
                    return new EntregaPersonalizado(Localidade, tipo, Produto);
                default:
                    throw new ApplicationException("Tipo de Entrega Desconhecido.");
            }
        }
    }
}
