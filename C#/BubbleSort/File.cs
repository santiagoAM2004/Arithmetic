using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Timers;
using System.IO;


namespace BubbleSort
{
    
    class File
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        public void startProgram()
        {
            Random numberRandom = new Random();
            TextWriter fileTxt = new StreamWriter("DesorganizadList.txt");
            string chainTxt = " ";
            Console.WriteLine("Type the range of random's number:");
            int numberRange = Convert.ToInt32(Console.ReadLine());
            watch.Start();
            Console.WriteLine("/----------Desorganizad List:---------/");
            for (int i = 0; i < numberRange; i++)
            {
                int number = numberRandom.Next(-1000, 999);
                chainTxt = chainTxt + number + " , "; 
                fileTxt.WriteLine(number);
            }
            Console.WriteLine(chainTxt);
            fileTxt.Close();
            this.BubbleSort();
        }
        public List<int> FileRead()
        {
            Console.WriteLine("/--------Ordinate List----------/");           
            List<int> desorganizadList = new List<int>();
            StreamReader read = new StreamReader("DesorganizadList.txt");
            while(!read.EndOfStream)
            {
                int numberList = Convert.ToInt32(read.ReadLine());
                desorganizadList.Add(numberList);
            }
            read.Close();   
            return desorganizadList;
        
        }

        public void BubbleSort()
        {
            string chainTxtList = " ";
            List<int> desorganizadList = this.FileRead();  
            int temp; 
            for (int j = 0; j <= desorganizadList.Count - 2; j++) 
            {
                for (int i = 0; i <= desorganizadList.Count - 2; i++) 
                {
                    if (desorganizadList[i] > desorganizadList[i + 1]) 
                    {
                        temp= desorganizadList[i + 1];
                        desorganizadList[i + 1] = desorganizadList[i];
                        desorganizadList[i] = temp;
                    }
                }
            } 
            foreach(int p in desorganizadList){
                chainTxtList = chainTxtList + p + " , ";
            } 
            Console.WriteLine(chainTxtList);
            this.SaveNewFile(desorganizadList);
        }

        public void SaveNewFile (List<int> ordinateList){
            TextWriter fileTxt2 = new StreamWriter("OrdinateList.txt");
            foreach(int i in ordinateList){
                fileTxt2.WriteLine(i);
            }
            fileTxt2.Close();
            watch.Stop();
            Console.WriteLine("tiempo: {0} ", watch.Elapsed);
        }
    }
}
