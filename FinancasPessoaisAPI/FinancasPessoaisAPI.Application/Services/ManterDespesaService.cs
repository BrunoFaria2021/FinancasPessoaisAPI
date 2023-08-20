using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;
using FinancasPessoaisAPI.Domain.Entities;

namespace FinancasPessoaisAPI.Application.Services
{
    public class ManterDespesaService : IManterDespesaService
    {
        private readonly IDespesaRepository _despesaRepository;

        public ManterDespesaService(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public void AtualizarDespesa(DespesaDTO despesaDTO)
        {
            Despesa despesa = _despesaRepository.ObterPorId(despesaDTO.Id);

            if (despesa != null)
            {
                // Atualizar apenas as propriedades que podem ser atualizadas
                despesa.Descricao = despesaDTO.Descricao;
                despesa.Valor = despesaDTO.Valor;

                _despesaRepository.Atualizar(despesa);
            }
        }

        public int CriarDespesa(DespesaDTO despesaDTO)
        {
            // Criar uma nova despesa com base no DTO
            Despesa despesa = new Despesa(despesaDTO.Descricao, despesaDTO.Valor, despesaDTO.Data);

            // Adicionar a nova despesa ao repositório
            _despesaRepository.Adicionar(despesa);

            return despesa.Id;
        }

        public void ExcluirDespesa(int id)
        {
            // Excluir a despesa com o ID fornecido
            Despesa despesa = _despesaRepository.ObterPorId(id);

            if (despesa != null)
            {
                _despesaRepository.Remover(despesa);
            }
        }

        public DespesaDTO ObterDespesaPorId(int id)
        {
            // Obter uma despesa pelo ID e mapear para o DTO
            Despesa despesa = _despesaRepository.ObterPorId(id);

            if (despesa != null)
            {
                return new DespesaDTO
                {
                    Id = despesa.Id,
                    Descricao = despesa.Descricao,
                    Valor = despesa.Valor,
                    Data = despesa.Data
                };
            }

            return null;
        }

        public IEnumerable<DespesaDTO> ObterTodasDespesas()
        {
            // Obter todas as despesas e mapear para DTOs
            IEnumerable<Despesa> despesas = _despesaRepository.ObterTodas();

            return despesas.Select(despesa => new DespesaDTO
            {
                Id = despesa.Id,
                Descricao = despesa.Descricao,
                Valor = despesa.Valor,
                Data = despesa.Data
            });
        }
    }
}