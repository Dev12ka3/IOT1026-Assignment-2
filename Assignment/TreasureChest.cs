namespace Assignment
{
    /// <summary>
    /// Represents a treasure chest with various properties and actions.
    /// </summary>
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        /// <summary>
        /// Default constructor that initializes the treasure chest with default values.
        /// </summary>
        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        /// <summary>
        /// Constructor that initializes the treasure chest with a specific state.
        /// </summary>
        /// <param name="state">The initial state of the treasure chest.</param>
        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        /// <summary>
        /// Constructor that initializes the treasure chest with specific properties.
        /// </summary>
        /// <param name="material">The material of the treasure chest.</param>
        /// <param name="lockType">The lock type of the treasure chest.</param>
        /// <param name="lootQuality">The loot quality of the treasure chest.</param>
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        /// <summary>
        /// Gets the current state of the treasure chest.
        /// </summary>
        /// <returns>The current state of the treasure chest.</returns>
        public State GetState()
        {
            return _state;
        }

        /// <summary>
        /// Performs the specified action on the treasure chest.
        /// </summary>
        /// <param name="action">The action to perform on the treasure chest.</param>
        /// <returns>The updated state of the treasure chest after performing the action.</returns>
        public State Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid input, please enter a valid selection");
                    break;
            }

            return _state; // Return the updated state of the chest
        }

        /// <summary>
        /// Unlocks the treasure chest if it is currently locked.
        /// </summary>
        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is now unlocked.");
            }
            else
            {
                Console.WriteLine("The chest is already unlocked.");
            }
        }

        /// <summary>
        /// Locks the treasure chest if it is currently closed.
        /// </summary>
        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
                Console.WriteLine("The chest is now locked.");
            }
            else
            {
                Console.WriteLine("The chest must be closed before it can be locked.");
            }
        }

        /// <summary>
        /// Opens the treasure chest if it is currently closed.
        /// </summary>
        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        /// <summary>
        /// Closes the treasure chest if it is currently open.
        /// </summary>
        public void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
                Console.WriteLine("The chest is now closed.");
            }
            else
            {
                Console.WriteLine("The chest is already closed.");
            }
        }

        /// <summary>
        /// Returns a string representation of the treasure chest.
        /// </summary>
        /// <returns>A string representation of the treasure chest.</returns>
        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        // Enum definitions omitted for brevity

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
