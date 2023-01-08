using Catlog;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
Product ram =new Product {
    Id=10,
    Title="Cabinate",
    Description="big",
    UnitPrice =4000
};

List<Product> flowers = new List<Product> ();
flowers.Add(ram);

try{
    var options = new JsonSerializerOptions{IncludeFields=true};
    var productsJson = JsonSerializer.Serialize<List<Product>>(flowers,options);
    string filePath=@"/home/monster/dotNet/lab/computerShop/Presistent/product.json";
    string jsonString = File.ReadAllText(filePath);
            List<Product> jsonFlowers = JsonSerializer.Deserialize<List<Product>>(jsonString);

    Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
    foreach( Product flower in jsonFlowers)
            {
                Console.WriteLine("helllo"+$"{flower.Title} : {flower.Description}");   
            } 

}catch(Exception e){

}

