using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEncomenda.Models
{
    public class Dados_Veiculo
    {
        public List<Dados_VeiculoModel> listaDados = new List<Dados_VeiculoModel>();

        public Dados_Veiculo()
        {
            listaDados.Add(new Dados_VeiculoModel
            {
                Modelo = "Carreta",
                Placa = "ABC4263",
                Capacidade = 130

            });
            listaDados.Add(new Dados_VeiculoModel
            {
                Modelo = "Moto CJ",
                Placa = "CDE5374",
                Capacidade = 25
            });
            listaDados.Add(new Dados_VeiculoModel
            {
                Modelo = "Fiat Touro",
                Placa = "FGH6485",
                Capacidade = 60
            });
        }
        public void CriaDados_Veiculo(Dados_VeiculoModel dadosModelo)
        {
            listaDados.Add(dadosModelo);
        }

        public void AtualizaDados_Veiculo(Dados_VeiculoModel dadosModelo)
        {
            foreach (Dados_VeiculoModel dados in listaDados)
            {
                if (dados.Placa == dadosModelo.Placa)
                {
                    listaDados.Remove(dados);
                    listaDados.Add(dadosModelo);
                    break;
                }
            }
        }
        public Dados_VeiculoModel GetDados_Veiculo(string Placa)
        {
            Dados_VeiculoModel _dadosModelo = null;

            foreach (Dados_VeiculoModel _dados in listaDados)
                if (_dadosModelo.Placa == Placa)
                    _dadosModelo = _dados;

            return _dadosModelo;
        }

        public void DeletarDados_Veiculo(String Placa)
        {
            foreach (Dados_VeiculoModel _dados in listaDados)
            {
                if (_dados.Placa == Placa)
                {
                    listaDados.Remove(_dados);

                    break;
                }
            }
        }
    }
}