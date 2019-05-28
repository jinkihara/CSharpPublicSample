using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysMngToolDemo.Haribote
{
    public class TableDefinitionInfo
    {
        private Dictionary<string, Dictionary<string,object>> info = new Dictionary<string, Dictionary<string,object>>();
        public TableDefinitionInfo()
        {
            Dictionary<string, object> dic;

            dic = new Dictionary<string, object>();
            dic.Add("ItemName", "項目名");
        }
    }

}
