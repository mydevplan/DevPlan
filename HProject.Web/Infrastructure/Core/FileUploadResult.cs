﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HProject.Web.Infrastructure.Core
{
    public class FileUploadResult
    {
        public string LocalFilePath { get; set; }
        public string FileName { get; set; }
        public long FileLength { get; set; }
    }
}