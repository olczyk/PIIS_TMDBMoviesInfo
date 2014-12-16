using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatTmdb.V3;

namespace PIIS_TMDBMoviesInfo
{
    public class MovieUtilities
    {
        private TmdbMovie movie;
        private TmdbMovieCast cast;

        public MovieUtilities(TmdbMovie movie, TmdbMovieCast cast)
        {
            this.movie = movie;
            this.cast = cast;
        }

        public string GetGenresIds()
        {
            string genresIds_3 = string.Empty;

            if (movie.genres.Count > 0)
            {
                foreach (var genre in movie.genres)
                {
                    genresIds_3 += genre.id.ToString() + "/";
                }
                genresIds_3 = genresIds_3.TrimEnd('/');
            }
            else
            {
                genresIds_3 = "null";
            }
            return genresIds_3;
        }

        public string GetProductionCompaniesIds()
        {
            string productionCompaniesIds_5 = string.Empty;

            if (movie.production_companies.Count > 0)
            {
                foreach (var company in movie.production_companies)
                {
                    productionCompaniesIds_5 += company.id.ToString() + "/";
                }
                productionCompaniesIds_5 = productionCompaniesIds_5.TrimEnd('/');
            }
            else
            {
                productionCompaniesIds_5 = "null";
            }
            return productionCompaniesIds_5;
        }

        public string GetProductionCountriesIso()
        {
            string productionCountriesIso_6 = string.Empty;

            if (movie.production_countries.Count > 0)
            {
                foreach (var country in movie.production_countries)
                {
                    productionCountriesIso_6 += country.iso_3166_1.ToString() + "/";
                }
                productionCountriesIso_6 = productionCountriesIso_6.TrimEnd('/');
            }
            else
            {
                productionCountriesIso_6 = "null";
            }
            return productionCountriesIso_6;
        }

        public string GetSpokenLanguagesIso()
        {
            string spokenLanguagesIso_10 = string.Empty;

            if (movie.spoken_languages.Count > 0)
            {
                foreach (var language in movie.spoken_languages)
                {
                    spokenLanguagesIso_10 += language.iso_639_1.ToString() + "/";
                }
                spokenLanguagesIso_10 = spokenLanguagesIso_10.TrimEnd('/');
            }
            else
            {
                spokenLanguagesIso_10 = "null";
            }
            return spokenLanguagesIso_10;
        }

        public string GetCastIds(int count)
        {
            string castIds_13 = string.Empty;

            if (cast.cast.Count > 0)
            {
                int temp = 0;

                foreach (var actor in cast.cast)
                {
                    if(temp < count)
                    {
                        castIds_13 += actor.id.ToString() + "/";
                    }
                    temp++;
                }
                castIds_13 = castIds_13.TrimEnd('/');
            }
            else
            {
                castIds_13 = "null";
            }
            return castIds_13;
        }

        public string GetCostumeMakeUpIds()
        {
            string costumeMakeUpIds_14 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++ )
            {
                if(cast.crew.ElementAt(i).department == "Costume&Make-Up")
                {
                    costumeMakeUpIds_14 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if(temp == 0)
            {
                costumeMakeUpIds_14 = "null";
            }
            else
            {
                costumeMakeUpIds_14 = costumeMakeUpIds_14.TrimEnd('/');
            }

            return costumeMakeUpIds_14;
        }


        public string GetDirectingIds()
        {
            string directingIds_15 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Directing")
                {
                    directingIds_15 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                directingIds_15 = "null";
            }
            else
            {
                directingIds_15 = directingIds_15.TrimEnd('/');
            }

            return directingIds_15;
        }

        public string GetCameraIds()
        {
            string cameraIds_16 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Camera")
                {
                    cameraIds_16 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                cameraIds_16 = "null";
            }
            else
            {
                cameraIds_16 = cameraIds_16.TrimEnd('/');
            }

            return cameraIds_16;
        }

        public string GetEditingIds()
        {
            string editingIds_17 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Editing")
                {
                    editingIds_17 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                editingIds_17 = "null";
            }
            else
            {
                editingIds_17 = editingIds_17.TrimEnd('/');
            }

            return editingIds_17;
        }

        public string GetProductionIds()
        {
            string productionIds_18 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Production")
                {
                    productionIds_18 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                productionIds_18 = "null";
            }
            else
            {
                productionIds_18 = productionIds_18.TrimEnd('/');
            }

            return productionIds_18;
        }

        public string GetSoundIds()
        {
            string soundIds_19 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Sound")
                {
                    soundIds_19 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                soundIds_19 = "null";
            }
            else
            {
                soundIds_19 = soundIds_19.TrimEnd('/');
            }

            return soundIds_19;
        }

        public string GetWritingIds()
        {
            string writingIds_20 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Writing")
                {
                    writingIds_20 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                writingIds_20 = "null";
            }
            else
            {
                writingIds_20 = writingIds_20.TrimEnd('/');
            }

            return writingIds_20;
        }

        public string GetArtIds()
        {
            string artIds_21 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Art")
                {
                    artIds_21 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                artIds_21 = "null";
            }
            else
            {
                artIds_21 = artIds_21.TrimEnd('/');
            }

            return artIds_21;
        }

        public string GetCrewIds()
        {
            string crewIds_22 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Crew")
                {
                    crewIds_22 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                crewIds_22 = "null";
            }
            else
            {
                crewIds_22 = crewIds_22.TrimEnd('/');
            }

            return crewIds_22;
        }

        public string GetVisualEffectsIds()
        {
            string visualEffectsIds_23 = string.Empty;

            int temp = 0;

            for (int i = 0; i < cast.crew.Count; i++)
            {
                if (cast.crew.ElementAt(i).department == "Visual Effects")
                {
                    visualEffectsIds_23 += cast.crew.ElementAt(i).id.ToString() + "/";
                    temp++;
                }
            }

            if (temp == 0)
            {
                visualEffectsIds_23 = "null";
            }
            else
            {
                visualEffectsIds_23 = visualEffectsIds_23.TrimEnd('/');
            }

            return visualEffectsIds_23;
        }
    }
}
