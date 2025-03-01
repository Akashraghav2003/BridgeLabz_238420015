using NUnit.Framework;
using Performance;



namespace PerformanceTest
{
    [TestFixture]
    public class TaskManagerTest
    {
        private int sleepTime;
        private TaskManager taskManager;

        [SetUp]
        public void SetUp()
        {
            taskManager = new TaskManager();
        }

        [Test, Timeout(2000)]
        public void RunningTask_ShouldFailedDueToTimeOut()
        {
            sleepTime = 3000;
            string result = taskManager.RunningTask(sleepTime);

            Assert.AreEqual("Task is complete", result);
        }
        [Test, Timeout(2000)]
        public void RunningTask_ShouldPassedWithoutTimeOut()
        {
            sleepTime = 1500;
            string result = taskManager.RunningTask(sleepTime);

            Assert.AreEqual("Task is complete", result);
        }
    }
}
