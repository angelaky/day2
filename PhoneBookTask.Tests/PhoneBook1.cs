using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBookTask.Tests
{
    [TestClass]
    public class PhoneBooksTest
    {
        [TestMethod]
       // [ExpectedException(typeof(ArgumentException))]
        public void AddMethodShouldAddOnlyOnePersonWithSamePhone()
        {
            Person person1 = new Person("ala bala", "sofiq", "088 888 888");
            Person person2= new Person("ala bala", "sofiq", "088 888 888");

            PhoneBooks testbook = new PhoneBooks();
            testbook.Add(person1);
            Assert.AreEqual(testbook.PersonsList.Count,1);
            //testbook.Add(person2);
        }

        [TestMethod]
        public void AddMethodShouldAddOnlyOnePersonWithSamePhone1()
        {
            Person person1 = new Person("ala bala", "sofiq", "088 888 888");
            Person person2 = new Person("ala bala", "sofiq", "088 888 888");
            PhoneBooks testbook = new PhoneBooks();

            testbook.Add(person1);
            testbook.Add(person2);

            if (testbook.personPhone.Contains(person1))
            {
                throw new Exception($"Person {person1} present in Hashset! - Whyyyy KJ#EHERKJRH$*&$RKJH$R");
            }

            Assert.AreEqual(testbook.PersonsList.Count, 1);
            //testbook.Add(person2);
        }
    }
}
