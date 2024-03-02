using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    internal class RealData : IData
    {
        private readonly HttpClient client;

        public RealData(HttpClient client)
        {
            this.client = client;
        }
        public IList<User> Users
        {
            get
            {
                return [];// client.GetAsync<IList<User>>("").GetAwaiter().GetResult();
            }
        }
    }
}
