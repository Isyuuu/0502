namespace MyApi.Services;

public class RpgServices
{
    private static IList<Rpg> database;

   static RpgServices()

    {
        database = new List<Rpg>();
        database.Add(new Rpg() { id = 0, name = "boss", lv = 777 });
        database.Add(new Rpg() { id = 1, name = "bigboss", lv = 888 });
        database.Add(new Rpg() { id = 2, name = "verybigboss", lv = 999 });
    }
public Rpg Get(int id)

{Rpg result = null;
    
    var db = from d in database
        where d.id == id
        select d;
    
    if (db.Any())
    {
        result = db.First();
    }

    return result;
}


}
