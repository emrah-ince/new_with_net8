Console.WriteLine("Shuffle Numbers:");
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
Random.Shared.Shuffle(numbers);
int index = 1;
numbers.ToList().ForEach(n => Console.WriteLine($"{index++}. number => {n}"));