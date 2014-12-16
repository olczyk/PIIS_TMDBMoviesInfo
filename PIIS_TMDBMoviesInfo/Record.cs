using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIIS_TMDBMoviesInfo
{
    public class Record
    {
        private int id;
        private int movieId;
        private int featureId;
        private string value;

        public Record(int id, int movieId, int featureId, string value)
        {
            this.id = id;
            this.movieId = movieId;
            this.featureId = featureId;
            this.value = value;

            PrintRecordInConsole();
        }

        public void PrintRecordInConsole()
        {
            Console.WriteLine(id + ";" + movieId + ";" + featureId + ";" + value);
        }

        public string PrintRecord()
        {
            return (id + ";" + movieId + ";" + featureId + ";" + value);
        }
    }
}
