using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracked.IO
{
    internal class CoreConfig
    {
        // When the program loads, it needs to ensure that its core configuration settings file exists.
        // This file can be modified by the user as needed, but the file itself, i.e., the name, cant. 

        private static readonly string RootFolder = 
            String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), 
                @"\Tracked");
        public static void ConfirmConfigFileExists()
        {
            // First, lets make sure the directory exists in the first place. If not, create it. Because its new
            // we know for a fact the config file doesn't exist. We're looking in the My Documents folder. 
            if (!Directory.Exists(RootFolder))
            {
                Directory.CreateDirectory(RootFolder);
            }
        }

    }
}
