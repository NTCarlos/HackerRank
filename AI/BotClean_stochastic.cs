using System;
using System.Collections.Generic;
using System.IO;

class Solution {

    static void nextMove(int posr, int posc, String [] board){
        var levelDirty = 0;
        var dirtyPosition = 0;
        var levelBot = 0;
        var botPosition = 0;
        
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i].Contains("d"))
            {
                levelDirty = i;
                dirtyPosition = board[i].IndexOf('d');
            }
            if (board[i].Contains("b"))
            {
                levelBot = i;
                botPosition = board[i].IndexOf('b');
            }
            
        }
        if (posr == levelDirty && posc == dirtyPosition)
        {
            Console.WriteLine("CLEAN");
            return;
        }
        
        if (levelBot < levelDirty)
        {
            Console.WriteLine("DOWN");
        }
        else if (levelBot > levelDirty)
        {
            Console.WriteLine("UP");
        }
        else
        {
            if (botPosition < dirtyPosition)
            {
                Console.WriteLine("RIGHT");
            }
            else if (botPosition > dirtyPosition)
            {
                Console.WriteLine("LEFT");
            }
        }
    }

static void Main(String[] args) {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        String[] board = new String[5];
        for(int i=0;i<5;i++) {
            board[i] = Console.ReadLine();
        }
        for(int i=0;i<2;i++) pos[i] = Convert.ToInt32(position[i]);
        nextMove(pos[0], pos[1], board);
    }
}