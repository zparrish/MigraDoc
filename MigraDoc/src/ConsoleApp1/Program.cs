using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Resources;
using PdfSharp.Pdf;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //var _resmngr = new ResourceManager("MigraDoc.Rendering.Resources.Messages", typeof(Area).GetTypeInfo().Assembly);

            //var resources = typeof(Document).GetTypeInfo().Assembly.GetManifestResourceNames();

            //try
            //{
            //    var ci = new System.Globalization.CultureInfo("de");
            //    var x = _resmngr.GetString("NumberTooLargeForRoman", ci);
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}


            //var y = "stop";
        }
    }
}
