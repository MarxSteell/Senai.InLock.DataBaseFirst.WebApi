using Senai.InLock.DataBaseFirst.WebApi.Domains;
using System.Collections.Generic;

namespace Senai.InLock.DataBaseFirst.WebApi.Interfaces
{
    interface IJogosRepository
    {
        List<Jogos> Listar();
        void Cadastrar(Jogos jogo);
        void Atualizar(Jogos jogo);
        void Excluir(Jogos jogo);
    }
}
