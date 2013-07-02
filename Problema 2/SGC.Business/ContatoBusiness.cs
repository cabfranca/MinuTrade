using System.Collections.Generic;
using SGC.Comum.Entities;
using SGC.DAL;

namespace SGC.Business
{
    public class ContatoBusiness
    {
        public IEnumerable<Contato> ObtemTodos()
        {
            return (new ContatoDAL()).GetAll();
        }

        public void Insere(Contato pContato)
        {
            (new ContatoDAL()).Create(pContato);
        }

        public void InsereLista(IEnumerable<Contato> pContatoList)
        {
            var contatoDAL = new ContatoDAL();

            foreach (var contato in pContatoList)
                contatoDAL.Create(contato);
        }

        public IEnumerable<Contato> LoadFromFile(string pFileName)
        {
            return (new ContatoDAL()).LoadFromFile(pFileName);
        }
    }
}
