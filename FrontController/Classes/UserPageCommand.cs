﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontController
{
    public class UserPageCommand:ICommand
    {
        public void Execute(HttpContext context)
        {
            context.Server.Transfer("/UserPage.aspx");
        }
    }
}