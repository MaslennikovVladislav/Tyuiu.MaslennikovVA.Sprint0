﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using Tyuiu.MaslennikovVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MaslennikovVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Владислав";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Владислав", res);
        }
    }
}
