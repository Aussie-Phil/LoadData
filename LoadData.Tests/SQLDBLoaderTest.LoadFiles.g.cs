using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoadData.Loaders;
// <copyright file="SQLDBLoaderTest.LoadFiles.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace LoadData.Loaders.Tests
{
    public partial class SQLDBLoaderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SQLDBLoaderTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void LoadFilesThrowsInvalidOperationException164()
{
    SQLDBLoader sQLDBLoader;
    int i;
    sQLDBLoader = new SQLDBLoader((string)null);
    i = this.LoadFiles(sQLDBLoader);
}
    }
}
