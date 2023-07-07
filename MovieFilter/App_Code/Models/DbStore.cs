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

}