#include <iostream>;
#include <string>;
using namespace std;
void login();
int main() 
{

    

   login();

    return 0;
}

void login()

{

 //Declaration of variables 
    string username;
    string password;

    cout<<"Please enter username: ";
    cin>>username;

    cout<<"Please enter password: ";
    cin>>password;


if (username=="eric"&&password=="1234")

{

    cout<<"Login Successfull: ";
    cout<<"Welcome Eric";
}

else if (username=="admin"&&password=="1234")
{
    cout<<"Login Successfull: ";
    cout<<"Welcome Admin";
}

else {cout<<"Illegal Login";}


}