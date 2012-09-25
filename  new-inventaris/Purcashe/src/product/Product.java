package product;

public class Product {
	public String ID;
	public String Name;
	public int Price;
	
	@Override
	public String toString()
	{
		return ID + "-" + Name + " Rp. " + String.valueOf(Price) ;
	}

}
