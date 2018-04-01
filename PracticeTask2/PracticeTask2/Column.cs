using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * There is a class called Column (which contains int Id, string Name,
 * string Header). As an input receive two dictionaries idsAndNames
 * <int, string> and namesAndHeaders <string, string>. We know that in first
 * dictionary key int represents a Id of column, and value string represents NameAnd for 
 * second dictionary key string is a Name and value string represents Header. 
 * Outpit the Column objects with all known data using the input dictionaries
 */
namespace PracticeTask2
{
    class Column
    {
        int Id;
        string Name;
        string Header;
        private static readonly IDictionary<string, int> idsAndNames = new Dictionary<string, int>();
        private static readonly IDictionary<string, string> namesAndHeaders = new Dictionary<string, string>();
        
}
}


}