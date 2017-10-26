﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrawler.Events
{
    public class OnStartEventArgs
    {
        public Uri Uri { get; set; }// 爬虫URL地址

        public OnStartEventArgs(Uri uri)
        {
            this.Uri = uri;
        }
    }
}
