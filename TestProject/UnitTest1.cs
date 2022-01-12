using NUnit.Framework;
using Mishanya.Controllers;
using Mishanya.Models;
using System.Collections.Generic;



namespace TestProject
{
    public class Tests
    {
        private readonly Tour tour = new Tour();
        private readonly ToursListViewModel list = new ToursListViewModel();
        private  MemoryRepository mem = new MemoryRepository();


        [SetUp]
        public void Setup()
        {
           
        }
        
        [Test]
        public void TestDB()
        {
            Assert.AreNotEqual(1124234234, tour.Price);
            Assert.IsNotNull(tour.Price);
        }
        [Test]
        public void TestTourList()
        {
            Assert.AreEqual(0m, list.TotalPrice);
            Assert.AreNotEqual(10,list.TotalPrice);
        }
        [Test]
        public void TestMemoryRepo()
        {
            Assert.AreNotEqual(10000m, mem.Tours);
            Assert.IsNotNull(mem.Tours);
        }
    }
}