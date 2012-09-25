package productdatabase;

import java.util.ArrayList;
import java.util.List;

import product.Product;

import customer.Customer;

public class ProductDb {
	private List<Product> ListProduct = new ArrayList<Product>();
	private static final ProductDb ProductDatabase = new ProductDb();
	
	public static ProductDb getInstance()
	{
		return ProductDb.ProductDatabase;
	}
	
	private ProductDb()
	{
		
	}
	
	public void addProduct(Product Product) 
	{
		ListProduct.add(Product);
	}
	
	public List<Product> listProduct()
	{
		return ListProduct;
	}
	
	public List<Product> clearData()
	{
		ListProduct.clear();
		return ListProduct;
	}

}
