using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            /*two variables, one to set the highest mountain (maxHeight)
             the other one to set the index of such mountain*/
            int maxHeight = 0, mountain = 0;
            
            for (int i = 0; i < 8; i++)
            {
                //each input value gives you the height of a mountain
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                
                /*if a mountain is higher than maxHeight,
                it becomes the highest mountain and we get
                it's index*/
                if(mountainH > maxHeight){
                    maxHeight = mountainH;
                    mountain = i;
                }
            }
            
            //return maxHeight to 0 in case another pass is neeeded
            maxHeight = 0;
            
            //print the index (mountain) capture in the for loop.
            Console.WriteLine(mountain);

        }
    }
}
