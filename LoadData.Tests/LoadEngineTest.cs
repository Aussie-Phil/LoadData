// <copyright file="LoadEngineTest.cs">Copyright ©  2016</copyright>

using System;
using LoadData;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoadData.Tests
{
    /// <summary>This class contains parameterized unit tests for LoadEngine</summary>
    [TestClass]
    [PexClass(typeof(LoadEngine))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LoadEngineTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal LoadEngine ConstructorTest()
        {
            LoadEngine target = new LoadEngine();
            return target;
            // TODO: add assertions to method LoadEngineTest.ConstructorTest()
        }

        /// <summary>Test stub for Load(String)</summary>
        [PexMethod]
        internal int LoadTest([PexAssumeUnderTest]LoadEngine target, string inputPath)
        {
            int result = target.Load(inputPath);
            return result;
            // TODO: add assertions to method LoadEngineTest.LoadTest(LoadEngine, String)
        }
    }
}
