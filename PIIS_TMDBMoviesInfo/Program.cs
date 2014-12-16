using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatTmdb.V3;

namespace PIIS_TMDBMoviesInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] moviesIds = { 389, 62, 20453, 453, 185, 702, 348, 705, 143, 279, 14, 73, 55, 93, 703, 28, 212, 105, 3175, 272, 10020, 76, 665, 44214, 78, 197, 642, 289, 524, 829, 598, 15, 901, 903, 562, 17654, 68718, 968, 141, 996, 935, 1417, 38, 5961, 275, 309, 550, 12, 13, 600, 783, 98, 770, 489, 769, 13223, 137, 12445, 11787, 949, 288, 205, 10191, 429, 7984, 46738, 27205, 89, 10775, 16869, 5915, 77338, 3078, 1585, 103663, 578, 329, 81, 24, 2118, 947, 87827, 100, 832, 24238, 77, 19, 70, 3082, 128, 585, 762, 583, 3083, 322, 10774, 6977, 213, 303, 11216, 654, 311, 510, 5924, 975, 391, 797, 22, 792, 539, 680, 1578, 85, 380, 11645, 2062, 567, 223, 641, 500, 1366, 804, 1580, 805, 857, 111, 424, 807, 11324, 187, 872, 993, 12405, 107, 239, 235, 13475, 1892, 845, 599, 7508, 103, 280, 284, 74643, 24428, 887, 115, 910, 2503, 826, 155, 11778, 1422, 1955, 9552, 961, 238, 962, 37247, 596, 914, 5925, 497, 49051, 990, 10098, 247, 45269, 8587, 121, 963, 11697, 982, 603, 3112, 423, 1124, 2493, 278, 694, 274, 745, 9277, 218, 1091, 1092, 3090, 37165, 117, 629, 576, 630, 7345, 595, 8392, 1480, 862, 627, 110 };

            WatTmdb.V3.Tmdb api = new Tmdb("APIKey"); //Enter your API key here 

            string[] lines = new string[moviesIds.Length * 23];

            int recordId = 1;

            for(int i=0; i<moviesIds.Length; i++)
            {
                TmdbMovie movie = api.GetMovieInfo(moviesIds[i]);
                TmdbMovieCast cast = api.GetMovieCast(moviesIds[i]);

                MovieUtilities movieUtilities = new MovieUtilities(movie, cast);

                string collectionId_1 = (movie.belongs_to_collection != null) ? movie.belongs_to_collection.id.ToString() : "null";
                string budget_2 = movie.budget.ToString();
                string genresIds_3 = movieUtilities.GetGenresIds();
                string popularity_4 = movie.popularity.ToString();
                string productionCompaniesIds_5 = movieUtilities.GetProductionCompaniesIds();
                string productionCountriesIso_6 = movieUtilities.GetProductionCountriesIso();
                string releaseDate_7 = movie.release_date;
                string revenue_8 = movie.revenue.ToString();
                string runtime_9 = movie.runtime.ToString();
                string spokenLanguagesIso_10 = movieUtilities.GetSpokenLanguagesIso();
                string voteAverage_11 = movie.vote_average.ToString();
                string voteCount_12 = movie.vote_count.ToString();
                string castIds_13 = movieUtilities.GetCastIds(8);
                string costumeMakeUpIds_14 = movieUtilities.GetCostumeMakeUpIds();
                string directingIds_15 = movieUtilities.GetDirectingIds();
                string cameraIds_16 = movieUtilities.GetCameraIds();
                string editingIds_17 = movieUtilities.GetEditingIds();
                string productionIds_18 = movieUtilities.GetProductionIds();
                string soundIds_19 = movieUtilities.GetSoundIds();
                string writingIds_20 = movieUtilities.GetWritingIds();
                string artIds_21 = movieUtilities.GetArtIds();
                string crewIds_22 = movieUtilities.GetCrewIds();
                string visualEffectsIds_23 = movieUtilities.GetVisualEffectsIds();

                Record record1 = new Record(recordId, i + 1, 1, collectionId_1);
                lines[recordId - 1] = record1.PrintRecord();
                recordId++;
                Record record2 = new Record(recordId, i + 1, 2, budget_2);
                lines[recordId - 1] = record2.PrintRecord();
                recordId++;
                Record record3 = new Record(recordId, i + 1, 3, genresIds_3);
                lines[recordId - 1] = record3.PrintRecord();
                recordId++;
                Record record4 = new Record(recordId, i + 1, 4, popularity_4);
                lines[recordId - 1] = record4.PrintRecord();
                recordId++;
                Record record5 = new Record(recordId, i + 1, 5, productionCompaniesIds_5);
                lines[recordId - 1] = record5.PrintRecord();
                recordId++;
                Record record6 = new Record(recordId, i + 1, 6, productionCountriesIso_6);
                lines[recordId - 1] = record6.PrintRecord();
                recordId++;
                Record record7 = new Record(recordId, i + 1, 7, releaseDate_7);
                lines[recordId - 1] = record7.PrintRecord();
                recordId++;
                Record record8 = new Record(recordId, i + 1, 8, revenue_8);
                lines[recordId - 1] = record8.PrintRecord();
                recordId++;
                Record record9 = new Record(recordId, i + 1, 9, runtime_9);
                lines[recordId - 1] = record9.PrintRecord();
                recordId++;
                Record record10 = new Record(recordId, i + 1, 10, spokenLanguagesIso_10);
                lines[recordId - 1] = record10.PrintRecord();
                recordId++;
                Record record11 = new Record(recordId, i + 1, 11, voteAverage_11);
                lines[recordId - 1] = record11.PrintRecord();
                recordId++;
                Record record12 = new Record(recordId, i + 1, 12, voteCount_12);
                lines[recordId - 1] = record12.PrintRecord();
                recordId++;
                Record record13 = new Record(recordId, i + 1, 13, castIds_13);
                lines[recordId - 1] = record13.PrintRecord();
                recordId++;
                Record record14 = new Record(recordId, i + 1, 14, costumeMakeUpIds_14);
                lines[recordId - 1] = record14.PrintRecord();
                recordId++;
                Record record15 = new Record(recordId, i + 1, 15, directingIds_15);
                lines[recordId - 1] = record15.PrintRecord();
                recordId++;
                Record record16 = new Record(recordId, i + 1, 16, cameraIds_16);
                lines[recordId - 1] = record16.PrintRecord();
                recordId++;
                Record record17 = new Record(recordId, i + 1, 17, editingIds_17);
                lines[recordId - 1] = record17.PrintRecord();
                recordId++;
                Record record18 = new Record(recordId, i + 1, 18, productionIds_18);
                lines[recordId - 1] = record18.PrintRecord();
                recordId++;
                Record record19 = new Record(recordId, i + 1, 19, soundIds_19);
                lines[recordId - 1] = record19.PrintRecord();
                recordId++;
                Record record20 = new Record(recordId, i + 1, 20, writingIds_20);
                lines[recordId - 1] = record20.PrintRecord();
                recordId++;
                Record record21 = new Record(recordId, i + 1, 21, artIds_21);
                lines[recordId - 1] = record21.PrintRecord();
                recordId++;
                Record record22 = new Record(recordId, i + 1, 22, crewIds_22);
                lines[recordId - 1] = record22.PrintRecord();
                recordId++;
                Record record23 = new Record(recordId, i + 1, 23, visualEffectsIds_23);
                lines[recordId - 1] = record23.PrintRecord();
                recordId++;
            }
            File.WriteAllLines("records.txt", lines);
        }
    }
}
