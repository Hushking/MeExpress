using MeExpress.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeExpress.ApplicationServices
{
    public class ProdutoAppService : IProdutoAppService
    {
        private IProdutoRepository produtoRepository;
        public ProdutoAppService(IProdutoRepository produtoRepositoryInstance)
        {
            this.produtoRepository = produtoRepositoryInstance;
        }
        public List<Produto> ObterList()
        {
            return produtoRepository.ObterList();
        }
    }
}
