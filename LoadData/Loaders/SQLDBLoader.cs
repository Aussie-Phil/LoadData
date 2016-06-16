using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories.Models;
using Data.Repositories;
using LoadData.Constants;
using System.IO;

namespace LoadData.Loaders
{
    /// <summary>
    /// 
    /// </summary>
    internal class SQLDBLoader : LoaderBase
    {
        private List<string> _fileNames = null;
        NodeRepository _nodeRepo = null;

        public SQLDBLoader() 
            : base()
        {
            _nodeRepo = new NodeRepository();
        }

        public SQLDBLoader(string inputPath)
            : base(inputPath)
        {
            _fileNames = new List<string>();
            _nodeRepo = new NodeRepository();
        }

        /// <summary>
        /// Populate the list of files in teh path specified
        /// </summary>
        /// <returns>Success if validation passes</returns>
        public int GetFiles()
        {
            int validationResult = 0;

            validationResult = Validate();

            if (validationResult == LoadConstants.Success)
            {
                _fileNames = Directory.GetFiles(InputPath).ToList<string>();
            }

            return validationResult;
        }


        //Insert Data

        //Load Files

    }
}
