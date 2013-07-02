using System.Collections.Generic;
using System.IO;
using System.Linq;
using SGC.Comum.Entities;

namespace SGC.DAL
{
    public class ContatoDAL
    {
        private SGCContexto _SGCContexto = new SGCContexto();

        public IEnumerable<Contato> GetAll()
        {
            return _SGCContexto.Contato.ToList();
        }

        public void Create(Contato pContato)
        {
            _SGCContexto.Contato.Add(pContato);
            _SGCContexto.SaveChanges();
        }

        public IEnumerable<Contato> LoadFromFile(string pFileName)
        {
            var contatosCarga = new List<Contato>();
            var allLines = File.ReadAllLines(pFileName);

            foreach (var line in allLines)
            {
                var contato = new Contato();

                contato.Nome                = line.Substring(0, 20).TrimEnd();
                contato.Email               = line.Substring(20, 20).TrimEnd();
                contato.DataNascimento      = line.Substring(40, 8).TrimEnd();
                contato.Celular             = line.Substring(48, 15).TrimEnd();
                contato.TelefoneResidencial = line.Substring(63, 15).TrimEnd();

                contatosCarga.Add(contato);
            }

            return contatosCarga;
        }
    }
}
