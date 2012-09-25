package com.example.purcashe;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.regex.Pattern;


import purchaseOrder.PurchaseOrder;
import purchaseOrderDb.PurchaseOrderDb;

import com.example.purcashe.R;

import customer.Customer;
import customerdatabase.CustomerDb;
import mailing.Mail;
import mainform.MainForm;
import android.os.Bundle;
import android.accounts.Account;
import android.accounts.AccountManager;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.Intent;
import android.util.Log;
import android.util.Patterns;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.Toast;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;


public class MainActivity extends Activity implements OnClickListener
{
	private MainForm Mainform;
	private Customer Customerx;
	private CustomerDb Database = CustomerDb.getInstance();
	private PurchaseOrderDb  DatabaseOrder = PurchaseOrderDb.getInstance();
	private String Email,Email2,Purchase,Names;
		
    @Override
    public void onCreate(Bundle savedInstanceState) 
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        Mainform = new MainForm(this);
        Mainform.getCmdCustomer().setOnClickListener(this);
        Mainform.getCmdProduct().setOnClickListener(this);
        Mainform.getCmdSave().setOnClickListener(this);  
        //Mainform.getTxtCustomer().setOnClickListener(this);        
               
        
        LoadListdata();    		
        Mainform.getTxtCustomer().setOnItemSelectedListener(new OnItemSelectedListener() 
    	{
    		@Override
    	    public void onItemSelected(AdapterView<?> parentView, View selectedItemView, int position, long id) {
    	        // your code here
               
                Customer Cus =  (Customer) parentView.getItemAtPosition(position); 
                Email= Cus.Address.toString();  
                Names = Cus.Name.toString();
    	    }

    	    @Override
    	    public void onNothingSelected(AdapterView<?> parentView) {
    	        // your code here
    	    }       
        });
    }


	@Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.activity_main, menu);
        return true;
    }

	public void onClick(View Viewx) 
	{
		// TODO Auto-generated method stub
		if(Viewx == Mainform.getCmdCustomer())
		{
			Intent Intentx = new Intent(this,CustomerActivity.class);
    		startActivity(Intentx);
		}
		else if(Viewx == Mainform.getCmdProduct())
		{
			Intent Intentx = new Intent(this,ProductActivity.class);
    		startActivity(Intentx);
		}
		else if(Viewx == Mainform.getCmdSave())
		{			
			
    		DatabaseOrder.clearData();
    		
    		AlertDialog alertDialog;
	    	alertDialog = new AlertDialog.Builder(this).create();
	    	 	    	
	    	
	    	
	    	Pattern emailPattern = Patterns.EMAIL_ADDRESS; // API level 8+	   
	    	
	    	Account[] accounts = AccountManager.get(getBaseContext()).getAccounts();
	    	for (Account account : accounts)
	    	{
	    	    if (emailPattern.matcher(account.name).matches()) 
	    	    {
	    	        Email2 = account.name;
	    	        //String x2x = AccountManager.getPassword(account);
	    	        //String xx = AccountManager.get(getBaseContext()).getPassword(account);
	    	        //System.out.println(xx);
	    	        
	    	    }
	    	}	    	
	    	
	    	SimpleDateFormat sdf = new SimpleDateFormat("dd MMMM yyyy hh:mm");
	    	String currentDateandTime = sdf.format(new Date());

	    	
	    	
	    	//Mail m = new Mail("agussupriyantosaid@gmail.com", "a6664691");
	    	Mail m = new Mail("itpro.salesmailer@gmail.com", "1tpr03rl4ngg4");
	    	
	   	 
		      String[] toArr = {Email2,"agussupriyantosaid@gmail.com","tugas_web_lanjut@yahoo.com"}; 
		      m.setTo(toArr); 
		      //m.setFrom("agussupriyantosaid@gmail.com"); 
		      String Date;
		      String Time;
		      m.setSubject("Pesanan Barang " + currentDateandTime); 
		      m.setBody("Nama customer : " + Names + "\nBarang Pesanan : \n" + Purchase); 
		 
		      try 
		      { 
		        //m.addAttachment("/sdcard/filelocation"); 
		 
		        if(m.send()) 
		        { 
		          System.out.println( "Email was sent successfully."); 
		          
		          alertDialog.setTitle("Pembelian");
			      alertDialog.setMessage("Pesanan sudah tersimpan.");   
		          for(double a=0; a<1000; a++)
			    	{
			    		for(double b=0; b<1000; b++)
				    	{			    			
			    			alertDialog.show(); 
				    	}
			    	}			    	
			    	
			    	DatabaseOrder.clearData();
		    		LoadListdata();
		    		Intent Intentx = new Intent(this,MailActivity.class);
		    		startActivity(Intentx);
		        } 
		        else 
		        { 
		        	System.out.println( "Email was sent unsuccessfully."); 
		        	Toast.makeText(getBaseContext(), "Pesanan tidak dapat diproses. Silahkan cek jaringan internet atau setting email.", Toast.LENGTH_LONG).show();
		        } 
		      } 
		      catch(Exception e) 
		      { 
		        //Toast.makeText(MailApp.this, "There was a problem sending the email.", Toast.LENGTH_LONG).show(); 
		        Log.e("MailApp", "Could not send email", e); 
		        Toast.makeText(getBaseContext(), "Pesanan tidak dapat diproses. Silahkan cek jaringan internet atau setting email.", Toast.LENGTH_LONG).show();
		      }   	
	    	
		}
	}   
	
	
	public void LoadListdata()
    {    	
		double Grand = 0;		   	
    	
		List<Customer> listCustomers = Database.listCustomer();
		
		if ( listCustomers.isEmpty())
		{
			Customerx = new Customer();
			Customerx.ID="Cus1";
			Customerx.Name = "Budi";
			Customerx.Address ="agussupriyantosaid@gmail.com";
			Database.addContact(Customerx);
			
			Customerx = new Customer();
			Customerx.ID="Cus2";
			Customerx.Name = "Buna";
			Customerx.Address ="aloysius.prayitno@gmail.com";
			Database.addContact(Customerx);
			
			Customerx = new Customer();
			Customerx.ID="Cus3";
			Customerx.Name = "Rudii";
			Customerx.Address ="agussupriyantosaid@yahoo.co.id";
			Database.addContact(Customerx);
			
			Customerx = new Customer();
			Customerx.ID="Cus4";
			Customerx.Name = "Ina";
			Customerx.Address ="agussupriyantosaid@gmail.com";
			Database.addContact(Customerx);			
		}
		
		ArrayAdapter<Customer> Adapter = new ArrayAdapter<Customer>(this,android.R.layout.simple_spinner_item,listCustomers);
    	Adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);    	
    	Mainform.getTxtCustomer().setAdapter(Adapter);
    	
    	
      	List<PurchaseOrder> ListPurchaseOrder = DatabaseOrder.ListPurchaseOrder();    	
      	ArrayAdapter<PurchaseOrder> Adapterx = new ArrayAdapter<PurchaseOrder>(this,R.layout.mystyle,ListPurchaseOrder);
      	Adapterx.setDropDownViewResource(android.R.layout.simple_list_item_1);
      
      	Mainform.getListProduct().setAdapter(Adapterx);
      	Purchase = "";
      	for(PurchaseOrder PO : ListPurchaseOrder)
      	{
      		Grand = Grand + (PO.Price * PO.Quantity);
      		Purchase = Purchase + "\n" + PO.toString() + "\n";
      	}
      	
      	Mainform.getTxtGrandTotal().setText(String.valueOf(Grand));
    }
}
