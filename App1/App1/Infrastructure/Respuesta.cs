﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Infrastructure
{
    class Respuesta
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }
    }
}
