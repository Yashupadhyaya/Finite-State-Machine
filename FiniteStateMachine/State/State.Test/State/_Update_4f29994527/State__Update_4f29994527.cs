using NUnit.Framework;
using System;

namespace YourNamespace.Tests
{
    [TestFixture]
    public class YourClassTests
    {
        [Test]
        public void Test_Update_CallsUpdateMethodWithGivenDeltaTime()
        {
            var yourClass = new YourClass();
            var deltaTime = 1.5f;

            yourClass._Update(deltaTime);

            Assert.AreEqual(deltaTime, yourClass.GetLastDeltaTime());
        }

        [Test]
        public void Test_Update_ThrowsArgumentNullExceptionForNullInstance()
        {
            YourClass yourClass = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                yourClass._Update(1.0f);
            });
        }
    }
}
