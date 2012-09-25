package purchaseOrderDb;

import java.util.ArrayList;
import java.util.List;

import productdatabase.ProductDb;
import purchaseOrder.PurchaseOrder;
import customer.Customer;

public class PurchaseOrderDb {
	private List<PurchaseOrder> ListPurchaseOrder = new ArrayList<PurchaseOrder>();
	private static final PurchaseOrderDb PurchaseOrderDatabase = new PurchaseOrderDb();
	
	public static PurchaseOrderDb getInstance()
	{
		return PurchaseOrderDb.PurchaseOrderDatabase;
	}

	
	public void addPurchaseOrder(PurchaseOrder PO) 
	{
		ListPurchaseOrder.add(PO);
	}
	
	public List<PurchaseOrder> ListPurchaseOrder()
	{
		return ListPurchaseOrder;
	}
	
	public List<PurchaseOrder> clearData()
	{
		ListPurchaseOrder.clear();
		return ListPurchaseOrder;
	}
}
