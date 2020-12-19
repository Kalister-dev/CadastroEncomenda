using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEncomenda.Models
{
    public class Encomenda
    {
        public List<EncomendaModel> listaEncomendas = new List<EncomendaModel>();

        public Encomenda()
        {
            
          
                

        }
        public void CriaEncomenda(EncomendaModel encomendaModelo)
        {
           

            listaEncomendas.Add(encomendaModelo);

            

        }

        public void AtualizaEncomenda(EncomendaModel encomendaModelo)
        {
            foreach (EncomendaModel encomenda in listaEncomendas)
            {
                if (encomenda.Nome == encomendaModelo.Nome)
                {
                    listaEncomendas.Remove(encomenda);
                    listaEncomendas.Add(encomendaModelo);
                    break;
                }
            }
        }
        public EncomendaModel GetEncomenda(string Nome)
        {
            EncomendaModel _encomendaModelo = null;

            
            
            foreach (EncomendaModel _encomenda in listaEncomendas)
                if (_encomendaModelo.Nome == Nome)
                    _encomendaModelo = _encomenda;
          
            
            return _encomendaModelo;
        }

        public void DeletarEncomenda(String Nome)
        {
            foreach (EncomendaModel _encomenda in listaEncomendas)
            {
                if (_encomenda.Nome == Nome)
                {
                    listaEncomendas.Remove(_encomenda);

                    break;
                }
            }
        }
    }
}