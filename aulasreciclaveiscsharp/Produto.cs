using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace aulasreciclaveiscsharp
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _nome = "produto";
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco;  }
            set
            {
                if (value != 0)
                {
                    _preco = value;
                }
            }
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double Total()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " Unidades em estoque, " + "Preço total: $" + Total();
        }
    }
}
