using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto
{
    public class Nota: Pedido
    {
    
    public int ValorPedido;
    public int ValorPendente;

    private bool estaAberta(){
        return true == false;
    }

    private bool estaFechada(){
        return true == false;
    }

    public string AdicionarItem(){
        return DescricaoPedido;
    }

    public string RemoverItem(){
        return DescricaoPedido;
    }
    
    }
}