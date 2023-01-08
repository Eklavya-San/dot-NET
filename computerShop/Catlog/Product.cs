namespace Catlog;
public class Product
{
    public int Id {get;set;}
    public string Title{get;set;}
    public string Description {get;set;}

    public double UnitPrice {get;set;}

    public Product (int id,string title,string des,double unitP){
        this.Id=id;
        this.Description=des;
        this.Title=title;
        this.UnitPrice=unitP;
    }
    public Product (){
        this.Id=1;
        this.Title="RAM";
        this.Description="DDR5 32gb";
        this.UnitPrice=9000;
    }
}
