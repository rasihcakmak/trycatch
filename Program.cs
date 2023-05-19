using System;

namespace abc
{
  class Program
  {

    
    static void Main(string [] args)
    {
     /* int degisken=0 ;
     try
     {
     Console.WriteLine("bir sayi giriniz");
     degisken=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(degisken) ;
     }
     catch(Exception ex)
     {
      Console.WriteLine("Hata: "
          + ex.Message.ToString());
      
     }*/
     /*finally
     {
      Console.WriteLine("işlem tamamlandı");
     }
   
       */
     try
     {
        //int a= int.Parse(null);
        int a = int.Parse("test");
    
     }
     catch (ArgumentNullException ex)
     {
        
        Console.WriteLine("Boş değer girdiniz");
        Console.WriteLine(ex);
     }
     catch(FormatException ex )
     {
       Console.WriteLine("Veri Tipi uygun degil");
       Console.WriteLine(ex);

     }



    }


  }


}
