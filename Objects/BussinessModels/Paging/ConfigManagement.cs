using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Paging
{
    public sealed class ConfigManagement
    {
        private readonly int pageSize = 50;
        private readonly long pageBlock = 5;

        private ConfigManagement() { }

        public static ConfigManagement GetInstance
        {
            get
            {
                return ConfigManagementCreator.instance;
            }
        }

        public int PageSize
        {
            get { return pageSize; }
        }

        public long PageBlock
        {
            get { return pageBlock; }
        }

        class ConfigManagementCreator
        {
            static ConfigManagementCreator() { }

            internal static readonly ConfigManagement instance = new ConfigManagement();
        }
    }
}