using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.setname("Omotoso David");
        Address add = new Address("Ejigbo","Akure","Ondo","Akure South","Nigeria");
        //Check if the Address is in usa or not.
        add.getAddressUSA();
        //creating the products class instance.
        Products products1 = new Products("Samsung Galaxy","125xdh",570,1);
        Products products2 = new Products("Sony Earpod","123trhq",155,1);
        Products products3 = new Products("Type C usb cord","124xhhg",25,2);
        // Order
        Order order1 = new Order();
        //Adding the products to the Ordered product list.
        order1._products.Add(products1);
        order1._products.Add(products2);
        order1._products.Add(products3);
        //The getName method of the getCustomer returns a string _name which will be set as the customers name;
        order1.setCustomer(customer.getName());
        //The getFullAdd method of the add(Address) returns a string add which will be set as the customers full Adress;
        order1.setCustAdd(add.getFullAdd());
        //The getAddress method of the add(Address) returns a string USA which will be set as the customers add if its USA or not;
        order1.checkAdd(add.getAddressUSA());
        //The fuction to print the order to the console.
        order1.order();
    }
}