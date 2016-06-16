﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadData.Constants;

namespace LoadData
{
    /// <summary>
    /// Class to control the loading of the files into the DB
    /// Could use a Factory pattern to determine the type of DB we're loading into
    /// </summary>
    internal class LoadEngine
    {
        private string _path = string.Empty;

        internal int Load(string inputPath)
        {
            int results = 0;
            _path = inputPath;

           //Load
           //Get files
           //Load Files
           

            return results;
        }

    }
}