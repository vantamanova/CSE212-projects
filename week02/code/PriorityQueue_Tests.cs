using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: item added to the back of the queue
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        var phone = new PriorityItem("Phone", 1);
        var wallet = new PriorityItem("Wallet", 2);
        var keys = new PriorityItem("Keys", 3);

        var expectedResult = "[Phone (Pri:1), Wallet (Pri:2), Keys (Pri:3)]";

        priorityQueue.Enqueue(phone.Value, phone.Priority);
        priorityQueue.Enqueue(wallet.Value, wallet.Priority);
        priorityQueue.Enqueue(keys.Value, keys.Priority);

        Assert.AreEqual(expectedResult, priorityQueue.ToString());

    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: The item with the highest priority removed and it's value returned
    // Defect(s) Found: Returns wrong item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        var phone = new PriorityItem("Phone", 1);
        var wallet = new PriorityItem("Wallet", 2);
        var keys = new PriorityItem("Keys", 3);

        priorityQueue.Enqueue(phone.Value, phone.Priority);
        priorityQueue.Enqueue(wallet.Value, wallet.Priority);
        priorityQueue.Enqueue(keys.Value, keys.Priority);

        var expectedResult = "Keys";

        var returnedItem = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, returnedItem.ToString());
    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: the item closest to the front of the queue will be removed and its value returned
    // Defect(s) Found: Returns wrong item
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        var phone = new PriorityItem("Phone", 1);
        var wallet = new PriorityItem("Wallet", 2);
        var keys = new PriorityItem("Keys", 2);

        priorityQueue.Enqueue(phone.Value, phone.Priority);
        priorityQueue.Enqueue(wallet.Value, wallet.Priority);
        priorityQueue.Enqueue(keys.Value, keys.Priority);

        var expectedResult = "Wallet";

        var returnedItem = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, returnedItem.ToString());
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an exception to be thrown.");
        }
        catch (InvalidOperationException exception)
        {
            Assert.AreEqual("The queue is empty.", exception.Message);
        }

    }

    // Add more test cases as needed below.
}