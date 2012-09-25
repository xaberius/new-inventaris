package emaildb;

import java.util.ArrayList;
import java.util.List;

import email.Email;


public class EmailDb {
	private List<Email> ListEmail = new ArrayList<Email>();
	private static final EmailDb EmailDatabase = new EmailDb();
	
	public static EmailDb getInstance()
	{
		return EmailDb.EmailDatabase;
	}

	
	public void addEmail(Email Email) 
	{
		ListEmail.add(Email);
	}
	
	public List<Email> listEmail()
	{
		return ListEmail;
	}
	
	public List<Email> clearData()
	{
		ListEmail.clear();
		return ListEmail;
	}
}
