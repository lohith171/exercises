﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video to the cloud");
        }
    }
}
