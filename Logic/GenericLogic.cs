namespace ReworkedOOPGenericCollections.Logic
{
    public static class GenericLogic
    {
        public static Stack<T> AddObjectsToStack<T>(T[] objects)
        {
            Console.WriteLine($"Adding objects to Stack\n");

            Stack<T> stack = new();
            foreach (var obj in objects)
            {
                try
                {
                    stack.Push(obj);
                }
                catch (ArgumentException ex)
                {
                    ExceptionHelper.ExceptionDetails(ex);
                }
            }
            return stack;
        }
        public static List<T> AddObjectsToList<T>(T[] objects)
        {
            Console.WriteLine($"Adding objects to List\n");

            List<T> list = new();
            foreach (var obj in objects)
            {
                try
                {
                    list.Add(obj);
                }
                catch (ArgumentException ex)
                {
                    ExceptionHelper.ExceptionDetails(ex);
                }
            }
            return list;
        }
        public static void PrintEVeryObjectInStack<T>(Stack<T> stack)
        {
            Console.WriteLine("Printing every object in the Stack\n");
            foreach (var obj in stack)
            {
                try
                {
                    Console.WriteLine($"{obj}");
                    Console.WriteLine($"Items left in the Stack = {stack.Count}");
                }
                catch (ArgumentException ex)
                {
                    ExceptionHelper.ExceptionDetails(ex);
                }
            }
        }

        public static void PopItemsInStack<T>(Stack<T> stack)
        {
            try
            {
                var stackLength = stack.Count;
                Console.WriteLine("Retrieve Using PoP Method\n");
                for (int i = 0; i < stackLength; i++)
                {
                    Console.WriteLine(stack.Pop());
                    Console.WriteLine($"Items left in the Stack = {stack.Count}");
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
            }
        }

        public static void PeekItemsInStack<T>(Stack<T> stack, int timesToPeek)
        {
            Console.WriteLine("Retrieve Using Peek Method\n");

            for (int i = 0; i < timesToPeek; i++)
            {
                try
                {
                    Console.WriteLine(stack.Peek());
                    Console.WriteLine($"Items left in the Stack = {stack.Count}");
                }
                catch (Exception ex)
                {
                    ExceptionHelper.ExceptionDetails(ex);
                }
            }
        }
        public static bool FindObjectInStackAtPosition<T>(Stack<T> stack, int position)
        {
            try
            {
                T foundObject = stack.Reverse().Skip(position - 1).FirstOrDefault();
                return foundObject != null;
            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
                return false;
            }
        }
        public static bool FindObjectInStack<T>(Stack<T> stack, T specificObject)
        {
            try
            {
                return stack.Contains(specificObject);
            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
                return false;
            }
        }
        public static void StackContains<T>(Stack<T> stack, Enum genericEnum)
        {
            try
            {
                foreach (var obj in stack)
                {
                    var props = typeof(T).GetProperties();
                    foreach (var prop in props)
                    {
                        if (prop.PropertyType.IsEnum)
                        {
                            Enum enumValue = (Enum)prop.GetValue(obj);
                            if (enumValue.Equals(genericEnum))
                            {
                                Console.WriteLine(obj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
            }
        }


        public static bool ListContainsSpecificObject<T>(List<T> list, T specificObject)
        {
            return list.Contains(specificObject);
        }

        public static void FindFirstObjectInListWithEnumValue<T>(List<T> list, Enum genericEnum)
        {
            try
            {
                Console.WriteLine($"Finding first object with the enum value: \"{genericEnum}\" in the List of object\n");

                T? foundObject = list.Find(obj =>
                {
                    var props = typeof(T).GetProperties();
                    foreach (var prop in props)
                    {
                        if (prop.PropertyType.IsEnum)
                        {
                            Enum enumValue = (Enum)prop.GetValue(obj);
                            if (enumValue.Equals(genericEnum))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                });
                if (foundObject is not null)
                {
                    Console.WriteLine(foundObject);
                }
                else
                {
                    Console.WriteLine($"Did not find an object with the enum value: \"{genericEnum}\".");
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
            }
        }

        public static void FindAllObjectsInListWithEnumValue<T>(List<T> list, Enum genericEnum)
        {
            try
            {
                Console.WriteLine($"Finding all objects with the enum value: \"{genericEnum}\" in the List of objects\n");

                List<T>? foundObjects = list.FindAll(obj =>
                {
                    var props = typeof(T).GetProperties();
                    foreach (var prop in props)
                    {
                        if (prop.PropertyType.IsEnum)
                        {
                            Enum enumValue = (Enum)prop.GetValue(obj);
                            if (enumValue.Equals(genericEnum))
                            {
                                return true;
                            }

                        }
                    }
                    return false;
                });
                if (foundObjects is not null)
                {
                    foreach (var correctObj in foundObjects)
                    {
                        Console.WriteLine(correctObj);
                    }
                }
                else
                {
                    Console.WriteLine($"Did not find an object with the enum value: \"{genericEnum}\".");
                }

            }
            catch (Exception ex)
            {
                ExceptionHelper.ExceptionDetails(ex);
            }
        }
    }
}