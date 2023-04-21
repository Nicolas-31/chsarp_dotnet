namespace TODOList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shallExit = false;
            var todos = new List<string>();

            while (!shallExit)
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all todos");
                Console.WriteLine("[A]dd a todo");
                Console.WriteLine("[R]emove a todo");
                Console.WriteLine("[E]xit");
                Console.WriteLine();

                var userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "E":
                    case "e":
                        shallExit = true;
                        break;

                    case "S":
                    case "s":
                        Console.WriteLine("List all TODOs");
                        SeeAllTodos(todos);
                        break;

                    case "A":
                    case "a":
                        Console.WriteLine("Add a TODO");
                        AddTodo(todos);
                        break;

                    case "R":
                    case "r":
                        Console.WriteLine("Remove a TODO");
                        RemoveTodo(todos);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.ReadKey();
            }
        }



        private static void SeeAllTodos(List<string> todos)
        {
            if (todos.Count == 0)
            {
                ShowNoTodosMessage();
                return;
            }


            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }

        }

        private static void AddTodo(List<string> todos)
        {
            string description;

            do
            {
                Console.WriteLine("Enter the TODO description");
                description = Console.ReadLine();

            } while (!IsDescriptionValid(todos, description));
            todos.Add(description);
        }

        private static bool IsDescriptionValid(List<string> todos, string description)
        {
            if (description == "")
            {
                Console.WriteLine("The description cannot be empty");
                return false;
            }
            else if (todos.Contains(description))
            {
                Console.WriteLine("The description must be unique");
                return false;
            }
            return true;
        }

        private static void RemoveTodo(List<string> todos)
        {
            if (todos.Count == 0)
            {
                ShowNoTodosMessage();
                return;
            }
            int index;

            do
            {
                Console.WriteLine("Select the index of the TODO you want to remove");
                SeeAllTodos(todos);

            } while (!TryReadIndex(todos, out index));

            RemoveTodoAtIndex(todos, index-1);

        }

        private static void RemoveTodoAtIndex(List<string> todos, int index)
        {
           
            var todoToBeRemoved = todos[index];
            todos.RemoveAt(index);
            Console.WriteLine("TODO Removed: " + todoToBeRemoved);
        }

        private static bool TryReadIndex(List<string> todos, out int index)
        {
            var userInput = Console.ReadLine();
            if (userInput == "")
            {
                index = 0;
                Console.WriteLine("Selected index cannot be empty");
                return false;
            }
            if (int.TryParse(userInput, out index) &&
                index >= 1 &&
                index <= todos.Count)
            {
                return true;
            }

            Console.WriteLine("The given index is not valid");
            return false;

        }

        private static void ShowNoTodosMessage()
        {
            Console.WriteLine("No TODOs have been added yet");
        }
    }
}