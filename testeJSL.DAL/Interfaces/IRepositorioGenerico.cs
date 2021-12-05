using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace testeJSL.DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {

        Task<IEnumerable<TEntity>> ConsultarTodos();
        Task<TEntity> ConsultarPorId(int id);
        Task<TEntity> ConsultarPorId(string id);
        Task Inserir (TEntity entity);
        Task Atualizar (TEntity entity);
        Task Excluir(TEntity entity);
        Task Excluir(int id);
        Task Excluir(string id);



    }
}
