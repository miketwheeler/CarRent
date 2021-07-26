using CarRent.Client.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarRent.Client.Services
{
    public class HttpRepository<T> : IHttpRepository<T> where T : class
    {
        private readonly HttpClient _client;
        private readonly HttpInterceptorService _interceptor;
        public HttpRepository(HttpClient client, HttpInterceptorService interceptor)
        {
            _client = client;
            _interceptor = interceptor;
        }
        public Task Create(string url, T obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string url, int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(string url, int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll(string url)
        {
            throw new NotImplementedException();
        }

        public Task Update(string url, T obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
