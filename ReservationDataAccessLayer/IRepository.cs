namespace ReservationDataAccessLayer
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllData();
        Task<T> GetById(long Id);
        Task<T> AddData(T data);
        Task<bool> UpdateData(T data);
        Task<bool> DeleteData(long id);

    }
}
