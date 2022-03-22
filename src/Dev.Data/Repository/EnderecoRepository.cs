using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.App.Data;
using Microsoft.EntityFrameworkCore;

namespace Dev.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                    .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
