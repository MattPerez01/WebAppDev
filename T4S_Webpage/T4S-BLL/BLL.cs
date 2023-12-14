using System.Data.SqlClient;
using System.Reflection;
using System.ComponentModel.Design;
using T4S_MODEL;
using T4S_DLL;


namespace T4S_BLL
{
    public class BLL
    {
        public string SignUp(SignUpModel model)
        {
            DLL userSignup = new DLL();

            return userSignup.addUser(model);

        }

        public string SignIn(SignInModel model)
        {
            DLL userSignIn = new DLL();

            return userSignIn.SigningIn(model);
        }
    }
}
