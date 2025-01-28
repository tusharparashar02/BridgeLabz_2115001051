using System;

class OTPGenerator
{
    static int GenerateOTP()
    {
        Random random = new Random();
        int otp = random.Next(100000, 999999);
        return otp;
    }

    // Method to ensure OTPs are unique by checking an array
    static bool CheckUniqueOTPs(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j])
                {
                    return false; 
                }
            }
        }
        return true; 
    }

    static void Main(string[] args){
        int[] otps = new int[10]; 
        for (int i = 0; i < 10; i++){
            otps[i] = GenerateOTP();
            Console.WriteLine("Generated OTP " + (i + 1) + ": " + otps[i]);
        }
        bool areUnique = CheckUniqueOTPs(otps);
        if (areUnique){
            Console.WriteLine("All OTPs are unique.");
        }
        else{
            Console.WriteLine("Some OTPs are not unique.");
        }
    }
}
