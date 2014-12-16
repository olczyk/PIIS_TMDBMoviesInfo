PIIS_TMDBMoviesInfo
===================

This program was made for the Programming of Inteligent Information Systems course as a tool needed for the movie reccomendation system project.

The general idea behind it is to retrieve values of the specified movie features. Their values have been taken from [The Movie Database (TMDb)](https://www.themoviedb.org/) using [WatTMDb](http://wattmdb.codeplex.com/) API wrapper library.

Instructions
=======================
In order to be ale to use the [TMDb API](https://www.themoviedb.org/documentation/api) you have to ask them for the **API key** and put it here:

`Tmdb api = new Tmdb("APIKey");`

As an input it takes a table of movie IDs (IDs from TMDb).

The output is the .txt file of the following format:

`[RecordId];[MyMovieId];[FeatureId];[FeatureValue]`

where `[MyMovieId]` corresponds to the position of the movie in the input table. 

The following features are hard coded in the application:

FeatureId | FeatureName | FeatureDescription
--- | --- | --- 
1 | CollectionId | If the movie belongs to a collection, it's ID is put here. If no the value is null.
2 | Budget | Budget in $.
3 | GenresIds | Movie genres seperated by "/".
4 | Popularity | Popularity of the movie. | 5
5 | ProductionCompaniesIds | Movie production companies separated by the "/".
6 | ProductionCountriesIso | Movie production counries codes separated by the "/".
7 | ReleaseDate | Movie release date.
8 | Revenue | Revenue in $.
9 | Runtime | Runtime in minutes.
10 | SpokenLanguagesIso | Movie spoken languages codes separated by the "/".
11 | VoteAverage | Movie average vote.
12 | VoteCount | Number of votes.
13 | CastIds | Ids of 10 people from movie cast separated by the "/". Starting from the most important characters.
14 | Costume&Make-UpIds | Ids of people from movie Costume & Make-Up department separated by the "/".
15 | DirectingIds | Ids of people from movie Directing department separated by the "/".
16 | CameraIds | Ids of people from movie Camera department separated by the "/".
17 | EditingIds | Ids of people from movie Editing department separated by the "/".
18 | ProductionIds | Ids of people from movie Production department separated by the "/".
19 | SoundIds | Ids of people from movie Sound department separated by the "/".
20 | WritingIds | Ids of people from movie Writing department separated by the "/".
21 | ArtIds | Ids of people from movie Art department separated by the "/".
22 | CrewIds | Ids of people from movie Crew department separated by the "/".
23 | VisualEffectsIds | Ids of people from movie Visual Effects department separated by the "/".



