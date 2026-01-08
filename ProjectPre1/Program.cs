using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPre1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //FileHendling obj = new FileHendling();
            //obj.createFile();
            //obj.addContentOnFile();
            //////obj.appendContentOnFile();
            //obj.readDataOnFile();
            ////obj.deleteFileOperation();

            ShortFileHendling sf = new ShortFileHendling();
            sf.createFile();
            sf.addContentOnFile();
            ////obj.appendContentOnFile();
            sf.readDataOnFile();
            //obj.deleteFileOperation();
        }
    }
}