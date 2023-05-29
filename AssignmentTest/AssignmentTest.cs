using Assignment;
namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void UnlockTest()
        {
            // Create a new chest that is initially locked
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);

            // Unlock the chest
            chest.Unlock();

            // Verify that the chest is now in the closed state
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());

            // Try to unlock the chest again
            chest.Unlock();

            // Verify that the chest remains in the closed state
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());
        }

        [TestMethod]
        public void LockTest()
        {
            // Create a new chest that is initially closed
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            // Lock the chest
            chest.Lock();

            // Verify that the chest is now in the locked state
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());

            // Try to lock the chest again
            chest.Lock();

            // Verify that the chest remains in the locked state
            Assert.AreEqual(TreasureChest.State.Locked, chest.GetState());
        }

        [TestMethod]
        public void OpenTest()
        {
            // Create a new chest that is initially closed
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);

            // Open the chest
            chest.Open();

            // Verify that the chest is now in the open state
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());

            // Try to open the chest again
            chest.Open();

            // Verify that the chest remains in the open state
            Assert.AreEqual(TreasureChest.State.Open, chest.GetState());

            // Create a new chest that is initially locked
            TreasureChest lockedChest = new TreasureChest(TreasureChest.State.Locked);

            // Try to open the locked chest
            lockedChest.Open();

            // Verify that the chest remains in the locked state
            Assert.AreEqual(TreasureChest.State.Locked, lockedChest.GetState());
        }

        [TestMethod]
        public void CloseTest()
        {
            // Create a new chest that is initially open
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);

            // Close the chest
            chest.Close();

            // Verify that the chest is now in the closed state
            Assert.AreEqual(TreasureChest.State.Closed, chest.GetState());

            // Try to close the chest again
            chest.Close();
        }
    }
}