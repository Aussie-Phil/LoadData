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

      
    }
}
