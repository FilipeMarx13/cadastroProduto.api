using cadastroProdutos.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProduto.Infra.Data.Context
{
    public class Database
    {
        private Database() {
            
        }
        
        private static Database _instance;
       
        public static Database GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

        public static List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
