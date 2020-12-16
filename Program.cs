using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HashTable1 
{
    struct UserInfo
    {
        public int userId;
        public string userName;
        public UserInfo(int id, string name) 
        {
            userId = id;
            userName = name;
        }
    }

    class Program
    {

        static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;
        

        static void Main(string[] args)
        {
            // HashTable - > key-value pairs
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();

            for (int i = 0; i < 4000000 ; i++)
            {
                userInfoHash.Add(i , "user"+ i );
                userInfoList.Add(new UserInfo(i, "user" + i));
            }

            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            //setting
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacementName";
            }

            //// Looping
            //foreach (DictionaryEntry entry in userInfoHash)
            //{
            //    Console.WriteLine("Key: " + entry.Key + "Value : " + entry.Value);
            //}

            // access 
            Random randomUserGen = new Random();
            int randomUser = -1;

            sw.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;

            int cycles = 5;
            int cycle = 0;

            while (cycle < cycle)
            {
                randomUser = randomUserGen.Next(3000000,  4000000);
                startTime = sw.ElapsedMilliseconds;
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;

                string userName = null;
                Console.WriteLine("Time take to retrieve " + userName + " from  list took " + string.Format("{0:0##}", deltaTime) + "ms");

                startTime = sw.ElapsedMilliseconds;
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;

                Console.WriteLine("Time take to retrieve " + userName + " from  hash took " + string.Format("{0:0##}", deltaTime) + "ms");
                cycle++;
            }

        }
    }
   
}
