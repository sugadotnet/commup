using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPBASE.Models
{
    public interface BaseVM_interface {
        int? ID { get; set; }
        Byte? DTA_STS { get; set; }
    } //End interface
} //End namespace APPBASE.Models