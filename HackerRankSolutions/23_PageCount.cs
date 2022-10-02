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

class Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
            int leftCount = 0, min =0 ;
            double numOfPage;

            for ( int i=1; i<=n; i++ )
            {
                if( p >= i * 2 )
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }

            numOfPage =Math.Ceiling( (double) ( n + 1 ) / 2);

            var rightCount = (int) numOfPage- (int) Math.Ceiling( (double) (p + 1) / 2 ); 

            min = rightCount < leftCount ? rightCount : leftCount;
            return min;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}