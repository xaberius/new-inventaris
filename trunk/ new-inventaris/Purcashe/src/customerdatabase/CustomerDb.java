package customerdatabase;

import java.util.ArrayList;
import java.util.List;

import customer.Customer;

public class CustomerDb {
	private List<Customer> ListCustomer = new ArrayList<Customer>();
	private static final CustomerDb CustomerDatabase = new CustomerDb();
	
	public static CustomerDb getInstance()
	{
		return CustomerDb.CustomerDatabase;
	}
	
	private CustomerDb()
	{
		
	}
	
	public void addContact(Customer Customer) 
	{
		ListCustomer.add(Customer);
	}
	
	public List<Customer> listCustomer()
	{
		return ListCustomer;
	}
}
