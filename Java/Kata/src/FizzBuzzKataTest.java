import static org.junit.Assert.*;
import junit.framework.TestCase;

import org.junit.Test;


public class FizzBuzzKataTest extends TestCase{
	
	private FizzBuzz fb;
	
	protected void setUp()
	{
		fb = new FizzBuzz();
	}
	
	@Test
	public void test_No_Rule() {
		//fail("Not yet implemented");
		assertEquals("1",fb.answer(1));
	}
	@Test
	public void test_FizzRule()
	{
		assertEquals("fizz",fb.answer(3));
	}
	@Test
	public void test_BuzzRule()
	{
		assertEquals("buzz",fb.answer(5));
	}
	@Test
	public void test_FizzBuzzRule()
	{
		assertEquals("fizzbuzz",fb.answer(15));
	}
	@Test
	public void test_1to100()
	{
		for(int number=0;number<100;number++)
		{
			if(isFizzBuzz(number))
			{
				assertEquals("fizzbuzz",fb.answer(number));
			}else if(isFizz(number))
			{
				assertEquals("fizz",fb.answer(number));
			}else if(isBuzz(number))
			{
				assertEquals("buzz",fb.answer(number));
			}else
			{
				assertEquals(number+"",fb.answer(number));
			}
		}
	}
	private Boolean isFizz(int number)
	{
		return number%3==0;
	}
	
	private Boolean isBuzz(int number)
	{
		return number%5==0;
	}
	private Boolean isFizzBuzz(int number)
	{
		return number%15==0;
	}
}
