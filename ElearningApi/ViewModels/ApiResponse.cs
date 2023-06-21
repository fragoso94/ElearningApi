namespace ElearningApi.ViewModels
{
    public class ApiResponse<T> : SimpleResponse where T : new()
    {
        public ApiResponse()
        {
            this.Data = new T();
        }

        /// <summary>
        /// Cuerpo de la respuesta.
        /// </summary>
        public T Data { get; set; }
    }
}
