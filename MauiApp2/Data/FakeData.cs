using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    public class FakeData : IData
    {
        public IList<User> Users => [
            new User { Name = "Bob", Email = "mailmail", Password = "12345"},
            new User { Name = "Rob", Email = "mailmail2", Password = "123456"}
        ];
    }
}
