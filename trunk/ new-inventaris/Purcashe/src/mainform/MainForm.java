package mainform;

import com.example.purcashe.R;
import android.app.Activity;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;

public class MainForm {
	private Activity Activity;
	private Spinner TxtCustomer;
	private ListView ListProduct;
	private EditText TxtGrandTotal;
	private Button CmdCustomer,CmdProduct,CmdSave;
	
	public MainForm(Activity Activityx)
	{
		this.Activity = Activityx;
		TxtCustomer = (Spinner) Activity.findViewById(R.id.TxtCustomer);
		ListProduct = (ListView) Activity.findViewById(R.id.ListProduct);
		TxtGrandTotal = (EditText) Activity.findViewById(R.id.GrandTotal);
		CmdCustomer = (Button) Activity.findViewById(R.id.CmdCustomer);
		CmdProduct = (Button) Activity.findViewById(R.id.CmdProduct);
		CmdSave = (Button) Activity.findViewById(R.id.CmdSave);				
	}
	
	public Activity getActivity()
	{
		return this.Activity;
	}
	
	public Spinner getTxtCustomer()
	{
		return TxtCustomer;
	}
	
	public ListView getListProduct()
	{
		return ListProduct;		
	}
	
	public EditText getTxtGrandTotal()
	{
		return TxtGrandTotal;
	}
	
	public Button getCmdCustomer() 
	{
		return CmdCustomer;
	}
	
	public Button getCmdProduct()
	{
		return CmdProduct;
	}
	
	public Button getCmdSave()
	{
		return CmdSave;
	}
}
