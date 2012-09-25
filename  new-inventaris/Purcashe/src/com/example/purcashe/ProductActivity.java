package com.example.purcashe;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.Reader;
import java.util.ArrayList;
import java.util.List;

import product.Product;
import productdatabase.ProductDb;
import productform.ProductForm;
import purchaseOrder.PurchaseOrder;
import purchaseOrderDb.PurchaseOrderDb;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.SpannableString;
import android.text.TextWatcher;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import android.widget.Toast;


public class ProductActivity extends Activity implements OnClickListener
{
	protected static final ArrayAdapter<Product> Apdaterx = null;
	private ProductForm Productform;
	private List<Product> listProduct,ListProductx;
	private Product Productx = new Product();
	private ProductDb Database = ProductDb.getInstance();
	private String ProductID;
	private int ProductPrice = 0;
	
	public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.addproduct);        
        
        Productform = new ProductForm(this);
        Productform.getCmdProductSave().setOnClickListener(this);
        
		Database.clearData();
		
        BufferedReader br = null;
        
		try 
		{
 
			String sCurrentLine;
			String[] dataBarang;
			int a= 1;

			br = new BufferedReader(new FileReader("/mnt/sdcard/Barang.csv"));
 
			while ((sCurrentLine = br.readLine()) != null) 
			{
				Productx = new Product();
				dataBarang= sCurrentLine.split(",");
				Productx.ID = dataBarang[0].toString();
				Productx.Name = dataBarang[1].toString();
				Productx.Price = a * 10;
				Database.addProduct(Productx);
				a++;
			}
 
		} 
		catch (IOException e) 
		{
			e.printStackTrace();
		} 
		finally 
		{
			try 
			{
				if (br != null)br.close();
			}
			catch (IOException ex)
			{
				ex.printStackTrace();
			}
		}
		
		listProduct = Database.listProduct();
		search(listProduct);
				
		Productform.getTxtSearch().addTextChangedListener(new TextWatcher()
		{
	        public void afterTextChanged(Editable s) 
	        {
	        	
	        }
	        public void beforeTextChanged(CharSequence s, int start, int count, int after)
	        {

	        }
	        public void onTextChanged(CharSequence s, int start, int before, int count)
	        {
	        	Toast.makeText(getBaseContext(), Productform.getTxtSearch().getText().toString(), Toast.LENGTH_LONG).show();
	        	ListProductx = new ArrayList<Product>();
	        	for(Product Px : listProduct)
	        	{
	        		System.out.println("");
	        		if(Px.Name.startsWith(Productform.getTxtSearch().getText().toString().toUpperCase()))        		
	        		{
	        			ListProductx.add(Px);	       			
	        		}	        		
	        	}
	        	
	        	search(ListProductx);
	        	
	        	for(Product Py : ListProductx)
	        	{
	        		System.out.println(Py.Name);	        		
	        	}
	        }
	    }); 
		
		
		Productform.getListProduct().setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> Apdaterx, View view, int pos,
					long arg3 ) {
				// TODO Auto-generated method stub
				
				String item = ((TextView)view).getText().toString();
				System.out.print(item.substring(0,3));
				
				Product Producty = (Product) Productform.getListProduct().getItemAtPosition(pos);
				
				//Toast.makeText(getBaseContext(),item.substring(0,3), Toast.LENGTH_LONG).show();
				for(Product Productx : listProduct)
				{
					if(Productx.ID.toString() == Producty.ID.toString())
					{
						Toast.makeText(getBaseContext(), "Barang terpilih", Toast.LENGTH_LONG).show();
						System.out.println("berhasilll...");
						ProductID = Productx.ID.toString();
						ProductPrice = Productx.Price;

						Productform.getTextProduct().setText("Nama Barang : "+ Productx.Name);
						
					}
				}
				                
			}
        });
    }

	@Override
	public void onClick(View Viewx) 
	{
		// TODO Auto-generated method stub
		
		if(Viewx == Productform.getCmdProductSave() && ProductID !="" && Productform.getTxtQuantity().getText().toString().length()>0)
		{
			java.util.Date Datex = new java.util.Date();
			PurchaseOrder PurchaseOrderx = new PurchaseOrder();
			PurchaseOrderx.PO_ID = Datex.toLocaleString();
			PurchaseOrderx.ProductID = ProductID;
			PurchaseOrderx.Price = ProductPrice;
			PurchaseOrderx.Quantity = Integer.parseInt(Productform.getTxtQuantity().getText().toString());
    	
			PurchaseOrderDb Database = PurchaseOrderDb.getInstance();
			Database.addPurchaseOrder(PurchaseOrderx);    
			Productform.getTxtQuantity().setText("");
			Intent Intentx = new Intent(this,MainActivity.class);
			startActivity(Intentx);
		}
		
		else
		{
			AlertDialog alertDialog;
    		alertDialog = new AlertDialog.Builder(this).create();
    		alertDialog.setTitle("Pembelian");
    		alertDialog.setMessage("Barang belum dipilih \natau jumlah belum diisi.");
    		alertDialog.show();
		}
		
		
	} 
	
	public void search(List<Product> LP)
	{			
			Productform.getListProduct().clearChoices();
			ArrayAdapter<Product> Adapterx = new ArrayAdapter<Product>(ProductActivity.this,R.layout.mystyle,LP);
			Productform.getListProduct().destroyDrawingCache();
			Productform.getListProduct().setVisibility(Productform.getListProduct().INVISIBLE);
			Productform.getListProduct().setVisibility(Productform.getListProduct().VISIBLE);

			Productform.getListProduct().setAdapter(Adapterx);
	}

}
