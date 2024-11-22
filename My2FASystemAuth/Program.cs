using System;
using System.Collections.Generic;
using System.IO;

namespace ConnectionChecker
{
    class Program
    {
        static async Task Main(string[] args)
        {
          // Instance av connect 
           Connect connect = new Connect();
           await connect.CheckConnectionAsync();

        }
    }
}