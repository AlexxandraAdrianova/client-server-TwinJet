namespace SimpleServer.Data;

public class DataSource
{
   private static DataSource instance;

   private DataSource()
   {
   }

   public static DataSource GetInstance()
   {
      if (instance == null)
      {
         instance = new DataSource();
      }

      return instance;
   }

   public List<Author> _authors = new List<Author>();
}