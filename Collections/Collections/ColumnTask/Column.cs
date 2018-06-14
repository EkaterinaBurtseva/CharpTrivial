using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ColumnTask
{
    public class Column
    {
        public string Header { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "id: " + this.Id + ", name: " + this.Name + ", header: " + this.Header;
        }
    }
}
