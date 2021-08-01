using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static void displayPathtoPrincess(int n, String [] grid)
    {
        var levelPeach = 0;
        var finalMov = "";
        var whichCorner = 0;
        var marioPosition = 0;
        var levelMario = 0;
        
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[i].Contains("p"))
            {
                levelPeach = i;
                whichCorner = grid[i].IndexOf('p');
                finalMov = whichCorner == 0 ? "LEFT" : "RIGHT";
            }
            if (grid[i].Contains("m"))
            {
                levelMario = i;
                marioPosition = grid[i].IndexOf('m');
            }
        }
        var amountOfMov = 0;
        var direction = "";
        var numberOfFinalSteps = Math.Abs(whichCorner - marioPosition);
        if (levelMario < levelPeach)
        {
            direction = "DOWN";
            amountOfMov = levelPeach - levelMario;
        }
        else if (levelMario > levelPeach)
        {
            direction = "UP";
            amountOfMov =  levelMario - levelPeach;
        }

        for (var i = 0; i < amountOfMov; i++)
        {
            Console.WriteLine(direction);
        }

        for (var i = 0; i < numberOfFinalSteps; i++)
        {
            Console.WriteLine(finalMov);
        }
    }

static void Main(String[] args) {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid  = new String[m];
        for(int i=0; i < m; i++) {
            grid[i] = Console.ReadLine(); 
        }

        displayPathtoPrincess(m,grid);
     }
}