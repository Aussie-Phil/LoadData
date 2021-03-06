using LoadData.Model;
// <copyright file="SQLDBLoaderTest.cs">Copyright ©  2016</copyright>

using System;
using LoadData.Loaders;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoadData.Loaders.Tests
{
    /// <summary>This class contains parameterized unit tests for SQLDBLoader</summary>
    [TestClass]
    [PexClass(typeof(SQLDBLoader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SQLDBLoaderTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal SQLDBLoader ConstructorTest()
        {
            SQLDBLoader target = new SQLDBLoader();
            return target;
            // TODO: add assertions to method SQLDBLoaderTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal SQLDBLoader ConstructorTest01(string inputPath)
        {
            SQLDBLoader target = new SQLDBLoader(inputPath);
            return target;
            // TODO: add assertions to method SQLDBLoaderTest.ConstructorTest01(String)
        }

        /// <summary>Test stub for GetFiles()</summary>
        [PexMethod]
        internal int GetFilesTest([PexAssumeUnderTest]SQLDBLoader target)
        {
            int result = target.GetFiles();
            return result;
            // TODO: add assertions to method SQLDBLoaderTest.GetFilesTest(SQLDBLoader)
        }



        /// <summary>Test stub for Close()</summary>
        [PexMethod]
        internal void CloseTest([PexAssumeUnderTest]SQLDBLoader target)
        {
            target.Close();
            // TODO: add assertions to method SQLDBLoaderTest.CloseTest(SQLDBLoader)
        }



        /// <summary>Test stub for InsertData(node)</summary>
        [PexMethod]
        internal bool InsertDataTest([PexAssumeUnderTest]SQLDBLoader target, node data)
        {
            bool result = target.InsertData(data);
            return result;
            // TODO: add assertions to method SQLDBLoaderTest.InsertDataTest(SQLDBLoader, node)
        }

        /// <summary>Test stub for LoadFiles()</summary>
        [PexMethod]
        internal int LoadFilesTest([PexAssumeUnderTest]SQLDBLoader target)
        {
            int result = target.LoadFiles();
            return result;
            // TODO: add assertions to method SQLDBLoaderTest.LoadFilesTest(SQLDBLoader)
        }

        [PexMethod]
        internal int LoadFiles([PexAssumeUnderTest]SQLDBLoader target)
        {
            int result = target.LoadFiles();
            return result;
            // TODO: add assertions to method SQLDBLoaderTest.LoadFiles(SQLDBLoader)
        }

        [PexMethod]
        internal bool InsertData([PexAssumeUnderTest]SQLDBLoader target, node data)
        {
            bool result = target.InsertData(data);
            return result;
            // TODO: add assertions to method SQLDBLoaderTest.InsertData(SQLDBLoader, node)
        }
    }
}
