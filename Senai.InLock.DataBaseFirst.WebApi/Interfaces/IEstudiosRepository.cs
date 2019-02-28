using Senai.InLock.DataBaseFirst.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.InLock.DataBaseFirst.WebApi.Interfaces
{
    interface IEstudiosRepository
    {
        List<Estudios> Listar();
        void Cadastrar(Estudios estudio);
        void Atualizar(Estudios estudio);
        void Excluir(Estudios estudio);
    }
}
