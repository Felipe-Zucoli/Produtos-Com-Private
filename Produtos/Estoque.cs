using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
     class Estoque
    {
       private string _nameProd;
       private double _precoProd;
       private int _quantProd;

        public double _valorTotal()
        {
           return _precoProd* _quantProd;
        }
        public void AdicionarProduto (int quantidade)
        {
            _quantProd = _quantProd + quantidade;
        }
        public void RetirarProduto (int quantidade)
        {
            _quantProd = _quantProd - quantidade;
        }

        public Estoque (string nome, double preco, int quantidade)
        {
            _nameProd = nome;
            _precoProd = preco;
            _quantProd = quantidade;
        }
        public string GetName ()
        {
            return _nameProd;
        }
        

        public double GetPrecoProd()
        {
            return _precoProd;
        }

        public int GetQuantProd() { 
            return _quantProd;
        }

        public void SetName (string nome)
        {
            if (nome != null && nome.Length > 2) { 
            _nameProd=nome;
            } else
            {
                Console.WriteLine("Erro, nome inválido!");
            }
        }

        

        public override string ToString()
        {
            return _nameProd + ",Preço $" + _precoProd + ", Quantidade " + _quantProd +",Valor total $" + _valorTotal();
        }
    }
}
