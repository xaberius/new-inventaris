package purchaseOrder;

import java.text.NumberFormat;
import java.util.Currency;
import java.util.List;
import java.util.Locale;
import java.util.jar.Attributes.Name;

import android.preference.ListPreference;

import product.Product;
import productdatabase.ProductDb;


public class PurchaseOrder 
{
	public String PO_ID;
	public String ProductID,ProductName;
	public int Quantity;
	public int Price;
	private List<Product> listProduct;
	private Product Productx = new Product();
	private ProductDb Database = ProductDb.getInstance();
	
	@Override
	public String toString()
	{
		Locale[] locales = { new Locale("IDR", "IDR") };

		listProduct = Database.listProduct();
		for(Product P : listProduct)
		{
			if(P.ID == this.ProductID)
			{
				ProductName= P.Name;
			}
		}
		
		return ProductID + "-" + ProductName + "    \nQty : " + String.valueOf(Quantity)
				+ " @ Rp. " + insertCommas(String.valueOf(Price)) + " Total : Rp. " + 
				insertCommas(String.valueOf(Price*Quantity));
		/*return ProductID + "-" + ProductName + "    \nQty : " + String.valueOf(Quantity)
				+ " @ Rp. " + displayCurrency(locales[0], Double.valueOf(Price)) + " Total : Rp. " + 
					displayCurrency(locales[0], Double.valueOf(Quantity*Price));*/
	}
	
	public String insertCommas(String str)
	{  
		if(str.length() < 4)
		{  
			return str;  
		}  
		return insertCommas(str.substring(0, str.length() - 3)) + "," + str.substring(str.length() - 3, str.length());  
	}  
}
