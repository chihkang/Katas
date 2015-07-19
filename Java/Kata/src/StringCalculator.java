
public class StringCalculator {
	
	private int _value=0;
	private String defaule_delimiter = ",";
	private String defaule_delimiter2 = "\n";
	private String Optional_delimiter="";
	
	public int add(String expression) {
		// TODO Auto-generated method stub
		if(expression.isEmpty()) return 0;

		_value = getValues(expression);
		
		return _value;
	}
	
	private int getValues(String expression)
	{
		try
		{
			_value = Integer.parseInt(expression);
		}catch(NumberFormatException NFex)
		{

			//[delimiter]\n[numbers¡K]¡¨ for example ¡§//;\n1;2¡¨ should return three where the default delimiter is ¡¥;¡¦
			if(isChangeDelimiter(expression))
			{
				Optional_delimiter= expression.substring(2, expression.indexOf("\n"));
				// \n is a space,so need to +1
				expression = expression.substring(expression.indexOf("\n")+1);
				expression = expression.replaceAll(Optional_delimiter, defaule_delimiter);
			}
			splitExpression(expression);
			
		}
		
		return _value;
	}

	private boolean isChangeDelimiter(String expression) {
		// TODO Auto-generated method stub
		return expression.startsWith("//");
	}

	private void splitExpression(String expression) {
		// TODO Auto-generated method stub
		
		expression = expression.replaceAll(defaule_delimiter2, defaule_delimiter);
		
		String[] values = expression.split(defaule_delimiter);
		
		for(String value :values)
			_value+=Integer.parseInt(value);
		
		
	}
}
