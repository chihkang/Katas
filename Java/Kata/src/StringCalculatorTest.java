import static org.junit.Assert.*;
import junit.framework.TestCase;

import org.junit.Test;


public class StringCalculatorTest extends TestCase{
	
	private StringCalculator sc;
	
	protected void setUp()
	{
		sc = new StringCalculator();
	}
	
	@Test
	public void test_add_Empty() {
		assertEquals(0,sc.add(""));
	}
	
	@Test
	public void test_add_One_Number()
	{
		assertEquals(1,sc.add("1"));
	}
	@Test
	public void test_add_Two_Numbers()
	{
		assertEquals(4,sc.add("1\n1,2"));
	}
	@Test
	public void test_add_ChangeDelimiter()
	{
		assertEquals(3,sc.add("//;\n1;2"));
	}
}
