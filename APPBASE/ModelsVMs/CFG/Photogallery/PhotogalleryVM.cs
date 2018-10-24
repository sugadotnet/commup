using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class PhotogallerylistVM
    {
        public int? ID { get; set; }
        public string TITLE { get; set; }
        public string SHORT_DESC { get; set; }
        public string PHOTO_IMG { get; set; }
    } //End public partial class PhotogallerylistVM
    public partial class PhotogallerydetailVM
    {
        public int? ID { get; set; }
        public Byte? DTA_STS { get; set; }
        public string TITLE { get; set; }
        public string PHOTO_IMG { get; set; }
        public string SHORT_DESC { get; set; }
        public string FULL_DESC { get; set; }
    } //End public partial class PhotogallerydetailVM

    public partial class PhotogallerylookupVM
    {
        public int? ID { get; set; }
        public string TITLE { get; set; }
        public string SHORT_DESC { get; set; }
    } //End public partial class PhotogallerylistVM

} //End namespace APPBASE.Models
