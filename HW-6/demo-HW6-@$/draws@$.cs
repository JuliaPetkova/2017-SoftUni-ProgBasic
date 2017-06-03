using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_HW6___
{
    class Program
    {
        static void Main(string[] args)
        {
            // нов ред -->
            // aaa
            // bbb
            Console.WriteLine("aaa\nbbb");



            // ескейпва се \ резултата е на 1 ред --> aaa\nbbb
            Console.WriteLine("aaa\\nbbb");




            // @ за писане на многоредови текстове

            Console.WriteLine(@"The name C sharp
                was inspired by musical notation where a 
                sharp indicates that the written note should be made
                a semitone higher in pitch.[29] This is similar to the");



            // @ за писане на links
            Console.WriteLine(@"c:\Temp");

        }
    }
}
