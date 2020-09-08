using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HashTableProject
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
    class MainClass
    {
        // doesn't need to be static
        static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;
        public static void notMain(String[] args)
        {
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();

            // Adding elements
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
                userInfoList.Add(new UserInfo(i, "user" + i));
            }
            // Removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }
            // Setting
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacementName";
            }

            // Looping
            foreach(DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key: " + entry.Key + " / Value: " + entry.Value);
            }

        }
    }
}