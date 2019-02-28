using Senai.InLock.DataBaseFirst.WebApi.Comains;
using Senai.InLock.DataBaseFirst.WebApi.Domains;
using Senai.InLock.DataBaseFirst.WebApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Senai.InLock.DataBaseFirst.WebApi.Repositories
{
    public class EstudioRepository :IEstudiosRepository
    {
        public void Atualizar(Estudios estudio)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Estudios.Update(estudio);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Estudios estudio)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Estudios.Add(estudio);
                ctx.SaveChanges();
            }
        }

        public void Excluir(Estudios estudio)
        {
            using (InLockContext ctx = new InLockContext())
            {
                ctx.Estudios.Remove(estudio);
                ctx.SaveChanges();
            }
        }

        public List<Estudios> Listar()
        {
            using (InLockContext ctx = new InLockContext())
            {
                return ctx.Estudios.ToList();
            }
        }
    }
}
