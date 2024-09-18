var Product = /** @class */ (function () {
    function Product(id, name, price, qty) {
        if (name === void 0) { name = ""; }
        if (price === void 0) { price = 0; }
        if (qty === void 0) { qty = 0; }
        this.ProductId = id;
        this.ProductName = name;
        this.UnitPrice = price;
        this.Qty = qty;
    }
    Product.prototype.getTotal = function (UnitPrice, Qty) {
        return this.UnitPrice * this.Qty;
    };
    Product.prototype.showDetails = function () {
        console.log("ProductId : ".concat(this.ProductId, ", ProductName : ").concat(this.ProductName, ", UnitPrice : ").concat(this.UnitPrice, ", Qty : ").concat(this.Qty));
    };
    return Product;
}());
var obj = new Product(1);
var id = 2;
var Name = 'Earphones';
var UnitPrice = 700;
var Qty = 4;
var obj1 = new Product(id, Name, UnitPrice, Qty);
obj.showDetails();
obj1.showDetails();
var TotalPrice = obj1.getTotal(UnitPrice, Qty);
console.log("TotalPrice : ".concat(TotalPrice));
