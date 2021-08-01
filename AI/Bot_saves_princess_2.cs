    static void nextMove(int n,int r, int c, String [] grid)
    {
        var levelPeach = 0;
        var peachPosition = 0;
        var marioPosition = 0;
        
        var levelMario = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[i].Contains("p"))
            {
                levelPeach = i;
                peachPosition = grid[i].IndexOf('p');
            }
            if (grid[i].Contains("m"))
            {
                levelMario = i;
                marioPosition = grid[i].IndexOf('m');
            }
        }
        
        if (levelMario < levelPeach)
        {
            Console.WriteLine("DOWN");
        }
        else if (levelMario > levelPeach)
        {
            Console.WriteLine("UP");
        }
        else
        {
            if (marioPosition < peachPosition)
            {
                Console.WriteLine("RIGHT");
            }
            else if (marioPosition > peachPosition)
            {
                Console.WriteLine("LEFT");
            }
        }
    }
