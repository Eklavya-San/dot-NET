namespace Membership;

public static class AuthManager{
    public static bool Validate (string email,string password,List members){
        bool status = false;
        foreach (List member in members){
            if(email==member.Email && password==member.Password){
                status = true; 
                return status;
            }

        }
        return status;
    }

    public static bool Register (string firstName, string LastName, string email, string location , string ContactNumber,List members){
        bool status = false;
        try{
            User therUser = new User(firstName,LastName,email,location,ContactNumber);
            foreach (List memeber in members){
                if(memeber.Email==therUser.Email){
                    throw Exception("User already exists") ;
                }else{
                    status=true;
                }
            }
            
        }catch (Exception e){

        }
        return true;
    }
}