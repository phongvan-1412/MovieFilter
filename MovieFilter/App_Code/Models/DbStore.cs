using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DbStore
{
    public static string InsertActor = "Sp_InsertActor";
    public static string UpdateActor = "Sp_UpdateActor";
    public static string GetActorById = "Sp_GetActorById";
    public static string GetActorByName = "Sp_GetActorByName";
    public static string GetAllActors = "Sp_GetActors";

    public static string InsertDirector = "Sp_InsertDirector";
    public static string UpdateDirector = "Sp_UpdateDirector";
    public static string GetDirectorById = "Sp_GetDirectorById";
    public static string GetDirectorByName = "Sp_GetDirectorByName";
    public static string GetAllDirectors = "Sp_GetDirectors";

    public static string InsertGenre = "Sp_InsertGenre";
    public static string UpdateGenre = "Sp_UpdateGenre";
    public static string GetGenreById = "Sp_GetGenreById";
    public static string GetGenreByName = "Sp_GetGenreByName";
    public static string GetAllGenres = "Sp_GetGenres";

    public static string InsertMovie = "Sp_InsertMovie";
    //public static string UpdateMovie = "Sp_UpdateMovie";
    public static string GetMovieById = "Sp_GetMovieById";
    public static string GetAllMovies = "Sp_GetMovies";

    public static string InsertMovCast = "Sp_InsertMovCast";
    public static string GetAllMovCasts = "Sp_GetMovCasts";

    public static string InsertMovDir = "Sp_InsertMovDir";
    public static string GetAllMovDirs = "Sp_GetMovDirs";

    public static string InsertMovGen = "Sp_InsertMovGen";
    public static string GetAllMovGens = "Sp_GetMovGens";
}