package productform;

import java.nio.Buffer;
import java.util.List;

import org.w3c.dom.Text;

import com.example.purcashe.R;

import android.app.Activity;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;

public class ProductForm {
	private Activity Activity;
	private ListView ListProduct;
	private EditText TxtQuantity,TxtSearch;
	private Button CmdSave;
	private TextView TxtProduct;
	
	public ProductForm(Activity Activityx)
	{
		this.Activity = Activityx;
		ListProduct = (ListView) Activityx.findViewById(R.id.ListProduct);
		TxtQuantity = (EditText) Activityx.findViewById(R.id.TxtJumlah);
		CmdSave = (Button) Activityx.findViewById(R.id.CmdProductSave);	
		TxtProduct = (TextView) Activityx.findViewById(R.id.textProduct);
		TxtSearch = (EditText) Activityx.findViewById(R.id.TxtCari);
	}
	
	public Activity getActivity()
	{
		return this.Activity;
	}
	
	public TextView getTextProduct()
	{
		return TxtProduct;
	}
	
	public ListView getListProduct()
	{
		return ListProduct;
	}
	
	public EditText getTxtQuantity()
	{
		return TxtQuantity;
	}
	
	public EditText getTxtSearch()
	{
		return TxtSearch;
	}
	
	public Button getCmdProductSave()
	{
		return CmdSave;
	}
	
}
