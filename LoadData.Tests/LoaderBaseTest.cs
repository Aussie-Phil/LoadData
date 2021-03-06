// <copyright file="LoaderBaseTest.cs">Copyright ©  2016</copyright>
using System;
using LoadData.Loaders;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoadData.Loaders.Tests
{
    /// <summary>This class contains parameterized unit tests for LoaderBase</summary>
    [PexClass(typeof(LoaderBase))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LoaderBaseTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        internal LoaderBase ConstructorTest()
        {
            LoaderBase target = new LoaderBase();
            return target;
            // TODO: add assertions to method LoaderBaseTest.ConstructorTest()
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal LoaderBase ConstructorTest01(string inputPath)
        {
            LoaderBase target = new LoaderBase(inputPath);
            return target;
            // TODO: add assertions to method LoaderBaseTest.ConstructorTest01(String)
        }

        /// <summary>Test stub for get_InputPath()</summary>
        [PexMethod]
        internal string InputPathGetTest([PexAssumeUnderTest]LoaderBase target)
        {
            string result = target.InputPath;
            return result;
            // TODO: add assertions to method LoaderBaseTest.InputPathGetTest(LoaderBase)
        }

        /// <summary>Test stub for set_InputPath(String)</summary>
        [PexMethod]
        internal void InputPathSetTest([PexAssumeUnderTest]LoaderBase target, string value)
        {
            target.InputPath = value;
            // TODO: add assertions to method LoaderBaseTest.InputPathSetTest(LoaderBase, String)
        }

        /// <summary>Test stub for get_LoadModel()</summary>
        [PexMethod]
        internal object LoadModelGetTest([PexAssumeUnderTest]LoaderBase target)
        {
            object result = target.LoadModel;
            return result;
            // TODO: add assertions to method LoaderBaseTest.LoadModelGetTest(LoaderBase)
        }

        /// <summary>Test stub for set_LoadModel(Object)</summary>
        [PexMethod]
        internal void LoadModelSetTest([PexAssumeUnderTest]LoaderBase target, object value)
        {
            target.LoadModel = value;
            // TODO: add assertions to method LoaderBaseTest.LoadModelSetTest(LoaderBase, Object)
        }

        /// <summary>Test stub for Validate()</summary>
        [PexMethod]
        internal int ValidateTest([PexAssumeUnderTest]LoaderBase target)
        {
            int result = target.Validate();
            return result;
            // TODO: add assertions to method LoaderBaseTest.ValidateTest(LoaderBase)
        }
    }
}
