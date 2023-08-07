namespace FinancasPessoaisAPI.Application.Interfaces
{
    public interface IManterService<TDTO>
    {
        TDTO GetById(int id);
        IEnumerable<TDTO> GetAll();
        int Create(TDTO dto);
        void Update(TDTO dto);
        void Delete(int id);
    }
}