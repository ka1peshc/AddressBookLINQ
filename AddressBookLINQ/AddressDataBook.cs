using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AddressBookLINQ
{
    class AddressDataBook
    {
        public DataTable AddData()
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

            table.Rows.Add("Kalpesh", "Chindarkar", "Sewri", "Mumbai", "Maharashtra", "400015", "kalpesh@gmail.com");
            table.Rows.Add("Ketan", "Chindarkar", "Sewri", "Mumbai", "Maharashtra", "400015", "ketan@gmail.com");
            table.Rows.Add("Shivani","Maynak","Bandra", "Mumbai", "Maharashtra", "400035", "shivaniM@gmail.com");
            table.Rows.Add("Mithali", "Bora", "SP road", "Nagpur", "Maharashtra", "401753", "Mithali@gmail.com");
            table.Rows.Add("Murli", "Krishna", "APO", "Vizag", "AndraPradesh", "701753", "murli007@gmail.com");
            return table;
        }

        public void DisplayAddressBook(DataTable table)
        {
            DataRow[] dr = table.Select();
            for(int i =0;i<dr.Length;i++)
            {
                Console.WriteLine("First name:" + dr[i][0] + " Second Name:"+ dr[i][1]+" City:"+dr[i][2]+" State:"+dr[i][3]+
                    " Zip No:"+dr[i][4]+" gmail:"+dr[i][5]);
            }
        }
    }
}
