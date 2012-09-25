package customerform;

import android.app.Activity;
import android.widget.Button;
import android.widget.EditText;
import com.example.purcashe.R;

public class CustomerForm
{
	private Activity Activity;
	private EditText TxtCustomerID,TxtCustomerName,TxtCustomerAddress;
	private Button CmdSave;
	
	public CustomerForm(Activity Activtyx)
	{
		this.Activity = Activtyx;
		TxtCustomerID = (EditText) Activtyx.findViewById(R.id.TxtCustomerID);
		TxtCustomerName = (EditText) Activtyx.findViewById(R.id.TxtCustomerName);
		TxtCustomerAddress = (EditText) Activtyx.findViewById(R.id.TxtCustomerAddress);
		CmdSave = (Button) Activtyx.findViewById(R.id.CmdCustomerSave);
	}
	
	public void reset()
	{
		TxtCustomerAddress.setText("");
		TxtCustomerID.setText("");
		TxtCustomerName.setText("");
	}
	
	public Activity getActivity()
	{
		return this.Activity;
	}
	
	public EditText getTxtCustomerID()
	{
		return TxtCustomerID;
	}
	
	public EditText getTxtCustomerName()
	{
		return TxtCustomerName;
	}
	
	public EditText getTxtCustomerAddress()
	{
		return TxtCustomerAddress;
	}
	
	public Button getCmdCustomerSave()
	{
		return CmdSave;
	}
}
