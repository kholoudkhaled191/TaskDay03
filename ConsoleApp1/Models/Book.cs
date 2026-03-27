using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{


    //1-  with explicit configuration , EF treats with ID as the Primary key by convention

    //2- ال(counry) string is reference type هقدر اجطه ب null عادي بس ال price decimal هو value type لو عايزه احطه ب null هحط ؟ 
    



    internal class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }



    }
}
