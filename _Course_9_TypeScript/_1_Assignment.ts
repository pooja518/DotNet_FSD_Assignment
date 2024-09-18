class Product{
    public ProductId : number;
    public  ProductName : string;
    public UnitPrice : number;
    public Qty : number;

    constructor (id:number, name: string = "", price: number = 0, qty: number = 0){
        this.ProductId = id;
        this.ProductName = name;
        this.UnitPrice = price;
        this.Qty = qty;
    }

    public getTotal(UnitPrice:number, Qty: number) : number{
        return this.UnitPrice* this.Qty;
    }

    public showDetails() : void{
        console.log(`ProductId : ${this.ProductId}, ProductName : ${this.ProductName}, UnitPrice : ${this.UnitPrice}, Qty : ${this.Qty}`);
    }

}


var obj:Product = new Product(1);

var id: number = 2;
var Name:string = 'Earphones';
var UnitPrice: number = 700;
var Qty: number = 4;
var obj1:Product = new Product(id, Name, UnitPrice, Qty);
obj.showDetails();
obj1.showDetails();

var TotalPrice: number = obj1.getTotal(UnitPrice, Qty);
console.log(`TotalPrice : ${TotalPrice}`);

