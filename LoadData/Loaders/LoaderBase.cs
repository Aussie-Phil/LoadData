﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadData.Loaders
{
    internal class LoaderBase
    {
        private string _inputPath = string.Empty;
        private object _loadModel = string.Empty;

        internal string InputPath
        {
            get
            {
                return _inputPath;
            }

            set
            {
                _inputPath = value;
            }
        }

        internal object LoadModel
        {
            get
            {
                return _loadModel;
            }

            set
            {
                _loadModel = value;
            }
        }


        internal LoaderBase()
        {
        }

        internal LoaderBase(string inputPath)
        {
            _inputPath = inputPath;
        }


    }
}