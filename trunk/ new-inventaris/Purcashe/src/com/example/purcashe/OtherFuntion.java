package com.example.purcashe;



public class OtherFuntion extends MainActivity {
	public static String fillPrice(String product)
    {   
		String price = null;
    	if(product == "RAM")
    	{
    		price ="1000";
    	}
    	else if (product == "LCD") {
			price ="2000";
		}
    	else if (product == "Motherboard") {
			price ="3000";
		}
    	else if (product == "DVD-RAM") {
			price ="4000";
		}
    	else if (product == "Power Supply") {
			price ="5000";
		}
		else if (product == "HDD") {
			price ="6000";
		}
    	return price;
    }
	public static String fillTotal(String Price, String Quantity)
    { 
		int a,b;
		double c;
		String Total = "0";
		
		a=Integer.parseInt(Price);
		b=Integer.parseInt(Quantity);
		if(a>0 && b>0)
		{
			c= a*b;
			Total = String.format("%.0f",c);
		}		
		return Total;
    }
}
