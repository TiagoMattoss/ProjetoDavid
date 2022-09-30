using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto

    
    {

        public class Pizza
        { 
         Pizza NovaPizza =  new Pizza();
        public string Sabor;
        public int Tamanho; 
        public double Preco;
        
        public string IngredienteExtra;

            public void saborPizza()
        {
            Console.WriteLine("Tomate", "Tempero", "queijo"); 
        } 

            public void tamanhoPizza()
        {
            Console.WriteLine("Pequena", "Grande", "Gigante"); 
        }
             public void PrecoPizza()
        {
        
            Console.WriteLine("30", "40", "50"); 
        }
             public void IngredientesExtra()
        {
        
            Console.WriteLine("Borda Recheada", "Refrigerante"); 
        }

    }
    }
