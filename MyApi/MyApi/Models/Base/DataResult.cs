namespace MyApi.Models.Base
{

    // dönüşler için
    public class DataResult<TEntity>
    {
        public TEntity Data { get; set; }
        public List<TEntity> ListData { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
