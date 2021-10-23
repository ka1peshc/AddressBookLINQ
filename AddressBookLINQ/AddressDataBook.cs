using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AddressBookLINQ
{
    class AddressDataBook
    {
        public void AddData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("Zip");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Emails");

        }
    }
}
