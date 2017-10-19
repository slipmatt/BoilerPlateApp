using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FrontEndBoilerPlate.Models
{
    [DataContract]
    public class DeleteConfirmViewModel
    {
        [DataMember]
        public string DeleteAction { get; set; }
        [DataMember]
        public string DeleteController { get; set; }
        [DataMember]
        public string HeaderText { get; set; }
        [DataMember]
        public int DeleteEntityId { get; set; }
    }
}