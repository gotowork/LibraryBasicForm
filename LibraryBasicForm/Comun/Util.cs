using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;

namespace LibraryBasicForm.Util
{
    public delegate void CallMasterSearch();

    public class Util
    {
        
    }

    public class CParameterSearch
    {
        public CParameterSearch()
        {
            Keys = new List<string>();
            Fields = new Dictionary<string, string>();
        }

        public List<string> Keys { get; set; }
        public Dictionary<string, string> Fields { get; set; }
    }

    public class CParameterIList : CParameterSearch
    {        
        public IList ResultSearch { get; set; }
    }

    public class CParameterDatatable : CParameterSearch
    {        
        public DataTable ResultSearch { get; set; }
    }
}
