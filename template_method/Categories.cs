using System;
using System.Data;
using System.Data.

namespace template_method
{
    public class Categories : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Categories ---- ");


            DataTable dataTable = _dataSet.Tables["Categories"];
            foreach (var row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }

        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            SqlConnection conn = new SqlConnection();

            _dataSet = new DataSet();
            dataAdapter.Fill(_dataSet, "Categories");
        }
    }
}