using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Awes
{
    public enum Post : int
    {
        /// <summary>
        /// Admin
        /// </summary>
        Root = 0,
        Director = 1,
        Boss,
        Manager,
        Eengineer,
        Customer_Service,
        Sales,
        Employee,
        PartTime,
        /// <summary>
        /// 已離開
        /// </summary>
        Leaving_Staff = -1,
        New_Register = -2
    }
}
