using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto
{
    public class Pedido
    {
        Pedido NovoPedido =  new Pedido();
        private int idPedido;
        public string ?DescricaoPedido = "sabor", Preco, tamanhoPizza;
        public double ValorInicial;
        public double ValorTotal;


       public int CriaPedido(){
        return idPedido;
    }

    public string CadastraPedido(){
        return DescricaoPedido;
    }

    public double AdicionarValorInicial(){
        return ValorInicial;
    }

    }
}