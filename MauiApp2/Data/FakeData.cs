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
            new User { 
                Name = "BOBer", 
                oneName="Bob", 
                twoName="Schmit", 
                Email = "mailmail", 
                Password = "12345"},
            //new User { Name = "Robertos", oneName="Rob", twoName="Brown", Email = "mailmail2", Password = "123456"}
        ];
    }
}
