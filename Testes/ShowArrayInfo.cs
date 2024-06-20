private static void ShowArrayInfo(Array arr)
    {
        Console.WriteLine("Length of Array:      {0,3}", arr.Length);
        Console.WriteLine("Number of Dimensions: {0,3}", arr.Rank);
        // For multidimensional arrays, show number of elements in each dimension.
        if (arr.Rank > 1) {
            for (int dimension = 1; dimension <= arr.Rank; dimension++)
                Console.WriteLine("   Dimension {0}: {1,3}", dimension,
                                  arr.GetUpperBound(dimension - 1) + 1);
        }
        Console.WriteLine();
    }
