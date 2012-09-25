package customer;

public class Customer {
	public String ID;
	public String Name;
	public String Address;
	
	@Override
	public String toString()
	{
		return this.ID + ". " + this.Name;
	}
}
