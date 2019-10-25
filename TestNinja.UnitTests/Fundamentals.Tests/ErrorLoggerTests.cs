using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ErrorLoggerTests
    {
        [TestMethod]
        public void Log_WhenCalled_SetLastErrorToProperty()
        {
            var errorLogger = new ErrorLogger();

            errorLogger.Log("a");

            Assert.AreEqual("a",errorLogger.LastError);
        }

        [TestMethod]
        public void Log_WhenParamIsNll_RaisesArgumentNullException()
        {
            var errorLogger = new ErrorLogger();

            Assert.ThrowsException<ArgumentNullException>(() => errorLogger.Log(null));
        }

        [TestMethod]
        public void Log_WhenParamIsJustASpace_RaisesArgumentNullException()
        {
            var errorLogger = new ErrorLogger();

            Assert.ThrowsException<ArgumentNullException>(() => errorLogger.Log(" "));
        }

        [TestMethod]
        public void Log_WhenParameterIsAnEmptyString_RaisesArgumentNullException()
        {
            var errorLogger = new ErrorLogger();

            Assert.ThrowsException<ArgumentNullException>(() => errorLogger.Log(""));
        }

        [TestMethod]
        public void Log_VallidError_RaisesErrorLoggedEvent()
        {
            var errorLogger = new ErrorLogger();

            var id = Guid.Empty;
            errorLogger.ErrorLogged += (sender,args) => { id = args; };
            errorLogger.Log("a");

            Assert.IsTrue(id != Guid.Empty);
        }
    }
}