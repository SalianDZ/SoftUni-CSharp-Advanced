int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

string[] directions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
int squirrelRow = 0;
int squirrelCol = 0;

for (int row = 0; row < size; row++)
{
	string data = Console.ReadLine();

	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = data[col];

		if (matrix[row, col] == 's')
		{
			squirrelRow = row;
			squirrelCol = col;
        }
	}
}
int hazelCounter = 0;

foreach (var direction in directions)
{
	if (direction == "left")
	{
		if (squirrelCol - 1 < 0)
		{
			Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return; 
		}
        squirrelCol -= 1;

        if (matrix[squirrelRow, squirrelCol] == 'h')
		{
			hazelCounter++;

            if (hazelCounter == 3)
			{
				Console.WriteLine("Good job! You have collected all hazelnuts!");
				Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
				return;
			}
			matrix[squirrelRow, squirrelCol] = '*'; 
			continue;
		}
		else if (matrix[squirrelRow, squirrelCol] == '*')

        {
			continue;
        }
		else if (matrix[squirrelRow, squirrelCol] == 't')
		{
			Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
			return;
        }
	}
	else if (direction == "right")
	{
        if (squirrelCol + 1 >= size)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
        squirrelCol += 1;

        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelCounter++;

            if (hazelCounter == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
                return;
            }
            matrix[squirrelRow, squirrelCol] = '*';
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == '*')
        {
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
    }
	else if (direction == "up")
	{
        if (squirrelRow - 1 < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
        squirrelRow -= 1;

        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelCounter++;

            if (hazelCounter == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
                return;
            }
            matrix[squirrelRow, squirrelCol] = '*';
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == '*')
        {
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
    }
	else if (direction =="down")
	{
        if (squirrelRow + 1 >= size)
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
        squirrelRow += 1;

        if (matrix[squirrelRow, squirrelCol] == 'h')
        {
            hazelCounter++;

            if (hazelCounter == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
                return;
            }
            matrix[squirrelRow, squirrelCol] = '*';
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == '*')
        {
            continue;
        }
        else if (matrix[squirrelRow, squirrelCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {hazelCounter}");
            return;
        }
    }
}

Console.WriteLine("There are more hazelnuts to collect.");
Console.WriteLine($"Hazelnuts collected: {hazelCounter}");