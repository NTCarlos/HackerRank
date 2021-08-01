using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void next_move(int posr, int posc, List <string> board) {
        double min=1000.000;
        int x=0,y=0;
        for(int i=0;i<board.Count();i++)
        {
            for(int j=0;j<board[i].Count();j++)
            {
                if(board[i][j]=='d')
                {
                    double a=Math.Sqrt((Math.Abs(i-posr)*Math.Abs(i-posr))+(Math.Abs(j-posc)*Math.Abs(j-posc)));
                    if(a<min)
                    {
                        min=a;
                        x=i;
                        y=j;
                    }
                }
            }
        }
        if(x==posr&&y==posc)
        {
            Console.WriteLine("CLEAN");
        }
        else
        {
            if(x>posr)
            {
                Console.WriteLine("DOWN");
            }
            else if(x<posr)
            {
                Console.WriteLine("UP");
            }
            else
            {
                if(y<posc)
                {
                    Console.WriteLine("LEFT");
                }
                else
                {
                    Console.WriteLine("RIGHT");
                }
            }
        }
    }

    static void Main(String[] args) {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        List<string> board = new List<string>();
        for(int i=0;i<5;i++)
        {
            board.Add(Console.ReadLine());
        }
        for(int i=0;i<2;i++) pos[i] = Convert.ToInt32(position[i]);
        next_move(pos[0], pos[1], board);
    }
}