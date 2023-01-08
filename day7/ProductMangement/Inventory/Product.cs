public class Riva{
    private int Id{
        get;set;
    }
    private int Balance{
        get;set;
    }
    private string Title {
        get;set;
    }
    private string ImageUrl{
        get;set;
    }
    private string Category {
        get; set;
    }
    private float UnitPrice {
        get;set;
    }
    private string Description {
        get;set;
    }
    private string Delivery{
        get;set;
    }
    public Riva(int Id,int Balance,string Title,string ImageUrl,string Category,string Description,float UnitPrice, string delivery ) {
        this.Id=Id;
        this.Balance=Balance;
        this.Category=Category;
        this.Description=Description;
        this.Title=Title;
        this.UnitPrice=UnitPrice;
        this.Delivery=delivery;
    }

}