package com.example.purcashe;

import com.example.purcashe.R;

import customer.Customer;
import customerdatabase.CustomerDb;
import customerform.CustomerForm;
import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;

public class CustomerActivity extends Activity implements OnClickListener
{
	private CustomerForm CustomerForm;
	
	public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.addcustomer);
        
        CustomerForm = new CustomerForm(this);
        CustomerForm.getCmdCustomerSave().setOnClickListener(this);
    }

	public void onClick(View Viewx) 
	{
		// TODO Auto-generated method stub
		Customer Customerx = new Customer();
		Customerx.Name = CustomerForm.getTxtCustomerName().getText().toString();
		Customerx.Address = CustomerForm.getTxtCustomerAddress().getText().toString();
		Customerx.ID = CustomerForm.getTxtCustomerID().getText().toString();
    	
    	CustomerDb Database = CustomerDb.getInstance();
    	Database.addContact(Customerx);
    	
    	CustomerForm.reset();
	}
	
	
	
}
