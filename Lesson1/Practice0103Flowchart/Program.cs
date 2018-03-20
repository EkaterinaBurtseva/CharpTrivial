using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0103Flowchart
{
    class Program
    {
        static void Main(string[] args){
            FlowChartFactorial(3);
        }
        public static void FlowChartFactorial(int n)
        {
            int fact = 1;
            while(n>1) {        
                fact = fact * n;
                n --;
            }
            Console.WriteLine(fact);
            
       
        }
    }
}
