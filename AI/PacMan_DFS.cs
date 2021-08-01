using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Node {
    public int r;
    public int c;
    public Node parent;
        
    public Node (int r, int c, Node parent) {
        this.r = r;
        this.c = c;
        this.parent = parent;
    }
}

class Solution {

    static void dfs( int r, int c, int pacman_r, int pacman_c, int food_r, int food_c, String [] grid){
        var stack = new Stack<Node>();
        var path = new Stack<Node>();
        
        var explored = new List<Node>();
        
        var visited = new bool[r, c];
        Node goal = null;
        
        var init = new Node(pacman_r, pacman_c, null);
        stack.Push(init);        
        
        while(stack.Count>0) {       
            var curr = stack.Pop();            
            visited[curr.r, curr.c] = true;
            explored.Add(curr);
            
            if(grid[curr.r].ElementAt(curr.c) == '.') {
                goal = curr;
                break;
            }     
            
            if(curr.r-1 >= 0 && !visited[curr.r-1, curr.c] && grid[curr.r-1].ElementAt(curr.c) != '%') {
                var newNode = new Node(curr.r-1, curr.c, curr);
                visited[curr.r-1, curr.c] = true;
                stack.Push(newNode);                
            }
            if(curr.c-1 >= 0 && !visited[curr.r, curr.c-1] && grid[curr.r].ElementAt(curr.c-1) != '%') {
                var newNode = new Node(curr.r, curr.c-1, curr);
                visited[curr.r, curr.c-1] = true;
                stack.Push(newNode);                
            }
            if(curr.c+1 < c && !visited[curr.r, curr.c+1] && grid[curr.r].ElementAt(curr.c+1) != '%') {
                var newNode = new Node(curr.r, curr.c+1, curr);
                visited[curr.r, curr.c+1] = true;
                stack.Push(newNode);                
            }
            if(curr.r+1 < r && !visited[curr.r+1, curr.c] && grid[curr.r+1].ElementAt(curr.c) != '%') {
                var newNode = new Node(curr.r+1, curr.c, curr);
                visited[curr.r+1, curr.c] = true;
                stack.Push(newNode);                
            }
        }
        
        var gg = goal;
        while(gg != null) {
            path.Push(gg);
            gg = gg.parent;
        }
        
        Console.WriteLine(explored.Count);
        foreach(var node in explored) {
            Console.WriteLine(node.r + " " + node.c);
        }
        Console.WriteLine(path.Count - 1);
        while(path.Any()) {
            gg = path.Pop();
            Console.WriteLine(gg.r + " " + gg.c);
        }
    }

    static void Main(String[] args) {
        int r,c;
        int pacman_r, pacman_c;
        int food_r, food_c;
    
        String pacman = Console.ReadLine();
        String food = Console.ReadLine();
        String pos = Console.ReadLine();
    
        String [] pos_split = pos.Split(' ');
        String [] pacman_split = pacman.Split(' ');
        String [] food_split = food.Split(' ');

        r = Convert.ToInt32(pos_split[0]);
        c = Convert.ToInt32(pos_split[1]);

        pacman_r = Convert.ToInt32(pacman_split[0]);
        pacman_c = Convert.ToInt32(pacman_split[1]);

        food_r = Convert.ToInt32(food_split[0]);
        food_c = Convert.ToInt32(food_split[1]);

        String[] grid  = new String[r];

        for(int i=0; i < r; i++) {
            grid[i] = Console.ReadLine(); 
        }

        dfs( r, c, pacman_r, pacman_c, food_r, food_c, grid);
    }
}