namespace BlazorWithApi.WASM.Services
{
    public interface IService<T>
    {
        // CRUD
        Task<List<T>> GetAll();
        Task<T> GetById(int id);  
        Task Add(T item);   
        Task Update(int id, T item);
        Task Delete(int id);
    }
}
