// our customers:

using Entities;

int number = 0;

Customer customer1 = new RealCustomer();    
customer1.Name = "Test";

Customer customer2 = new RealCustomer();
customer2.Name = "Test";



List<Customer> customers = new List<Customer>();


AddCustomer(customer1, customers);
AddCustomer(customer2, customers);

void AddRealCustomer(RealCustomer realCustomer, List<RealCustomer> realcustomers)
{
    realcustomers.Add(realCustomer);
}
void AddCustomer(Customer customer, List<Customer> customers)
{
    customers.Add(customer);
}

foreach (Customer customer in customers)
{
    Console.WriteLine($" {customer.Name}");
}