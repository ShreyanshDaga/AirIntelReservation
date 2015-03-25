using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AIR.Entities
{
    [DataContract]
    public class APIResult
    {
        [DataMember]
        public int ErrorCount { get; set; }
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public Dictionary<string, string> ErrorMessages { get; set; }
        [DataMember]
        public Dictionary<string, string> Results { get; set; }

        public APIResult()
        {
            this.ErrorCount = 0;
            this.ErrorMessages = new Dictionary<string, string>();
            this.Results = new Dictionary<string, string>();
        }

        public void AddError(string Key, string ErrorMessage)
        {
            this.ErrorMessages.Add(Key, ErrorMessage);
            this.ErrorCount++;
            this.IsSuccess = false;

        }

        public void AddResult(string Key, string ResultMessage)
        {
            this.Results.Add(Key, ResultMessage);
            this.IsSuccess = true;
        }

    }
}
