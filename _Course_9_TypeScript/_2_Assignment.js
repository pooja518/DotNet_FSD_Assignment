var Customer = /** @class */ (function () {
    function Customer(Id, Name, City) {
        if (Id === void 0) { Id = 0; }
        if (Name === void 0) { Name = ""; }
        if (City === void 0) { City = ""; }
        this.Id = Id;
        this.Name = Name;
        this.City = City;
    }
    Customer.prototype.showDetails = function () {
        console.log("Customer Details :  Id - ".concat(this.Id, ", Name : ").concat(this.Name, ", City : ").concat(this.City));
    };
    return Customer;
}());
var obj1 = new Customer();
var obj2 = new Customer(1);
var obj3 = new Customer(1, 'Pooja');
var obj4 = new Customer(1, 'Pooja', 'Hyderabad');
obj1.showDetails();
obj2.showDetails();
obj3.showDetails();
obj4.showDetails();
