using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionMicroservice.Repository
{
   public interface itransactions
    {
       public string deposit(dwacc value);
        public string withdraw(dwacc value);
        public string transfer(transfers value);
    }
}
