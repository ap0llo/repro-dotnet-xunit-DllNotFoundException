using LibGit2Sharp;
using System;
using System.IO;
using Xunit;

namespace beta5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var tempPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            
            Repository.Init(tempPath);

            Directory.Delete(tempPath, true);
        }
    }
}
