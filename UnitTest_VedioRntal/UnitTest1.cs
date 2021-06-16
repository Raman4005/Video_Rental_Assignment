using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Rental_Assignment;

namespace UnitTest_VedioRntal
{
   
    [TestClass]
    public class UnitTest1
    {
        Database_class Obj_Data = new Database_class();
        [TestMethod]
        public void TestMethod1()
        {
            string Connection = Obj_Data.ConnString;
            Assert.AreEqual(@"Data Source=LAPTOP-52CB3J4K\SQLEXPRESS01;Initial Catalog=RamanDatabase;Integrated Security=True", Connection);
        }
        
    }
}
