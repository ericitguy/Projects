#include <iostream>
using namespace std;

int main() 
{
	
	//Declaration of variables
   double input1=0.0;
   double input2 = 0.0;
   string op ="";
   double solution = 0.0;
   
   cout<<"Please enter the value of the first number: ";
   cin>>input1;
   
   cout<<"Please enter the Operator: ";
   cin>>op;

   cout<<"Please enter the value of the second number: ";
   cin>>input2;
   
   if(op=="+"){
	   solution = input1 + input2;
	   
   }
   else if(op == "/")
   {
	   solution = input1 / input2;
   }
   else if (op == "*")
   {
	   solution = input1 * input2;
   }
   else if (op == "-")
	   
	   {
		   solution = input1 - input2;
	   }
	
   cout << solution << endl;
    return 0;
}