﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    public interface Expression
    {
        int[] interpret();
    }
}