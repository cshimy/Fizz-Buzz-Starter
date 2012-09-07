using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		public UnitTest1()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(1, new FizzBuzz.Class1().foo(1));
			//Assert.AreEqual(4, new FizzBuzz.Class1().foo(4));
			//Assert.AreEqual(11, new FizzBuzz.Class1().foo(11));
			//Assert.AreEqual(22, new FizzBuzz.Class1().foo(22));
		}

		//[TestMethod]
		//public void TestMethod2()
		//{
		//    Assert.AreEqual("FIZZ", new FizzBuzz.Class1().foo(3));
		//}

		//[TestMethod]
		//public void TestMethod3()
		//{
		//    Assert.AreEqual("BUZZ", new FizzBuzz.Class1().foo(5));
		//}

		//[TestMethod]
		//public void TestMethod4()
		//{
		//    Assert.AreEqual("FIZZBUZZ", new FizzBuzz.Class1().foo(30));
		//}

		//[TestMethod]
		//public void TestMethod5()
		//{
		//    Assert.AreEqual("ZAP", new FizzBuzz.Class1().foo(14));
		//}

		//[TestMethod]
		//public void TestMethod6()
		//{
		//    Assert.AreEqual("FIZZZAP", new FizzBuzz.Class1().foo(21));
		//}

		//[TestMethod]
		//public void TestMethod7()
		//{
		//    Assert.AreEqual("BUZZZAP", new FizzBuzz.Class1().foo(35));
		//}

		//[TestMethod]
		//public void TestMethod8()
		//{
		//    Assert.AreEqual("FIZZBUZZZAPP", new FizzBuzz.Class1().foo(105));
		//}
	}
}
