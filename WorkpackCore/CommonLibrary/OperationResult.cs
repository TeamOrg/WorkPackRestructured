using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLibrary
{
    public class OperationResult
    {
        public string Message;
        public string MessageType; // Success:S or Error:E
        public IList<object> returnData;
        public List<List<object>> list = new List<List<object>>();
        public List<Dictionary<string, string>> lstDict = new List<Dictionary<string, string>>();
        public object data;
    }
}
