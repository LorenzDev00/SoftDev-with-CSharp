//WARNING: ecercises complited into 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Laboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            [ . . . ]
        }
     }
}

//1. Having an integer list make Max() Min() Sum() and Swap of the elements 

List<int> listaNumeri = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 };

            foreach(int numero in listaNumeri)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\nNumero Max: {0}", listaNumeri.Max());

            Console.WriteLine("Numero Max: {0}", listaNumeri.Min());

            Console.WriteLine("Summa di tutti i numeri: {0}", listaNumeri.Sum());
            
            
            int tmp;                             //Swap cycle --> for a preseted list length
            for (int i = 0; i < 10-1; i++)
            {    
                 
                 tmp = listaNumeri[i];
                 listaNumeri[i] = listaNumeri[i + 1];
                 listaNumeri[i + 1] = tmp; 
        
            }
            foreach (int numero in listaNumeri)
            {
                Console.Write(numero + " ");
            }

            Console.ReadLine();
 
//2.A Find words that contains with syllable "LA"

List<string> listaStringhe = new List<string>() {"Lanterna","Cane","Topo","Aereo","Lazzo","Gatto","Lanzarote"};
            List<string> listaA = new List<string>();
            listaA = listaStringhe.Where(x => x.ToUpper().Contains("LA")).ToList();
            foreach(string str in listaA)
            {
                Console.Write(str + " ");
            }
            Console.ReadLine();
            
//2.B Words that begin with letter "A"

List<string> listaStringhe = new List<string>() {"Ape","Cane","Topo","Aereo","Astronauta","Gatto"};
            List<string> listaA = new List<string>();
            listaA = listaStringhe.Where(x => x.StartsWith("A")).ToList();
            foreach(string str in listaA)
            {
                Console.Write(str + " ");
            }
            Console.ReadLine();

//4. Create a phrase into a string variable, then reverse the phrase 

            Console.Write("Enter a String : ");
            string phrase = Console.ReadLine();             //User types a string
            char[] arrayPhrase = phrase.ToCharArray();      //String Conversion --> char array
            Console.Write("Reversed string: ");
            for(int i = arrayPhrase.Length-1; i >= 0; i--)  //String reverse cylce
            {
                Console.Write(arrayPhrase[i]);
            }
            Console.ReadLine();
            
//5. Having a list of n element, divide it into m sublists with k elements per each 

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            var splitted = list.Select((x, i) => new { Index = i, Value = x })   
                               .GroupBy(x => x.Index / 4)                        //Determing sublists number depending on elements contained per each 
                               .Select(x => x.Select(v => v.Value).ToList())     //Selecting elements and inserting into sublists --> insering sublists into list "Splitted"
                               .ToList();

            
            Console.Write("Initial list: ");
            foreach (int i in list)
            {
                Console.Write(i + " "); 
            }

            int j = 1;
            Console.WriteLine("\nSplitted list: ");
            foreach (var group in splitted)            //Pirinting each group of lists 
            {
                
                Console.Write("\nLista {0}: ", j);
                group.ForEach(
                      x => Console.Write(x + " "));
                Console.Write(" ");
                j++;
            }

            Console.ReadLine();

//6. Having a specified amount of lists, merge them into one sigle list

            List<int> list01 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list02 = new List<int> { 6, 7, 8, 9, 10 };
            List<int> list03 = new List<int> { 11, 12, 13, 14, 15 };
            List<int> list04 = new List<int> { 21, 22, 23, 24, 25 };

            List<List<int>> containerList = new List<List<int>> { list01, list02, list03, list04 };
            List<int> mergelist = new List<int>();

            int j = 1;
            foreach (List<int> list in containerList)
            {
                
                Console.Write("\nList {0}: ", j);
                for(int i = 0; i < list.Count; i++)     //Printing all elements in single lists 
                {
                    Console.Write(list[i] + " ");
                }
                mergelist.AddRange(list);               //Merging all the lists into one --> merglist 
                j++;
            }

            Console.Write("\nMerged list: ");
           foreach(int i in mergelist)                  //Printing all elements of the mergelist
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

//7. Having two integer lists; make a union and an intersection of them 

            List<int> list01 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> list02 = new List<int> { 4, 5, 6, 7, 8 };

           var IntersectionList = list01.Intersect(list02);  //Intersection using LINQ
           var UnionList = list01.Union(list02);             //Union using LINQ

            Console.Write("List 01: ");                      
            foreach (int i in list01)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nList 02: ");
            foreach (int i in list02)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nIntersection list: ");
            foreach (int i in IntersectionList)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nUnion list: ");
            foreach (int i in UnionList)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();
