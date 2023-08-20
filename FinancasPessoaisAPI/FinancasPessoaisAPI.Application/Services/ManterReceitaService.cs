using FinancasPessoaisAPI.Application.DTOs;
using FinancasPessoaisAPI.Application.Interfaces;
using FinancasPessoaisAPI.Domain.Core.interfaces.Repository;
using FinancasPessoaisAPI.Domain.Entities;

namespace FinancasPessoaisAPI.Application.Services
{
    public class ManterReceitaService : IManterReceitaService
    {
        private readonly IReceitaRepository _receitaRepository;

        public ManterReceitaService(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        public void AtualizarReceita(ReceitaDTO receitaDTO)
        {
            // Verifica se a receita com o ID especificado existe
            var existingReceita = _receitaRepository.ObterPorId(receitaDTO.Id);
            if (existingReceita == null)
            {
                throw new Exception("Receita não encontrada.");
            }

            // Atualiza a entidade existente com os valores do DTO
            existingReceita.Atualizar(receitaDTO.Descricao, receitaDTO.Valor, receitaDTO.Data);

            // Chama o método de atualização no repositório
            _receitaRepository.Atualizar(existingReceita);
        }


        public int CriarReceita(ReceitaDTO receitaDTO)
        {
            // Converte o DTO para a entidade e chama o método de criação no repositório
            Receita receita = ConverterParaReceita(receitaDTO);
            _receitaRepository.Adicionar(receita);
            return receita.Id; // Retorna o ID da receita criada
        }

        public void ExcluirReceita(int id)
        {
            // Obtém a receita pelo ID e chama o método de remoção no repositório
            Receita receita = _receitaRepository.ObterPorId(id);
            if (receita != null)
            {
                _receitaRepository.Remover(receita);
            }
        }

        public ReceitaDTO ObterReceitaPorId(int id)
        {
            // Obtém a receita pelo ID e converte para DTO
            Receita receita = _receitaRepository.ObterPorId(id);
            return ConverterParaReceitaDTO(receita);
        }

        public IEnumerable<ReceitaDTO> ObterTodasReceitas()
        {
            // Obtém todas as receitas do repositório e converte para DTOs
            IEnumerable<Receita> receitas = _receitaRepository.ObterTodas();
            List<ReceitaDTO> receitasDTO = new List<ReceitaDTO>();
            foreach (Receita receita in receitas)
            {
                receitasDTO.Add(ConverterParaReceitaDTO(receita));
            }
            return receitasDTO;
        }

        private Receita ConverterParaReceita(ReceitaDTO receitaDTO)
        {
            Receita receita = new Receita();
            receita.Inicializar(receitaDTO.Descricao, receitaDTO.Valor, receitaDTO.Data);
            return receita;
        }
        private ReceitaDTO ConverterParaReceitaDTO(Receita receita)
        {
            return new ReceitaDTO
            {
                Id = receita.Id,
                Descricao = receita.Descricao,
                Valor = receita.Valor,
                Data = receita.Data
            };
        }
    }
}