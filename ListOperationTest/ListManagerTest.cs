using ListOperations;
using NUnit.Framework;


namespace ListOperationTest
{
    [TestFixture]
    public class ListManagerTest
    {
        private List<int> testlist;
        private ListManager listManager;

        [SetUp]
        public void SetUp()
        {
            testlist = new List<int>();
            listManager = new ListManager();
        }

        [Test]
        public void AddElement_List_ReturnList()
        {
            listManager.AddElements(testlist, 10);
            Assert.Contains(10, testlist);
        }
        [Test]
        public void RemoveElement_RemoveElementFromList()
        {
            testlist.Add(5);

            bool result = listManager.RemoveElemnt(testlist, 5);

            Assert.IsTrue(result);
            Assert.IsFalse(testlist.Contains(5));
        }
        [Test]
        public void RemoveElement_RemoveElementFromListNotContains_ReturnFalse()
        {
            testlist.Add(5);

            bool result = listManager.RemoveElemnt(testlist, 3);

            Assert.IsFalse(result);
            Assert.IsTrue(testlist.Contains(5));
        }

        [Test]
        public void GetSized_ReturnSizeOfList()
        {
            testlist.Add(5);
            testlist.Add(7);
            testlist.Add(8);
            testlist.Add(5);

            int size = listManager.GetSize(testlist);


            Assert.AreEqual(4, size);
        }
        [Test]
        public void GetSized_ReturnSizeOfListafterRemovel()
        {
            testlist.Add(5);
            testlist.Add(7);
            testlist.Add(8);
            testlist.Add(5);

            listManager.RemoveElemnt(testlist, 5);
            listManager.RemoveElemnt(testlist, 7);

            int size = listManager.GetSize(testlist);
            Assert.AreEqual(2, size);
        }
        [Test]

        public void RemoveElement_ThrowArgumentalNullException()
        {
            Assert.Throws<ArgumentNullException>(() => listManager.RemoveElemnt(null, 5));
        }
        

    }
}
