﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public interface IMutualFilterStrategy
    {
        List<string> FetchUserCollectionToScan(string i_UserId);
    }
}
