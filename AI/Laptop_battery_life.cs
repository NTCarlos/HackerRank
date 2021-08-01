using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        double timeCharged = Convert.ToDouble(Console.ReadLine().Trim());
        var output=timeCharged*2.0;
        if(output>8.0)
            output=8.0;
        Console.WriteLine(output);
    }
}