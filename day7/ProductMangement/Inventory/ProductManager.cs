using System.Linq;

public class ProductManager{
    public static List <Riva> GetSoldProducts(){
        List <Riva> products = GetAllProducts();
        var soldOutProducts = from prod int 
    }
}