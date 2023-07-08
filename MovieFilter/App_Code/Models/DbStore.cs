using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DbStore
{
    public static string GetAllMovies = "Sp_GetMovies";

    public static string InsertActor = "Sp_InsertActor";
    public static string UpdateActor = "Sp_UpdateActor";
    public static string GetActorById = "Sp_GetActorById";
    public static string GetAllActors = "Sp_GetActors";

    public static string InsertDirector = "Sp_InsertDirector";
    public static string UpdateDirector = "Sp_UpdateDirector";
    public static string GetDirectorById = "Sp_GetDirectorById";
    public static string GetAllDirectors = "Sp_GetDirectors";

    public static string InsertGenre = "Sp_InsertGenre";
    public static string UpdateGenre = "Sp_UpdateGenre";
    public static string GetGenreById = "Sp_GetGenreById";
    public static string GetAllGenres = "Sp_GetGenres";

}