
using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
        }

        [Test]
        public void DBCapacity()
        {
            Assert.IsTrue(database.Count == 16);
        }

        [Test]
        public void AddException()
        {
            Assert.Throws<InvalidOperationException>(()=> database.Add(17));
        }

        [Test]
        public void Add()
        {
            database = new Database(1, 2);
            database.Add(3);
            Assert.That(database.Count == 3);
        }

        [Test]
        public void RemoveException()
        {
            database = new Database();
            Assert.Throws<InvalidOperationException>(()=> database.Remove());
        }

        [Test]
        public void Remove()
        {
            database.Remove();
            Assert.That(database.Count == 15);
        }

        [Test]
        public void Fetch()
        {
            database.Fetch();
            Assert.That(database.Count == 16);
        }
    }
}