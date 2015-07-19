
public class oddEven {

	public String show_Even_Odd__Prime(int number) {
		// TODO Auto-generated method stub
		if(isEven(number)) return "Even";
		else if(isOdd(number)) return "Odd";
		else return "Prime";
	}
	
	private Boolean isEven(int number)
	{
		return number%2==0;
	}
	
	private Boolean isOdd(int number)
	{
		return !isEven(number) && isDivideByOther(number);
	}
	
	private Boolean isDivideByOther(int number)
	{
		for(int i=3;i<number/2;i++)
		{
			if(number%i==0)
			{
				return true;
			}
		}
		return false;
	}
}
