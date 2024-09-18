class Customer {
  public Id: number;
  public Name: string;
  public City: string;

  constructor(Id: number = 0, Name: string = "", City: string = "") {
    this.Id = Id;
    this.Name = Name;
    this.City = City;
  }

  public showDetails(): void {
    console.log(
      `Customer Details :  Id - ${this.Id}, Name : ${this.Name}, City : ${this.City}`
    );
  }
}

var obj1: Customer = new Customer();
var obj2: Customer = new Customer(1);
var obj3: Customer = new Customer(1, "Pooja");
var obj4: Customer = new Customer(1, "Pooja", "Hyderabad");

obj1.showDetails();
obj2.showDetails();
obj3.showDetails();
obj4.showDetails();

