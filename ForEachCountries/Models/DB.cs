using LessionOnePartTwo.Controllers;

namespace LessionOnePartTwo.Models
{
    public class DB {
     
        public DB(){

            var c1 = new Country();
            var c2 = new Country();
            var c3 = new Country();
            var c4 = new Country();
            var c5 = new Country();
            c1.Name = "Israel";
            c2.Name = " USA";
            c3.Name = "Japan";
            c4.Name = "Thiland";
            c5.Name = "Chine";
           myc = new List<Country> { c1, c2, c3, c4, c5 };
        }
        public List<Country> myc; 

    }
}
