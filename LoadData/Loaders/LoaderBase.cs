using LoadData.Constants;
using LoadData.Model;
using System;
using System.IO;

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

        public int Validate()
        {
            if (string.IsNullOrWhiteSpace(_inputPath))
            {
                return LoadConstants.ErrNoPath; 
            }

            if (!Directory.Exists(InputPath))
            {
                return LoadConstants.ErrPathInvalid;
            }

            if (_loadModel == null)
            {
                return LoadConstants.ErrNoModel;
            }

            return LoadConstants.Success;
        }

        public virtual int LoadFiles()
        {
            throw new NotImplementedException("This method is not yet implemented. Be sure to Override it.");
        }

        public virtual bool InsertData(node data)
        {
            throw new NotImplementedException("This method is not yet implemented. Be sure to Override it.");
        }
    }
}
