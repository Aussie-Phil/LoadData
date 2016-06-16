using System;
using System.Collections.Generic;
using System.Linq;
using Data.Repositories.Models;
using Data.Repositories;
using LoadData.Constants;
using System.IO;
using LoadData.Model;

namespace LoadData.Loaders
{
    /// <summary>
    /// Provides the methods to retreive the files and then load them into the DB
    /// 
    /// The idea here was to have a nice factory pattern to allow extension to connect to a couple of type of DB's but out of spec and time.
    /// Two repositories is also a bit tangled .. apologies
    /// </summary>
    internal class SQLDBLoader : LoaderBase
    {
        private List<string> _fileNames = null;
        NodeRepository _nodeRepo = null;
        NodeLinksRepository _linkRepo = null;

        public SQLDBLoader() 
            : base()
        {
            _nodeRepo = new NodeRepository();
            _linkRepo = new NodeLinksRepository();
        }

        public SQLDBLoader(string inputPath)
            : base(inputPath)
        {
            _fileNames = new List<string>();
            _nodeRepo = new NodeRepository();
            _linkRepo = new NodeLinksRepository();
        }

        /// <summary>
        /// Populate the list of files in the path specified
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

        public override int LoadFiles()
        {

            _linkRepo.DeleteAll();
            _nodeRepo.DeleteAll();

            foreach (string fileName in _fileNames)
            {
                string file = File.ReadAllText(fileName);

                node nextData = new node();

                nextData = (node)Deserialise.XmlDeserialise<node>(file);

                if (nextData != null)
                {

                    InsertData(nextData);
                }

                nextData = null;

            }

            return LoadConstants.Success;
        }

        public override bool InsertData(node data)
        {

            NODES nodeRow = new NODES();
            NODE_LINKS linkRow = null;

            nodeRow.NODE_ID = Convert.ToInt32(data.id);
            nodeRow.NODE_LABEL = data.label;

            _nodeRepo.Create(nodeRow);
            _nodeRepo.Save();

            foreach (nodeAdjacentNodesID adjacent in data.adjacentNodes)
            {
                linkRow = new NODE_LINKS();

                linkRow.NODE_ID = nodeRow.NODE_ID;
                linkRow.ADJACENT_NODE_ID = Convert.ToInt32(adjacent.Value);

                _linkRepo.Create(linkRow);
                _linkRepo.Save();
            }

            return true;
        }

        public void Close()
        {
            //Would include this with IDisposable if I had more time.
            _nodeRepo.Close();
            _linkRepo.Close();

            _nodeRepo = null;
            _linkRepo = null;
        }

    }
}
