import static org.junit.Assert.*;
import junit.framework.TestCase;

import org.junit.Test;


public class OddEvenTest extends TestCase{
	
	private oddEven oe;
	
	protected void setUp()
	{
		oe = new oddEven();
	}
	
	@Test
	public void test_Even_number() {
		assertEquals("Even",oe.show_Even_Odd__Prime(2));
	}
	
	@Test
	public void test_Odd_number()
	{
		assertEquals("Odd",oe.show_Even_Odd__Prime(9));
	}
	
	@Test
	public void test_Prime_number()
	{
		assertEquals("Prime",oe.show_Even_Odd__Prime(3));
	}
	
	@Test
	public void test_1To100()
	{
		for(int number=0;number<100;number++)
		{
			//System.out.println(number+" is : "+oe.show_Even_Odd__Prime(number));
			System.out.printf("%d is %s \n",number,oe.show_Even_Odd__Prime(number));
		}
	}
	
}
