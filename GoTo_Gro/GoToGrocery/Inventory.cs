using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    class Inventory
    {
        //pull stuff from databse and chuck it all in a big ol' array then 
        //read that bad boi out and dump it all in a csv file
        List<List<string>> myList = new List<List<string>>();

        //foreach row in databse, make new sublist with data from each
        //column and add to big list
        foreach (row in databse)
        {
            myList.Add(new List<string> { "id", "fname", "lname" etc.(item stuff not member stuff) });
        }

        // To iterate over it.
        foreach (List<string> subList in myList)
        {
            foreach (string item in subList)
            {
                //put csv export stuff in here
                Console.WriteLine(item);
            }
        }
    }
}
