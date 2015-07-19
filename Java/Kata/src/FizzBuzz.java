
public class FizzBuzz implements IFizzBuzz{
	
	private String _result="";
	
	public String answer(int number) {
		// TODO Auto-generated method stub
		if(isFizzBuzz(number))  _result = "fizzbuzz";
		else if(isFizz(number)) _result = "fizz";
		else if(isBuzz(number)) _result = "buzz";
		else _result = number+"";
		
		return _result;
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
