using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyTicketing
{
    interface ITicketingRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactID);
        bool Insert(string name, string family, string number, string email, string title, string description);
        bool Delete(int contactID);
    }
}
