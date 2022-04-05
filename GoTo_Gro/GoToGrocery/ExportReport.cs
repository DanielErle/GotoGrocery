using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    class ExportReport
    {
        //before your loop
        StringBuilder csv = new StringBuilder();

        public ExportReport()
        {
            while (rdr.Read())
            {
                //in your loop
                string id = rdr["Member_ID"].ToString();
                string first = rdr[""].ToString();
                string last = rdr[""].ToString();
                string dob = rdr[""].ToString();
                string phone = rdr[""].ToString();
                string email = rdr[""].ToString();
                string status = rdr[""].ToString();
                string start = rdr[""].ToString();

                string newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", id, first, last, dob, phone, email, status, start);
                csv.AppendLine(newLine);
            }

            //after your loop
            File.WriteAllText(filePath, csv.ToString());

        }
    }
}
